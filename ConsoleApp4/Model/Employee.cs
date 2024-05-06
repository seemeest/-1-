namespace ConsoleApp4.Model
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _age;
        private string _position;


        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _lastName = value;
            }
        }

        public string Age
        {
            get => _age;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _age = value;
            }
        }

        public string Position
        {
            get => _position;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _position = value;
            }
        }

        public override string ToString()
        {
            return $" First Name : {FirstName}, Last Name : {LastName}, Age : {Age}, Position : {Position}";
        }
    }

}
