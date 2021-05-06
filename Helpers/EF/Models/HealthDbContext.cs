using Microsoft.EntityFrameworkCore;
using SampleDataVisualization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDataVisualization.Helpers.EF.Models
{
    public partial class HealthDbContext : DbContext
    {
        public HealthDbContext()
        {
        }

        public HealthDbContext(DbContextOptions<HealthDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RegisterDetails> RegisterDetails { get; set; }
        public virtual DbSet<HealthDetails> HealthDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<RegisterDetails>(entity =>
            {
                entity.ToTable("UserDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(300);
                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(300);
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(300);
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200);
            });
            modelBuilder.Entity<HealthDetails>(entity =>
            {
                entity.ToTable("HealthDetails");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Diabetic)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Age).HasMaxLength(64);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

