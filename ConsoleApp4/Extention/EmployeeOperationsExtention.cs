using ConsoleApp4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Extention
{

    static class EmployeeOperationsExtention
    {
        public static void ExecuteCommand(this EmployeeOperations employeeOperations, List<Employee> Employees)
        {
            switch (employeeOperations)
            {
                case EmployeeOperations.Add:
                    Employees.AddEmployee(); break;
                case EmployeeOperations.Write:
                    Employees.WriteEmployees(); break;
                case EmployeeOperations.Find:
                    Employees.FindEmployee(); break;
                case EmployeeOperations.Delete:
                    Employees.WriteEmployees();
                    Employees.DeleteEmployee(); break;
                case EmployeeOperations.Edit:
                    Employees.WriteEmployees();
                    Employees.EditEmployee(); break;
            }
        }
    }
}
