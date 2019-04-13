using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class Results
    {
        //public Draw Draw;
        public List<int> resultList;
        public static int[] categoryWins;


       public Results()
        {
            resultList = new List<int>();
            categoryWins = new int[12];
        }


        
        public static List<int> GetResultList(List<int> drawNoList, List<int> ticketNoList)
        {
            List<int> resultList = ticketNoList.Intersect(drawNoList).ToList(); ;
            return resultList;
        }

        public static int[] GetCategory(List<int> resultList)
        {
            int total = resultList.Count;
            switch (total)
            {
                case 1:

                    break;
                default:
                    break;
            }

            return categoryWins;
        }
    }   
}
