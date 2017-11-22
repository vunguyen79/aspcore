using MyCompany.Data.Entities.Users;
using MyCompany.Repository.UnitOfWorks;
using MyCompany.Service.Dtos.Users;
using MyCompany.Service.IServices.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.Service.Services.Users
{
    public class UserProfileService : ServiceBase<UserProfile, UserProfileDto>, IUserProfileService
    {
        public UserProfileService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

}

