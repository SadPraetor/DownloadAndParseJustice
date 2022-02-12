using DownloadAndParseJustice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCut
{
	public static class ReplaceLineHandler
	{
		public static void ReplaceLine()
		{
			int lineToReplace = 300821;
			lineToReplace--;
			string newText = "<ico>253</ico>";

			var fileName = "sro-actual-praha-2022.xml";
			var dataRetriever = new FileDataRetriever(@".\..\..\..\..\..\Download\");

			var destinationFilePath = @".\..\..\..\..\..\Download\new_sro-actual-praha-2022.xml";

			const Int32 bufferSize = 4096;
			using (StreamWriter streamWriter = new StreamWriter(File.Create(destinationFilePath)))
			using (var streamReader = new StreamReader(dataRetriever.GetDataStreamFromFile(fileName), Encoding.UTF8, true, bufferSize))
			{
				int i = 1;
				String line;
				while ((line = streamReader.ReadLine()) is not null)
				{
					if (i == lineToReplace)
					{
						streamWriter.WriteLine(newText);
						i++;
						continue;
					}
					streamWriter.WriteLine(line);
					if (i%100000 == 0)
					{
						Console.WriteLine("Line: " + i.ToString());
					}
					i++;
				}

				streamWriter.Flush();
			}
		}
	}
}
