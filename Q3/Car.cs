using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Car
    {
        private string _name;
        private string _brand;
        private string _colour;
        private int _regNumber;

        static private int _lastRegNumber;

        public Car(string name, string brand, string colour)
        {
            Name = name;

            Brand = brand;

            Colour = colour;

            _lastRegNumber++;

            _regNumber = _lastRegNumber;
        }

        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (value == "VW" || value == "Audi" || value == "BMW")
                {
                    _brand = value;
                }
                else
                {
                    _brand = "unknown";
                }
            }

        }
        public string Colour
        { get { return _colour; } set { _colour = value; } }


        public override string ToString()
        {
            return $"Name : {Name}/n Brand : {Brand}/n Colour: {Colour}";
        }
    }
}
