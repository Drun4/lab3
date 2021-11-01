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

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Data> list_capacity = new List<Data>();
            list_capacity.Add(new Data() { Name = "Bottle", Value = 500});
            list_capacity.Add(new Data() { Name = "Glass", Value = 200});
            list_capacity.Add(new Data() { Name = "Wineglass", Value = 170});
            list_capacity.Add(new Data() { Name = "Short", Value = 50});
            comboValueBox.DataSource = list_capacity;
            comboValueBox.DisplayMember = "Name";
            comboValueBox.ValueMember = "Value";

            List<Data> list_of_drinks = new List<Data>();
            list_of_drinks.Add(new Data() { Name = "Bear", Value = 10 });
            list_of_drinks.Add(new Data() { Name = "Whiskey", Value = 50 });
            list_of_drinks.Add(new Data() { Name = "Wine", Value = 18 });
            list_of_drinks.Add(new Data() { Name = "Vodka", Value = 40});
            comboPercentBox.DataSource = list_of_drinks;
            comboPercentBox.DisplayMember = "Name";
            comboPercentBox.ValueMember = "Value";

            sizeOfVeselBox.Text = "";
            percentOfAlchBox.Text = "";
            amountOfVeselsBox.Text = "";
            valueOfDrinksBox.Text = "";
            valueOfPureAlchBox.Text = "";
        }

        private void comboValueBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Data obj = comboValueBox.SelectedItem as Data;
            sizeOfVeselBox.Text = obj.Value.ToString();
        }
        
        private void comboPercentBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Data obj = comboPercentBox.SelectedItem as Data;
            percentOfAlchBox.Text = obj.Value.ToString();
        }

    }
}
