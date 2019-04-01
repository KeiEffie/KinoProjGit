using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Player
    {
        public int ID;
        public string Name;


        public Player(int id)
        {
            ID = id;
            NumbersToPlay = new List<int>();
            Bonus = false;
            PlayersList = new List<Player>();
        }

        public Player()
        {
        }

        public override string ToString()
        {
            return "Player ID:" + ID;
        }


        //Διαβάζει τα νούμερα που παίζει ο Player και τα βάζει  σε μία λίστα 
        public void CreateSixNumbersList()
        {
            int kinoNumber = 0;
            int count = 1;
            var NumbersToPlay = new List<int>();
            int bonusNumber = 0;
            bool anas = false;
            Random r = new Random();

            PlayersList.Add(new Player(r.Next(501,1501)));

            Console.WriteLine("Choose 6 Numbers from the list above from 1 to 80");
            while (count <= 6)
            {
                Console.Write($"Enter Next Number, No{count}: ");
                try { kinoNumber = int.Parse(Console.ReadLine()); } catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number:"); }


                if (NumbersToPlay.Contains(kinoNumber)) //check whether the number is already in List
                {
                    Console.Write($"You have given this number before. Please try again!");
                }
                else if (kinoNumber > 80 || kinoNumber < 1)
                {
                    Console.Write($"You have given a number out of range of 1-80. Please try again!");
                }
                else
                {
                    NumbersToPlay.Add(kinoNumber); // Add User Input to Six Numers List
                    count++;
                }
            }
                while(!anas)
                {
                    string ansBonus="";
                    if (count == 7)
                    {
                        Console.Write($"Will you play a Bonus number? (Y/N): ");
                        try {ansBonus = Console.ReadLine(); } catch { Console.Write("You didn't enter a Y or N. Please try again! "); Console.WriteLine("Will you play a Bonus number? (Y/N): "); }
                        if (ansBonus.ToUpper()=="Y")
                        {
                           bonusNumber = kinoNumber;
                           Bonus = anas = true;
                        Console.WriteLine($"Your Bonus Number is: {bonusNumber}");
                        }
                    }
                }
            PrintSixNumbersList(NumbersToPlay);
        }//end CreateSixNumbersList


        public void PrintSixNumbersList(List<int> alist)
        {
            NumbersToPlay = alist;
            Console.WriteLine("Player has chosen the following Numbers:");
            foreach (int i in NumbersToPlay)                       //εκτύπωση της λίστας των 6 αριθμών
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
            try { kinoPlayers = int.Parse(Console.ReadLine());}
            catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number:"); }


            Dictionary<List<Player>, List<int>> PlayerSixNumbersPair = new Dictionary<List<Player>, List<int>>();

            ////για όσους Players εβαλε ο χρήστης, τόσες φορές δημιουργησε μία λίστα για 6 Numbers για κάθε Player
            for (int i = 0; i<kinoPlayers; i++)
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
                while (kinoNums.Contains(num) == true)		   //if it has try another random, until it hasnt been picked
                {
                    num = randm.Next(1, 80);
                }
                kinoNums[i] = num;			                    //hasnt been picked, so added to the array
            }
            return kinoNums;
        }

    }//end class
}// end namespace
