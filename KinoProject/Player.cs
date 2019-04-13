using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Player
    {
        public int ID;
        private string name;
        public string Name { get; set; }
        public int noTickets; 

        public Player(int id, int noTickets)
        {
            ID = id;
            Name = name;
            noTickets = 1;
        }

        public override string ToString()
        {
            return "Player ID:" + ID + " " + Name + "TicketsPlayed" + noTickets;
        }


    }//end class
}// end namespace
