using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer();


            customer1.CustomerName = "Berk";
            customer1.CustomerLastName = "Colak";

            Customer customer2 = new Customer();

            customer2.CustomerName = "Berk2";
            customer2.CustomerLastName = "Colak2";

            Customer[] customers = new Customer[] { customer1,customer2 };


            customerManager.CustomerAdd(customer1);

            customerManager.CustomerDelete(customer1);

            customerManager.CustomerList(customers);

        }
    }
}
