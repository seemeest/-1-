using ConsoleApp4.Model;

namespace ConsoleApp4.Extention
{

    /// <summary>
    /// Extension метод (метод расширения) добавляет новый функционал List Employee <br/>
    /// Методы:<br />
    /// AddEmployee - добавление нового работника в список <br />
    /// WriteEmployees - вывод всех работников в списке <br />
    /// FindEmployee - метод поиска по имени ,фамилии и должности <br />
    /// DeleteEmployee - удаление работника по индексу из коллекции <br />
    /// EditEmployee - измиинение данные сотрудника<br />
    /// </summary>
    static class EmployeeExtension
    {

        /// <summary>
        /// Метод для сокращения числа строк для удобного считывания 
        /// </summary>
        /// <param name="prompt"> текст для вывода </param>
        /// <example> FirstName = ReadInput("Введите FirstName: "),  </example>
        /// <returns> Console.ReadLine()</returns>
        private static string ReadInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /// <summary>
        /// добавление нового работника в список 
        /// </summary>
        /// <param name="Employees"></param>
        public static void AddEmployee(this List<Employee> Employees)
        {
            var newEmployee = new Employee
            {
                FirstName = ReadInput("Введите FirstName: "),
                LastName = ReadInput("Введите LastName: "),
                Age = ReadInput("Введите Age: "),
                Position = ReadInput("Введите Position: ")
            };
            Employees.Add(newEmployee);
        }
        /// <summary>
        /// вывод всех работников в списке
        /// </summary>
        /// <param name="Employees"></param>
        public static void WriteEmployees(this IEnumerable<Employee> Employees)
        {
            var i = 0;
            Employees.ToList().ForEach(e => { Console.WriteLine($"{i}) {e}"); i++; });
        }
        /// <summary>
        /// метод поиска по имени ,фамилии и должности 
        /// </summary>
        /// <param name="Employees"></param>
        public static void FindEmployee(this IEnumerable<Employee> Employees)
        {
            var param = ReadInput("Введите имя, фамилию или должность: ");
            var result = Employees.Where(e => e.FirstName.Contains(param) ||
                                              e.LastName.Contains(param) ||
                                              e.Position.Contains(param));

            if (result.Any())
            {
                result.WriteEmployees();
                return;
            }
            Console.WriteLine("Сотрудник не найден");
        }
        /// <summary>
        /// удаление работника по индексу из коллекции
        /// </summary>
        /// <param name="Employees"></param>
        public static void DeleteEmployee(this List<Employee> Employees)
        {
            if (int.TryParse(ReadInput("Введите номер: "), out int n))
            {
                Employees.RemoveAt(n);
                return;
            }
            Console.WriteLine("Неверный номер");
        }
        /// <summary>
        /// измиинение данные сотрудника
        /// </summary>
        /// <param name="Employees"></param>
        public static void EditEmployee(this List<Employee> Employees)
        {
            if (int.TryParse(ReadInput("Введите номер: "), out int i))
            {
                Console.WriteLine("Введите новые значения/чтобы не менять значения введите пробел ");
                Employees[i].FirstName = ReadInput("Введите FirstName: ");
                Employees[i].LastName = ReadInput("Введите LastName: ");
                Employees[i].Age = ReadInput("Введите Age: ");
                Employees[i].Position = ReadInput("Введите Position: ");
            }
            else
            {
                Console.WriteLine("Неверный номер");
            }
        }
    }
}
