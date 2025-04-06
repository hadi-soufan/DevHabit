using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace DevHabit.Api.Extensions;

public static class ControllerExtension
{
    public static IServiceCollection AddCustomControllers(this IServiceCollection services)
    {
        services.AddControllers(options =>
        {
            options.ReturnHttpNotAcceptable = true;
        })
        .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver =
            new CamelCasePropertyNamesContractResolver())
        .AddXmlSerializerFormatters();

        return services;
    }
}
