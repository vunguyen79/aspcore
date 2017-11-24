using MyCompany.Data.Entities.Users;
using MyCompany.Service.Dtos.Users;
using MyCompany.Service.Services.Users;

namespace MyCompany.Api.Controllers.Users
{
    public class UserProfileController : BaseController<UserProfile, UserProfileDto, IUserProfileService>
    {
        public UserProfileController(IUserProfileService service) : base(service)
        {

        }

    }
}