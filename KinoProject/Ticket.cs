using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Ticket
    {
        //enum WinCategory
        //{
        //    SixPlus = 1,
        //    Six = 2,
        //    FivePlus = 4,
        //    Five = 8,
        //    FourPlus = 16,
        //    Four = 32,
        //    ThreePlus = 64,
        //    Three = 128,
        //    TwoPlus = 256,
        //    Two = 512,
        //    OnePlus = 1024,
        //    One = 2048,
        //    Zero = 4096
            
        //}
        ////get value
        //int day = (int)Days.TuesDay;
        ////cast to enum
        //Days day = (Days)3;
        ////Converts int to enum values

        ////Method 2:
        //Days day = (Days)Enum.ToObject(typeof(Days), 3);

        private int id;
        public int ID
        { get
            { return id; }
            set
            {
                id = UniqueID();
            }
        }
        public Player Player;
        public Draw Draw;
        public List<int> NumbersPlayedL;
        private int drawTimes = 0;
        public int DrawTimes { get { return drawTimes; } set { drawTimes = value; }}

        public int bonusNumber = 0;
        public bool Bonus;
        public List<int> PartakeDrawList;
        //list keeping the draw IDs that the specific ticket partook
        private int winsCategory;
        public int WinsCategory { get { return winsCategory; } set { winsCategory = (int)WinCategory.Zero; } }          //enum

        //προσωρινά μόνο
        public Ticket()
        {
        }

        public Ticket(int id)
        {
            ID = id;
            Player = new Player();
            PartakeDrawList = new List<int>();
            NumbersPlayedL = new List<int>();
            DrawTimes = drawTimes;
            Bonus = false;
            WinsCategory = WinsCategory;
        }


        //Διαβάζει τα νούμερα που παίζει ο Player και τα βάζει  σε μία λίστα 
        public void CreateSixNumbersList()
        {
            int kinoNumber = 0;
            int count = 1;
            var NumbersPlayedL = new List<int>();
            
            bool anas = false;
            Random r = new Random();

            Console.WriteLine("Choose 6 Numbers from the list above from 1 to 80");
            while (count <= 6)
            {
                Console.Write($"Enter Next Number, No{count}: ");
                try { kinoNumber = int.Parse(Console.ReadLine()); } catch { Console.Write("You didn't enter a Number. Please try again! "); Console.WriteLine("Please enter a valid Number:"); }


                if (NumbersPlayedL.Contains(kinoNumber)) //check whether the number is already in List
                {
                    Console.Write($"You have given this number before. Please try again!");
                }
                else if (kinoNumber > 80 || kinoNumber < 1)
                {
                    Console.Write($"You have given a number out of range of 1-80. Please try again!");
                }
                else
                {
                    NumbersPlayedL.Add(kinoNumber); // Add User Input to Six Numers List
                    count++;
                }
            }
            while (!anas)
            {
                string ansBonus = "";
                if (count == 7)
                {
                    Console.Write($"Will you play a Bonus number? (Y/N): ");
                    try { ansBonus = Console.ReadLine(); } catch { Console.Write("You didn't enter a Y or N. Please try again! "); Console.WriteLine("Will you play a Bonus number? (Y/N): "); }
                    if (ansBonus.ToUpper() == "Y")
                    {
                        bonusNumber = kinoNumber;
                        Bonus = anas = true;
                        Console.WriteLine($"Your Bonus Number is: {bonusNumber}");
                    }
                }
            }
            PrintSixNumbersList(NumbersPlayedL);
        }//end CreateSixNumbersList


        public void PrintSixNumbersList(List<int> nList)
        {
            Console.WriteLine();
            Console.WriteLine("Player has chosen the following Numbers:");
            foreach (int n in nList)
            {
                Console.Write($"   {n},");
            }
            Console.WriteLine("Player has chosen the following Numbers:");

            Console.WriteLine();
            Console.WriteLine($"KINO BONUS:   {bonusNumber}");
        }


        //public void PrintSixNumbersList(List<Ticket> tList)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Player has chosen the following Numbers:");
        //    foreach (Ticket t in tList)
        //    {
        //        Console.Write($"   {t.NumbersPlayedL},");
        //    }
        //    Console.WriteLine("Player has chosen the following Numbers:");

        //    //    Console.WriteLine();
        //    //    Console.WriteLine($"KINO BONUS:   {bonusNumber}");
        //}








        private int UniqueID() //another way of implementing an auto ID containing numbers 
                                 //but numbers from 0-9 
        {

            char[] charLettersArray = "0123456789".ToCharArray();
            Random random = new Random();
            string finalString = "";

            for (int i = 0; i < 5; i++)  // max = 99999
            {
                finalString += charLettersArray[random.Next(charLettersArray.Length)];
            }
            int finalID = int.Parse(finalString);
            // ΑΝ ΥΠΑΡΧΕΙ ΤΟ Id  ξανατρέξε την ίδια μέθοδο, αλλιώς πρόσθεσέ το στην λίστα με τα IDs και επέστρεψε το UNIQUE ID
            if (!TicketL.Contains(finalID))
            {
                TicketL.Add(finalID);
            }
            else
            {
                UniqueID();
            }

            Console.WriteLine("Ticket ID:  {0}", finalString);
            return finalID;
        }


    }
}
