// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Starting");

var rootPath = Path.GetFullPath(@".\..\..\..\..\..\Download\");
//var fileName = "nadf-actual-usti_nad_labem-2022.xml";
var fileName = "sro-actual-praha-2022.xml";
var filePath = Path.Combine( rootPath,fileName);
Console.WriteLine(File.Exists(filePath));

int pointOfProblem = 300821;
int range = 10;
var rangeToPrint = Enumerable.Range(pointOfProblem-range, range*2+1).ToArray();

const Int32 bufferSize = 4096;
using (var fileStream = File.OpenRead(filePath))
using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, bufferSize))
{
    int i = 1;
    String line;
    while ((line = streamReader.ReadLine()) is not null)
    {
		if (rangeToPrint.Contains(i))
		{
			if (i == pointOfProblem -1)
			{
				Console.Write("Point of problem");
			}
		    Console.WriteLine(line);            
		}
		if (i > rangeToPrint.Last()) break;

        i++;
    }
}

Console.WriteLine("Done");
