using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
   
    class Ticket
    {
        
        public int ID { get; set; }
        public List<int> NumbersPlayedL;
        public bool bonus;
        public Player Player;
        public KinoGame kino;
      

        public Ticket(int id, Player player)
        {
            ID = id;
            Player = player;
            NumbersPlayedL = new KinoGame().SetKinoList();
            bonus = GetBonus(); 
        }


        public Ticket()
        {

        }

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
                    //bonusNumber = kinoNumber;  // actually is the last number of n-length list
                    bonus = anas = true;
                }
            }
            return bonus;
        }//end GetBonus
    }//end class and namespace
}
