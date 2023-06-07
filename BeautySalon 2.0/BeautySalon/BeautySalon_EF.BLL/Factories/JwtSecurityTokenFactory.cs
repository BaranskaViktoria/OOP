using BeautySalon_EF.BLL.Configurations;
using BeautySalon_EF.BLL.Interfaces;
using BeautySalon_EF.DAL.Entities;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;


namespace TeamworkSystem.BusinessLogicLayer.Factories
{
    public class JwtSecurityTokenFactory : IJwtSecurityTokenFactory
    {
        private readonly JwtTokenConfiguration jwtTokenConfiguration;

        public JwtSecurityToken BuildToken(Products products)
        {
            throw new NotImplementedException();
        }
    }
}
