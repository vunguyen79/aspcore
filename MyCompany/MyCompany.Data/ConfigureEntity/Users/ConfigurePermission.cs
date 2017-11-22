using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyCompany.Data.Entities.Users;

namespace MyCompany.Data.ConfigureEntity.Users
{
    public class ConfigurePermission
    {
        public ConfigurePermission(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permission");
        }
    }
}
