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
            _oldOptions = new List<PizzaOption>();
            SetPizzaSize();
            SetPizzaMeats();
            SetPizzaVeges();
            SetPizzaSauce();
            SetPizzaCheese();
            SetDelivery();
            
            Console.Write(this);
        }
        
        private void SetPizzaSize()
        {
            Console.Clear();
            string input = "";
            Regex r = new Regex("^[1-" + PizzaOption.AllSizes.Count + "]$");

            Console.WriteLine();
            Console.WriteLine("Pizza Sizes.");
            int count = 0;
            PizzaSize oldSize = null;

            if (this._oldOptions.Count > 0)
            {
                oldSize = (PizzaSize)this._oldOptions.Find(t => t.GetType() == typeof(PizzaSize));
            }
            foreach (PizzaOption size in PizzaOption.AllSizes)
            {
                Console.WriteLine($"{++count}) {size} {((oldSize != null && oldSize == size) ? " - previous option" : "")}");
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

            this._options.Add(PizzaOption.AllSizes[index - 1]);
            this._total += PizzaOption.AllSizes[index - 1].Cost;
        }

        private void SetPizzaMeats()
        {
            string input = "";
            Regex r = new Regex("^[1-" + (PizzaOption.AllMeats.Count + 1) + "]$");
            bool[] added = new bool[PizzaOption.AllMeats.Count];
            int count = 0;

            if(this._options.Count > 0)
            {
                foreach(PizzaOption option in this._oldOptions)
                {
                    if (option.GetType() == typeof(Meat))
                    {
                        for (int i = 0; i < PizzaOption.AllMeats.Count; i++)
                        {
                            if(((Meat)option) == PizzaOption.AllMeats[i])
                            {
                                added[i] = !added[i];
                            }
                        }
                    }
                       
                }
            }

            int index;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Pizza Meats. Add .75 per meat added.");
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
            
            for(int i = 0; i < added.Length; i++)
            {
                if (added[i])
                {
                    this._options.Add(PizzaOption.AllMeats[i]);
                    this._total += PizzaOption.AllMeats[i].Cost;
                }
            }
        }

        private void SetPizzaVeges()
        {
            string input = "";
            Regex r = new Regex("^[1-" + (PizzaOption.AllVeges.Count + 1) + "]$");
            bool[] added = new bool[PizzaOption.AllVeges.Count];
            int count = 0;
            if (this._options.Count > 0)
            {
                foreach (PizzaOption option in this._oldOptions)
                {
                    if (option.GetType() == typeof(Vegetable))
                    {
                        for (int i = 0; i < PizzaOption.AllVeges.Count; i++)
                        {
                            if (((Vegetable)option) == PizzaOption.AllVeges[i])
                            {
                                added[i] = !added[i];
                            }
                        }
                    }

                }
            }
            int index;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Pizza Vegetables. Add .50 cents per Vegetable added.");
                count = 0;
                foreach (PizzaOption vege in PizzaOption.AllVeges)
                {
                    Console.WriteLine($"{++count}) {vege.Name} {((added[count - 1]) ? " (Remove)" : "(Add)")}");
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
                    this._options.Add(PizzaOption.AllVeges[i]);
                    this._total += PizzaOption.AllVeges[i].Cost;
                }
            }
        }

        private void SetPizzaSauce()
        {
            Console.Clear();
            string input = "";
            Regex r = new Regex("^[1-" + (PizzaOption.AllSauces.Count) + "]$");
            bool[] added = new bool[PizzaOption.AllSauces.Count];
            int count = 0;

            Console.WriteLine();
            Console.WriteLine("Pizza Sauces.");
            count = 0;
            PizzaSauce oldSauce = null;

            if (this._oldOptions.Count > 0)
            {
                oldSauce = (PizzaSauce)this._oldOptions.Find(t => t.GetType() == typeof(PizzaSauce));
            }
            foreach (PizzaOption sauce in PizzaOption.AllSauces)
            {
                Console.WriteLine($"{++count}) {sauce} {((oldSauce != null && oldSauce == sauce) ? " - previous option" : "")}");
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

            this._options.Add(PizzaOption.AllSauces[index - 1]);
            this._total += PizzaOption.AllSauces[index - 1].Cost;
        }

        private void SetPizzaCheese()
        {
            Console.Clear();
            string input = "";
            Regex r = new Regex("^[1-" + (PizzaOption.AllCheeses.Count) + "]$");
            bool[] added = new bool[PizzaOption.AllCheeses.Count];
            int count = 0;
            
            Console.WriteLine();
            Console.WriteLine("Pizza Cheeses.");
            count = 0;
            Cheese oldCheese = null;

            if (this._oldOptions.Count > 0)
            {
                oldCheese = (Cheese)this._oldOptions.Find(t => t.GetType() == typeof(Cheese));
            }
            foreach (PizzaOption cheese in PizzaOption.AllCheeses)
            {
                Console.WriteLine($"{++count}) {cheese} {((oldCheese != null && oldCheese == cheese) ? " - previous option" : "")}");
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

            this._options.Add(PizzaOption.AllCheeses[index - 1]);
            this._total += PizzaOption.AllCheeses[index - 1].Cost;
        }
        private void SetDelivery()
        {
            Console.Clear();
            string input = "";
            Regex r = new Regex("^[1-" + (PizzaOption.DeliveryOptions.Count) + "]$");
            bool[] added = new bool[PizzaOption.DeliveryOptions.Count];
            int count = 0;

            Console.WriteLine();
            Console.WriteLine("Delivery Options.");
            count = 0;
            Delivery oldDelivery = null;

            if (this._oldOptions.Count > 0)
            {
                oldDelivery = (Delivery)this._oldOptions.Find(t => t.GetType() == typeof(Delivery));
            }
            foreach (PizzaOption delivery in PizzaOption.DeliveryOptions)
            {
                Console.WriteLine($"{++count}) {delivery} {((oldDelivery != null && oldDelivery == delivery) ? " - previous option" : "")}");
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

            this._options.Add(PizzaOption.DeliveryOptions[index - 1]);
            this._total += PizzaOption.DeliveryOptions[index - 1].Cost;
        }

        public override string ToString()
        {
            PizzaSize size = (PizzaSize)this._options.Find(t => t.GetType() == typeof(PizzaSize));
            Delivery delivery = (Delivery)this._options.Find(t => t.GetType() == typeof(Delivery));
            PizzaSauce sauce = (PizzaSauce)this._options.Find(t => t.GetType() == typeof(PizzaSauce));
            Cheese cheese = (Cheese)this._options.Find(t => t.GetType() == typeof(Cheese));
            List<PizzaOption> meats = this._options.FindAll(t => t.GetType() == typeof(Meat));
            List<PizzaOption> veges = this._options.FindAll(t => t.GetType() == typeof(Vegetable));

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

            return "";
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

            Console.Write(this);
        }
    }
}
