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
      

        public Ticket(int id)
        {
            ID = id;
            NumbersPlayedL = new KinoGame().SetKinoList();
            bonus = GetBonus(); 
        }

        public override string ToString()
        {
            return "Ticket ID: " + ID + " Numbers on Ticket: " + String.Join(", ", NumbersPlayedL.Select(i => i.ToString())) + (bonus ? $"with Kino Bonus: {NumbersPlayedL.Last()}" : "");
        }

        // Get Bonus
        public bool GetBonus()
        {
            Console.Write($"Will you play a Bonus number? (Y/N): ");
            string ansBonus = Console.ReadLine();
                    if (ansBonus.ToUpper() == "Y")
                    {
                        bonus = true;
                    }
                    else if (ansBonus.ToUpper() == "N")
                    {
                        bonus = false;
                    }
                    else
                    {
                    Console.Write("You didn't enter a Y or N. Please try again! "); Console.WriteLine("Will you play a Bonus number? (Y/N): ");
                    }
            return bonus;
        }//end GetBonus


    }//end class and namespace
}
