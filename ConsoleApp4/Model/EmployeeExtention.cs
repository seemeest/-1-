namespace ConsoleApp4.Model
{
    public static class EmployeeExtention 
    {
        private static string ReadInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        public static void AddCommand(this List<Employee> Employees)
        {
            var newEmployee = new Employee() {
                FirstName = ReadInput("Введите FirstName: "),
                LastName = ReadInput("Введите LastName: "),
                Age = ReadInput("Введите Age: "),
                Position = ReadInput("Введите Position: "),
            };
            Employees.Add(newEmployee);
        }
        public static void WriteComman(this IEnumerable<Employee> Employees)
        {
            var i = 0;
            Employees.ToList().ForEach(e => { Console.WriteLine($"{i}) {e}"); i++; });
        } 
        public static void FindComman(this IEnumerable<Employee> Employees)
        {
            var param = ReadInput("Введите имя ,фамилию  или должность ");
            var result = Employees.Where(e => e.FirstName.Contains(param)|| e.LastName.Contains(param) || e.Position.Contains(param));
            if(result.Any())
            {
                WriteComman(result);
               return;
            }
            Console.WriteLine("сотрудник не найден");
        } 
        public static void DeleteComman(this List<Employee> Employees)
        {
            Console.WriteLine("Введите номер");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Employees.RemoveAt(n); return;
            }
            Console.WriteLine("неверный номер");
        }
        public static void EditComman(this List<Employee> Employees)
        {
            Console.WriteLine("Введите номер");
            if (int.TryParse(Console.ReadLine(), out int i))
            {
                Console.WriteLine("Введите новые значения/чтобы не менять значения введите пробел ");
                Employees[i].FirstName = ReadInput("Введите FirstName: ");
                Employees[i].LastName = ReadInput("Введите LastName: ");
                Employees[i].Age = ReadInput("Введите Age: ");
                Employees[i].Position = ReadInput("Введите Position: ");

            }
            Console.WriteLine("неверный номер");
           
        }
    }
}
