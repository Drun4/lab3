using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Drink drink = null;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (sizeOfVeselBox.Text.Equals("") || percentOfAlchBox.Text.Equals("") || amountOfVeselsBox.Equals(""))
            {
                valueOfDrinksBox.Text = "Mistake";
                valueOfPureAlchBox.Text = "Mistake";
            }
            else
            {
                double _size = double.Parse(sizeOfVeselBox.Text);
                double _percent = double.Parse(percentOfAlchBox.Text);
                double _number = double.Parse(amountOfVeselsBox.Text);
                drink = new Drink(_size, _percent, _number);

                valueOfDrinksBox.Text = drink.DrinkSize().ToString();
                valueOfPureAlchBox.Text = drink.DrinkAlcoholSize().ToString();
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            drink = null;
            sizeOfVeselBox.Text = "";
            percentOfAlchBox.Text = "";
            amountOfVeselsBox.Text = "";
            valueOfDrinksBox.Text = "";
            valueOfPureAlchBox.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
