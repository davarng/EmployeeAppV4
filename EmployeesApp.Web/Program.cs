namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //First commit
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}