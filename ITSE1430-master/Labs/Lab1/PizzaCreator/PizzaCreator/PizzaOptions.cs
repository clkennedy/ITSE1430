using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class PizzaOption
    {

        protected string _name;
        protected double _cost;

        public PizzaOption(string name, double cost)
        {
            this._name = name;
            this._cost = cost;
        }

        public override string ToString()
        {
            return this._name + " (" + Math.Round(this._cost, 2) + ")";
        }

    }
}
