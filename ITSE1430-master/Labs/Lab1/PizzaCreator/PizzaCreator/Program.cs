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
            Menu _menu = setupMenu();

            _menu.start();
        }

        static public Menu setupMenu()
        {
            Menu menu = new Menu();

            menu.addMenuItem(new MenuItem("New Order", menu.newOrder));
            menu.addMenuItem(new MenuItem("Modify Order", menu.modifyOrder));
            menu.addMenuItem(new MenuItem("Display Order", menu.displayOrder));
            menu.addMenuItem(new MenuItem("Quit", Program.quit));
            
            return menu;
        }

        
        static public void quit()
        {
            Environment.Exit(0);
        }
    }
}
