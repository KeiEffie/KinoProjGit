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


        public void Results(List<Draw> drawL, List<Ticket> ticketL)
        {
            foreach (Ticket t in ticketL)
            {
                Console.WriteLine($"For Ticket Number: {t.ID}");
                foreach (Draw d in drawL)
                {                                                                           //var intersect = array1.Intersect(array2);
                    var WonList = d.WinnerList.Intersect(t.NumbersPlayedL);                     //foreach(int j in t.NumbersPlayedL)
                  
                }
            }
            // return WonList;
        }

       public void CountMatches()
        {
            int timesWon = WonList.Count;
            switch (timesWon)
            {
                case 1:
                    break;
                default:
                    break;
            }
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

        public static void Statistics(List<Draw> drawL, List<Ticket> ticketL)
        {

        }
        
           

        
    }
}
