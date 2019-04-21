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

        public int id;
        
      //den μπορεί να κάνει initialize με το bonus
        public Draw(int ids, double drawAmount)
        {
            id = ids;
            WinnerList = DrawNumbers();
            BonusNumber = GetBonus();
            DrawAmount = drawAmount;
        }
        public override string ToString()
        {
            return "Draw ID:" + id + " BonusNumber: " + BonusNumber + " Draw Amount: " + DrawAmount + " Winning KINO Numbers are:" + string.Join(",", WinnerList.ToArray());
        }

        //public  ListToString()   //δεν χρησιμοποιείται, είναι για αναφορά για το Join()
        //{ 
        //    string DrawNumListChar = string.Join(", ", WinnerList.ToArray());
        //}

        // ΚΛΗΡΩΣΕ 12 ΜΟΝΑΔΙΚΟΥΣ ΑΡΙΘΜΟΥΣ, ο 12ος είναι και KINO BONUS     
        public List<int> DrawNumbers()
        {
            List<int> WinnerList = new List<int>();
            Random numberToDraw = new Random();

            int counter = 1;
            BonusNumber = 0;

            int randomDraw = numberToDraw.Next(1, 80);

            while (counter <= 12)
            {
                if (!WinnerList.Contains(randomDraw))
  ///Αν δεν υπάρχει στην λίστα πρόσθεσέ το
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
            // OR:
            //return WinnerList.Last();
        }

        //εκτύπωση της λίστας των 12 αριθμών
        public void PrintDrawNumbersList()
        {
            Console.WriteLine($"The Amount of this Draw is {DrawAmount} ");
            Console.WriteLine($"The Winning Numbers of Draw with ID: {id} are the following:");
            string WinnerListToString = String.Join(", ", WinnerList.Select(i => i.ToString()));
            //foreach (int i in WinnerList)
            //{
            //    Console.Write($"   {i},");
            //}
            Console.WriteLine(WinnerListToString);
            Console.WriteLine($"KINO BONUS:   { GetBonus()}");
        }


    }
}





