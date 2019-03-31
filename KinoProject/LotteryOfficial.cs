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
        public Draw Draw { get; set; }
                // List<int> WinnerList
                // int BonusNumber 
        //public Player player { get; set; }
                // List<Player> PlayersList
                // List<int> NumbersToPlay
       
        public Ticket Ticket { get; set; }
                // int ID  
                // List<Player> Players 
                // List<int> NumbersToPlay 
        public List<int> WonNumbers { get; set; }


        public LotteryOfficial()
        {
            Draw = new Draw();
            Ticket = new Ticket();
            WonNumbers = new List<int>();
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
