using MyCompany.Service.IServices.Users;
using MyCompany.Data.Entities.Users;
using MyCompany.Service.Dtos.Users;

namespace MyCompany.Api.Controllers.Users
{
    public class UserProfileController : BaseController<UserProfile, UserProfileDto, IUserProfileService>
    {
        public UserProfileController(IUserProfileService service) : base(service)
        {

        }

    }
}