﻿using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Interfaces
{
    public interface IEmployeeService
    {
        public void Add(Employee employee);

        public Employee[] GetAll();

        public Employee GetById(int id);

        public bool CheckIsVIP(Employee employee);
    }
}

