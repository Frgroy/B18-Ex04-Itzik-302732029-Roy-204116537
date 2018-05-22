using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
     public class InterfacesMenu
     {
          private MainMenu m_MainMenu = new MainMenu();

          public void Run()
          {
               Menu versionAndCapitalsMenu = new Menu("Version and Capitals", m_MainMenu.Menu.Level + 1);
               Menu showDateAndTime = new Menu("Show date/time", m_MainMenu.Menu.Level + 1);
               ShowDate showDate = new ShowDate("Show Date");
               ShowTime showTime = new ShowTime("Show Time");
               ShowVersion showVersion = new ShowVersion("Show Version");
               CountCapitals countCapitals = new CountCapitals("Count Capitals");

               m_MainMenu.Add(showDateAndTime);
               m_MainMenu.Add(versionAndCapitalsMenu);
               showDateAndTime.Add(showDate);
               showDateAndTime.Add(showTime);
               versionAndCapitalsMenu.Add(showVersion);
               versionAndCapitalsMenu.Add(countCapitals);
               try
               {
                    m_MainMenu.Show();
               }
               catch (Exception ex)
               {
                    Console.WriteLine(ex.Message);
               }
          }
     }
}
