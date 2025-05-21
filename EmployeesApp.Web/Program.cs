using EmployeesApp.Web.Services;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //First commit
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            //builder.Services.AddTransient<EmployeeService>();//Employee do not Added to the list because instanse of employee service is created every time we use the controller.
            //builder.Services.AddScoped<EmployeeService>();
            builder.Services.AddSingleton<EmployeeService>();//Employee is Added to the list because it is create one employee service.

            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}