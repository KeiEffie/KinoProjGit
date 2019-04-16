using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{


    class Results
    {
        //readonly double[,] cR = new double[,] { { 0, 0 }, { 1, 0.002 }, { 2, 0.006 }, { 3, 0.01 }, { 4, 0.03 },{ 5, 0.07 },{6, 0.23}, {1.5,0.004 },{2.50, 0.008},{ 3.5, 0.02 },{4.5,0.05 },{5.5,0.15 },{6.5, 0.35 },{7,0.07 } };
        //Αν σε κάποια κατηγορία δεν υπάρχουν νικητές το ποσό της κατηγορίας θα μεταφέρεται και θα προστίθεται στην επόμενη κλήρωση.
        //                                                0,   1,    2,     3,    4,    5,    6,    1+,    2+,    3+,   4+,    5+,   6+, Φιλανθρωπικούς
        //                                                0,   0.2%, 0.6%,  1%,   3%,   7%,  23%,  0.4%,  0.8%,  2%,   5%,   15%,  35%,   7%
        //                                               [0], [1],  [2],   [3],  [4],  [5],  [6],  [7],   [8],   [9],  [10], [11], [12], [13]
        private double[] categoryRates = new double[14] { 0, 0.002, 0.006, 0.01, 0.03, 0.07, 0.23, 0.004, 0.008, 0.02, 0.05, 0.15, 0.35, 0.07 };
        public double[] CategoryRates { get => categoryRates; set => categoryRates = value; }

        public List<int> resultList;
        public int categoryWins;
        public double categoryRate;
        public int BonusNo = 0;


        public Results()
        {
            resultList = new List<int>();
            categoryWins = 0;
            categoryRate = 0;
        }

        public List<int> GetResultList(List<int> drawNoList, Ticket ticket)
        {
            List<int> resultList = ticket.NumbersPlayedL.Intersect(drawNoList).ToList();

            if (ticket.NumBonus)
            {
                if (drawNoList.Last() == ticket.NumbersPlayedL.Last())
                    BonusNo = ticket.NumbersPlayedL.Last();
            }
            resultList.Sort();
            if (resultList.Contains(BonusNo))
            {
                resultList.Remove(BonusNo);
                resultList.Add(BonusNo);
            }
            return resultList;
        }

        public int GetCategoryNo(List<int> resultList)
        {
            categoryWins = resultList.Count;
            return categoryWins;
        }

        public double GetCategoryRate(int categoryWins)
        {
            categoryRate = categoryRates[categoryWins];
            return categoryRate;
        }

      

    }
}
