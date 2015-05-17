using System;
using System.Collections.Generic;
using System.Text;
using  Windows.UI.Popups;
namespace FirstProgram
{
  public  class StaticMethod
    {
      public static void ShowMsg(string name)
      {
          string text = "Hello " + name;
#if WINDOWS_APP
          text += " (Windows)";
#else
          text += " (Windows Phone)";
#endif
          var msgbox = new MessageDialog(text, "My first program");
           msgbox.ShowAsync();
      }
    }
}
