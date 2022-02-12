using System;
using DownloadAndParseJustice.Services

public static class DataReading
{
	public static ReadAndPrintData ()
	{
		int lineWithProblem = 0;
		int displaySize = 0;
		bool markLine = true;

		var fileName = "sro-actual-praha-2022.xml";

		var dataRetriever = new FileDataRetriever(@".\..\..\..\..\..\Download\");





	}
	
	private static ReadAndPrintData (Stream stream, int lineWithProblem, int displaySize, bool markLine = true)
	{
		using (var streamReader = new StreamReader (stream, Encoding.UTF8, true, bufferSize)))
	}
}
