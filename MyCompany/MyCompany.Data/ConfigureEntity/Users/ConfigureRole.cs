using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCompany.Data.Entities.Users;
using System;

using Microsoft.EntityFrameworkCore;

namespace MyCompany.Data.ConfigureEntity.Users
{
    public class ConfigureRole
    {
        public ConfigureRole(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");

        }
    }
}
