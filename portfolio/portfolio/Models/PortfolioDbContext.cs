using System;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Collections.Generic;
namespace portfolio.Models
{
    public class PortfolioDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=YOUNIS;Integrated Security=True;");
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Study> Studies { get; set; }

    }
}
