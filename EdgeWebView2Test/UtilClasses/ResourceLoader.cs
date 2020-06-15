using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdgeWebView2Test.UtilClasses
{
  public static class ResourceLoader
  {
    public static string GetJsResource(string fileName)
    {
      string result = "";

      var assembly = Assembly.GetExecutingAssembly();
      List<string> resourceNames = assembly.GetManifestResourceNames().ToList();

      if (!resourceNames.Any(l => l.Contains(fileName)))
      {
        throw new System.Exception($"Javascript Resource {fileName} is missing from browser assembly");
      }

      string fullResourceName = resourceNames.Where(l => l.Contains(fileName)).First();

      using (Stream stream = assembly.GetManifestResourceStream(fullResourceName))
      using (StreamReader reader = new StreamReader(stream))
      {
        result = reader.ReadToEnd();
      }

      return result;
    }

  }
}
