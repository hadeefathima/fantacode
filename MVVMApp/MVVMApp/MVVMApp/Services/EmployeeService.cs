using MVVMApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMApp.Services
{
   public class EmployeeService
    {
        public List<Employee> GetEmployees()
        {
            var list = new List<Employee>
            {
                new Employee
                {
                    Name="jasna",
                    Department="EEE"
                },
                new Employee
                {
                    Name="FIDA",
                    Department="CSE"
                }
            };
            return list;
        }
    }
}
