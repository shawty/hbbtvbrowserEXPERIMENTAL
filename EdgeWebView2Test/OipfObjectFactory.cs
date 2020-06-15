using EdgeWebView2Test.UtilClasses;
using Microsoft.Web.WebView2.Core;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EdgeWebView2Test
{
  [ClassInterface(ClassInterfaceType.AutoDual)]
  [ComVisible(true)]
  public class OipfObjectFactory
  {
    private List<string> allowedMimeTypes = new List<string>()
    {
      "application/oipfApplicationManager",
      "application/oipfCapabilities",
      "application/oipfConfiguration",
      "application/oipfDrmAgent",
      "application/oipfParentalControlManager",
      "application/oipfSearchManager",
      "video/broadcast",
      "video/mpeg",
      "video/mp4"
    };

    public OipfObjectFactory(CoreWebView2 webView)
    {
      string JScode = ResourceLoader.GetJsResource("OipfObjectFactory.js");
      webView.AddScriptToExecuteOnDocumentCreatedAsync(JScode);
    }

    public bool IsObjectSupported(string mimeType)
    {
      // Supported on tosh...
      // Application Manager
      // Capabilities
      // Configuration
      // DRM Agent
      // Parental Control Manager
      // Search Manager
      // Broadcast Video

      return allowedMimeTypes.Contains(mimeType);
    }

  }
}
