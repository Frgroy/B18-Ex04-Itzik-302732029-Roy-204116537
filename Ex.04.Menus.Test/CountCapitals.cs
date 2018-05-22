using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
     public class CountCapitals : MenuItem, IExecutable
     {
          public CountCapitals(string i_ItemName) : base(i_ItemName)
          {
          }

          public void Execute()
          {
               Methods methods = new Methods();
               methods.CountCapitals();
          }
     }
}