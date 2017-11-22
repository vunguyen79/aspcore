using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyCompany.Data.Entities.Users;

namespace MyCompany.Data.ConfigureEntity.Users
{
    public class ConfigureUserProfile
    {
        public ConfigureUserProfile(EntityTypeBuilder<UserProfile> builder)
        {
            builder.ToTable("UserProfile");

        }
    }
}
