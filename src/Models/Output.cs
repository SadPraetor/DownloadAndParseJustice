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
		public int BusinessID { get; set; }
		public string AddressStreet { get; set; }
		public string AddressStreetNr { get; set; }
		public string AddressHouseNr { get; set; }
		public string AddressZIP { get; set; }
		public string LegalForm { get; set; }
	}
}
