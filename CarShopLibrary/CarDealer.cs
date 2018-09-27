using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopLibrary
{
    public class CarDealer
    {
        List<Customer> CustomerList = new List<Customer>();
        List<Car> CarList = new List<Car>();

        public void AddCustomerToList(Customer customer)
        {
            CustomerList.Add(customer);
        }

        public void AddCarToList(Car car)
        {
            CarList.Add(car);
        } 

        public string GetCustomersFromList()
        {
            string output = "";
            var customerlist = from Customer in CustomerList select Customer;
            foreach(var v in customerlist)
            {
                output = "Customer Name: " + v.Name + ", Phonenumber: " + v.Phonenumber + ", Type: " + v.type + "\n";
            }
            return output;
        } 
        public string GetCarsFromList()
        {
            string output = "";
            var carlist = from Car in CarList select Car;
            foreach (var v in carlist)
            {
                output = "Car Brand: " + v.Brand + ", Year: " + v.Year + "\n";
            }
            return output;
        }
    }
}
