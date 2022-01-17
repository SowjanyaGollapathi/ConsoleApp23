using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CustomerContext())
            {
                List<CustomerDetails> customers = context.CustomerDetails.ToList();
                foreach(var customer in customers)
                {
                    Console.WriteLine(customer.Id);
                    Console.WriteLine(customer.Name);
                    Console.WriteLine(customer.Address);
                    Console.WriteLine(customer.PhoneNo);
                    Console.WriteLine(customer.Location);

                }
            }
            
        }
    }
}
