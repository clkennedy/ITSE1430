/* Author: Cameron Kennedy
 * Date: 8/22/2018
 * Class: ITSE 1430 MW 5 -7:15
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PizzaCreator
{
    class Menu
    {
        private List<MenuItem> _items;
        private Order _order;
        public Menu()
        {
            this._items = new List<MenuItem>();
            this._order = null;
        }

        public void AddMenuItem(MenuItem mi)
        {
            this._items.Add(mi);
        }
        
        public void Display()
        {
            int count = 0;
            
            Console.WriteLine("Main Menu");
            Console.WriteLine();
            foreach (MenuItem item in this._items){
                Console.WriteLine($"{++count}) {item}");
            }
            
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Cart: $");
            Console.Write(Math.Round(this._order?.Total ?? 0.00, 2).ToString("0.00"));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public void Start()
        {
            int input = 0;
            do
            {
                Console.Clear();
                this.Display();

                input = GetValidInput();

                this._items[input - 1].Call();

            } while (input <= this._items.Count);
        }

        private int GetValidInput()
        {
            Regex r = new Regex($"^[1-{this._items.Count}]");

            string input = "";

            do
            {
                Console.Write("Please Enter Between 1 and " + this._items.Count + ": ");
                input = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();

                if (!r.IsMatch(input))
                {
                    Console.WriteLine("Not a Valid Input, Please Try again.");
                }

            } while (!r.IsMatch(input));
            int convertedInt = Convert.ToInt32(input);

            return convertedInt;
        }


        public void NewOrder()
        {
            Console.Clear();
            if (this._order != null)
            {
                Console.Write("Order Already Exist, Create a New One? (y/n): ");
                Regex r = new Regex("^y|Y");

                string input = Console.ReadKey().KeyChar.ToString();

                if (!r.IsMatch(input)) return;
            }
            this._order = new Order();
        }
        public void ModifyOrder()
        {
            if (!this._order?.Modify() ?? true)
            {
                Console.WriteLine("No Order Exist to Modify, press any key to continue..");
                Console.ReadKey();
            }
        }
        public void DisplayOrder()
        {
            if(!this._order?.Display() ?? true)
            {
                Console.WriteLine("No Order Exist to Display, press any key to continue..");
                Console.ReadKey();
            }
                
        }

    }
}
