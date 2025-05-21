using EmployeesApp.Web.Interfaces;
using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class OtherEmployeeService : IEmployeeService
    {
        readonly List<Employee> employees =
        [
            new Employee()
            {
                Id = 562,
                Name = "Kristina",
                Email = "Anders.Hejlsberg@outlook.com",
            },
            new Employee()
            {
                Id = 62,
                Name = "Petter",
                Email = "k.d@outlook.com",
            },
            new Employee()
            {
                Id = 15662,
                Name = "Olle",
                Email = "Admin.Torgersen@outlook.com",
            },
            new Employee()
            {
                Id = 52,
                Name = "Sara",
                Email = "s.h@outlook.com",
            },
            new Employee()
            {
                Id = 563,
                Name = "Felicia",
                Email = "j.s@outlook.com",
            },
        ];

        public void Add(Employee employee)
        {
            employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }


        // Collection expression syntax, introduced in C# 12.
        public Employee[] GetAll() => [.. employees.OrderBy(e => e.Name)];

        ////Classic C# syntax for GetAll()
        //public Employee[] GetAll()
        //{
        //    return employees
        //        .OrderBy(e => e.Name)
        //        .ToArray();
        //}

        public Employee GetById(int id) => employees
            .Single(e => e.Id == id);

        public bool CheckIsVIP(Employee employee) =>
            employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);
    }
}
