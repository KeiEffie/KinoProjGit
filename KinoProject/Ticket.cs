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

        public override string ToString()
        {
            return "Player ID:" + ID + " " + Player + " " + PrintNums;
        }

       



    }
}
