using Task.Models;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("adil", "" , "Ibadov" , 20);
            Company company = new Company("Code Academy" );
            company.AddUser( employee );
            Console.WriteLine("Employee Name : " + employee.Name);
            Console.WriteLine("Employee Surname : " + employee.Surname);
            Console.WriteLine("Employee username : " + employee.Username);
            Console.WriteLine("Employee Age : " + employee.Age);
            Console.WriteLine("Company Name : " + company.Name);
        }

    }
}