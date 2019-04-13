using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Draw
    {

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
                id = value;
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
        public override string ToString()
        {

            return "Draw ID:" + ID + " BonusNumber: " + BonusNumber + " Draw Amount: " + DrawAmount + " Winning KINO Numbers are:" + string.Join(",", WinnerList.ToArray());
        }

        public string ListToString()
        {
            string DrawNumListChar = string.Join(", ", WinnerList.ToArray());

            return DrawNumListChar;
        }

        // ΚΛΗΡΩΣΕ 12 ΜΟΝΑΔΙΚΟΥΣ ΑΡΙΘΜΟΥΣ, ο 12ος είναι και KINO BONUS     
        public List<int> DrawNumbers()
        {
            List<int> DrawNumList = new List<int>();
            Random numberToDraw = new Random();

            int counter = 1;
            BonusNumber = 0;

            int randomDraw = numberToDraw.Next(1, 80);

            while (counter <= 12)
            {
                if (!DrawNumList.Contains(randomDraw))
  ///Αν δεν υπάρχει στην λίστα πρόσθεσέ το
              {
                    DrawNumList.Add(randomDraw);
                }
                else
                {
                    counter--;
                }
                randomDraw = numberToDraw.Next(1, 80);
                counter++;
            }
            return DrawNumList;
        }

        public int GetBonus()
        {
            // BonusNumber = WinnerList.Last();
            //return BonusNumber;
            // OR:
            return WinnerList.Last();
        }

        //εκτύπωση της λίστας των 12 αριθμών
        public void PrintDrawNumbersList()
        {
            Console.WriteLine($"The Amount of this Draw is {DrawAmount} ");
            Console.WriteLine($"The Winning Numbers of Draw {ID} are the following:");
            foreach (int i in WinnerList)
            {
                Console.Write($"   {i},");
            }
            Console.WriteLine();
            Console.WriteLine($"KINO BONUS:   {BonusNumber}");
        }


    }
}





