using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Drink
    {
        private double size;
        private double percent;
        private double number;

        private List<Data> list_capacity = null;
        private List<Data> list_of_drinks = null;


        public Drink(double _size, double _percent, double _number, List<Data> _list_capacity, List<Data> _list_of_drinks)
        {
            size = _size;
            percent = _percent;
            number = _number;
            list_capacity = _list_capacity;
            list_of_drinks = _list_of_drinks;
        }

        public double DrinkSize()
        {
            return size * number;
        }

        public double DrinkAlcoholSize()
        {
            return (size * number) * (percent / 100);
        }
    }
}
