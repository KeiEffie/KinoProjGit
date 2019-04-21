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
                Console.WriteLine("1. Play Tickets for Kino Game");
                Console.WriteLine("2. Make the Draw");
                Console.WriteLine("3. Winners");
                Console.WriteLine("4. Statistics");
                Console.WriteLine("5. Exit");

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
                        lottery.PlayKino();
                        lottery.PrintPlayersListDetails();
                        break;
                    case 2:
                        if (lottery.TicketL.Count != 0)
                        {

                            double drawAmount = 0;
                            bool trying = false;
                            do
                            {
                                Console.WriteLine("Enter the Total Draw Amount to be shared: ");
                                try { drawAmount = double.Parse(Console.ReadLine()); }
                                catch
                                {
                                    trying = true;
                                    Console.WriteLine("Enter a valid double for total Draw Amount");
                                }

                            } while (trying);
                            Draw draw = new Draw(lottery.Increment(lottery.XxID),drawAmount);
                            draw.DrawNumbers();
                            draw.PrintDrawNumbersList();
                            lottery.DrawL.Add(draw);
                        }
                        else
                        {
                            Console.WriteLine("No Ticket has been Played! Play fist a Kino! Then make a Draw");
                        }
                        break;

                    case 3:
                        lottery.GetResults();
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("You chose to Exit Program");
                        return;
                    default:
                        break;
                }//end switch

                Console.WriteLine();
                Console.Write("PROGRAM END:Would you like to continue? (Y/N): ");
                string answ = Console.ReadLine();

                try
                {
                    if (answ.ToUpper() != "Y"){ans = false;}
                    else if (answ.ToUpper() != "N") { ans = true; }
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
