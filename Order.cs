﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore
{
    class Order
    {
        double _taxPct;
        double _deliveryCosts;
        Pizza p;
        Customer c;

        public Order(Pizza pizza, Customer customer)
        {
            c = customer;
            p = pizza;
            TaxPct = 25.0;
            DeliveryCosts = 40.0;
        }

        double TaxPct
        {
            get { return _taxPct; }
            set { _taxPct = value; }
        }

        double DeliveryCosts
        {
            get { return _deliveryCosts; }
            set { _deliveryCosts = value; }
        }

        public override string ToString()
        {
            return $"Order information: {c.Name} - Pizza: {p.Name} - {TaxPct}% moms - Forsendelse pris: {DeliveryCosts}kr. - Total: {CalculateTotalPrice()}";
        }

        public double CalculateTotalPrice()
        {
            return p.Price * (1 + TaxPct / 100) + DeliveryCosts;
        }
    }
}