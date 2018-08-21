using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class PizzaOption
    {
        public static List<PizzaSize> AllSizes = new List<PizzaSize>(){
                                                        new PizzaSize("Small", 5),
                                                        new PizzaSize("Medium", 6.25),
                                                        new PizzaSize("Large", 8.75)};

        public static List<Meat> AllMeats = new List<Meat>(){ new Meat("Bacon", .75),
                                                        new Meat("Ham", .75),
                                                        new Meat("Papperoni", .75),
                                                        new Meat("Sausage", .75)};


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
