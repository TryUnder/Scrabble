using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrabble.Application.Common.Interfaces.Authentication;
using Scrabble.Application.Common.Interfaces.Services;
using Scrabble.Infrastructure.Authentication;
using Scrabble.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            return services;
        }
    }
}
