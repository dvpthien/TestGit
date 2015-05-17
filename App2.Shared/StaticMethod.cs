using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Popups;

namespace App2
{
  public  class StaticMethod
    {
      public static void Click(string text)
      {
          var dialog = new MessageDialog(text);
          dialog.ShowAsync();
      }
    }
}
