using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        public enum ClassType { FIGHTER, HUNTER, PRIEST, ROGUE, WIZARD};
        public enum Race { HUMAN, ELF, DWARF, HALFLNG, GNOME, ORC, HALFELF, HALFORC};

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
            this._classType = ClassType.FIGHTER;
            this._race = Race.HUMAN;
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
            this._attributes.Add(new Attribute("Strength", 1));
            this._attributes.Add(new Attribute("Dexterity", 1));
            this._attributes.Add(new Attribute("Constitution", 1));
            this._attributes.Add(new Attribute("Wisdon", 1));
            this._attributes.Add(new Attribute("Intelegence", 1));
            this._attributes.Add(new Attribute("Charisma", 1));
            this._attributes.Add(new Attribute("Luck", 1));
        }

    }
}
