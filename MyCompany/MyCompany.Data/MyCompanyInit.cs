using MyCompany.Common.Helper;
using MyCompany.Data.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data
{

    public static class MyCompanyInit
    {
        public static void Initialize(MyCompanyContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            //seed
            var roles =
          new List<Role>
        {
            new Role(){ Name = "Admin", Description="Administrator" },
            new Role(){ Name = "User", Description="User" },
            new Role(){ Name = "Lawyer",  Description="Lawyer" },
             new Role(){Name = "Business",  Description="Business" }
        };
            context.Roles.AddRange(roles);
            // context.SaveChanges();

            var permissions = new List<Permission>
            {
               new Permission() { Name = "Full Control", Description="Has full control"},
                 new Permission() { Name = "Reader", Description="Has read-only"},
            };
            context.Permissions.AddRange(permissions);
            //  context.SaveChanges();

            var user = new User
            {
                UserName = "admin",
                Email = "vu.nh@live.com",
                Password = Cipher.Encrypt("Abcd!234"),
                AddedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
               
                Permission = permissions.Where(x => x.Name == "Full Control").FirstOrDefault(),
                Role = roles.Where(x => x.Name == "Admin").FirstOrDefault(),
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}