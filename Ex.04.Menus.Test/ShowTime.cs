using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
     internal class ShowTime : MenuItem, IExecutable
     {
          public ShowTime(string i_ItemName) : base (i_ItemName)
          {
          }

          public void Execute()
          {
               showTime();
          }

          private void showTime()
          {
               Console.WriteLine(DateTime.Now.ToShortTimeString());
          }
     }
}
