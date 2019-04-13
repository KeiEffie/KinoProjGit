using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Results
    {
//        public Draw Draw;
        public List<int> resultList;





        public static List<int> GetResults(Draw draw, Ticket ticket)
        {
            List<int> resultArray = new List<int>();
            Console.WriteLine($"For Ticket Number: {ticket.ID}");
            var resultList = ticket.NumbersPlayedL.Intersect(draw.WinnerList);
            return resultList;
        }


    }
}
