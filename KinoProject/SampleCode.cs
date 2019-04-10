using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
    class SampleCode
    {
        public void SwitchMenu()
        {
            switch (choice)
            {
                case 1:
                    CreateNumbersTable();
                    lottery.
                    player.CreateSixNumbersList();
                    break;
                case 2:
                    var newDict = player.CreateRandomPlayersDict();
                    player.PrintRandomPlayersWithNumbersDict(newDict);
                    break;
                case 3:
                    double drawAmount = 0;
                    bool test = false;
                    do
                    {
                        Console.WriteLine("Enter the Total Draw Amount to be shared: ");
                        try { drawAmount = double.Parse(Console.ReadLine()); }
                        catch
                        {
                            test = true;
                            Console.WriteLine("Enter a valid double for total Draw Amount");
                        }

                    } while (test);
                    Draw draw = new Draw(drawAmount);
                    draw.PrintWinnerList();
                    break;
                case 4:
                    lottery.Results();
                    lottery.CountMatches();
                    lottery.PrintMatches();
                    break;
                case 5:
                    break;
                case 6:
                    Console.WriteLine("You chose to Exit Program");
                    return;
                case 7:
                    break;
                default:
                    break;
            }//end switch
        }
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
            if (!DrawList.Contains(finalID))
            {
                DrawList.Add(finalID);
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
