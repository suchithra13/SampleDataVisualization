#pragma checksum "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "895bd2a0022d8908395c391951edcc7c058f16a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\_ViewImports.cshtml"
using SampleDataVisualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\_ViewImports.cshtml"
using SampleDataVisualization.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"895bd2a0022d8908395c391951edcc7c058f16a8", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9046b944037e52fc35f2fc2b981a751e4fbb4ba5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("lnk"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AppLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExternalLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\" style=\"margin-top: 2em\">\r\n");
#nullable restore
#line 5 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
     if (!SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-6\">\r\n\r\n            <h3>Sign In using credentials</h3>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "895bd2a0022d8908395c391951edcc7c058f16a86716", async() => {
                WriteLiteral("\r\n                <div class=\"form-row\">\r\n                    <div class=\"form-group\">\r\n                        <input class=\"form-control input-lg\" id=\"Email\" name=\"Email\" type=\"text\" placeholder=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 589, "\"", 625, 1);
#nullable restore
#line 14 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
WriteAttributeValue("", 597, Html.ViewData.Eval("Email"), 597, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""form-group"">
                        <input class=""form-control input-lg"" id=""Password"" name=""Password"" type=""Password"" placeholder=""Password""");
                BeginWriteAttribute("value", " value=\"", 896, "\"", 904, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""form-group"">
                        <input type=""checkbox"" id=""chkRememberMe"" name=""rememberMe"" value=""true"" checked=""checked"">
                        <label for=""chkRememberMe"">Remember Me</label>
                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""form-group col-md-4"">
                        <button type=""submit"" class=""btn btn-primary"">Login</button>
                    </div>
                </div>

                <div class=""form-row"">
                    <div class=""form-group col-md-4"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "895bd2a0022d8908395c391951edcc7c058f16a88784", async() => {
                    WriteLiteral("Register New User");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ReturnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
                                                                                                           WriteLiteral(ViewData["ReturnUrl"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ReturnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
                                                                                       WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-lg-6\">\r\n            <div class=\"nav-item float-right\">\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "895bd2a0022d8908395c391951edcc7c058f16a814529", async() => {
                WriteLiteral("\r\n                        <div>\r\n                            <Button type=\"submit\" class=\"btn btn-primary\" name=\"provider\" value=\"Google\" title=\"Login Using Google Account\">Log In With Google</Button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
                                                                                                     WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n            </div>\r\n        </div>");
#nullable restore
#line 52 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
              }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-lg-6"">
            <table id=""session-info"" class=""table table-bordered"">
                <caption style=""caption-side:top;"">Authenticated User Session</caption>
                <tbody>
                    <tr>
                        <th>Id</th>
                        <td>");
#nullable restore
#line 61 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
                       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Email</th>\r\n                        <td>");
#nullable restore
#line 65 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
                       Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>UserName</th>\r\n                        <td>");
#nullable restore
#line 69 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
                       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>DisplayName</th>\r\n                        <td>");
#nullable restore
#line 73 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
                       Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>AuthProvider</th>\r\n                        <td>");
#nullable restore
#line 77 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
                       Write(Model.AuthProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>ProfileUrl</th>\r\n                        <td>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 3514, "\"", 3537, 1);
#nullable restore
#line 82 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
WriteAttributeValue("", 3520, Model.ProfileUrl, 3520, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <span>");
#nullable restore
#line 83 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
                              Write(Model.ProfileUrl ?? "(fallback)");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n                <tfoot>\r\n                    <tr>\r\n                        <td colspan=\"2\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "895bd2a0022d8908395c391951edcc7c058f16a821150", async() => {
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-link\">Sign Out</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </td>
                    </tr>
                    <tr>
                        <td colspan=""2"">
                            View Public and Secure Pages and APIs on <a href=""/"">Home page</a>.
                        </td>
                    </tr>
                </tfoot>
            </table>
        </div>
");
#nullable restore
#line 103 "C:\Users\Admin\source\repos\SampleDataVisualization\Views\Account\Login.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<script>
    window.addEventListener('load', function () {
        $(document).bindHandlers({
            switchUser: function (u) {
                $(""#Email"").val(u);
                $(""#Password"").val('p@55wOrd');
            }
        });
    });</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<UserDetails> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
