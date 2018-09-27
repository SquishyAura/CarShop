using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarShopLibrary;

namespace CarShop
{
    public partial class CarShopForm : System.Web.UI.Page
    {
        CarDealer mycarshop = new CarDealer();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BuyButton_Click(object sender, EventArgs e)
        {
            mycarshop.AddCarToList(new Car(BrandBox.Text, Convert.ToInt32(YearBox.Text)));
        }

        protected void SignUpButton_Click(object sender, EventArgs e)
        {
            if(PrivateRadio.Checked == true)
            {
                mycarshop.AddCustomerToList(new PrivateCustomer(NameBox.Text, Convert.ToInt32(PhoneNumberBox.Text), "Private"));
            } 
            else if (BusinessRadio.Checked == true)
            {
                mycarshop.AddCustomerToList(new BusinessCustomer(NameBox.Text, Convert.ToInt32(PhoneNumberBox.Text), "Business"));
            }
        }

        protected void CarShowButton_Click(object sender, EventArgs e)
        {
            if (mycarshop.GetCarsFromList().Equals("")){
                CarLabel.Text = "List is currently empty";
            }
            CarLabel.Text = "hej nigga"; //mycarshop.GetCarsFromList();

        }

        protected void ShowCustomerButton_Click(object sender, EventArgs e)
        {

        }
    }
}