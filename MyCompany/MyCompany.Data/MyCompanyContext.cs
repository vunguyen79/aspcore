using Microsoft.EntityFrameworkCore;
using MyCompany.Data.ConfigureEntity.Users;
using MyCompany.Data.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.Data
{
    public class MyCompanyContext : DbContext
    {
        public MyCompanyContext(DbContextOptions<MyCompanyContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ConfigureRole(modelBuilder.Entity<Role>());
            new ConfigurePermission(modelBuilder.Entity<Permission>());
            new ConfigureUserProfile(modelBuilder.Entity<UserProfile>());

            new ConfigureUser(modelBuilder.Entity<User>());
        }
    }
}

