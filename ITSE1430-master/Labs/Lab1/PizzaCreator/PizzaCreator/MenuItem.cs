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

    
    class MenuItem
    {
        private Action _callMethod;
        private string _menuName;

        public MenuItem() {
            this._callMethod = null;
            this._menuName = "";
        }

        public MenuItem(string name, Action method)
        {
            this._callMethod = method;
            this._menuName = name;
        }

        public void clear()
        {
            this._menuName = "";
            this._callMethod = null;
        }

        public void changeCallBackMethod(Action method)
        {
            this._callMethod = method;
        }

        public void call()
        {
            this._callMethod();
        }

        public override string ToString()
        {
            return this._menuName;
        }
    }
}
