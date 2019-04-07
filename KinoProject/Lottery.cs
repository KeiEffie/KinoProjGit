using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Lottery
    {
        //the lottery event - entering players into a lottery, 
        //interface  - how to enter player details and ticket details etc.
        //drawing a lottery
        public List<Draw> DrawL;
        public List<Ticket> TicketL;
        public List<Player> PlayersL;
        public List<int> WonList;
      




        public Lottery()
        {
            DrawL = new List<Draw>();
            TicketL = new List<Ticket>();
            PlayersL = new List<Player>();
            WonList = new List<int>();
        }


        public void Results()
        {
            foreach (Ticket t in TicketL)
            {
                Console.WriteLine($"For Ticket Number: {t.ID}");
                foreach (Draw d in DrawL)
                {                                                                           //var intersect = array1.Intersect(array2);
                    var WonList = d.WinnerList.Intersect(t.NumbersPlayedL);                     //foreach(int j in t.NumbersPlayedL)
                  
                }
            }
            // return WonList;
        }
        public void PrintResults()
        {
            Console.WriteLine();
            Console.WriteLine($"The Winning Numbers Found:");

            foreach (int i in WonList)
            {
                Console.Write($"   {i},");

            }
            Console.WriteLine();
        }


        public void PrintMatches()
        {
            foreach (Ticket t in TicketL)
            {
                Console.WriteLine($"For Ticket Number: {t.ID}");
                foreach (int i in t.NumbersPlayedL)
                {
                    Console.WriteLine();
                    Console.WriteLine("Played Numbers");
                    Console.Write($"   {i},");
                }
                foreach (int j in WonList)
                {
                    Console.WriteLine();
                    Console.WriteLine("Won Numbers");
                    Console.Write($"   {j},");
                }
            }
        }

        public void CountMatches()
        {
            int numsWon = WonList.Count;
                
            foreach (Draw d in DrawL)
            {
                foreach (Ticket t in TicketL)
                {
                    switch (numsWon)
                    {
                        case 0:
                            t.WinsCategory = (int)WinCategory.Zero;
                            break;
                        case 1:
                            t.WinsCategory = (int)WinCategory.One;
                            break;
                        case 2:
                            t.WinsCategory = (int)WinCategory.Two;
                            break;
                        case 3:
                            break;
                            t.WinsCategory = (int)WinCategory.Three;
                            break;
                        case 4:
                            t.WinsCategory = (int)WinCategory.Four;
                            break;
                        case 5:
                            t.WinsCategory = (int)WinCategory.Five;
                            break;
                        case 6:
                            t.WinsCategory = (int)WinCategory.Six;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        

        public static void Statistics(List<Draw> drawL, List<Ticket> ticketL)
        {

        }
        
           

        
    }
}
