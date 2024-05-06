namespace ConsoleApp4.Model
{
    public  enum EmployeeOperations
    {
        Add=1,
        Write,
        Find,
        Delete,
        Edit
    }

    public static class EmployeeOperationsExtention
    {
        public static void ExecuteCommand(this EmployeeOperations employeeOperations, List<Employee> Employees)
        {
            switch (employeeOperations)
            {
                case EmployeeOperations.Add:
                    Employees.AddCommand(); break;
                case EmployeeOperations.Write:
                    Employees.WriteComman(); break;
                case EmployeeOperations.Find:
                    Employees.FindComman(); break;
                case EmployeeOperations.Delete:
                    Employees.WriteComman();
                    Employees.DeleteComman(); break;
                case EmployeeOperations.Edit:
                    Employees.WriteComman();
                    Employees.EditComman(); break;
            }
        }
    }
}
