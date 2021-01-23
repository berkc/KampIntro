using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi " + customer.CustomerName);
        }

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi " + customer.CustomerName);
        }

        public void CustomerList(Customer[] customer)
        {
            foreach (Customer customer1 in customer)
            {
                Console.WriteLine(customer1.CustomerName);
            }
        }
    }
}
