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
        public List<Ticket> TicketsPlayList;


        public Player(int id, List<Ticket> ticketsPlayList)
        {
            ID = id;
            Name = name;
            TicketsPlayList = ticketsPlayList;
            noTickets = TicketsPlayList.Count;
        }

        public override string ToString()
        {
            return "Player ID:" + ID + " " + Name + "TicketsPlayed" + noTickets;
        }


    }//end class
}// end namespace
