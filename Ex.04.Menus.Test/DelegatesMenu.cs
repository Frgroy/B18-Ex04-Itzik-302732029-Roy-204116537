using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
     public class DelegatesMenu
     {
          private MainMenu m_MainMenu = new MainMenu();

          public void Run()
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
               showDate.ItemActivated += ShowDate_Operate;
               showTime.ItemActivated += ShowTime_Operate;
               showVersion.ItemActivated += ShowVersion_Operate;
               countCapitals.ItemActivated += CountCapitals_Operate;
               m_MainMenu.Show();
          }

          private void ShowDate_Operate()
          {
               Methods methods = new Methods();
               methods.ShowDate();
          }

          private void ShowTime_Operate()
          {
               Methods methods = new Methods();
               methods.ShowTime();
          }

          private void ShowVersion_Operate()
          {
               Methods methods = new Methods();
               methods.ShowVersion();
          }

          private void CountCapitals_Operate()
          {
               Methods methods = new Methods();
               methods.CountCapitals();
          }
     }
}
