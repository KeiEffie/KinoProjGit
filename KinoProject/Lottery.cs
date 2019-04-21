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
        //Dictionary<List<Player>, Ticket[]> playersTicketsPair;
        //public int noPlayers;

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
        public void CreateNumbersTable()
        {


            for (int j = 1; j <= 80; j++)
            {
                if (j < 10)
                {
                    Console.Write("  {0}  ", j);
                }
                else if (j % 10 == 0)
                {
                    Console.Write("  {0}  ", j);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("  {0}  ", j);
                }
            }
        }

    public int Increment(int xID)
        {
            return XxID += 1;
        }
        //χρειαζεται να γράψω κάποιο κώδικα για tickets, για να ρωτάω πόσα tickets θα παίξει ο/οι players και να τα βάλω στην μεταβλητή noTickets
        public int GetnoTickets()
        {
            int noTickets = 0;
            Console.WriteLine("How many Tickets would you like to play for each player? (min 1 - max 3)");
            try { noTickets = int.Parse(Console.ReadLine()); } catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number (min 1 - max 3):"); }
            return noTickets;
        }
        public int GetnoPlayers()
        {
            int noPlayers = 0;
            Console.WriteLine("How many Players would like to play? (min 1 - max 5)");
            try { noPlayers = int.Parse(Console.ReadLine()); } catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number (min 1 - max 5):"); }
            return noPlayers;
        }

        // Create Player(s)---with one or more than one tickets
        public List<Player> GetPlayersList(int noTickets, int noPlayers)
        {
            while (noPlayers != 0)
            {
                Player player = new Player(Increment(XxID), GetTicketsList(noTickets));
                PlayersL.Add(player);
                noPlayers--;
            }
            //while (noTickets !=0)
            //    {
            //        Player player = new Player(Increment(XxID), noTickets);
            //        PlayersL.Add(player);
            //        noTickets--;
            //    }
            return PlayersL;
        }

        //Create Ticket(s)
        private List<Ticket> GetTicketsList (int noTickets)
        {
            var kino = new KinoGame();
            foreach (Player p in PlayersL)
            {
                var ticket = new Ticket(Increment(XxID), p);
                TicketL.Add(ticket);
            }
            return TicketL;
        }

        //public Ticket[] GetTickets(List<Player> PlayersL, int noTickets)
        //{
        //    Ticket[] nATicket = new Ticket[noTickets - 1];
        //    int z = 0;

        //    foreach (Player p in PlayersL)
        //    {
        //        //KinoGame kino = new KinoGame();
        //        for (z = 1; z <= p.noTickets; z++)
        //        {
        //            var ticket = new Ticket(Increment(XxID), p);
        //            nATicket[z] = ticket;
        //        }
        //    }
        //    return nATicket;
        //}

        //public Dictionary<List<Player>, Ticket[]> CreatePlayersTicketsPair(List<Player> PlayersL, int noTickets)
        //{
        //    ////για όσους Players εβαλε ο χρήστης, τόσες φορές σύνδεσε ένα array με τα Tickets που έπαιξαν
        //    for (int i = 0; i < PlayersL.Count; i++)
        //    {
        //        Ticket[] stg = GetTickets(PlayersL, 1);
        //        playersTicketsPair.Add(PlayersL, stg);   //γέμισμα του Dictionary με PlayersList και NumbersList
        //    }
        //    return playersTicketsPair;
        //}//end CreatePlayersTicketsPair


         //ΈΛΕΓΧΟΣ ΓΙΑ BONUS - ΕΚΤΥΠΩΣΗ ΚΑΤΗΓΟΡΙΑΣ ΑΠΟΤΕΛΕΣΜΑΤΩΝ - ΓΙΑ ΚΑΘΕ TICKET
        public void PrintCategory(Results results, Draw draw, Ticket ticket)
        {
            //ticket.kino ? ticket.NumbersPlayedL.Last() : 0;
            if (ticket.bonus)
            {
                if (ticket.NumbersPlayedL.Last() == draw.BonusNumber)
                {
                    Console.WriteLine("Winning Category is: ");
                    Console.WriteLine($"The Winnings Category is : {results.categoryWins}+");
                    Console.WriteLine($"The amount Won: {(draw.DrawAmount * results.GetCategoryRate(results.categoryWins + 6))}");
                }
            }
            else
            {
                Console.WriteLine("Winning Category is: ");
                Console.WriteLine($"The Winnings Category is : {results.categoryWins}     ");
                Console.WriteLine($"The amount Won: {(draw.DrawAmount * results.GetCategoryRate(results.categoryWins))}");
            }

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
    }
}
