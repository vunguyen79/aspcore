using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.Service.Mapping
{
    public class ConfigurationMapper
    {
        public static void Register()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new EntityToDtoUsersMapper());
                cfg.AddProfile(new DtoToEntityUsersMapper());
            });
        }
    }
}