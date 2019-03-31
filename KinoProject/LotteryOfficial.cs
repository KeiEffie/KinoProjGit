using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class LotteryOfficial
    {
        //the lottery event - entering players into a lottery, 
        //interface  - how to enter player details and ticket details etc.
        //drawing a lottery
        public List<Draw> DrawL;
        public List<Ticket> TicketL;
        public List<Player> PlayersL;
        public List<int> WonNumbers { get; set; }


        public LotteryOfficial()
        {
            Draw = new List<Draw>();
            Ticket = new List<Ticket>();
            WonNumbers = new List<WonNumbers>();
        }

        public static void Results(Draw draw, Ticket ticket)
        {
            Console.WriteLine($"For Ticket Number: {ticket.ID}");            
            for (int i=0; i < ticket.player.NumbersToPlay.Capacity; i++)
            {
                foreach (int j in ticket.player.NumbersToPlay)
                {
                    draw.WinnerList.Contains(j);

                }
                
            }
            

        }

    }
}
