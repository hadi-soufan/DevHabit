using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace DevHabit.Api.Extensions
{
    public static class OpenTelemetryExtension
    {
        public static void AddCustomOpenTelemetry(this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            services.AddOpenTelemetry()
                .ConfigureResource(resource => resource.AddService(environment.ApplicationName))
                .WithTracing(tracing => tracing
                    .AddHttpClientInstrumentation()
                    .AddAspNetCoreInstrumentation()
                    .AddNpgsql())
                .WithMetrics(metrics => metrics
                    .AddHttpClientInstrumentation()
                    .AddAspNetCoreInstrumentation()
                    .AddRuntimeInstrumentation())
                .UseOtlpExporter();

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddOpenTelemetry(options =>
                {
                    options.IncludeScopes = true;
                    options.IncludeFormattedMessage = true;
                });
            });
        }
    }
}
