using AutoMapper;
using MyCompany.Data.Entities.Users;
using MyCompany.Service.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.Service.Mapping
{
    public class EntityToDtoUsersMapper : Profile
    {
        public EntityToDtoUsersMapper()
        {
            CreateMap<User, UserDto>().AfterMap((src, dest) =>
            {
                dest.Id = src.Id;
                dest.AccountId = src.AccountId;
                dest.UserName = src.UserName;
                dest.Email = src.Email;
                dest.Password = src.Password;
             
                dest.Name = dest.FirstName + ' ' + dest.LastName;
                dest.Role = new RoleDto
                {
                    Id = src.Role.Id,
                    Name = src.Role.Name,
                    Description = src.Role.Description
                };
                dest.Permission = new PermissionDto
                {
                    Id = src.Role.Id,
                    Name = src.Role.Name,
                    Description = src.Role.Description
                };

                dest.ModifiedDate = src.ModifiedDate;
            });

            CreateMap<Permission, PermissionDto>().ReverseMap();

            CreateMap<UserProfile, UserProfileDto>().ReverseMap();

            CreateMap<Role, RoleDto>().ReverseMap();

        }
    }
}
