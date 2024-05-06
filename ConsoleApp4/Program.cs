using ConsoleApp4.Extention;
using ConsoleApp4.Model;

List<Employee> Employees = new List<Employee>();

while (true)
{
    Console.WriteLine("Command:");
    Console.WriteLine("\t1 -  Add a new employee");
    Console.WriteLine("\t2 -  List of employees");
    Console.WriteLine("\t3 -  Find  employees");
    Console.WriteLine("\t4 -  Removing an employee ");
    Console.WriteLine("\t5 -  Edit  employee ");

    var selectOperations = Console.ReadLine();
    Console.Clear();
    if (int.TryParse(selectOperations, out int n))
    {
        EmployeeOperations employeeOperations = (EmployeeOperations)n;
        employeeOperations.ExecuteCommand(Employees);

        //Или
        //((EmployeeOperations)n).ExecuteCommand(Employees);
    }

}

