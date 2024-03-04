using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Pizza
    {
        string _name;
        string _toppings;
        int _price;

        public Pizza()
        {
            _name = "";
            _toppings = "";
            _price = 0;
        }

        public Pizza(string name, string toppings, int price)
        {
            _name = name;
            _toppings = toppings;
            _price = price;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Toppings
        {
            get { return _toppings; }
            set { _toppings = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }


        public override string ToString()
        {
            return $"{Name}: {Toppings} - Pris: {Price}kr.";
        }
    }
}