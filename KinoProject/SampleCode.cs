using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class SampleCode
    {

        //Δημιουργία ενός array με 6 νούμερα ----  άλλος ένας τρόπος
        public Array RandomSix()
        {
            int[] kinoNums = new int[6];
            Random randm = new Random();
            int num = 0;

            for (int i = 0; i < kinoNums.Length; i++)
            {
                num = randm.Next(1, 80);                        //generate random number
                                                                //check to see whether number has already been picked
                while (kinoNums.Contains(num) == true)		   //if it has try another random, until it hasnt been picked
                {
                    num = randm.Next(1, 80);
                }
                kinoNums[i] = num;			                    //hasnt been picked, so added to the array
            }
            return kinoNums;
        }
        // Δημιουργία μιας λίστας με 6 numbers
        public List<int> CreateRandomSixNumbersList()
        {
            Random random = new Random();
            List<int> newSixPlayerNumbers = new List<int>(6);
            int idNumber = (random.Next(1, 80));

            for (int j = 0; j < newSixPlayerNumbers.Capacity; j++)
            {
                if (!newSixPlayerNumbers.Contains(idNumber))
                {
                    newSixPlayerNumbers.Add(idNumber);
                }
                else
                {
                    j--;
                }
                idNumber = (random.Next(1, 80));
            }
            return newSixPlayerNumbers;
        }//end 

        private int UniqueLRID() //another way of implementing an auto ID containing numbers 
                                 //but numbers from 0-9 
        {

            char[] charLettersArray = "0123456789".ToCharArray();
            Random random = new Random();
            string finalString = "";

            for (int i = 0; i < 5; i++)  // max = 99999
            {
                finalString += charLettersArray[random.Next(charLettersArray.Length)];
            }
            int finalID = int.Parse(finalString);
            // ΑΝ ΥΠΑΡΧΕΙ ΤΟ Id του Ticket ξανατρέξε την ίδια μέθοδο, αλλιώς πρόσθεσέ το στην λίστα με τα IDs και επέστρεψε το UNIQUE ID
            if (!DrawL.Contains(finalID))
            {
                DrawL.Add(finalID);
            }
            else
            {
                UniqueLRID();
            }

            Console.WriteLine("Draw ID:  {0}", finalString);
            return finalID;
        }
    }
}
