using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EdgeWebView2Test.DataObjects
{
  public class VestelSdkChannelDefinition
  {
    public int ChannelType { get; set; } // spec
    public string Ccid { get; set; } // spec
    public int Onid { get; set; } // spec
    public int Nid { get; set; }
    public int Tsid { get; set; } // spec
    public int Sid { get; set; } // spec
    public string Name { get; set; } // spec
    public string Dsd { get; set; } // spec
    public int IdType { get; set; } // spec
    public bool Locked { get; set; } // spec
    public int Recordable { get; set; }
    public int MajorChannel { get; set; } // spec
    public int MinorChannel { get; set; } // spec

    public string tunerID { get; set; } // spec
    public int sourceID { get; set; } // spec
    public int freq { get; set; } // spec
    public int cni { get; set; } // spec
    public bool favourite { get; set; } // spec
    public List<string> favIDs { get; set; } // spec
    public bool manualBlock { get; set; } // spec
    public string ipBroadcastID { get; set; } // spec
    public int channelMaxBitRate { get; set; } // spec
    public int channelTTR { get; set; } // spec

  }
}
