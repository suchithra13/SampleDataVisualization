using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleDataVisualization.Helpers;
using SampleDataVisualization.Helpers.EF.Models;
using SampleDataVisualization.Models;
using SampleDataVisualization.Models.AccountViewModel;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SampleDataVisualization.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<UserDetails> userManager;
        private SignInManager<UserDetails> signInManager;
        private DbContextOptions<HealthDbContext> _dbContextOptions;
        public AccountController(UserManager<UserDetails> userMgr, SignInManager<UserDetails> signinMgr, DbContextOptions<HealthDbContext> dbContextOptions)
        {
            userManager = userMgr;
            signInManager = signinMgr;
            _dbContextOptions = dbContextOptions;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveRecords(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                UserHelper userHelper = new UserHelper(_dbContextOptions);
                await userHelper.SaveUserDetails(registerViewModel);
                ViewBag.msg = "User details saved";

                return LocalRedirect("/Account/Login");
            }
            else
            {
                return View("/Account/Register");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> AppLogin(LoginViewModel model, string returnUrl = null)
        {
            UserHelper userHelper = new UserHelper(_dbContextOptions);
            var userDetails = await userHelper.GetUserByEmail(model.Email);
            if (userDetails != null)
            {
                if (userDetails.Password == model.Password)
                {
                    return LocalRedirect("/Health/Health");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View("Login", model);
                }

            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View("Login", model);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            LoginViewModel model = new LoginViewModel
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await signInManager.PasswordSignInAsync(new UserDetails { Email = model.Email }, model.Password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            // Request a redirect to the external login provider.
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account", new { ReturnUrl = returnUrl });
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            LoginViewModel loginViewModel = new LoginViewModel
            {
                ReturnUrl = returnUrl,
            };

            if (remoteError != null)
            {
                return View("Login", loginViewModel);
            }
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return View("Login", loginViewModel);
            }

            // Sign in the user with this external login provider if the user already has a login.
            var result = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (result.Succeeded)
            {
                return LocalRedirect("/Health/Health");
            }
            else
            {
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                if (email != null)
                {
                    var user = await userManager.FindByEmailAsync(email);
                    if (user == null)
                    {
                        user = new UserDetails
                        {
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                        };
                        await userManager.CreateAsync(user);
                    }
                    await userManager.AddLoginAsync(user, info);
                    await signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect("/Health/Health");
                }
                return View("Error");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            LoginViewModel loginViewModel = new LoginViewModel
            {
                ReturnUrl = returnUrl,
            };
            if (ModelState.IsValid)
            {
                var user = new UserDetails
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    ProviderDisplayName = $"{model.FirstName} {model.LastName}",
                    UserName = model.Email,
                    Email = model.Email,
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return Redirect("/Account/Login");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        private IActionResult AccessDenied()
        {
            return View();
        }
    }
}

