/*
 * Author : Cameron Kennedy
 * ITSE 1430
 * 9/20/2018 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class CharacterAttribute
    {

        public const int Max_Value = 100;
        public const int Min_Value = 1;
        public const int TotalAllocatedPointsAllowed = 350;

        public const string Strength = "Strength";
        public const string Intellegence = "Intellegence";
        public const string Charisma = "Charisma";
        public const string Constitution = "Constitution";
        public const string Wisdom = "Wisdom";
        public const string Luck = "Luck";
        public const string Dexterity = "Dexterity";
        
        public string Name {get;  set;}

        private int _value;
        public int Value {
            get { return _value; }
            set {
                _value = (value > Max_Value) ? Max_Value : 
                (value < Min_Value) ? Min_Value : value;
            }
        }

        public CharacterAttribute(string name, int value )
        {
            Value = value;
            Name = name;
        }
    }
}
