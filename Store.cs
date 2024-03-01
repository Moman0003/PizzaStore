using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Store
    {
        public void Start()
        {

            Pizza p1 = new Pizza("Margherita", 65);
            Pizza p2 = new Pizza("Calzone", 95);
            Pizza p3 = new Pizza("Fire årstider", 105);

            Customer c1 = new Customer("john","e@mail.com","street X","XXXX");
            Customer c2 = new Customer("Moman", "e@mail.com", "street X", "XXXX");
            Customer c3 = new Customer("Jens", "e@mail.com", "street X", "XXXX");

            Order o1 = new Order(p1, c1);
            Order o2 = new Order(p2, c2);
            Order o3 = new Order(p3, c3);

            Console.WriteLine("Menu:");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.WriteLine();

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);


            Console.WriteLine(c3);

        }
    }
}