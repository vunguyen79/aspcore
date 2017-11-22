using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Data.Entities.Users;
using MyCompany.Service.Dtos.Users;
using MyCompany.Service.IServices.Users;

namespace MyCompany.Api.Controllers.Users
{
    public class PermissionController :  BaseController<Permission, PermissionDto, IPermissionService>
    {

        public PermissionController(IPermissionService service) : base(service)
        {

        }
    
    }
}
