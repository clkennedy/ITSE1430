using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    class Attribute
    {
        public const int MAX_VALUE = 100;
        public const int MIN_VALUE = 1;

        private string _name;
        private int _value;

        public string Name { get { return this._name; } set { this._name = value; } }
        public int Value { get { return this._value; }
            set {
                this._value = (value > MAX_VALUE)? MAX_VALUE : 
                    (value < MIN_VALUE)? MIN_VALUE: value; } }

        public Attribute(string name, int value )
        {
            this._value = value;
            this._name = name;
        }
    }
}
