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
        public int XxID { get; set; }

        public Lottery()
        {
            DrawL = new List<Draw>();
            TicketL = new List<Ticket>();
            PlayersL = new List<Player>();
            WonNumbers = new List<int>();
        }

        public int Increment(int xID)
        {
            return XxID += 1;
        }

        // kalo to kinogame create numbers kai vazo prin ayto:
        //PlayersL.Add(new Player(r.Next(501, 1501)));
        public List<Player> GetPlayersList(int noTickets)
        {
                while(noTickets !=0)
                {
                    Player player = new Player(Increment(XxID));
                    PlayersL.Add(player);
                    noTickets--;
                }
            return PlayersL;
        }

        public List<Ticket> GetTicket()
        {
            var kino = new KinoGame(7);
            int noKinos = kino.GetnoKINO();
            foreach (Player p in PlayersL)
            {
                var ticket = new Ticket(Increment(XxID), kino.GetBonus(), noKinos, p);
                TicketL.Add(ticket);
            }
            return TicketL;
        }

       
        public void PrintSixNumbersList(List<int> alist)
        {
            Console.WriteLine("Player has chosen the following Numbers:");
            foreach (int i in alist)                       //εκτύπωση της λίστας των 6 αριθμών
            {
                Console.Write($"   {i},");
            }
            //    Console.WriteLine();
            //    Console.WriteLine($"KINO BONUS:   {bonusNumber}");
        }
        public void PrintRandomPlayersList()
        {
            Console.WriteLine("Players:");
            foreach (Player pl in PlayersL)                   //εκτύπωση της λίστας των Players
            {
                Console.WriteLine($"Player ID: {pl.ID}");
            }
        }

      
        //αντί για dictionary λιστα μέσα σε λίστα
        public List<List<Player>> SetPlayersNumbersPair()
        {
            var listLista = new List<List<Player>>();
            return listLista;
        }
       

        

       


      

    }
}
