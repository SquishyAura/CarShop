using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopLibrary
{
    public class Car
    {
        public string Brand { get; set; }
        private int year;

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }
        public Car(string brand, int year)
        {
            this.Brand = brand;
            this.Year = year;
        }

       
    }
}
