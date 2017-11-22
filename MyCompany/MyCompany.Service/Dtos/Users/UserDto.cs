using MyCompany.Data.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.Service.Dtos.Users
{
    public class UserDto
    {
        public UserDto()
        {
            UserProfile = new UserProfileDto();
            Role = new RoleDto();
            Permission = new PermissionDto();
        }
        public int Id { get; set; }
        public string AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public UserProfileDto UserProfile { get; set; }
        public RoleDto Role { get; set; }
        public PermissionDto Permission { get; set; }


    }
}
