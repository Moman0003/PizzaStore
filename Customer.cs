using System;

namespace PizzaStore
{
    public class Customer
    {
        string _name;
        string _email;
        string _adresse;
        string _tlfnr;

        public Customer(string name, string email, string adresse, string tlfnr)
        {
            _name = name;
            _email = email;
            _adresse = adresse;
            _tlfnr = tlfnr;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Tlfnr
        {
            get { return _tlfnr; }
            set { _tlfnr = value; }
        }

        public override string ToString()
        {
            return $"Navn: {Name} - Telefon nummer: {Tlfnr} - Email: {Email} - Adresse: {Adresse}";
        }


    }
}
