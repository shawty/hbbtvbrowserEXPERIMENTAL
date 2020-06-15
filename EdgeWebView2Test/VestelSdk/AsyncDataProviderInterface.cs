using EdgeWebView2Test.DataObjects;
using EdgeWebView2Test.UtilClasses;
using EdgeWebView2Test.WebMessages;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EdgeWebView2Test.VestelSdk
{
  [ClassInterface(ClassInterfaceType.AutoDual)]
  [ComVisible(true)]
  public class AsyncDataProviderInterface
  {
    private CoreWebView2 _webView;
    private bool _eventActive = false;

    private List<VestelSdkChannelDefinition> channelData = new List<VestelSdkChannelDefinition>();

    // Temp var until i figure out why null objects in array on returning list above
    //private readonly string channelJson = "";

    public string GetChannelData => channelData.ToJsonString();

    public AsyncDataProviderInterface(CoreWebView2 webView)
    {
      _webView = webView;

      string channelJson = File.ReadAllText("ExternalData\\channelList.json");
      //this.channelJson = channelJson; // To remove once null object situation is resolved.
      channelData = JsonConvert.DeserializeObject<List<VestelSdkChannelDefinition>>(channelJson);

      string JScode = ResourceLoader.GetJsResource("AsyncDataProviderInterface.js");
      _webView.AddScriptToExecuteOnDocumentCreatedAsync(JScode);
    }

    public void AddEventListener(string eventName)
    {
      if(eventName == "channelListReady")
      {
        _eventActive = true;
      }
    }

    public bool getChannelList(bool minifiedVersion = false)
    {
      if(_eventActive)
      {
        WebMessageChannelListReadyEvent jsevent = new WebMessageChannelListReadyEvent()
        {
          Status = 0,
          ChannelData = channelData
        };
        PostMessageSender.SendWebMessage(jsevent, _webView);
      }
      return true;
    }

    public void removeEventListener(string eventName)
    {
      if(eventName == "channelListReady")
      {
        _eventActive = false;
      }
    }

  }
}
