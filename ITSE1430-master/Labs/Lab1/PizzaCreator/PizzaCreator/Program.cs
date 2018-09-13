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
    class Program
    {
        static void Main(string[] args)
        {
            Menu _menu = SetupMenu();

            _menu.Start();
        }

        static public Menu SetupMenu()
        {
            Menu menu = new Menu();

            menu.AddMenuItem(new MenuItem("New Order", menu.NewOrder));
            menu.AddMenuItem(new MenuItem("Modify Order", menu.ModifyOrder));
            menu.AddMenuItem(new MenuItem("Display Order", menu.DisplayOrder));
            menu.AddMenuItem(new MenuItem("Quit", Program.Quit));
            
            return menu;
        }

        
        static public void Quit()
        {
            Environment.Exit(0);
        }
    }
}
