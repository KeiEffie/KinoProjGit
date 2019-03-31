using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Ticket
    {
        public int DrawTimes;
        public Player Player;
        public List<int> NumbersPlayedL;
        public bool Bonus;
        public int WinsCategory;
        public Draw Draw;


        //προσωρινά μόνο
        public Ticket()
        {

        }

        public Ticket(int id)
        {
            ID = id;
            Players = new List<Player>();
            NumbersToPlay = new List<int>();

        }




    }
}
