using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Ticket
    {
        enum WinCategory
        {
            SixPlus = 1,
            Six = 2,
            FivePlus = 4,
            Five = 8,
            FourPlus = 16,
            Four = 32,
            ThreePlus = 64,
            Three = 128,
            TwoPlus = 256,
            Two = 512,
            OnePlus = 1024,
            One = 2048,
            Zero = 4096
            
        }
        ////get value
        //int day = (int)Days.TuesDay;
        ////cast to enum
        //Days day = (Days)3;
        ////Converts int to enum values

        ////Method 2:
        //Days day = (Days)Enum.ToObject(typeof(Days), 3);

        public static List<int> TicketL = new List<int>();           // ***************** STATIC PROPERTY ****************

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


        public bool Bonus;
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
            Draw = new Draw();
            NumbersPlayedL = new List<int>();
            DrawTimes = drawTimes;
            Bonus = false;
            WinsCategory = WinsCategory;
        }
                    
        

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
