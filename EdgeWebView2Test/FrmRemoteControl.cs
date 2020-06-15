using System.Collections.Generic;
using System.Windows.Forms;

namespace EdgeWebView2Test
{
  public delegate void RemoteKeyPressedDelegate(int virtualKeyCode);

  public partial class FrmRemoteControl : Form
  {
    public event RemoteKeyPressedDelegate RemoteKeyPressed;

    Dictionary<string, int> keyCodeMap = new Dictionary<string, int>()
    {
      { "power", 409 },
      { "mute", 449 },
      { "one", 49 },
      { "two", 50 },
      { "three", 51 },
      { "four", 52 },
      { "five", 53 },
      { "six", 54 },
      { "seven", 55 },
      { "eight", 56 },
      { "nine", 57 },
      { "zero", 48 },
      { "lang", 662 },
      { "volup", 447 },
      { "voldn", 448 },
      { "menu", 462 },
      { "prgup", 427 },
      { "prgdn", 428 },
      { "info", 457 },
      { "up", 38 },
      { "left", 37 },
      { "ok", 13 },
      { "right", 39 },
      { "back", 461 },
      { "down", 40 },
      { "red", 403 },
      { "green", 404 },
      { "yellow", 405 },
      { "blue", 406 },
      { "rewind", 412 },
      { "pause", 19 },
      { "fastforward", 417 },
      { "play", 415 },
      { "stop", 413 }
    };

    public FrmRemoteControl()
    {
      InitializeComponent();
    }

    private void RemoteKeyClick(object sender, System.EventArgs e)
    {
      Button btn = sender as Button;
      if(btn == null)
      {
        return;
      }

      string keyTag = (string)btn.Tag;
      if(keyCodeMap.ContainsKey(keyTag))
      {
        RemoteKeyPressed?.Invoke(keyCodeMap[keyTag]);
      }
    }

  }
}
