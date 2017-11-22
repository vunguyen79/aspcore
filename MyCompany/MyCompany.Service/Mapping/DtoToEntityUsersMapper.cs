using AutoMapper;
using MyCompany.Data.Entities.Users;
using MyCompany.Service.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.Service.Mapping
{
    public class DtoToEntityUsersMapper : Profile
    {
        public DtoToEntityUsersMapper()
        {
            CreateMap<UserDto, User>()
                .ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<RoleDto, Role>()
              .ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<UserProfileDto, UserProfile>()
             .ForMember(x => x.Id, opt => opt.Ignore());

            CreateMap<PermissionDto, Permission>()
             .ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
