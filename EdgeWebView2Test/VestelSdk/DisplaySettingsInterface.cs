using EdgeWebView2Test.UtilClasses;
using Microsoft.Web.WebView2.Core;
using System.Runtime.InteropServices;

namespace EdgeWebView2Test.VestelSdk
{
  [ClassInterface(ClassInterfaceType.AutoDual)]
  [ComVisible(true)]
  public class DisplaySettingsInterface
  {
    public DisplaySettingsInterface(CoreWebView2 webView)
    {
      string JScode = ResourceLoader.GetJsResource("DisplaySettingsInterface.js");
      webView.AddScriptToExecuteOnDocumentCreatedAsync(JScode);
    }

    public int GetPanelHeight()
    {
      // Physical hardware height of the TV set's LCD Panel (32" Toshiba)
      return 768;
    }

    public int GetPanelWidth()
    {
      // Physical hardware width of the TV set's LCD Panel (32" Toshiba)
      return 1366;
    }

    public bool is3DModeActive()
    {
      // Test TV does not do 3D, we'll make this a configurable value at some point
      return false;
    }

  }
}
