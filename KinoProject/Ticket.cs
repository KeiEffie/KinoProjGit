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
        public int WinersCategory;


        private int id;
        public int ID { get; set; }

        //προσωρινά μόνο
        public Ticket()
        {

        }

        public Ticket(int id, bool bonus, List<int> numbersPlayedL, Player player)
        {
            ID = id;
            Player = player;
            NumbersPlayedL = numbersPlayedL;
            Bonus = bonus;

        }

        public List<int> GetNumbersPlayedL()
        {
            var kinoGame = new KinoGame();
            return NumbersPlayedL;
        }




    }
}
