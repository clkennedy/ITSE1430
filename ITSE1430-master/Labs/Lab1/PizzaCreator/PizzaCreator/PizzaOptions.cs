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
        public enum PizzaType { SIZE, MEAT, VEGE, SAUCE, CHEESE, DELIVERY };

        public static List<PizzaOption> AllSizes = new List<PizzaOption>(){
                                                        new PizzaOption("Small", 5, PizzaType.SIZE),
                                                        new PizzaOption("Medium", 6.25, PizzaType.SIZE),
                                                        new PizzaOption("Large", 8.75, PizzaType.SIZE)};

        public static List<PizzaOption> AllMeats = new List<PizzaOption>(){
                                                        new PizzaOption("Bacon", .75, PizzaType.MEAT),
                                                        new PizzaOption("Ham", .75, PizzaType.MEAT),
                                                        new PizzaOption("Papperoni", .75, PizzaType.MEAT),
                                                        new PizzaOption("Sausage", .75, PizzaType.MEAT)};

        public static List<PizzaOption> AllVeges = new List<PizzaOption>(){
                                                        new PizzaOption("Bck Olives", .50, PizzaType.VEGE),
                                                        new PizzaOption("Mushrooms", .50, PizzaType.VEGE),
                                                        new PizzaOption("Onions", .50, PizzaType.VEGE),
                                                        new PizzaOption("Peppers", .50, PizzaType.VEGE)};

        public static List<PizzaOption> AllSauces = new List<PizzaOption>(){
                                                        new PizzaOption("Traditional", 0, PizzaType.SAUCE),
                                                        new PizzaOption("Garlic", 1, PizzaType.SAUCE),
                                                        new PizzaOption("Oregano", 1, PizzaType.SAUCE) };

        public static List<PizzaOption> AllCheeses = new List<PizzaOption>(){
                                                        new PizzaOption("Regular", 0, PizzaType.CHEESE),
                                                        new PizzaOption("Extra", 1.25, PizzaType.CHEESE) };

        public static List<PizzaOption> DeliveryOptions = new List<PizzaOption>(){
                                                        new PizzaOption("Take Out", 0, PizzaType.DELIVERY),
                                                        new PizzaOption("Delivery", 2.50, PizzaType.DELIVERY) };


        protected string _name;
        protected double _cost;
        protected PizzaType _type;

        public double Cost { get { return this._cost; } }
        public string Name { get { return this._name; } }

        public PizzaType Type { get { return this._type; } }

        public PizzaOption(string name, double cost)
        {
            this._name = name;
            this._cost = cost;
        }

        public PizzaOption( string name, double cost, PizzaType type )
        {
            this._name = name;
            this._cost = cost;
            this._type = type;
        }

        public override string ToString()
        {
            return $"{this._name} (${Math.Round(this._cost, 2)})";
        }

    }
}
