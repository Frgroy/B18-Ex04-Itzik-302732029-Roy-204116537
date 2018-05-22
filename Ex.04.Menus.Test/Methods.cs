using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
     public class Methods
     {
          public void ShowDate()
          {
               Console.WriteLine(DateTime.Now.ToShortDateString());
          }

          public void ShowTime()
          {
               Console.WriteLine(DateTime.Now.ToShortTimeString());
          }

          public void ShowVersion()
          {
               Console.WriteLine("Version: 18.2.4.0");
          }

          public void CountCapitals()
          {
               string userSentence;
               int capitalsCounter = 0;

               Console.WriteLine("Please enter a sentence: ");
               userSentence = Console.ReadLine();

               while (userSentence == string.Empty)
               {
                    Console.WriteLine("Illegal input. Try again.");
                    userSentence = Console.ReadLine();
               }

               foreach (char letter in userSentence)
               {
                    if (letter >= 'A' && letter <= 'Z')
                    {
                         capitalsCounter++;
                    }
               }

               Console.WriteLine(string.Format(
                    "The sentence: \"{0}\" contains {1} capital letters.",
                    userSentence,
                    capitalsCounter));
          }
     }
}
