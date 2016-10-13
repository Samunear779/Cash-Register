using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        const double BURGER = 2.49;
        const double FRIES = 1.89;
        const double WRAP = 2.99;
        const double DRINK = 0.99;
        const double TAX = 0.13;
        double total;
        double burgerQ;
        double friesQ;
        double wrapQ;
        double drinkQ;
        double subtotal;
        double taxA;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                burgerQ = Convert.ToInt32(inputB.Text);
                friesQ = Convert.ToInt32(inputF.Text);
                wrapQ = Convert.ToInt32(inputW.Text);
                drinkQ = Convert.ToInt32(inputD.Text);
                subtotal = burgerQ * BURGER + friesQ * FRIES + wrapQ * WRAP + drinkQ * DRINK;
                taxA = subtotal * TAX;
                total = subtotal + taxA; //hey


                outputLabel.Text = "Subtotal                        " + subtotal.ToString("C");
                outputLabel.Text += "\nTax                          " + taxA.ToString("C");
                outputLabel.Text += "\nTotal                        " + total.ToString("C");
            }

            catch // display error message if input is not a number 
            {
                outputLabel.Text = "You must enter an integer you silly";
            }
        }

        private void burger_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
