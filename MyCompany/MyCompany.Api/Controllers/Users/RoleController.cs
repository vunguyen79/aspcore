using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Service.IServices.Users;
using MyCompany.Data.Entities.Users;
using MyCompany.Service.Dtos.Users;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyCompany.Api.Controllers.Users
{
    public class RoleController : BaseController<Role, RoleDto, IRoleService>
    {

        public RoleController(IRoleService service) : base(service)
        {

        }

    }
}

