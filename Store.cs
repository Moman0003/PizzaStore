﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Store
    {


        public void Start()
        {
            Butik b = new Butik("Big Mammas Pizzeria", "Frederiksværksgade 4, 3400 Hillerød", "1234 5678");


            Pizza p1 = new Pizza("Margherita", "Tomat og ost", 80);
            Pizza p2 = new Pizza("Calzone", "Tomat, ost, skinke og champignoner", 98);
            Pizza p3 = new Pizza("Italiana","Tomat, ost, løg og kødsauce", 93);

            Customer c1 = new Customer("Jens","Jens@mail.com","vejnavn og nummer","1234 5678");
            Customer c2 = new Customer("Moman", "Moman@mail.com", "vejnavn og nummer", "1234 5678");
            Customer c3 = new Customer("Peter", "Peter@mail.com", "vejnavn og nummer", "1234 5678");

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

            Console.WriteLine();

            Console.WriteLine("Kunder:");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(b);

        }
    }
}