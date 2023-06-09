﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BeautySalon_EF.BLL.Configurations
{
    public class JwtTokenConfiguration
    {
        private readonly IConfiguration configuration;

        public string Issuer => configuration["JwtIssuer"];

        public string Audience => configuration["JwtAudience"];

        public static DateTime ExpirationDate => DateTime.UtcNow.AddYears(1);

        public SymmetricSecurityKey Key =>
            new(Encoding.UTF8.GetBytes(configuration["JwtSecurityKey"]));

        public SigningCredentials Credentials =>
            new(Key, SecurityAlgorithms.HmacSha256);

        public JwtTokenConfiguration(IConfiguration configuration) =>
            this.configuration = configuration;
    }
}