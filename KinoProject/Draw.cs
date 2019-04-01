using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Draw
    {
        public static List<int> DrawIDsList = new List<int>();  //***************  STATIC PROPERTY **************

        public List<int> WinnerList;
        public int BonusNumber { get; set; }
        public double DrawAmount { get; set; }

        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = UniqueLRID();
            }
        }



        //προσωρινά μόνο
        public Draw()
        {

        }

        //den μπορεί να κάνει initialize με το bonus
        public Draw(double drawAmount)
        {
            ID = id;
            WinnerList = DrawNumbers();
            BonusNumber = GetBonus();
            DrawAmount = drawAmount;
        }
        private int UniqueLRID() //another way of implementing an auto ID containing numbers 
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
// ΑΝ ΥΠΑΡΧΕΙ ΤΟ Id της Κλήρωσης ξανατρέξε την ίδια μέθοδο, αλλιώς πρόσθεσέ το στην λίστα με τα IDs και επέστρεψε το UNIQUE ID
            if (!DrawIDsList.Contains(finalID))
            {
                DrawIDsList.Add(finalID);
            }
            else
            {
                UniqueLRID();
            }

            Console.WriteLine("Draw ID:  {0}", finalString);
            return finalID;
        }

        public List<int> DrawNumbers()          // ΚΛΗΡΩΣΕ 12 ΜΟΝΑΔΙΚΟΥΣ ΑΡΙΘΜΟΥΣ, ο 12ος είναι και KINO BONUS
        {
            WinnerList = new List<int>();
            Random numberToDraw = new Random();
            int counter = 1;
            BonusNumber = 0;

            int randomDraw = numberToDraw.Next(1, 80);

            while (counter <= 12)
            {
                if (!WinnerList.Contains(randomDraw))             //Αν δεν υπάρχει στην λίστα πρόσθεσέ το
                {
                    WinnerList.Add(randomDraw);
                }
                else
                {
                    counter--;          
                }
                randomDraw = numberToDraw.Next(1, 80);
                counter++;
            }
            return WinnerList;
        }

        public int GetBonus()
        {
            BonusNumber = WinnerList.Last();
            return BonusNumber;
        }


        public void PrintWinnerList()
        {
            Console.WriteLine($"The Amount of this Draw is {DrawAmount} ");
            Console.WriteLine($"The Winning Numbers of Draw {ID} are the following:");
            foreach (int i in WinnerList)                       //εκτύπωση της λίστας των 12 αριθμών
            {
                Console.Write($"   {i},");
            }
            Console.WriteLine();
            Console.WriteLine($"KINO BONUS:   {BonusNumber}");
        }

      
    }
}





