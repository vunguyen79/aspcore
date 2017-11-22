using MyCompany.Data.Entities.Users;
using MyCompany.Repository.UnitOfWorks;
using MyCompany.Service.Dtos.Users;
using MyCompany.Service.IServices.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Service.Services.Users
{
    public class UserService : ServiceBase<User, UserDto>, IUserService
    {
        private readonly IUserService _userService;
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public async Task<UserDto> GetUserInfoAsync(int userId)
        {
            var user = _repository.FindBy(userId);
            if (user == null) return null;
            //
            var userProfile = new UserProfile();
            var role = new Role();
            var permission = new Permission();

            var profileRepository = _unitOfWork.UserProfileRepository;
            var roleRepository = _unitOfWork.RoleRepository;
            var functionRepository = _unitOfWork.PermissionRepository;

            userProfile = await profileRepository.FindByAsync(user.Id);
            role = await roleRepository.FindByAsync(user.RoleId);
            permission = await functionRepository.FindByAsync(user.PermissionId);

        
            user.Permission = permission;
            user.Role = role;
            //
            return EntityToDto(user);
        }
    }

}
