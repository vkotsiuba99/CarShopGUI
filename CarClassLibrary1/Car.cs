using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            Make = "nothing";
            Model = "nothing";
            Price = 0.00M;
        }

        public Car(string Make, string Model, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Price = Price;
        }

        override public string ToString()
        {
            return Make + " " + Model + " Price: $" + Price;
        }
    }
}
