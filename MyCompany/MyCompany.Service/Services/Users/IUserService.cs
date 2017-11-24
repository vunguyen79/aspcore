using MyCompany.Data.Entities.Users;
using MyCompany.Service.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Service.Services.Users
{
    public interface IUserService : IServiceBase<User, UserDto>
    {
        Task<UserDto> GetUserInfoAsync(int userId);
    }
}
