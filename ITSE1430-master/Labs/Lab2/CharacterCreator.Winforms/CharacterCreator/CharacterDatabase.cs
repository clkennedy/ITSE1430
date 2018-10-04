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

        public Character[] Characters { get { return _characters; } }

        public void Add(Character character )
        {
            _characters[currentIndex++] = character;
            
            if (currentIndex == _characters.Length)
            {
                IncreaseArraySize();
            }
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
                for (int i = indexOfChar; i < this.currentIndex; i++)
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
