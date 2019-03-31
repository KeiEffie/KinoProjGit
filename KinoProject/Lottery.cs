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
        public List<int> WonNumbers { get; set; }


        public Lottery()
        {
            DrawL == new List<Draw>();
            TicketL = new List<Ticket>();
            PlayersL=new List<Player>();
            WonNumbers = new List<WonNumbers>();
        }

        public static void Results(List<Draw> drawL, List<Ticket> ticketL)
        {
            foreach (Ticket t in ticketL)
            {
            }
            Console.WriteLine($"For Ticket Number: {ticket.ID}");            
            for (int i=0; i < ticket.player.NumbersToPlay.Capacity; i++)
            {
                foreach (int j in ticket.player.NumbersToPlay)
                {
                    draw.WinnerList.Contains(j);

                }
                
            }
            

        }
        public static void Statistics(Draw draw, Ticket ticket)
        {

        }
           

        
    }
}
