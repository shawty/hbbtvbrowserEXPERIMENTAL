using EdgeWebView2Test.DataObjects;
using System.Collections.Generic;

namespace EdgeWebView2Test.WebMessages
{
  public class WebMessageChannelListReadyEvent : WebMessageBase
  {
    public int Status { get; set; }
    public List<VestelSdkChannelDefinition> ChannelData { get; set; }

    public WebMessageChannelListReadyEvent()
    {
      MessageType = "event";
      EventName = "channelListReady";
    }

  }
}
