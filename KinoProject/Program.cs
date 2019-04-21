using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ans = true;
            Lottery lottery = new Lottery();
            
            do
            {
                int choice = 0;
                Console.WriteLine();
                Console.WriteLine("Choose a category number");
                Console.WriteLine("1. One Player Kino Game");
                Console.WriteLine("2. Many Players Kino Game");
                Console.WriteLine("3. Make the Draw");
                Console.WriteLine("4. Winners");
                Console.WriteLine("5. Statistics");
                Console.WriteLine("6. Exit");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please enter a valid menu number (1-6)");
                }
                switch (choice)
                {
                    case 1:
                    case 2:
                        lottery.PlayKino();
                        lottery.PrintPlayersListDetails();
                        break;
                    case 3:
                        double drawAmount = 0;
                        bool test = false;
                        do
                        {
                            Console.WriteLine("Enter the Total Draw Amount to be shared: ");
                            try { drawAmount = double.Parse(Console.ReadLine());}
                            catch
                            {
                                test = true;
                                Console.WriteLine("Enter a valid double for total Draw Amount");
                            }
                            
                        } while (test);
                        Draw draw = new Draw(drawAmount);
                        draw.DrawNumbers();
                        draw.PrintDrawNumbersList();
                        break;
                    case 4:
                        //lottery.PrintCategory();
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("You chose to Exit Program");
                        return;
                    case 7:
                        break;
                    default:
                        break;
                }//end switch

                Console.WriteLine();
                Console.Write("PROGRAM END:Would you like to continue? (Y/N): ");
                string answ = Console.ReadLine();

                try
                {
                    if (answ.ToUpper() != "Y"){ans = false;}
                }
                catch
                {
                    Console.WriteLine("Please enter a valid menu number (1-11)");
                }

            } while (ans);
            return;


        }
    }
}
