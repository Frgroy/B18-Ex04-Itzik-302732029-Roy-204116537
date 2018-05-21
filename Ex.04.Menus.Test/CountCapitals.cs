using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;
using System.Text.RegularExpressions;

namespace Ex04.Menus.Test
{
     internal class CountCapitals : MenuItem, IExecutable
     {
          public CountCapitals(string i_ItemName) : base (i_ItemName)
          {
          }

          public void Execute()
          {
               countCapitals();
          }

          private void countCapitals()
          {
               String userSentence;
               int capitalsCounter = 0;

               Console.WriteLine("Please enter a sentence: ");
               userSentence = Console.ReadLine();
               
               foreach (char letter in userSentence)
               {
                    if (letter >= 'A'  && letter <= 'Z')
                    {
                         capitalsCounter++;
                    }
               }

               Console.WriteLine(String.Format(
                    "The sentence: \"{0}\" contains {1} capital letters.", 
                    userSentence, 
                    capitalsCounter));
          }
     }
}