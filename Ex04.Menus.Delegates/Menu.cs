using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
     public class Menu : MenuItem
     {
          private const string k_MainHeader = "Delegates Menu:";
          private const int k_FirstLevel = 1;
          private const string k_Seperator = "--------------------------------------------------------------------";
          private const string k_IllegalInputMessage = "Illegal input.";
          private const bool k_isQuitItem = true;
          private readonly int r_Level;
          private readonly Dictionary<int, MenuItem> r_MenuItems = new Dictionary<int, MenuItem>();

          public Dictionary<int, MenuItem> MenuItems
          {
               get { return r_MenuItems; }
          }

          public int Level
          {
               get { return r_Level; }
          }

          public Menu(string i_ItemName, int i_ItemLevel)
              : base(i_ItemName)
          {
               r_Level = i_ItemLevel;
               MenuItem quit = new MenuItem("Back", k_isQuitItem);
               Add(quit);
          }

          public Menu()
               : base(k_MainHeader)
          {
               r_Level = k_FirstLevel;
               MenuItem quit = new MenuItem("Exit", k_isQuitItem);
               Add(quit);
          }

          public void Add(MenuItem i_MenuItem)
          {
               r_MenuItems.Add(r_MenuItems.Count, i_MenuItem);
          }

          public void Show()
          {
               bool isMenuActive = true;

               while (isMenuActive)
               {
                    printHeader();
                    printMenu();
                    string userChoiceString = Console.ReadLine();
                    int userChoise;
                    Console.Clear();
                    if (int.TryParse(userChoiceString, out userChoise) && r_MenuItems.ContainsKey(userChoise))
                    {
                         handleKeyPressed(userChoise, ref isMenuActive);
                    }
                    else
                    {
                         Console.WriteLine(k_IllegalInputMessage);
                    }
               }
          }

          private void printHeader()
          {
               string headerMessage = string.Format(@"{0}. {1}", r_Level, Name);
               Console.WriteLine(headerMessage);
               Console.WriteLine(k_Seperator);
          }

          private void printMenu()
          {
               string choiceRequest = string.Format(@"Enter Selection or press {0}", r_MenuItems[0].Name);
               Console.WriteLine(choiceRequest);
               foreach (KeyValuePair<int, MenuItem> menuItem in r_MenuItems)
               {
                    Console.WriteLine(string.Format(@"[{0}] {1}", menuItem.Key, menuItem.Value.Name));
               }
          }

          private void handleKeyPressed(int userChoise, ref bool isMenuActive)
          {
               Menu menu = r_MenuItems[userChoise] as Menu;
               ActionItem action = r_MenuItems[userChoise] as ActionItem;

               if (menu != null)
               {
                    menu.Show();
               }
               else if (action != null)
               {
                    action.DoWhenOperated();
               }
               else if (r_MenuItems[userChoise].IsQuit)
               {
                    isMenuActive = false;
               }
               else
               {
                    throw new ArgumentNullException();
               }
          }
     }
}
