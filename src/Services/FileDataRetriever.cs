using DownloadAndParseJustice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadAndParseJustice.Services
{
	public class FileDataRetriever : IDataRetrieverService
	{
		public string BaseDirectory { get; set; }
		public FileDataRetriever(string baseDirectory)
		{
			BaseDirectory = baseDirectory;
		}

		public Stream GetDataStreamFromFile (string fileName)
		{
			var filePath = Path.Combine(BaseDirectory, fileName);
			if (!File.Exists(filePath)) throw new FileNotFoundException(filePath);
			
			return File.OpenRead(filePath);
		}

	}
}
