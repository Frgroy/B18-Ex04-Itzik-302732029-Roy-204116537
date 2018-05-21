using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
     public class MainMenu
     {
          private Menu m_Menu = new Menu();

          public Menu Menu
          {
               get { return m_Menu; }
          }

          public void Show()
          {
               m_Menu.Show();
          }

          public void Add(MenuItem i_MenuItem)
          {
               m_Menu.Add(i_MenuItem);
          }
     }
}
