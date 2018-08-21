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
        private String _menuName;

        public MenuItem() {
            this._callMethod = null;
            this._menuName = "";
        }

        public MenuItem(String name, Action method)
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
