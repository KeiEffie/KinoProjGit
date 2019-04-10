using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class KinoGame
    {
        public List<int> KinoNumbersList { get; set; }
        public bool Bonus { get; set; }
        public int noKino;
        public bool isManual = true;


        public KinoGame()
        {
            KinoNumbersList = new List<int>(noKino);
            Bonus = GetBonus();
        }


        //createNumbersList
        //Bonus



        //Manual or Random create Kino Numbers List
        public ManualRandomChoice()
        {
            Console.WriteLine("Would you like to choose Kino numbers");
            Console.WriteLine("Or let the Kino System choose 6 Numbers from 1 to 80  Randomly for you");
            Console.Write("To input Randomly Press 0 \t"); Console.WriteLine("To input Manually Press 1");

            try
            {
                isManual = Convert.ToBoolean(Console.ReadLine());
            }
            catch
            {
                Console.Write("You didn't enter a 0 or 1 choice. Please try again! ");
                Console.WriteLine("Manually choose 6 Numbers OR Randomly? (0/1): ");
            }

            Console.WriteLine($"Your Choice is: {isManual}, ie {Convert.ToInt32(isManual)}");

            //return isManual;
        }//end Manual OR Random

        // Get Bonus
        public bool GetBonus()
        {
            bool anas = false;
            while (!anas)
            {
                string ansBonus = "";

                Console.Write($"Will you play a Bonus number? (Y/N): ");
                try { ansBonus = Console.ReadLine(); } catch { Console.Write("You didn't enter a Y or N. Please try again! "); Console.WriteLine("Will you play a Bonus number? (Y/N): "); }
                if (ansBonus.ToUpper() == "Y")
                {
                    //bonusNumber = kinoNumber;  // actually is the last number of x-length list
                    Bonus = anas = true;
                }
            }
            return Bonus;
        }//end GetBonus


        //auto increment

        public int GetnoKINO()
        {
            Console.WriteLine("How many Kino Numbers would you like to play? (min 3 - max 15)");
            try { noKino = int.Parse(Console.ReadLine()); } catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number (min 3 - max 15):"); }
            return noKino;
        }

        public List<int> SetKINOList(int noKino)
        {
            ManualRandomChoice();
            noKino = GetnoKINO();
            List<int> KinoNumbersList = new List<int>(noKino);
            if (isManual)
            {
                KinoNumbersList = CreateManualKINONumbersList();
            }
            else
            {
                KinoNumbersList = CreateRandomKINONumbersList();
            }
        }

        // Δημιουργία μιας λίστας με KINO numbers - Manually 
        public List<int> CreateManualKINONumbersList()
        {
            int kinoNumber = 0;
            int count = 1;

            Console.WriteLine($"Choose {noKino} Numbers from the list above from 1 to 80");


            while (count <= noKino)
            {
                Console.Write($"Enter Next Number, No{count}: ");
                try { kinoNumber = int.Parse(Console.ReadLine()); } catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number:"); }


                if (KinoNumbersList.Contains(kinoNumber))
                //check whether the number is already in List
                {
                    Console.Write($"You have given this number before. Please try again!");
                }
                else if (kinoNumber > 80 || kinoNumber < 1)
                {
                    Console.Write($"You have given a number out of range of 1-80. Please try again!");
                }
                else
                {
                    KinoNumbersList.Add(kinoNumber); // Add User Input to Six Numers List
                    count++;
                }
            }
            return KinoNumbersList;

        }//end Manual

        // Δημιουργία μιας λίστας με KINO numbers - Randomly
        public List<int> CreateRandomKINONumbersList()
        {
            Random random = new Random();
            int idNumber = (random.Next(1, 80));

            for (int j = 0; j < KinoNumbersList.Capacity; j++)
            {
                if (!KinoNumbersList.Contains(idNumber))
                {
                    KinoNumbersList.Add(idNumber);
                }
                else
                {
                    j--;
                }
                idNumber = (random.Next(1, 80));
            }
            return KinoNumbersList;
        }//end Random


    }
}
