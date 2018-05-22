using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
     public class MenuItem
     {
          protected readonly string r_Name;
          protected readonly bool r_IsQuitItem;

          public string Name
          {
               get { return r_Name; }
          }

          public bool IsQuit
          {
               get { return r_IsQuitItem; }
          }

          public MenuItem(string i_ItemName)
          {
               r_Name = i_ItemName;
               r_IsQuitItem = false;
          }

          public MenuItem(string i_ItemName, bool i_IsQuit)
          {
               r_Name = i_ItemName;
               r_IsQuitItem = i_IsQuit;
          }
     }
}
