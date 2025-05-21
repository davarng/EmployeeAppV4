using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeesApp.Web.Models
{
    public class MyLogFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Action is about to be executed");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Action has now been excuted");
        }
    }
}
