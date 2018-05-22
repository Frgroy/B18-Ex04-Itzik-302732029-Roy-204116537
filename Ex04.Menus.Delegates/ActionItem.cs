using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
     public delegate void ItemActivatedDelegate();

     public class ActionItem : MenuItem
     {
          public event ItemActivatedDelegate ItemActivated;

          public ActionItem(string i_ItemName)
              : base(i_ItemName)
          {
          }

          public void DoWhenOperated()
          {
               OnOperation();
          }

          protected virtual void OnOperation()
          {
               if (ItemActivated != null)
               {
                    ItemActivated.Invoke();
               }
               else
               {
                    throw new NullReferenceException();
               }
          }
     }
}
