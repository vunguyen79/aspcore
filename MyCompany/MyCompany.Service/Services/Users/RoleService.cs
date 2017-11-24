using MyCompany.Data.Entities.Users;
using MyCompany.Repository.UnitOfWorks;
using MyCompany.Service.Dtos.Users;


namespace MyCompany.Service.Services.Users
{
    public class RoleService : ServiceBase<Role, RoleDto>, IRoleService
    {
        public RoleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

}