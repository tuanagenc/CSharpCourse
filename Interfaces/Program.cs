using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            {
             
            }
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demirog",
                Address = "Ankara"
            };


            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demirog",
                Departman = "Computer Sciences"
            };
        }

    
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departman { get; set; }
    }
    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}