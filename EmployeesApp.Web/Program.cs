using EmployeesApp.Web.Interfaces;
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
            builder.Services.AddSingleton<IEmployeeService,OtherEmployeeService>();//Employee is Added to the list because it is create one employee service.

            // 1E. It is easier to change which service is used so you can use different ones for testing while only changing one line of code.
            //     Lifespan of the service can easily be controlled by the builder.Services by changing it to AddTransient, AddScoped or AddSingleton.
            //     Easier to maintain and test the code.

            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}