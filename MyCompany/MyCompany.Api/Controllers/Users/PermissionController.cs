using MyCompany.Data.Entities.Users;
using MyCompany.Service.Dtos.Users;
using MyCompany.Service.Services.Users;

namespace MyCompany.Api.Controllers.Users
{
    public class PermissionController :  BaseController<Permission, PermissionDto, IPermissionService>
    {

        public PermissionController(IPermissionService service) : base(service)
        {

        }
    
    }
}
