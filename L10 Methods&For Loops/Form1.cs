using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L10_Methods_For_Loops
{
    public partial class Form1 : Form
    {
        //global variables
        double salePrice; // the amount entered by user to add tax to
        int integerToSquare; // the value entered by user to find the square of
        string firstName, lastName; //strings entered by user to reorder there name
        int noItems; //user enters number of items wanted
        double itemCost; //user enters cost of each item
        public Form1()
        {
            InitializeComponent();
        }

        //the taxCalc method will use the parameter of salePrice and make the calculation to find
        // total price after tax
        private void taxCalc(double salePrice)
        {
            //local variables withTax because it will only be used in this method
            double withTax = salePrice * 1.13;
            afterTaxOutput.Text = "The price after tax is $" + withTax.ToString("F2");
        }
        private void calculateTotalPrice_Click(object sender, EventArgs e)
        {
            try 
            {
                salePrice = Convert.ToDouble(beforeTaxBox.Text);
                //when sending a variable to a method, just include it in the ()
                taxCalc(salePrice);
            }
            catch
            {
                afterTaxOutput.Text = "please enter a dollar amount";
            }

        }

        //when we want the method to return a value to the program, we reply
        // with the type of variable to return
        private double calcTotalPrice(double salePrice)
        {
            return salePrice * 1.13;
        }

        private void calcTotalPrice2_Click(object sender, EventArgs e)
        {
            try
            {
                salePrice = Convert.ToDouble(beforeTaxBox2.Text);
                //if your method returns a value, we set a variable equal to that method to call on it
                double withTax = calcTotalPrice(salePrice);
                afterTaxOutput2.Text = "The price after tax is $" + withTax.ToString("F2");
            }
            catch
            {
                afterTaxOutput2.Text = "please enter a dollar amount";
            }
        }

        //the method squareNumber will take any integer 'n' and return the squared value
        //notice the name of the variable 'n' does not need to be the same as the variable
        // name passed to it (integerToSquare)
        private int squareNumber(int n)
        {
            return n * n;
        }

        private void calcSquareButton_Click(object sender, EventArgs e)
        {
            try
            {
                integerToSquare = Convert.ToInt16(squareTextBox.Text);
                //you can call on the function within the output statement
                squaredOutputLabel.Text = integerToSquare + " squared is " + squareNumber(integerToSquare);
            }
            catch
            {
                squaredOutputLabel.Text = "please enter an integer value";
            }
        }

        private string makeGreeting (string firstName, string lastName)
        {
            string greeting = "Hello! " + firstName + " " + lastName + "! Welcome to the program!";
            return greeting;
        }

        private void reOrderButton_Click(object sender, EventArgs e)
        {
            //notice when reading in a string we don't need try catch as
            // strings can take on any character without error
            firstName = firstNameBox.Text;
            lastName = lastNameBox.Text;
            string outputGreeting = makeGreeting(firstName, lastName);
            nameOutputLabel.Text = outputGreeting;
        }

        //calcCost will read the variables (int) for number of items
        // and (double) itemCost to put the total cost (not including tax)
        private double calcCost(int noItems, double itemCost)
        {
            return noItems * itemCost;
        }

        private void calcTotalPriceButton_Click(object sender, EventArgs e)
        {
            try
            {
                double item = Convert.ToDouble(itemCostBox.Text);
                int noItems = Convert.ToInt16(numberOfItemsBox.Text);
                totalPriceOutputLabel.Text = "$" + calcCost(noItems, item).ToString("F2");
            }
            catch
            {
                totalPriceOutputLabel.Text = "enter an integer";
            }
        }

        private void forLoopsButton_Click(object sender, EventArgs e)
        {
            ForLoopsForm forLoopsForm = new ForLoopsForm();
            forLoopsForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
