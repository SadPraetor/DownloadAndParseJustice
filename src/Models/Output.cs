using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadAndParseJustice.Models
{
	public class Output
	{
		public string Name { get; set; }
		public uint BusinessID { get; set; }
		public string AddressStreet { get; set; }
		public ushort? AddressStreetNr { get; set; }
		public string AddressHouseNr { get; set; }
		public ushort? AddressZIP { get; set; }
		public string LegalForm { get; set; }
	}
}
