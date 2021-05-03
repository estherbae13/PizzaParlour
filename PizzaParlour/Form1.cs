using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlour
{
    public partial class Form1 : Form
    {
        //global varities
        double basePrice = 7.00;
        double toppingPrice = 1.25;
        double toppingNumber;
        double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declare topping number
                toppingNumber = Convert.ToDouble(toppingsInput.Text);

                //calculate total price
                total = basePrice + toppingNumber * toppingPrice;

                //show final price
                toppingsOutput.Text = $"The price of the pizza with {toppingNumber} toppings is ${total}.";
            }
            catch
            {
                toppingsOutput.Text = "Please enter a numerical value.";
            }
        }
    }
}
