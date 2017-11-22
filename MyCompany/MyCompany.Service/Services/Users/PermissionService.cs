using MyCompany.Data.Entities.Users;
using MyCompany.Repository.UnitOfWorks;
using MyCompany.Service.Dtos.Users;
using MyCompany.Service.IServices.Users;

namespace MyCompany.Service.Services.Users
{

    public class PermissionService : ServiceBase<Permission, PermissionDto>, IPermissionService
    {
        public PermissionService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

}

