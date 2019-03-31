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
        public List<Player> Players { get; set; }
        public List<int> NumbersToPlay { get; set; }
        public Player player { get; set; }

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
