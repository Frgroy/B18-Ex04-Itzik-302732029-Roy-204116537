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
               ActionItem showDate = new ActionItem("Show Date");
               ActionItem showTime = new ActionItem("Show Time");
               ActionItem showVersion = new ActionItem("Show Version");
               ActionItem countCapitals = new ActionItem("Count Capitals");

               m_MainMenu.Add(showDateAndTime);
               m_MainMenu.Add(versionAndCapitalsMenu);
               showDateAndTime.Add(showDate);
               showDateAndTime.Add(showTime);
               versionAndCapitalsMenu.Add(showVersion);
               versionAndCapitalsMenu.Add(countCapitals);
               showDate.ItemActivated += ShowDate_OnActiveDelegate;
               showTime.ItemActivated += ShowTime_OnActiveDelegate;
               showVersion.ItemActivated += ShowVersion_OnActiveDelegate;
               countCapitals.ItemActivated += CountCapitals_OnActiveDelegate;
               m_MainMenu.Show();
          }

          private void ShowDate_OnActiveDelegate()
          {
               Methods methods = new Methods();
               methods.ShowDate();

          }

          private void ShowTime_OnActiveDelegate()
          {
               Methods methods = new Methods();
               methods.ShowTime();
          }

          private void ShowVersion_OnActiveDelegate()
          {
               Methods methods = new Methods();
               methods.ShowVersion();
          }

          private void CountCapitals_OnActiveDelegate()
          {
               Methods methods = new Methods();
               methods.CountCapitals();
          }
     }
}
