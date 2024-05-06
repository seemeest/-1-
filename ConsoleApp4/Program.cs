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

    if (int.TryParse(Console.ReadLine(), out int n))
    {
        Console.Clear();
        EmployeeOperations employeeOperations = (EmployeeOperations)n;
        employeeOperations.ExecuteCommand(Employees);

    }

}

