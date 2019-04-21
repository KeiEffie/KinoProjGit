//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace KinoProject
//{
//    class SampleCode
//    {
//        public void SwitchMenu()
//        {
//            switch (choice)
//            {
//                case 1:

//                    lottery.CreateNumbersTable();
//                    player.CreateSixNumbersList();
//                    break;
//                case 2:
//                    var newDict = player.CreateRandomPlayersDict();
//                    player.PrintRandomPlayersWithNumbersDict(newDict);
//                    break;
//                case 3:
//                    double drawAmount = 0;
//                    bool test = false;
//                    do
//                    {
//                        Console.WriteLine("Enter the Total Draw Amount to be shared: ");
//                        try { drawAmount = double.Parse(Console.ReadLine()); }
//                        catch
//                        {
//                            test = true;
//                            Console.WriteLine("Enter a valid double for total Draw Amount");
//                        }

//                    } while (test);
//                    Draw draw = new Draw(drawAmount);
//                    draw.PrintWinnerList();
//                    break;
//                case 4:
//                    lottery.Results();
//                    lottery.CountMatches();
//                    lottery.PrintMatches();
//                    break;
//                case 5:
//                    break;
//                case 6:
//                    Console.WriteLine("You chose to Exit Program");
//                    return;
//                case 7:
//                    break;
//                default:
//                    break;
//            }//end switch
//        }
//        //Δημιουργία ενός array με 6 νούμερα ----  άλλος ένας τρόπος
//        public Array RandomSix()
//        {
//            int[] kinoNums = new int[6];
//            Random randm = new Random();
//            int num = 0;

//            for (int i = 0; i < kinoNums.Length; i++)
//            {
//                num = randm.Next(1, 80);                        //generate random number
//                                                                //check to see whether number has already been picked
//                while (kinoNums.Contains(num) == true)		   //if it has try another random, until it hasnt been picked
//                {
//                    num = randm.Next(1, 80);
//                }
//                kinoNums[i] = num;			                    //hasnt been picked, so added to the array
//            }
//            return kinoNums;
//        }
//        // Δημιουργία μιας λίστας με 6 numbers
//        public List<int> CreateRandomSixNumbersList()
//        {
//            Random random = new Random();
//            List<int> newSixPlayerNumbers = new List<int>(6);
//            int idNumber = (random.Next(1, 80));

//            for (int j = 0; j < newSixPlayerNumbers.Capacity; j++)
//            {
//                if (!newSixPlayerNumbers.Contains(idNumber))
//                {
//                    newSixPlayerNumbers.Add(idNumber);
//                }
//                else
//                {
//                    j--;
//                }
//                idNumber = (random.Next(1, 80));
//            }
//            return newSixPlayerNumbers;
//        }//end 

//        private int UniqueLRID() //another way of implementing an auto ID containing numbers 
//                                 //but numbers from 0-9 
//        {

//            char[] charLettersArray = "0123456789".ToCharArray();
//            Random random = new Random();
//            string finalString = "";

//            for (int i = 0; i < 5; i++)  // max = 99999
//            {
//                finalString += charLettersArray[random.Next(charLettersArray.Length)];
//            }
//            int finalID = int.Parse(finalString);
//            // ΑΝ ΥΠΑΡΧΕΙ ΤΟ Id του Ticket ξανατρέξε την ίδια μέθοδο, αλλιώς πρόσθεσέ το στην λίστα με τα IDs και επέστρεψε το UNIQUE ID
//            if (!DrawList.Contains(finalID))
//            {
//                DrawList.Add(finalID);
//            }
//            else
//            {
//                UniqueLRID();
//            }

//            Console.WriteLine("Draw ID:  {0}", finalString);
//            return finalID;
//        }

//        public Dictionary<List<Player>, Ticket[]> CreatePlayersTicketsPair()
//        {

//            ////για όσους Players εβαλε ο χρήστης, τόσες φορές σύνδεσε ένα array με τα Tickets που έπαιξαν
//            for (int i = 0; i < PlayersL.Count; i++)
//            {
//                playersTicketsPair.Add(PlayersL, GetTickets());   //γέμισμα του Dictionary με PlayersList και NumbersList
//            }
//            return playersTicketsPair;
//        }//end CreateRandomPlayers

//        public List<List<Player>> SetPlayersNumbersPair()
//        {
//            var listLista = new List<List<Player>>();
//            return listLista;
//        }
//        public Dictionary<List<Player>, Ticket[]> CreatePlayersTicketsPair2()
//        {


//            Dictionary<List<Player>, List<int>> PlayerSixNumbersPair = new Dictionary<List<Player>, List<int>>()
//;

//            ////για όσους Players εβαλε ο χρήστης, τόσες φορές δημιουργησε μία λίστα για 6 Numbers για κάθε Player
//            for (int i = 0; i < kinoPlayers; i++)
//            {

//                NumbersToPlay = CreateRandomSixNumbersList();           //γέμισμα της λίστας των 6 Numbers για κάθε Player


//                PlayersList = CreateRandomPlayer();                     //γέμισμα της λίστας των Players
//                PlayerSixNumbersPair.Add(PlayersList, NumbersToPlay);   //γέμισμα του Dictionary με PlayersList και NumbersList

//            }

//            return PlayerSixNumbersPair;

//        }//end CreateRandomPlayers
//         //εκτύπωση της λίστας των Players και της λίστας των 6 αριθμών
//        public void PrintRandomPlayersWithNumbersDict(Dictionary<List<Player>, List<int>> newDict)
//        {
//            //Print each pair of Key-Value from Dictionary PlayerSixNumbersPair
//            foreach (KeyValuePair<List<Player>, List<int>> pl in newDict)
//            {
//                Console.WriteLine();
//                for (int j = 0; j < pl.Key.Count; j++)
//                {
//                    Console.WriteLine($"Pair here: {pl.Key[j]}");

//                    for (int i = 0; i < pl.Value.Count; i++)
//                    {

//                        Console.WriteLine($"Pair Value: {pl.Value[i]}");
//                    }
//                }
//            }
//        }//end 

//        public PlayKinoGame()
//        {
//            var kino = new KinoGame();
//            int noKinos = kino.GetnoKINO();
//            foreach (Player p in PlayersL)
//            {
//                var ticket = new Ticket(Increment(XxID), kino.GetBonus(), noKinos, p);
//            }
//        }
//        // Δημιουργία μιας λίστας με Players
//        public List<Player> CreateRandomPlayer()
//        {
//            List<Player> newPlayersList = new List<Player>();
//            var random = new Random();
//            int idNumber = (random.Next(101, 750));

//            var newPlayer = new Player(idNumber);

//            if (!newPlayersList.Contains(newPlayer)) //check whether the number is already in List
//            {
//                /* newPlayer = new Player(idNumber);*/                // gemizo to ID,δημιουργία νέου Player
//                newPlayersList.Add(newPlayer);                      //προσθήκη  του νέου Player στην λίστα των Players
//            }
//            return newPlayersList;
//        }//end 

//        // Δημιουργία μιας λίστας με 6 numbers
//        public List<int> CreateRandomSixNumbersList()
//        {
//            Random random = new Random();
//            List<int> newSixPlayerNumbers = new List<int>(6);
//            int idNumber = (random.Next(1, 80));

//            for (int j = 0; j < newSixPlayerNumbers.Capacity; j++)
//            {
//                if (!newSixPlayerNumbers.Contains(idNumber))
//                {
//                    newSixPlayerNumbers.Add(idNumber);
//                }
//                else
//                {
//                    j--;
//                }
//                idNumber = (random.Next(1, 80));
//            }
//            return newSixPlayerNumbers;
//        }//end 

//        //Δημιουργία ενός array με 6 νούμερα ----  άλλος ένας τρόπος
//        public Array RandomSix()
//        {
//            int[] kinoNums = new int[6];
//            Random randm = new Random();
//            int num = 0;

//            for (int i = 0; i < kinoNums.Length; i++)
//            {
//                num = randm.Next(1, 80);                        //generate random number
//                                                                //check to see whether number has already been picked
//                while (kinoNums.Contains(num) == true)
//                //if it has try another random, until it hasnt been picked
//                {
//                    num = randm.Next(1, 80);
//                }
//                kinoNums[i] = num;
//                //hasnt been picked, so added to the array
//            }
//            return kinoNums;
//        }


//        //public static void GetResults(Draw draw, Ticket ticket)
//        //{
//        //    List<int> resultArray = new List<int>();
//        //    Console.WriteLine($"For Ticket Number: {ticket.ID}");
//        //    for (int i = 0; i < ticket.NumbersPlayedL.Count; i++)
//        //    {
//        //        foreach (int j in ticket.NumbersPlayedL)
//        //        {
//        //            if (draw.WinnerList.Contains(j))
//        //                resultArray.Add(j);
//        //        }
//        //    }
//        //}
//        public static List<int> GetResults(Draw draw, Ticket ticket)
//        {
//            List<int> resultList = ticket.NumbersPlayedL.Intersect(draw.WinnerList).ToList(); ;
//            return resultList;
//        } 
////ΈΛΕΓΧΟΣ ΓΙΑ BONUS - ΕΚΤΥΠΩΣΗ ΚΑΤΗΓΟΡΙΑΣ ΑΠΟΤΕΛΕΣΜΑΤΩΝ - ΓΙΑ ΚΑΘΕ TICKET
//        public void PrintCategory(int categoryWins, Draw draw)
//         {
//        if (BonusNo == 0)
//        {
//           Console.WriteLine("Winning Category is: 1");
//           Console.WriteLine($"The Winnings Category is : {categoryWins}     ");
//           Console.WriteLine($"The amount Won: {(draw.DrawAmount * GetCategoryPercentage(categoryWins))}");
//        }
//        else
//        {
//            Console.WriteLine("Winning Category is: 1");
//            Console.WriteLine($"The Winnings Category is : {categoryWins}+");
//           Console.WriteLine($"The amount Won: {(draw.DrawAmount * GetCategoryPercentage(categoryWins + 6))}");
//        }

//        }

//public bool GetManualBonusKino()
//{
//    Console.WriteLine("Would you like to play KINO Bonus ? (0:No, 1:Yes)");
//    try { bonus = bool.Parse(Console.ReadLine()); } catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number:(0/1), 0:No Bonus, 1:Yes: (Play Bonus):"); }
//    return bonus;
//}

//public bool GetRandomBonusKino()
//{
//    Console.WriteLine("Would you like to play KINO Bonus for your Automatic Players? (0:No, 1:Yes)");
//    try { bonus = bool.Parse(Console.ReadLine()); } catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number:(0/1), 0:No Bonus, 1:Yes: (Play Bonus):"); }
//    return bonus;
//}
//public Ticket[] GetTickets(List<Player> PlayersL, int noTickets)

// public Ticket[] GetTickets(List<Player> PlayersL, int noTickets)
//                {
//                    Ticket[] nATicket = new Ticket[noTickets - 1];
//int z = 0;

//                    foreach (Player p in PlayersL)
//                    {
//                        var kino = new KinoGame();
//                        for (z = 1; z <= p.noTickets; z++)
//                        {
//                            var ticket = new Ticket(Increment(XxID), p);
//nATicket[z] = ticket;
//                        }
//                    }
//                    return nATicket;
//                }


///////***************************************************************************************************************************************
//void CreateNumbersTable()
//{


//    for (int j = 1; j <= 80; j++)
//    {
//        if (j < 10)
//        {
//            Console.Write("  {0}  ", j);
//        }
//        else if (j % 10 == 0)
//        {
//            Console.Write("  {0}  ", j);
//            Console.WriteLine();
//        }
//        else
//        {
//            Console.Write("  {0}  ", j);
//        }
//    }
//}

/////***************************************************************************************************************************************
////print 80numbers list for the user as a table in console
////foreach (int i in list80Kino)
////  {
/////***************************************************************************************************************************************
//for (int j = 1; j <= 80; j++)
//{
//    if (j < 10)
//    {
//        Console.Write("  {0}  ", j);
//    }
//    else if (j % 10 == 0)
//    {
//        Console.Write("  {0}  ", j);
//        Console.WriteLine();
//    }
//    else
//    {
//        Console.Write("  {0}  ", j);
//    }
//}
/////***************************************************************************************************************************************

////Πόσοι παίκτες θα παίξουν ΚΙΝΟ?
//Console.WriteLine("Enter players to play");
//    int playersToPlay = int.Parse(Console.ReadLine());

//    //initialiaze την λίστα των players
//    List<Player> somePlayers = new List<Player>();

//    //initialize την λίστα των 6 Numbers, των Players, του Dictionary
//    List<int> playerSixNumbersList = new List<int>();
//    List<Player> newPlayersList = new List<Player>();

//    Dictionary<List<Player>, List<int>> PlayerSixNumbersPair = new Dictionary<List<Player>, List<int>>();


//    // για όσους Players εβαλε ο χρήστης, τόσες φορές δημιουργησε μία λίστα για 6 Numbers για κάθε Player
//    for (int i = 0; i < playersToPlay; i++)
//    {
//        playerSixNumbersList = Player.CreateSixNumbersList();

//        //γέμισμα της λίστας των Players
//        somePlayers = Player.GetPlayers();

//        //εκτύπωση της λίστας των 6
//        foreach (int num in playerSixNumbersList)
//        {
//            Console.WriteLine(num);
//        }
//        //εκτύπωση της λίστας των Players
//        foreach (Player player in somePlayers)
//        {
//            Console.WriteLine($"Player ID: {player.ID}");
//            Console.WriteLine($"Player ToString : {player.ToString()}");
//        }

//        //// The Add method throws an exception if the new key is 
//        //// already in the dictionary.
//        //try
//        //{
//        //    openWith.Add("txt", "winword.exe");
//        //}
//        //catch (ArgumentException)
//        //{
//        //    Console.WriteLine("An element with Key = \"txt\" already exists.");
//        //}



//        //γέμισμα του Dictionary με PlayersList και NumbersList
//        PlayerSixNumbersPair.Add(somePlayers, playerSixNumbersList);
//    }

//    //Print each pair of Key-Value from Dictionary PlayerSixNumbersPair
//    foreach (KeyValuePair<List<Player>, List<int>> pl in PlayerSixNumbersPair)
//    {
//        Console.WriteLine();
//        for (int j = 0; j < pl.Key.Count; j++)
//        {
//            Console.WriteLine($"Pair here: {pl.Key[j]}");
//            for (int i = 0; i < pl.Value.Count; i++)
//            {

//                Console.WriteLine($"Pair Value: {pl.Value[i]}");
//            }
//        }
//    }

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
//public void PrintSixNumbersList(List<int> alist)
//{
//    Console.WriteLine("Player has chosen the following Numbers:");
//    foreach (int i in alist)                       //εκτύπωση της λίστας των 6 αριθμών
//    {
//        Console.Write($"   {i},");
//    }
//    //    Console.WriteLine();
//    //    Console.WriteLine($"KI NO BONUS:   {bonusNumber}");
//}


//    }
//}