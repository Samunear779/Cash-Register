//ICS3U Cash Registor Summative
//Mr.T
//October 16, 2016 

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
        // Declare constants and variables 
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
        double tendered;
        double change;

        public Form1()
        {
                       InitializeComponent();
        }
        
        //creating brushes pens and fonts for the graphics
        private void print_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(Color.White, 10);
            Pen whitePen = new Pen(Color.White, 10);

            formGraphics.FillRectangle(whiteBrush, 375, 110, 300, 335);
            Font drawFont = new Font("Courier New", 10, FontStyle.Bold);

            //Use Drawstring to print reicpt
            formGraphics.DrawString("Sam's Food Fun", drawFont, blackBrush, 470, 110);
            formGraphics.DrawString("Order Number 107", drawFont, blackBrush, 375, 130);
            formGraphics.DrawString("October 13, 2016", drawFont, blackBrush, 375, 150);
            formGraphics.DrawString("Burger x " +burgerQ+"................ $"+burgerQ * BURGER, drawFont, blackBrush, 375, 190);
            formGraphics.DrawString("Fries x " + friesQ + "................. $" + friesQ * FRIES, drawFont, blackBrush, 375, 210);
            formGraphics.DrawString("Wraps x " + wrapQ + "................. $" + wrapQ * WRAP, drawFont, blackBrush, 375, 230);
            formGraphics.DrawString("Drink x " + drinkQ + "................. $" + drinkQ * DRINK, drawFont, blackBrush, 375, 250);
            formGraphics.DrawString("Subtotal ..................$" +subtotal, drawFont, blackBrush, 375, 290);
            formGraphics.DrawString("Tax ...................... " + taxA.ToString("C"), drawFont, blackBrush, 375, 310);
            formGraphics.DrawString("Total .................... " + total.ToString("C"), drawFont, blackBrush, 375, 330);
            formGraphics.DrawString("Tendered ................. " + tendered.ToString("C"), drawFont, blackBrush, 375, 370);
            formGraphics.DrawString("Change ................... " + change.ToString("C"), drawFont, blackBrush, 375, 390);
            formGraphics.DrawString("Have A Good Day", drawFont, blackBrush, 470, 410);

        }

        //resets labels,text boxs, and graohics
        private void newOrder_Click(object sender, EventArgs e)
        {
            inputB.Text = Convert.ToString(0);
            inputF.Text = Convert.ToString(0);
            inputW.Text = Convert.ToString(0);
            inputD.Text = Convert.ToString(0);
            givenMoney.Text = Convert.ToString(0);
            Graphics formGraphics = this.CreateGraphics();
            formGraphics.Clear(Color.LightSeaGreen);
            outputLabel.Text = "    ";
        }

        //Calculates the amount of change that the costumer needs 
        private void calculateChange_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToInt32(givenMoney.Text);
            change = tendered - total;
            outputLabel.Text += "\nChange                          " + change.ToString("C");
        }

        //Calculates totals by saving textboxs to variables then using math to determine the totals
        private void calculateTotals_Click(object sender, EventArgs e)
        {
            try //Determines if there is an error 
            {
                burgerQ = Convert.ToInt32(inputB.Text);
                friesQ = Convert.ToInt32(inputF.Text);
                wrapQ = Convert.ToInt32(inputW.Text);
                drinkQ = Convert.ToInt32(inputD.Text);

                subtotal = burgerQ * BURGER + friesQ * FRIES + wrapQ * WRAP + drinkQ * DRINK;
                taxA = TAX * subtotal;
                total = taxA + subtotal;

                outputLabel.Text = "Subtotal                          " + subtotal.ToString("C");
                outputLabel.Text += "\nTax                                  " + taxA.ToString("C");
                outputLabel.Text += "\nTotal                               " + total.ToString("C");
            }

            catch // display error message if input is not a number 
            {
                outputLabel.Text = "You must enter an integer";
            }
        }
    }
}
