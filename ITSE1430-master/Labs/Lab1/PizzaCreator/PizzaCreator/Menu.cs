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
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            sb.Append(Environment.NewLine);
            sb.Append("Main Menu");
            sb.Append(Environment.NewLine);
            foreach (MenuItem item in this._items){
                sb.Append(++count);
                sb.Append(") ");
                sb.Append(item);
                sb.Append(Environment.NewLine);
            }

            //if(this._order != null)
            //{
            //    sb.Append(Environment.NewLine);
            //    Console.BackgroundColor = ConsoleColor.White;
            //    Console.ForegroundColor = ConsoleColor.Black;
            //    sb.Append("Cart: $");
            //    sb.Append(Math.Round(this._order.Total, 2).ToString("0.00"));
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ForegroundColor = ConsoleColor.White;
            //    sb.Append(Environment.NewLine);
            //}
            return sb.ToString();
        }

        public void start()
        {
            int input = 0;
            do
            {
                Console.Write(this);

                if (this._order != null)
                {
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("Cart: $");
                    Console.Write(Math.Round(this._order.Total, 2).ToString("0.00"));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
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
                input = Console.ReadLine();

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
            if(this._order != null)
            {
                Console.Write("Order Already Exist, Create a New One? (y/n): ");
                Regex r = new Regex("^y|Y|Yes|YES");

                string input = Console.ReadLine();

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
                Console.Write(this._order);
            }
            else
            {
                Console.WriteLine("No Order Exist to Display");
            }
            
        }

    }
}
