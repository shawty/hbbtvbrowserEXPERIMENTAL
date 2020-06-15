namespace EdgeWebView2Test.WebMessages
{
  public class WebMessageGenericEvent : WebMessageBase
  {
    public object EventData { get; set; }

    public WebMessageGenericEvent(string eventName, object eventData)
    {
      MessageType = "genericEvent";
      EventName = eventName;
      EventData = eventData;
    }

  }
}
