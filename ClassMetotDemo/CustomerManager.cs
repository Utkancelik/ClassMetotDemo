using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {


        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("{0} Id'sine sahip {1} adlı müşterimiz sisteme eklenmiştir", customer.Id, customer.FirstName);
        }


        public void GetList()
        {
            

            Customer customer1 = new Customer();
            customer1.Id = 1111;
            customer1.FirstName = "Halil";
            customer1.LastName = "Soymaz";

            Customer customer2 = new Customer();
            customer2.Id = 1111;
            customer2.FirstName = "Kudriyaşov";
            customer2.LastName = "Bekmez";

            Customer customer3 = new Customer();
            customer3.Id = 1111;
            customer3.FirstName = "Şasir";
            customer3.LastName = "Damdan";

            Customer[] customers = new Customer[] {customer1,customer2,customer3 };


            for (int i = 1; i <= customers.Length; i++)
            {
                Console.WriteLine("{0}. Müşterimiz {1} {2} bey.", i, customers[i-1].FirstName, customers[i-1].LastName);
            }
        }

        public void DeletingCustomer(Customer customer)
        {

            Console.WriteLine("Bunu yapamadım ya");

            
            
        }
    }
}
