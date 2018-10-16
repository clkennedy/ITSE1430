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
        private List<CharacterAttribute> _attributes = new List<CharacterAttribute>() {
            new CharacterAttribute(CharacterAttribute.Strength, 1),
            new CharacterAttribute(CharacterAttribute.Dexterity, 1),
            new CharacterAttribute(CharacterAttribute.Constitution, 1),
            new CharacterAttribute(CharacterAttribute.Wisdom, 1),
            new CharacterAttribute(CharacterAttribute.Intellegence, 1),
            new CharacterAttribute(CharacterAttribute.Charisma, 1),
            new CharacterAttribute(CharacterAttribute.Luck, 1)
        };
        public string CharacterName { get; set;} = "";

        public string CharacterDescription { get; set; } = "";

        public ClassType CharacterClassType {get; set; } = ClassType.Fighter;
        public Race CharacterRace{ get; set; } = Race.Human;

        public void SetAttribute(string attName, int attValue)
        {
            CharacterAttribute att = _attributes.Find(t => t.Name == attName);
            att.Value = attValue;
        }

        public int GetAttribute(string attName)
        {
            return _attributes.Find(t => t.Name == attName).Value;
        }
        public override string ToString()
        {
            return $"{CharacterName} | {CharacterRace.ToString()} {CharacterClassType.ToString()} ";
        }

    }
}
