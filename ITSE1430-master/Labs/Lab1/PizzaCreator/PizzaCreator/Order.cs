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
            setPizzaSize();
            setPizzaMeats();
            setPizzaVeges();
            setPizzaSauce();
            setPizzaCheese();
            setDelivery();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write(this);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }


        private void setPizzaSize()
        {
            StringBuilder sb;
            string input = "";
            Regex r = new Regex("^[1-" + PizzaOption.AllSizes.Count + "]$");
            do
            {
                sb = new StringBuilder();
                sb.Append(Environment.NewLine);
                sb.Append("Pizza Sizes");
                sb.Append(Environment.NewLine);
                int count = 0;
                PizzaSize oldSize = null;
                if(this._oldOptions.Count > 0)
                {
                    oldSize = (PizzaSize)this._oldOptions.Find(t => t.GetType() == typeof(PizzaSize));
                }
                foreach (PizzaOption size in PizzaOption.AllSizes)
                {
                    sb.Append(++count);
                    sb.Append(") ");
                    sb.Append(size);
                    sb.Append((oldSize != null && oldSize == size) ? " - previous option" : "");
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Please Select One (required): ");

                Console.Write(sb);

                input = Console.ReadLine();
                
                if (!r.IsMatch(input))
                {
                    Console.WriteLine("Invalid Selection, Please Try Again");
                }

            } while (!r.IsMatch(input));

            int index = Convert.ToInt32(input);

            this._options.Add(PizzaOption.AllSizes[index - 1]);
            this._total += PizzaOption.AllSizes[index - 1].Cost;
        }

        private void setPizzaMeats()
        {
            StringBuilder sb;
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
                sb = new StringBuilder();
                sb.Append(Environment.NewLine);
                sb.Append("Pizza Meats. Add .75 per meat added.");
                sb.Append(Environment.NewLine);
                count = 0;
                foreach (PizzaOption meat in PizzaOption.AllMeats)
                {
                    sb.Append(++count);
                    sb.Append(") ");
                    sb.Append(meat.Name);
                    sb.Append((added[count - 1]) ? " (Remove)" : " (Add)");
                    sb.Append((added[count - 1]) ? " (Remove)" : " (Add)");
                    sb.Append(Environment.NewLine);
                }

                sb.Append(++count);
                sb.Append(") ");
                sb.Append("Finish");
                sb.Append(Environment.NewLine);

                sb.Append("Please Select One an Option: ");

                Console.Write(sb);

                input = Console.ReadLine();

                if (!r.IsMatch(input))
                {
                    Console.WriteLine("Invalid Selection, Please Try Again");
                }
                else
                {
                    index = Convert.ToInt32(input);
                    if (index != count)
                    {
                        added[index - 1] = !added[index - 1];
                    }
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

        private void setPizzaVeges()
        {
            StringBuilder sb;
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
                sb = new StringBuilder();
                sb.Append(Environment.NewLine);
                sb.Append("Pizza Vegetables. Add .50 cents per Vegetable added.");
                sb.Append(Environment.NewLine);
                count = 0;
                foreach (PizzaOption vege in PizzaOption.AllVeges)
                {
                    sb.Append(++count);
                    sb.Append(") ");
                    sb.Append(vege.Name);
                    sb.Append((added[count - 1]) ? " (Remove)" : " (Add)");
                    sb.Append(Environment.NewLine);
                }

                sb.Append(++count);
                sb.Append(") ");
                sb.Append("Finish");
                sb.Append(Environment.NewLine);

                sb.Append("Please Select an Option: ");

                Console.Write(sb);

                input = Console.ReadLine();

                if (!r.IsMatch(input))
                {
                    Console.WriteLine("Invalid Selection, Please Try Again");
                }
                else
                {
                    index = Convert.ToInt32(input);
                    if (index != count)
                    {
                        added[index - 1] = !added[index - 1];
                    }
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

        private void setPizzaSauce()
        {
            StringBuilder sb;
            string input = "";
            Regex r = new Regex("^[1-" + (PizzaOption.AllSauces.Count) + "]$");
            bool[] added = new bool[PizzaOption.AllSauces.Count];
            int count = 0;
            do
            {
                sb = new StringBuilder();
                sb.Append(Environment.NewLine);
                sb.Append("Pizza Sauces.");
                sb.Append(Environment.NewLine);
                count = 0;
                PizzaSauce oldSauce = null;
                if (this._oldOptions.Count > 0)
                {
                    oldSauce = (PizzaSauce)this._oldOptions.Find(t => t.GetType() == typeof(PizzaSauce));
                }
                foreach (PizzaOption sauce in PizzaOption.AllSauces)
                {
                    sb.Append(++count);
                    sb.Append(") ");
                    sb.Append(sauce);
                    sb.Append((oldSauce != null && oldSauce == sauce) ? " - previous option" : "");
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Please Select an Option: ");

                Console.Write(sb);

                input = Console.ReadLine();

                if (!r.IsMatch(input))
                {
                    Console.WriteLine("Invalid Selection, Please Try Again");
                }
                
            } while (!r.IsMatch(input));
            
            int index = Convert.ToInt32(input);

            this._options.Add(PizzaOption.AllSauces[index - 1]);
            this._total += PizzaOption.AllSauces[index - 1].Cost;
        }

        private void setPizzaCheese()
        {
            StringBuilder sb;
            string input = "";
            Regex r = new Regex("^[1-" + (PizzaOption.AllCheeses.Count) + "]$");
            bool[] added = new bool[PizzaOption.AllCheeses.Count];
            int count = 0;
            do
            {
                sb = new StringBuilder();
                sb.Append(Environment.NewLine);
                sb.Append("Pizza Cheeses.");
                sb.Append(Environment.NewLine);
                count = 0;
                Cheese oldCheese = null;
                if (this._oldOptions.Count > 0)
                {
                    oldCheese = (Cheese)this._oldOptions.Find(t => t.GetType() == typeof(Cheese));
                }
                foreach (PizzaOption cheese in PizzaOption.AllCheeses)
                {
                    sb.Append(++count);
                    sb.Append(") ");
                    sb.Append(cheese);
                    sb.Append((oldCheese != null && oldCheese == cheese) ? " - previous option" : "");
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Please Select an Option: ");

                Console.Write(sb);

                input = Console.ReadLine();

                if (!r.IsMatch(input))
                {
                    Console.WriteLine("Invalid Selection, Please Try Again");
                }

            } while (!r.IsMatch(input));

            int index = Convert.ToInt32(input);

            this._options.Add(PizzaOption.AllCheeses[index - 1]);
            this._total += PizzaOption.AllCheeses[index - 1].Cost;
        }
        private void setDelivery()
        {
            StringBuilder sb;
            string input = "";
            Regex r = new Regex("^[1-" + (PizzaOption.DeliveryOptions.Count) + "]$");
            bool[] added = new bool[PizzaOption.DeliveryOptions.Count];
            int count = 0;
            do
            {
                sb = new StringBuilder();
                sb.Append(Environment.NewLine);
                sb.Append("Delivery Options.");
                sb.Append(Environment.NewLine);
                count = 0;
                Delivery oldDelivery = null;
                if (this._oldOptions.Count > 0)
                {
                    oldDelivery = (Delivery)this._oldOptions.Find(t => t.GetType() == typeof(Delivery));
                }
                foreach (PizzaOption delivery in PizzaOption.DeliveryOptions)
                {
                    sb.Append(++count);
                    sb.Append(") ");
                    sb.Append(delivery);
                    sb.Append((oldDelivery != null && oldDelivery == delivery) ? " - previous option" : "");
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Please Select an Option: ");

                Console.Write(sb);

                input = Console.ReadLine();

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
            StringBuilder sb = new StringBuilder();
            PizzaSize size = (PizzaSize)this._options.Find(t => t.GetType() == typeof(PizzaSize));
            Delivery delivery = (Delivery)this._options.Find(t => t.GetType() == typeof(Delivery));
            PizzaSauce sauce = (PizzaSauce)this._options.Find(t => t.GetType() == typeof(PizzaSauce));
            Cheese cheese = (Cheese)this._options.Find(t => t.GetType() == typeof(Cheese));
            List<PizzaOption> meats = this._options.FindAll(t => t.GetType() == typeof(Meat));
            List<PizzaOption> veges = this._options.FindAll(t => t.GetType() == typeof(Vegetable));

            sb.Append(Environment.NewLine);

            sb.Append(size.Name + " Pizza");
            sb.Append("\t");
            sb.Append("$"+size.Cost.ToString("0.00") + "\t");
            sb.Append(Environment.NewLine);

            sb.Append(delivery.Name);
            sb.Append("\t");
            sb.Append("$" + delivery.Cost.ToString("0.00") + "\t");
            sb.Append(Environment.NewLine);

            sb.Append("Sauce\t\t\t");
            sb.Append(Environment.NewLine);
            sb.Append("   ");
            sb.Append(sauce.Name);
            sb.Append("\t");
            sb.Append("$" + sauce.Cost.ToString("0.00") + "\t");
            sb.Append(Environment.NewLine);

            sb.Append("Cheese\t\t\t");
            sb.Append(Environment.NewLine);
            sb.Append("   ");
            sb.Append(cheese.Name);
            sb.Append("\t");
            sb.Append("$" + cheese.Cost.ToString("0.00") + "\t");
            sb.Append(Environment.NewLine);

            sb.Append("Meats\t\t\t");
            sb.Append(Environment.NewLine);
            foreach(PizzaOption option in meats)
            {
                sb.Append("   ");
                sb.Append(option.Name);
                if (option.Name.Length < 4) sb.Append("\t");
                sb.Append("\t");
                sb.Append("$" + option.Cost.ToString("0.00") + "\t");
                sb.Append(Environment.NewLine);
            }

            sb.Append("Vegetables\t\t");
            sb.Append(Environment.NewLine);
            foreach (PizzaOption option in veges)
            {
                sb.Append("   ");
                sb.Append(option.Name);
                sb.Append("\t");
                sb.Append("$" + option.Cost.ToString("0.00") + "\t");
                sb.Append(Environment.NewLine);
            }

            sb.Append("------------------------");
            sb.Append(Environment.NewLine);
            
            sb.Append("Total");
            sb.Append("\t\t");
            sb.Append("$" + this._total.ToString("0.00") + "\t");
            sb.Append(Environment.NewLine);

            return sb.ToString();
        }

        public void modify()
        {
            this._oldOptions = this._options;
            this._options = new List<PizzaOption>();
            this._total = 0.00;
            setPizzaSize();
            setPizzaMeats();
            setPizzaVeges();
            setPizzaSauce();
            setPizzaCheese();
            setDelivery();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write(this);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
