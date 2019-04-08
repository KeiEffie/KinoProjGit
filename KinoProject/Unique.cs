using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoProject
{
   public static class Unique
    {
        public static List<int> DrawIDsList = new List<int>();
        public static List<int> TicketIDsList = new List<int>();



        public static int UniqueLRID() //another way of implementing an auto ID containing numbers 
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
            Console.WriteLine("Draw ID:  {0}", finalString);
            return finalID;
        }

        //public static int CheckUNQ(int finalID)
        //{
        //    // ΑΝ ΥΠΑΡΧΕΙ ΤΟ Id της Κλήρωσης ξανατρέξε την ίδια μέθοδο, αλλιώς πρόσθεσέ το στην λίστα με τα IDs και επέστρεψε το UNIQUE ID
        //    if (!DrawIDsList.Contains(finalID))
        //    {
        //        DrawIDsList.Add(finalID);              //o elegxos tha prepei na elegxei prota to eidos tis listas kai meta na kanei auta to fi
        //    }
        //    else
        //    {
        //        UniqueLRID();
        //    }

        //    return finalID;
    }


}