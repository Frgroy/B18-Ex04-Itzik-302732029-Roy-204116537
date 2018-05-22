using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
     public class ShowTime : MenuItem, IExecutable
     {
          public ShowTime(string i_ItemName) : base(i_ItemName)
          {
          }

          public void Execute()
          {
               Methods methods = new Methods();
               methods.ShowTime();
          }
     }
}
