using Microsoft.EntityFrameworkCore;
using SuplyManagement.Contexts;

namespace SuplyManagement.Configurations
{
    public class EnvironmentConfiguration
    {
        private IConfiguration? _configuration;
        private IServiceCollection? _services;

        public EnvironmentConfiguration Service(IServiceCollection services)
        {
            _services = services;
            return this;
        }

        public EnvironmentConfiguration Configuration(IConfiguration configuration)
        {
            _configuration = configuration;
            return this;
        }

        public EnvironmentConfiguration DbConnection()
        {
            var connectionString = _configuration!.GetConnectionString("Database");

            _services!.AddDbContext<SuplyManagementContext>(options =>
            {
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            });

            return this;
        }

        public EnvironmentConfiguration UseCors()
        {
            var client = _configuration!["BaseUrl:Client"];

            _services!.AddCors(option =>
            {
                option.AddPolicy("AllowOrigin", policy =>
                {
                    policy.WithOrigins(client!);
                    policy.AllowAnyHeader();
                    policy.AllowAnyMethod();
                    policy.AllowAnyOrigin();
                });
            });

            return this;
        }
    }
}
