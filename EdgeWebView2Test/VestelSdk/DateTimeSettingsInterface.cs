using EdgeWebView2Test.UtilClasses;
using Microsoft.Web.WebView2.Core;
using System;
using System.Runtime.InteropServices;

namespace EdgeWebView2Test.VestelSdk
{
  [ClassInterface(ClassInterfaceType.AutoDual)]
  [ComVisible(true)]
  public class DateTimeSettingsInterface
  {
    private string timeZoneMode = "AUTO"; // could also be "MANUAL"

    public DateTimeSettingsInterface(CoreWebView2 webView)
    {
      string JScode = ResourceLoader.GetJsResource("DateTimeSettingsInterface.js");
      webView.AddScriptToExecuteOnDocumentCreatedAsync(JScode);
    }

    public int GetLocalCTime()
    {
      Int32 unixTimestamp = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
      return unixTimestamp;
    }

    public int GetTimeZoneCount()
    {
      int count = TimeZoneInfo.GetSystemTimeZones().Count;
      return count;
    }

    public string GetTimeZoneMode()
    {
      return timeZoneMode;
    }

    public int GetTimeZoneOffset()
    {
      TimeSpan offset = TimeZoneInfo.Local.GetUtcOffset(DateTime.Now);
      return (int)Math.Round(offset.TotalSeconds);
    }

    public int GetUTCCTime()
    {
      Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
      return unixTimestamp;
    }

    public bool isBroadcastTimeKnown()
    {
      return true;
    }

    public bool setCurrentDateTime(int unixTimeStamp)
    {
      // true = ok, false = failed
      // Dummy return as where not allowing this to happen
      return true;
    }

    public bool setTimeZoneMode(string mode)
    {
      // TODO: this really needs to be error checked, only "AUTO" and "MANUAL" are allowed
      timeZoneMode = mode;
      return true;
    }

    public bool setTimeZoneOffset(int offsetInSeconds)
    {
      // true = ok, false = failed
      // Dummy return as where not allowing this to happen
      return true;
    }

  }
}
