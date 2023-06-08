using System.Reflection;
using BeautySalon.CA.Application.Common.Mappings.Mapster;
using Mapster;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Common.Mapping.Mapster
{
    public static class MapsterConfigurations
    {
        public static void RegisterMapsterConfiguration(this IServiceCollection services)
        {
            RegisterCommentConfig.Registration();
            RegisterCommentProductConfig.Registration();
            RegisterMasterConfig.Registration();
            RegisterOrdeerConfig.Registration();
            RegisterProductConfig.Registration();
            RegisterReplyProductsConfig.Registration();
            RegisterReplyConfig.Registration();
            RegisterSalonCityConfig.Registration();
            RegisterServiceConfig.Registration();
            RegisterUserConfig.Registration();
            
            TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        }
    }
}