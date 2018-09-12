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

        public void addMenuItem(MenuItem mi)
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
            Console.Write((this._order != null) ? Math.Round(this._order.Total, 2).ToString("0.00") : "0.00");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            
        }

        public void start()
        {
            int input = 0;
            do
            {
                Console.Clear();
                this.Display();

                input = getValidInput();

                this._items[input - 1].call();

            } while (input < 5);
        }

        private int getValidInput()
        {
            Regex r = new Regex("^[1-4]");

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


        public void newOrder()
        {
            Console.Clear();
            if (this._order != null)
            {
                Console.Write("Order Already Exist, Create a New One? (y/n): ");
                Regex r = new Regex("^y|Y");

                string input = Console.ReadKey().KeyChar.ToString();

                if (!r.IsMatch(input))
                {
                    return;
                }
            }
            this._order = new Order();
            //Console.WriteLine("New Order");
        }
        public void modifyOrder()
        {
            if(this._order != null)
            {
                this._order.modify();
            }
            else
            {
                Console.WriteLine("No Order Exist to Modify");
            }
            
        }
        public void displayOrder()
        {
            if(this._order != null)
            {
                this._order.Display();
            }
            else
            {
                Console.WriteLine("No Order Exist to Display");
            }
            
        }

    }
}
