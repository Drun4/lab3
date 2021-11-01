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

        public Drink(double _size, double _percent, double _number)
        {
            size = _size;
            percent = _percent;
            number = _number;
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
