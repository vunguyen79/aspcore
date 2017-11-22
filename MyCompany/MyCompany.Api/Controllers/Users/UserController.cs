using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Service.Dtos.Users;
using MyCompany.Data.Entities.Users;
using MyCompany.Service.IServices.Users;

namespace MyCompany.Api.Controllers.Users
{
    [Route("user")]
    public class UserController : BaseController<User, UserDto, IUserService>
    {

        public UserController(IUserService service) : base(service)
        {

        }
        [HttpGet]
        [Route("test")]
        public virtual async Task<IActionResult> Test()
        {

            return Ok("Hoang Vu Test");
        }

        [HttpGet]
        [Route("info")]
        public virtual async Task<IActionResult> GetInfo()
        {
            var userId = 1;
            return Ok(await _service.GetUserInfoAsync(userId));
        }
    }
}
