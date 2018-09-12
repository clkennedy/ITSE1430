/* Author: Cameron Kennedy
 * Date: 8/22/2018
 * Class: ITSE 1430 MW 5 -7:15
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PizzaCreator
{
    class Order
    {
        private List<PizzaOption> _options;
        private List<PizzaOption> _oldOptions;

        private double _total = 0.00;

        public double Total {
            get { return this._total; }
        }

        public Order()
        {
            _options = new List<PizzaOption>();
            modify();
        }
        
        public PizzaOption ChooseOption(PizzaOption oldOption, List<PizzaOption> options)
        {
            PizzaOption chosenOption = null;

            Regex r = new Regex("^[1-" + options.Count + "]$");
            int count = 0;
            string input = "";

            foreach (PizzaOption option in options)
            {
                Console.WriteLine($"{++count}) {option} {((oldOption != null && oldOption == option) ? " - previous option" : "")}");
            }

            do
            {
                Console.Write("Please Select One (required): ");

                input = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();
                if (!r.IsMatch(input))
                {
                    Console.WriteLine("Invalid Selection, Please Try Again");
                }

            } while (!r.IsMatch(input));

            int index = Convert.ToInt32(input);

            chosenOption = options[index - 1];

            this._options.Add(chosenOption);
            this._total += chosenOption.Cost;

            return chosenOption;
        }

        public bool[] ChooseOption(bool[] added, List<PizzaOption> options, string title )
        {
            Regex r = new Regex("^[1-" + (options.Count + 1) + "]$");
            int index;
            string input = "";
            int count = 0;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(title);
                count = 0;

                foreach (PizzaOption meat in PizzaOption.AllMeats)
                {
                    Console.WriteLine($"{++count}) {meat.Name} {((added[count - 1]) ? " (Remove)" : "(Add)")}");
                }

                Console.WriteLine($"{++count}) Finish");

                do
                {
                    Console.Write("Please Select an Option: ");

                    input = Console.ReadKey().KeyChar.ToString();
                    Console.WriteLine();

                    if (!r.IsMatch(input))
                    {
                        Console.WriteLine("Invalid Selection, Please Try Again");
                    }
                } while (!r.IsMatch(input));

                index = Convert.ToInt32(input);
                if (index != count)
                {
                    added[index - 1] = !added[index - 1];
                }
            } while (!r.IsMatch(input) || Convert.ToInt32(input) != count);

            for (int i = 0; i < added.Length; i++)
            {
                if (added[i])
                {
                    this._options.Add(options[i]);
                    this._total += options[i].Cost;
                }
            }

            return added;
        }

        private void SetPizzaSize()
        {
            Console.Clear();
            Regex r = new Regex("^[1-" + PizzaOption.AllSizes.Count + "]$");

            Console.WriteLine();
            Console.WriteLine("Pizza Sizes.");
            //int count = 0;
            PizzaOption oldSize = null;

            if (this._oldOptions.Count > 0)
            {
                oldSize = this._oldOptions.Find(t => t.Type == PizzaOption.PizzaType.SIZE);
            }

            ChooseOption(oldSize, PizzaOption.AllSizes);
        }

        private void SetPizzaMeats()
        {
            
            bool[] added = new bool[PizzaOption.AllMeats.Count];
            

            if(this._options.Count > 0)
            {
                foreach(PizzaOption option in this._oldOptions)
                {
                    if (option.Type == PizzaOption.PizzaType.MEAT)
                    {
                        for (int i = 0; i < PizzaOption.AllMeats.Count; i++)
                        {
                            if(option == PizzaOption.AllMeats[i])
                            {
                                added[i] = !added[i];
                            }
                        }
                    }
                       
                }
            }

            ChooseOption(added, PizzaOption.AllMeats, "Pizza Meats. Add .75 per meat added.");
        }

        private void SetPizzaVeges()
        {
            Regex r = new Regex("^[1-" + (PizzaOption.AllVeges.Count + 1) + "]$");
            bool[] added = new bool[PizzaOption.AllVeges.Count];

            if (this._options.Count > 0)
            {
                foreach (PizzaOption option in this._oldOptions)
                {
                    if (option.Type == PizzaOption.PizzaType.VEGE)
                    {
                        for (int i = 0; i < PizzaOption.AllVeges.Count; i++)
                        {
                            if (option == PizzaOption.AllVeges[i])
                            {
                                added[i] = !added[i];
                            }
                        }
                    }

                }
            }

            ChooseOption(added, PizzaOption.AllVeges, "Pizza Vegetables. Add .50 cents per Vegetable added.");
        }

        private void SetPizzaSauce()
        {
            Console.Clear();
            Regex r = new Regex("^[1-" + (PizzaOption.AllSauces.Count) + "]$");
            bool[] added = new bool[PizzaOption.AllSauces.Count];

            Console.WriteLine();
            Console.WriteLine("Pizza Sauces.");

            PizzaOption oldSauce = null;

            if (this._oldOptions.Count > 0)
            {
                oldSauce = this._oldOptions.Find(t => t.Type == PizzaOption.PizzaType.SAUCE);
            }

            ChooseOption(oldSauce, PizzaOption.AllSauces);
        }

        private void SetPizzaCheese()
        {
            Console.Clear();
            Regex r = new Regex("^[1-" + (PizzaOption.AllCheeses.Count) + "]$");
            bool[] added = new bool[PizzaOption.AllCheeses.Count];
            
            Console.WriteLine();
            Console.WriteLine("Pizza Cheeses.");
            PizzaOption oldCheese = null;

            if (this._oldOptions.Count > 0)
            {
                oldCheese = this._oldOptions.Find(t => t.Type == PizzaOption.PizzaType.CHEESE);
            }

            ChooseOption(oldCheese, PizzaOption.AllCheeses);
            
        }

        private void SetDelivery()
        {
            Console.Clear();
            Regex r = new Regex("^[1-" + (PizzaOption.DeliveryOptions.Count) + "]$");
            bool[] added = new bool[PizzaOption.DeliveryOptions.Count];

            Console.WriteLine();
            Console.WriteLine("Delivery Options.");

            PizzaOption oldDelivery = null;

            if (this._oldOptions.Count > 0)
            {
                oldDelivery = this._oldOptions.Find(t => t.Type == PizzaOption.PizzaType.DELIVERY);
            }

            ChooseOption(oldDelivery, PizzaOption.DeliveryOptions);
        }

        public void Display()
        {
            PizzaOption size = this._options.Find(t => t.Type == PizzaOption.PizzaType.SIZE);
            PizzaOption delivery = this._options.Find(t => t.Type == PizzaOption.PizzaType.DELIVERY);
            PizzaOption sauce = this._options.Find(t => t.Type == PizzaOption.PizzaType.SAUCE);
            PizzaOption cheese = this._options.Find(t => t.Type == PizzaOption.PizzaType.CHEESE);
            List<PizzaOption> meats = this._options.FindAll(t => t.Type == PizzaOption.PizzaType.MEAT);
            List<PizzaOption> veges = this._options.FindAll(t => t.Type == PizzaOption.PizzaType.VEGE);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine();
            
            Console.WriteLine($"{size.Name} Pizza\t${size.Cost.ToString("0.00")}\t");
            
            Console.WriteLine($"{delivery.Name}\t${delivery.Cost.ToString("0.00")}\t");
            
            Console.WriteLine($"Sauce\t\t\t");
            Console.WriteLine($"   {sauce.Name}\t${sauce.Cost.ToString("0.00")}\t");
            
            Console.WriteLine($"Cheese\t\t\t");
            Console.WriteLine($"   {cheese.Name}\t${cheese.Cost.ToString("0.00")}\t");

            Console.WriteLine($"Meats\t\t\t");
            foreach (PizzaOption option in meats)
            {
                if (option.Name.Length < 4)
                {
                    Console.WriteLine($"   {option.Name}\t\t${option.Cost.ToString("0.00")}\t");
                } else
                {
                    Console.WriteLine($"   {option.Name}\t${option.Cost.ToString("0.00")}\t");
                }
            }
            
            Console.WriteLine($"Vegetables\t\t");
            foreach (PizzaOption option in veges)
            {
                Console.WriteLine($"   {option.Name}\t${option.Cost.ToString("0.00")}\t");
            }

            Console.WriteLine($"------------------------");
            Console.WriteLine($"Total\t\t${this._total.ToString("0.00")}\t");

            Console.ResetColor();

            Console.WriteLine();
            Console.Write("Press any key to continue..");
            Console.ReadKey();
            
        }

        public void modify()
        {
            this._oldOptions = this._options;
            this._options = new List<PizzaOption>();
            this._total = 0.00;

            SetPizzaSize();
            SetPizzaMeats();
            SetPizzaVeges();
            SetPizzaSauce();
            SetPizzaCheese();
            SetDelivery();

            this.Display();
        }
    }
}
