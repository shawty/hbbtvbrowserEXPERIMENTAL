namespace EdgeWebView2Test.WebMessages
{
  public class WebMessageKeyPress : WebMessageBase
  {
    public int keyCode { get; set; }

    public WebMessageKeyPress()
    {
      MessageType = "keypress";
    }

  }
}
