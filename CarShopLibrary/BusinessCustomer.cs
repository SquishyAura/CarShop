using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopLibrary
{
    public class BusinessCustomer : Customer
    {
        public BusinessCustomer(string name, int phonenumber, string type)
        {
            this.Name = name;
            this.Phonenumber = phonenumber;
            this.type = (Type)Enum.Parse(typeof(Type), type);
        }
    }
}
