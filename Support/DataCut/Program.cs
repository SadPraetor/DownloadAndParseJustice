// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Starting");

var rootPath = Path.GetFullPath(@".\..\..\..\..\..\Download\");
//var fileName = "nadf-actual-usti_nad_labem-2022.xml";
var fileName = "sro-actual-praha-2022.xml";
var filePath = Path.Combine( rootPath,fileName);
Console.WriteLine(File.Exists(filePath));


const Int32 BufferSize = 128;
using (var fileStream = File.OpenRead(filePath))
using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
{
    int i = 1;
    String line;
    while ((line = streamReader.ReadLine()) != null)
    {
		if (i is 230826 or 230827 or 230829)
		{
		    Console.WriteLine(line);            
		}
		if (i == 230829) break;

        i++;
    }
}

Console.WriteLine("Done");
