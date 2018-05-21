using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
     internal class DelegatesMenu
     {
          private MainMenu m_MainMenu = new MainMenu();

          internal void Run()
          {
               Menu versionAndCapitalsMenu = new Menu("Version and Capitals", m_MainMenu.Menu.Level + 1);
               Menu showDateAndTime = new Menu("Show date/time", m_MainMenu.Menu.Level + 1);
               MenuItem showDate = new MenuItem("Show Date");
               MenuItem showTime = new MenuItem("Show Time");
               MenuItem showVersion = new MenuItem("Show Version");
               MenuItem countCapitals = new MenuItem("Count Capitals");

               versionAndCapitalsMenu.OnActiveDelegate += VersionAndCapitalsMenu_OnActiveDelegate;
               showDateAndTime.OnActiveDelegate += ShowDateAndTime_OnActiveDelegate;
               showDate.OnActiveDelegate += ShowDate_OnActiveDelegate;
               showTime.OnActiveDelegate += ShowTime_OnActiveDelegate;
               showVersion.OnActiveDelegate += ShowVersion_OnActiveDelegate;
               countCapitals.OnActiveDelegate += CountCapitals_OnActiveDelegate;
          }

          private void VersionAndCapitalsMenu_OnActiveDelegate()
          {
               
          }

          private void ShowDateAndTime_OnActiveDelegate()
          {

          }

          private void ShowDate_OnActiveDelegate()
          {
               
          }

          private void ShowTime_OnActiveDelegate()
          {
               
          }

          private void ShowVersion_OnActiveDelegate()
          {

          }

          private void CountCapitals_OnActiveDelegate()
          {

          }
     }
}
