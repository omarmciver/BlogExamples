// This is an auto-generated file.
using System.IO;
using System.Reflection;

public static class EmbeddedResourceStream
{
	public static string LoremIpsum => ReadResource(Assembly.GetExecutingAssembly().GetName().Name + ".SomeFolder.SomeSubfolder.LoremIpsum.txt");

	private static string ReadResource(string resourceName){
		using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
		  using (StreamReader reader = new StreamReader(stream))
		  {
			  string result = reader.ReadToEnd();
			  return result;
		  }
	}
}
