using EdgeWebView2Test.UtilClasses;
using Microsoft.Web.WebView2.Core;
using System;
using System.Runtime.InteropServices;

namespace EdgeWebView2Test.VestelSdk
{
  [ClassInterface(ClassInterfaceType.AutoDual)]
  [ComVisible(true)]
  public class ActivityMonitorInterface
  {
    private DateTime lastKeyPressTime = DateTime.Now;

    public ActivityMonitorInterface(CoreWebView2 webView)
    {
      string JScode = ResourceLoader.GetJsResource("ActivityMonitorInterface.js");
      webView.AddScriptToExecuteOnDocumentCreatedAsync(JScode);
    }

    public void RegisterKeyPress()
    {
      lastKeyPressTime = DateTime.Now;
    }

    public int GetLastActivityTimestamp()
    {
      Int32 unixTimestamp = (Int32)(lastKeyPressTime.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
      return unixTimestamp;
    }

  }
}
