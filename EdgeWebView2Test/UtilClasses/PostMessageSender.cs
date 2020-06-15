using EdgeWebView2Test.WebMessages;
using Microsoft.Web.WebView2.Core;

namespace EdgeWebView2Test.UtilClasses
{
  public static class PostMessageSender
  {
    public static void SendWebMessage(WebMessageBase messageObject, CoreWebView2 webView)
    {
      webView.PostWebMessageAsJson(messageObject.ToJsonString());
    }

  }
}
