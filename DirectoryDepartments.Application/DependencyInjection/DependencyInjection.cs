using DirectoryDepartments.Application.Services;
using DirectoryDepartments.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DirectoryDepartments.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.InitServices();
        }
        public static void InitServices(this IServiceCollection services)
        {
            //services.AddScoped<IEmployeeService, EmployeeService>();
            //services.AddScoped<IDivisionService, DivisionService>();
            //services.AddHostedService<MigrationsHostedService>();
            //services.AddAutoMapper(typeof(DivisionMapping), typeof(EmployeeMapping));
        }
    }
}
