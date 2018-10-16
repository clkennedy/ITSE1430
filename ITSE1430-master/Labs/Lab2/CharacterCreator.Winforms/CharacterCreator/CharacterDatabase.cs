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
    public class CharacterDatabase
    {
        Character[] _characters = new Character[1];
        private int currentIndex = 0;

        public Character[] Characters {
            get { return _characters; }
        }

        public void Add(Character character)
        {
            if (currentIndex == _characters.Length)
            {
                IncreaseArraySize();
            }

            _characters[currentIndex++] = character;
        }

        public void Remove(Character character )
        {
            int indexOfChar = -1;
            for (int i = 0; i < currentIndex; i++)
            {
                if (_characters[i] == character)
                {
                    indexOfChar = i;
                }
            }

            if (indexOfChar != -1)
            {
                for (int i = indexOfChar; i < currentIndex; i++)
                {
                    if (i < _characters.Length - 1)
                    {
                        _characters[i] = _characters[i + 1];
                    }
                }
            }
            currentIndex--;
        }

        private void IncreaseArraySize()
        {
            Character[] newCharacterSizeList = new Character[_characters.Length * 2];
            for (int i = 0; i < _characters.Length; i++)
            {
                newCharacterSizeList[i] = _characters[i];
            }
            _characters = newCharacterSizeList;
            newCharacterSizeList = null;
        }
    }
}
