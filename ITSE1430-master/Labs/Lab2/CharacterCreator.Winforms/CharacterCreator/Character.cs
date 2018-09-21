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
    public class Character
    {
        public enum ClassType { Fighter, Hunter, Priest, Rogue, Wizard};
        public enum Race { Human, Elf, Dwarf, Halfling, Gnome, Orc, HalfElf, HalfOrc};

        private string _name;
        private string _description;
        private ClassType _classType;
        private Race _race;
        private List<Attribute> _attributes;
        public string CharacterName
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public string CharacterDescription
        {
            get { return this._description; }
            set { this._description = value; }
        }

        public ClassType CharacterClassType { get { return this._classType; }
            set { this._classType = value; } }
        public Race CharacterRace
        {
            get { return this._race; }
            set { this._race = value; }
        }

        public Character()
        {
            this._name = "";
            this._description = "";
            this._classType = ClassType.Fighter;
            this._race = Race.Human;
            ResetAttributes();
        }
        public Character( string name, string desc, ClassType classType, Race race)
        {
            this._name = name;
            this._description = desc;
            this._classType = classType;
            this._race = race;
            ResetAttributes();
        }

        public void ResetAttributes()
        {
            this._attributes = new List<Attribute>();
            this._attributes.Add(new Attribute(Attribute.STRENGTH, 1));
            this._attributes.Add(new Attribute(Attribute.DEXERITY, 1));
            this._attributes.Add(new Attribute(Attribute.CONSTITUTION, 1));
            this._attributes.Add(new Attribute(Attribute.WISDOM, 1));
            this._attributes.Add(new Attribute(Attribute.INTELLEGENCE, 1));
            this._attributes.Add(new Attribute(Attribute.CHARISMA, 1));
            this._attributes.Add(new Attribute(Attribute.LUCK, 1));
        }
        public void SetAttribute(string attName, int attValue)
        {
            Attribute att = this._attributes.Find(t => t.Name == attName);
            att.Value = attValue;
        }

        public int GetAttribute(string attName)
        {
            return this._attributes.Find(t => t.Name == attName).Value;
        }
        public override string ToString()
        {
            return $"{this._name} | {this._race.ToString()} {this._classType.ToString()} ";
        }

    }
}
