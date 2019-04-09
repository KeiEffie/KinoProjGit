using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Ticket
    {
        //public int DrawTimes;
        public Player Player;
        public List<int> NumbersPlayedL;
        public bool Bonus;
        public int WinsCategory;
        

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
        public Ticket()
        {

        }

        public Ticket(Player player, List<int> numbersPlayedL)
        {
            ID = id;
            Player = player;
            NumbersPlayedL = numbersPlayedL;

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
            // ΑΝ ΥΠΑΡΧΕΙ ΤΟ Id του Ticket ξανατρέξε την ίδια μέθοδο, αλλιώς πρόσθεσέ το στην λίστα με τα IDs και επέστρεψε το UNIQUE ID
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



    }
}
