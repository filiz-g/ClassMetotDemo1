using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class CustomerManagers
    {
        public void Add(Customers customers)
        {
            Console.WriteLine("Customer Added : " + customers.Id + " " + customers.name + " " + customers.surname + " " + customers.Age + " " + customers.Iban);
        }

        public void Delete(Customers customers)
        {
            Console.WriteLine("Customer Deleted: " + customers.Id + " " + customers.name + " " + customers.surname + " " + customers.Age + " " + customers.Iban);
        }

    }
}
