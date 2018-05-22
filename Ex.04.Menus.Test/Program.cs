using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
     public class Program
     {
          public static void Main()
          {
               InterfacesMenu interfacesMenu = new InterfacesMenu();
               DelegatesMenu delegatesMenu = new DelegatesMenu();
               interfacesMenu.Run();
               delegatesMenu.Run();
          }
     }
}