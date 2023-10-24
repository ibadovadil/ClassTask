namespace Task.Models
{
    internal class Company
    {
        private string name;
        private Employee[] employees = new Employee[0];

        public Company(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public void AddUser(Employee item) {
            Array.Resize(ref employees, 0);
        }
    }
} 
