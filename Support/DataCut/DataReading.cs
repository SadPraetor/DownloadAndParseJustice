using System;
using System.Text;
using DownloadAndParseJustice.Services;

public static class DataReading
{
	public static void ReadAndPrintData()
	{
		int lineWithProblem = 7995209;
		int displaySize = 50;
		bool markLine = true;

		var fileName = "new_sro-actual-praha-2022.xml";

		var dataRetriever = new FileDataRetriever(@".\..\..\..\..\..\Download\");

		ReadAndPrintData(dataRetriever.GetDataStreamFromFile(fileName),
			lineWithProblem, displaySize, markLine);
	}

	private static void ReadAndPrintData(Stream stream, int lineWithProblem, int rangeToPrint, bool markLine = true)
	{


		const Int32 bufferSize = 4096;
		using (var streamReader = new StreamReader(stream, Encoding.UTF8, true, bufferSize))
		{
			var mapping = new Mapping(lineWithProblem, rangeToPrint);

			int i = 1;
			String line;
			while ((line = streamReader.ReadLine()) is not null)
			{
				if (i >= mapping.Bottom && i <= mapping.Top)
				{
					if (markLine && i == mapping.AdjustedPointOfproblem)
					{
						line = AdjustLineWithmarking(line);
					}
					Console.WriteLine(line);
				}
				if (i > mapping.Top) break;

				i++;
			}
		}
	}

	private static string AdjustLineWithmarking(string line)
	{
		if (line.Substring(0, 2) == "  ")
		{
			return line = "=>" + line.Substring(2);
		}

		return line = "=> " + line;
	} 

	private class Mapping
	{

		private int _bottom;
		public int Bottom {
			get => _bottom;
			set 
			{
				if (value < 0) 
					throw new ArgumentOutOfRangeException("Bottom must be greater then 0");
				_bottom = value;				
			}
		}

		public int Top { get; set; }

		public int AdjustedPointOfproblem { get; set; }

		public Mapping(int lineWithProblem, int rangeToPrint)
		{
			AdjustedPointOfproblem = --lineWithProblem;
			var bottom = lineWithProblem - rangeToPrint;
			if (bottom < 0)
			{
				bottom = 0;
			}
			Bottom = bottom;
			Top = AdjustedPointOfproblem + rangeToPrint;
		}
	}
}
