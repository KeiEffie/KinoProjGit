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
        public int noTickets;
        public List<Ticket> TicketsPlayList;


        public Player(int id, List<Ticket> ticketsPlayList)
        {
            ID = id;
            TicketsPlayList = ticketsPlayList;
            noTickets = TicketsPlayList.Count;
        }

        public override string ToString()
        {
            return "Player ID:" + ID + " " +  "TicketsPlayed" + noTickets + " Numbers on Ticket: " + String.Join(", ", TicketsPlayList.Select(i => i.ToString()));
        }


    }//end class
}// end namespace
