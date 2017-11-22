using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCompany.Data.Entities.Users;

namespace MyCompany.Data.ConfigureEntity.Users
{
    public class ConfigureUser
    {
        public ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

        }
    }
}
