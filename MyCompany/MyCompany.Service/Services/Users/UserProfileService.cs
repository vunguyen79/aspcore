using MyCompany.Data.Entities.Users;
using MyCompany.Repository.UnitOfWorks;
using MyCompany.Service.Dtos.Users;

namespace MyCompany.Service.Services.Users
{
    public class UserProfileService : ServiceBase<UserProfile, UserProfileDto>, IUserProfileService
    {
        public UserProfileService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

}

