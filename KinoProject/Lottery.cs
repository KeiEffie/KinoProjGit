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
        public int xId = 0;

        public Lottery()
        {
            DrawL = new List<Draw>();
            TicketL = new List<Ticket>();
            PlayersL = new List<Player>();
            WonNumbers = new List<int>();
        }

        public int icrement(x)
        {
            xId += 1;
        }

        // kalo to kinogame create numbers kai vazo prin ayto:
        //PlayersL.Add(new Player(r.Next(501, 1501)));
        public List<Player> GetPlayersList(int noTickets)
        {
            if (noTickets <= noPlayers)
            {
                for (i = 1; i <= noTickets; i++)
                {
                    Player player = new Player();
                    PlayersL.Add(player);
                }
            }
            return PlayersL;
        }

        public void GetPlayer()
        {
            foreach (Player p in PlayersL)
            {

            }
        }

        public PlayKinoGame()
        {
            var kinoGame = new KinoGame();
            int noKino = kinoGame.GetnoKino();
            //public Ticket(int id, bool bonus, List<int> numbersPlayedL, Player player)
            var ticket = new Ticket(icrement(xId), kinoGame.GetBonus, SetKINOList(noKino), GetPlayer())
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
            foreach (Player pl in PlayersList)                   //εκτύπωση της λίστας των Players
            {
                Console.WriteLine($"Player ID: {pl.ID}");
            }
        }

        //εκτύπωση της λίστας των Players και της λίστας των 6 αριθμών
        public void PrintRandomPlayersWithNumbersDict(Dictionary<List<Player>, List<int>> newDict)
        {
            //Print each pair of Key-Value from Dictionary PlayerSixNumbersPair
            foreach (KeyValuePair<List<Player>, List<int>> pl in newDict)
            {
                Console.WriteLine();
                for (int j = 0; j < pl.Key.Count; j++)
                {
                    Console.WriteLine($"Pair here: {pl.Key[j]}");

                    for (int i = 0; i < pl.Value.Count; i++)
                    {

                        Console.WriteLine($"Pair Value: {pl.Value[i]}");
                    }
                }
            }
        }//end 
        //αντί για dictionary λιστα μέσα σε λίστα
        public List<List<Player>> SetPlayersNumbersPair()
        {
            var listLista = new List<List<Player>>();
            return listLista;
        }
        public Dictionary<List<Player>, List<int>> CreateRandomPlayersDict()
        {

            int kinoPlayers = 0;        ////Πόσοι παίκτες θα παίξουν ΚΙΝΟ?

            Console.Write("Enter the number of players you want to play KINO: ");
            try { kinoPlayers = int.Parse(Console.ReadLine()); }
            catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number:"); }


            Dictionary<List<Player>, List<int>> PlayerSixNumbersPair = new Dictionary<List<Player>, List<int>>();

            ////για όσους Players εβαλε ο χρήστης, τόσες φορές δημιουργησε μία λίστα για 6 Numbers για κάθε Player
            for (int i = 0; i < kinoPlayers; i++)
            {

                NumbersToPlay = CreateRandomSixNumbersList();           //γέμισμα της λίστας των 6 Numbers για κάθε Player

                PlayersList = CreateRandomPlayer();                     //γέμισμα της λίστας των Players

                PlayerSixNumbersPair.Add(PlayersList, NumbersToPlay);   //γέμισμα του Dictionary με PlayersList και NumbersList
            }

            return PlayerSixNumbersPair;
        }//end CreateRandomPlayers


        // Δημιουργία μιας λίστας με Players
        public List<Player> CreateRandomPlayer()
        {
            List<Player> newPlayersList = new List<Player>();
            var random = new Random();
            int idNumber = (random.Next(101, 750));

            var newPlayer = new Player(idNumber);

            if (!newPlayersList.Contains(newPlayer)) //check whether the number is already in List
            {
                /* newPlayer = new Player(idNumber);*/                // gemizo to ID,δημιουργία νέου Player
                newPlayersList.Add(newPlayer);                      //προσθήκη  του νέου Player στην λίστα των Players
            }
            return newPlayersList;
        }//end 


        // Δημιουργία μιας λίστας με 6 numbers
        public List<int> CreateRandomSixNumbersList()
        {
            Random random = new Random();
            List<int> newSixPlayerNumbers = new List<int>(6);
            int idNumber = (random.Next(1, 80));

            for (int j = 0; j < newSixPlayerNumbers.Capacity; j++)
            {
                if (!newSixPlayerNumbers.Contains(idNumber))
                {
                    newSixPlayerNumbers.Add(idNumber);
                }
                else
                {
                    j--;
                }
                idNumber = (random.Next(1, 80));
            }
            return newSixPlayerNumbers;
        }//end 

        //Δημιουργία ενός array με 6 νούμερα ----  άλλος ένας τρόπος
        public Array RandomSix()
        {
            int[] kinoNums = new int[6];
            Random randm = new Random();
            int num = 0;

            for (int i = 0; i < kinoNums.Length; i++)
            {
                num = randm.Next(1, 80);                        //generate random number
                                                                //check to see whether number has already been picked
                while (kinoNums.Contains(num) == true)
                //if it has try another random, until it hasnt been picked
                {
                    num = randm.Next(1, 80);
                }
                kinoNums[i] = num;
                //hasnt been picked, so added to the array
            }
            return kinoNums;
        }


        public static void Results(Draw draw, Ticket ticket)
        {
            Console.WriteLine($"For Ticket Number: {ticket.}");
            for (int i = 0; i < ticket.NumbersPlayedL.Capacity; i++)
            {
                foreach (int j in ticket.NumbersPlayedL)
                {
                    draw.WinnerList.Contains(j);

                }
            }
        }

    }
}
