namespace Inheritance
{
    class Program
    {
        static void Main(string[] agrs)
        {

            Customer customer = new Customer();
            Student student = new Student();
            student.Departmant = "Software";

            Person[] person = new Person[3]
            {
            new Customer
            {FirstName =  "Tuana" },
            new Student
            {FirstName = "Yunus"},
            new Person
            {FirstName = "Ali"}
            };
            foreach (var item in person)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }
    }


    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}