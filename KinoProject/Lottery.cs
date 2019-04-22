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
        
     // a general ID for any object
    public int Increment(int xID)
        {
            return XxID += 1;
        }

        //a Play KINO Method
        public void PlayKino()
        {
            int noTickets = GetnoTickets();
            int noPlayers = GetnoPlayers();
            PlayersL = GetPlayersList(noTickets, noPlayers);
            //TicketL.Add(PlayersL.ForEach(p=>p.TicketsPlayList);
            //OR ????
            foreach (Player p in PlayersL)
            {
                foreach (Ticket t in p.TicketsPlayList)
                {
                    TicketL.Add(t);         //ADD PLAYED TICKETS TO LOTTERY TICKETS LIST
                }
            }
        }

        //how many tickets will be played by each player
        public int GetnoTickets()
        {
            int noTickets = 0;
            Console.WriteLine("How many Tickets would you like to play for each player? (min 1 - max 3)");
            try { noTickets = int.Parse(Console.ReadLine()); } catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number (min 1 - max 3):"); }
            return noTickets;
        }
       
    // How many players will play
        public int GetnoPlayers()
        {
            int noPlayers = 0;
            Console.WriteLine("How many Players would like to play? (min 1 - max 5)");
            try { noPlayers = int.Parse(Console.ReadLine()); } catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number (min 1 - max 5):"); }
            return noPlayers;
        }

        // Create Player(s) List ---with one or more than one tickets
        public List<Player> GetPlayersList(int noTickets, int noPlayers)
        {
            List<Player> tempPlayersList = new List<Player>();
            while (noPlayers != 0)
            {
                Player player = new Player(Increment(XxID), GetTicketsList(noTickets));
                tempPlayersList.Add(player);
                noPlayers--;
            }
            return tempPlayersList;
        }

        //Create Ticket(s) List
        private List<Ticket> GetTicketsList (int noTickets)
        {
            List<Ticket> tempTicketList = new List<Ticket>();
            for (int j = 0; j < noTickets; j++)
            {
                var ticket = new Ticket(Increment(XxID));
                tempTicketList.Add(ticket);
                //TicketL.Add(ticket);
            }

            return tempTicketList;
        }

        public void GetResultsList()   /// thelei douleiaaaaa
        {
            Results results = new Results();
            foreach (Ticket t in TicketL)
            {
                foreach (Draw d in DrawL)
                {
                    var resultList = results.GetResultList(d.WinnerList, t.NumbersPlayedL);
                    PrintCategory(results, d, t);
                }
            }
        }
         public void GetResults()   /// thelei douleiaaaaa
        {
          
            Results results = new Results();
            List<int> resultList =new List<int>();
            foreach (Draw d in DrawL)
            {
              // Console.WriteLine(t.ToString());
               foreach (Ticket t in TicketL)
                {
                  // Console.WriteLine(d.ToString());

                     resultList = results.GetResultList(d.WinnerList, t.NumbersPlayedL);
                    Console.WriteLine("Inside");
                    Console.WriteLine(String.Join(", ",  resultList.Select(i => i.ToString())));
namespace                    Console.WriteLine($"Category Winners :{categW}");
                    var catRate = results.GetCategoryRate(categW);
                    Console.WriteLine($"Category Rate :{catRate}");
                    // Console.WriteLine("Inside");
                    // Console.WriteLine(String.Join(", ", t.NumbersPlayedL.Select(i => i.ToString())));
                    // Console.WriteLine(String.Join(", ", d.WinnerList.Select(i => i.ToString())));
                    PrintCategory(results, d, t);
                    Console.WriteLine("After");
                    PrintPlayersListDetails();
                }
            }
        }
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


        public void PrintPlayersListDetails()
        {

            Console.WriteLine("Players:");
            foreach (Player p in PlayersL)                   //εκτύπωση της λίστας των Players
            {
                Console.WriteLine($"Player ID: {p.ID}, played {p.noTickets} Ticket(s) with:");
                foreach(Ticket t in p.TicketsPlayList)                    //εκτύπωση της λίστας των Tickets του κάθε Player
                {
                    string KinoNumsOnTicket = String.Join(", ", t.NumbersPlayedL.Select(i => i.ToString()));
                    Console.WriteLine("Ticket ID: {0} with KINO Numbers:{1} ,  {2}", t.ID, KinoNumsOnTicket, (t.bonus ? $"with Kino Bonus: {t.NumbersPlayedL.Last()}" : ""));

                    //Console.WriteLine(String.Join(", ", t.NumbersPlayedL.Select(i => i.ToString())));
                    // OR THE FOLLOWING:!!!!!!!!!!!!!!
                    //for (int i=0; i < t.NumbersPlayedL.Count; i++)
                    //{
                    //    Console.Write(t.NumbersPlayedL[i] + ",, ");
                    //}
                }
            }
        }



    }//end lottery
}
