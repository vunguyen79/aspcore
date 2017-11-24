using MyCompany.Data.Entities.Users;
using MyCompany.Service.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.Service.Services.Users
{
    public interface IRoleService : IServiceBase<Role, RoleDto>
    {
    }
}
