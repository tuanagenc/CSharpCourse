


namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();8
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();




            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.FirstName = "Engin";
            customer.LastName = "Demirog";

            Customer customer2 = new Customer
            {
                Id = 1,
                City = "İstanbul",


            };
            Console.WriteLine(customer.FirstName);
            Console.ReadLine();

        }
    }
}

//    class CustomerManager
//    {
//        public void Add()

//        {
//            Console.WriteLine("Customer Added!");
//        }
//        public void Update()
//        {
//            Console.WriteLine("Customer Updated!");

//        }
//    }
//}

