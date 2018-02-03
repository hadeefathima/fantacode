using MVVMApp.Model;
using MVVMApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVVMApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged

    {
        private List<Employee> _employeeList;

        public List<Employee> EmployeeList {
            get { return _employeeList; }
            set
            {
                _employeeList = value;
                
            }
        }
        public MainViewModel()
        {
            var employeeservice = new EmployeeService();
            EmployeeList = employeeservice.GetEmployees();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
