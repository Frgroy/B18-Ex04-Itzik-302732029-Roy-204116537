using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
     public class ShowDate : MenuItem, IExecutable
     {
          public ShowDate(string i_ItemName) : base(i_ItemName)
          {
          }
     
          public void Execute()
          {
               Methods methods = new Methods();
               methods.ShowDate();
          }
     }
}
