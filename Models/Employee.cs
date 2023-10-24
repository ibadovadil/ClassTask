namespace Task.Models
{
    internal class Employee
    {
        private string name;
        private string surname;
        private string username;
        private byte age;
        
        public Employee(string name , string username , string surname , byte age) {
            Name = name;
            Surname = surname;
            Username = username;
            Age = age;
        }
        public string Name
        {
            get { return name; }
            set { 
                if (!string.IsNullOrEmpty(value)) {
                  name=  char.ToUpper(value[0]) + value.Substring(1);
                }
                else
                {
                    Console.WriteLine("Name can not null or empty");
                }
            }
        }


        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = $"{Name}_{Surname}";}
            //set { username = name + "_" + surname; }
        }

        public byte Age
        {
            get {
                if (age <=0 )
                {
                    Console.WriteLine("age cannot be less than 0 and 0");
                }
                return age; }
            set { age = value; }
        }



    }
}
