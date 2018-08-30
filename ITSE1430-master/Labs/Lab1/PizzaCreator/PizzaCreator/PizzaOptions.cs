/* Author: Cameron Kennedy
 * Date: 8/22/2018
 * Class: ITSE 1430 MW 5 -7:15
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class PizzaOption
    {
        public static List<PizzaOption> AllSizes = new List<PizzaOption>(){
                                                        new PizzaSize("Small", 5),
                                                        new PizzaSize("Medium", 6.25),
                                                        new PizzaSize("Large", 8.75)};

        public static List<PizzaOption> AllMeats = new List<PizzaOption>(){ new Meat("Bacon", .75),
                                                        new Meat("Ham", .75),
                                                        new Meat("Papperoni", .75),
                                                        new Meat("Sausage", .75)};
        public static List<PizzaOption> AllVeges = new List<PizzaOption>(){
                                                        new Vegetable("Balck Olives", .50),
                                                        new Vegetable("Mushrooms", .50),
                                                        new Vegetable("Onions", .50),
                                                        new Vegetable("Peppers", .50)};

        public static List<PizzaOption> AllSauces = new List<PizzaOption>(){
                                                        new PizzaSauce("Traditional", 0),
                                                        new PizzaSauce("Garlic", 1),
                                                        new PizzaSauce("Oregano", 1) };

        public static List<PizzaOption> AllCheeses = new List<PizzaOption>(){
                                                        new Cheese("Regular", 0),
                                                        new Cheese("Extra", 1.25) };

        public static List<PizzaOption> DeliveryOptions = new List<PizzaOption>(){
                                                        new Delivery("Take Out", 0),
                                                        new Delivery("Delivery", 2.50) };


        protected string _name;
        protected double _cost;

        public double Cost { get { return this._cost; } }
        public string Name { get { return this._name; } }

        public PizzaOption(string name, double cost)
        {
            this._name = name;
            this._cost = cost;
        }

        public override string ToString()
        {
            return this._name + " ($" + Math.Round(this._cost, 2) + ")";
        }

    }
}
