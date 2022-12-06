using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)


        {

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();

            customer1.CustomerId = 1;
            customer1.CustomerName = "John";
            customer1.CustomerOrderName = "Iphone 5 , Kindle , Story-Book ";

            
            customer2.CustomerId = 2;
            customer2.CustomerName = "Selin";
            customer2.CustomerOrderName = "Iphone 14 , Strawberry , Sci-Fi Books";


            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2 };

           

            Console.WriteLine("----------Options--------------");
            Console.WriteLine("1 : Add");
            Console.WriteLine("2 : Delete");
            Console.WriteLine("3 : List");
            Console.WriteLine("-------------------------------");

            int number;
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                customerManager.Add(customer1);
                customerManager.Add(customer2);
            }
            else if (number == 2)
            {
                customerManager.Delete(customer1);
                customerManager.Delete(customer2);
            }
            else if (number == 3)
            {
                foreach (var selected in customers)
                {
                    customerManager.List(selected);
                }
            }










        }
    }
}
