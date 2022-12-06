using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add (Customer customerNew)
        {

            Console.WriteLine("Customer Added : "+customerNew.CustomerName);

        }
        public void Delete(Customer customerDelete)
        {

            Console.WriteLine("Customer Deleted : "+customerDelete.CustomerName);
        }
        public void List(Customer customer)
        {
            Console.WriteLine(customer.CustomerId);
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerOrderName);
        }


    }
}
