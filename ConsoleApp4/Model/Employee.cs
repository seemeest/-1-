namespace ConsoleApp4.Model
{

    /// <summary>
    /// Модель сотрудника
    /// </summary>
    public class Employee
    {
        
        private string _firstName;
        private string _lastName;
        private string _age;
        private string _position;

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName
        {
            get => _firstName;
            set
            {
                // ессли Space || Emety || Null - не меняем _firstName
                if (!string.IsNullOrWhiteSpace(value))
                    _firstName = value;
            }
        }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get => _lastName;
            set
            {
                // ессли Space || Emety || Null - не меняем _lastName
                if (!string.IsNullOrWhiteSpace(value))
                    _lastName = value;
            }
        }
        /// <summary>
        /// Возраст
        /// </summary>
        public string Age
        {
            get => _age;
            set
            {
                // ессли Space || Emety || Null - не меняем _age
                if (!string.IsNullOrWhiteSpace(value))
                    _age = value;
            }
        }
        /// <summary>
        /// Должность
        /// </summary>
        public string Position
        {
            get => _position;
            set
            {
                // ессли Space || Emety || Null - не меняем _position
                if (!string.IsNullOrWhiteSpace(value))
                    _position = value;
            }
        }


        /// <summary>
        /// Переопределил метод  ToString() для удобного вывода
        /// </summary>
        /// <returns>  $" First Name : {FirstName}, Last Name : {LastName}, Age : {Age}, Position : {Position}"  </returns>
        public override string ToString()
        {
            return $" First Name : {FirstName}, Last Name : {LastName}, Age : {Age}, Position : {Position}";
        }
    }

}
