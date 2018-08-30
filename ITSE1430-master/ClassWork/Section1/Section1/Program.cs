using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class Program
    {
        static void Main( string[] args )
        {
            while (DisplayMenu());
            // PlayWithStrings();
        }

        private static void PlayWithStrings()
        {
            string hoursString = "10";
            bool result = Int32.TryParse(hoursString, out int hours);
            hoursString = hours.ToString();
            //hoursString = @"""Hello""";
        }

        private static bool DisplayMenu()
        {
            Console.WriteLine("A)dd Movie");
            Console.WriteLine("E)dit Movie");
            Console.WriteLine("D)elete Movies");
            Console.WriteLine("V)iew Movies");
            Console.WriteLine("Q)uit");

            string input = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            switch (input[0])
            {
                case 'A': case 'a': AddMovie(); break;
                case 'D': case 'd': DeleteMovie(); break;
                case 'E': case 'e':EditMovie(); break;
                case 'V': case 'v':ViewMovie(); break;
                case 'Q': case 'q': return false;
                default: Console.WriteLine("Please enter a valid value."); break;
            }
            return true;
        }

        private static void AddMovie()
        {
            Console.WriteLine("Add Movie");
        }

        private static void ViewMovie()
        {
            Console.WriteLine("View Movie");
        }

        private static void EditMovie()
        {
            Console.WriteLine("Edit Movie");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("Delete Movie");
        }

        private static void Quit()
        {
            Console.Write("Press any key to continue..");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
