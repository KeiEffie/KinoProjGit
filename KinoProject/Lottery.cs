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
        public List<Results> ResultsL;
        Dictionary<List<Player>, Ticket[]> playersTicketsPair;
         
        public List<int> WonNumbers { get; set; }
        public int XxID { get; set; }

        public Lottery()
        {
            DrawL = new List<Draw>();
            TicketL = new List<Ticket>();
            PlayersL = new List<Player>();
            WonNumbers = new List<int>();
            ResultsL = new List<Results>();
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
                    Player player = new Player(Increment(XxID), noTickets);
                    PlayersL.Add(player);
                    noTickets--;
                }
            return PlayersL;
        }

        public List<Ticket> GetTicket()
        {
            var kino = new KinoGame();
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
            //    Console.WriteLine($"KI NO BONUS:   {bonusNumber}");
        }

        public void PrintPlayersList()
        {
            Console.WriteLine("Players:");
            foreach (Player p in PlayersL)                   //εκτύπωση της λίστας των Players
            {
                Console.WriteLine($"Player ID: {p.ID}");
            }
        }

        public Ticket[] GetTickets(List<Player> PlayersL, int noTickets)
       
       // public Ticket[] GetTickets(List<Player> PlayersL, int noTickets)
        {
            Ticket[] nATicket = new Ticket[noTickets-1];
            int z = 0;
            
            foreach (Player p in PlayersL)                   
            {
                var kino = new KinoGame(); 
                int noKinos = kino.GetnoKINO();

                for (z=1; z <= p.noTickets; z++)
                {
                    var ticket = new Ticket(Increment(XxID), kino.GetBonus(), noKinos, p);
                    nATicket[z] = ticket;
                }
            }
            return nATicket;
        }

        public Dictionary<List<Player>, Ticket[]> CreatePlayersTicketsPair(List<Player> PlayersL, int noTickets)
        {
            ////για όσους Players εβαλε ο χρήστης, τόσες φορές σύνδεσε ένα array με τα Tickets που έπαιξαν
            for (int i = 0; i < PlayersL.Count; i++)
            {
                Ticket[] stg = GetTickets(PlayersL, 1);
                playersTicketsPair.Add(PlayersL, stg);   //γέμισμα του Dictionary με PlayersList και NumbersList
            }
            return playersTicketsPair;
        }//end CreatePlayersTicketsPair


         //ΈΛΕΓΧΟΣ ΓΙΑ BONUS - ΕΚΤΥΠΩΣΗ ΚΑΤΗΓΟΡΙΑΣ ΑΠΟΤΕΛΕΣΜΑΤΩΝ - ΓΙΑ ΚΑΘΕ TICKET
        public void PrintCategory(Results results, Draw draw, Ticket ticket)
        {
            if (!ticket.Bonus)
            {
                Console.WriteLine("Winning Category is: ");
                Console.WriteLine($"The Winnings Category is : {results.categoryWins}     ");
                Console.WriteLine($"The amount Won: {(draw.DrawAmount * results.GetCategoryRate(results.categoryWins))}");
            }
            else
            {
                Console.WriteLine("Winning Category is: ");
                Console.WriteLine($"The Winnings Category is : {results.categoryWins}+");
                Console.WriteLine($"The amount Won: {(draw.DrawAmount * results.GetCategoryRate(results.categoryWins + 6))}");
            }

        }

    }
}
