using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EdgeWebView2Test.UtilClasses
{
  public static class ObjectExtensions
  {
    public static string ToJsonString(this object sourceObject)
    {
      return JsonConvert.SerializeObject(sourceObject, new JsonSerializerSettings
      {
        ContractResolver = new DefaultContractResolver()
        {
          NamingStrategy = new CamelCaseNamingStrategy()
        }
      });
    }

  }
}
