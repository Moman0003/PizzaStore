using System;
namespace PizzaStore
{
	public class Butik
	{

        private string _name;
        private string _location;
        private string _contactinfo;

        public Butik(string name, string location, string contactinfo)
        {
            _name = name;
            _location = location;
            _contactinfo = contactinfo;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string Contactinfo
        {
            get { return _contactinfo; }
            set { _contactinfo = value; }
        }


        public override string ToString()
        {
            return $"{Name} - Find os her: {Location} - Kontakt os på: {Contactinfo}";
        }



        
    }
}

