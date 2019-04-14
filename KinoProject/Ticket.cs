using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
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
    class Ticket
    {
        
        public int ID { get; set; }
        public Player Player;
        public List<int> NumbersPlayedL;
        public bool Bonus;
        //public int DrawTimes;
        //public int WinersCategory;

        public KinoGame kino;
        //{
        //  get {return kino;}
        //  set {kino = value;}
        //}

        public Ticket(int id, bool bonus, int noKinos, Player player)
        {
            ID = id;
            Player = player;
            NumbersPlayedL = new KinoGame(noKinos).SetKINOList(noKinos);
            Bonus = kino.bonus;
        }


        public Ticket()
        {

        }


    }//end class and namespace
}
