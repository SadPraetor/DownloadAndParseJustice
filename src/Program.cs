
using DownloadAndParseJustice.Models;
using System.IO.Compression;
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");

var client = new HttpClient();

client.BaseAddress = new Uri("https://dataor.justice.cz/api/");

//var name = "nadf-actual-usti_nad_labem-2022.xml.gz";
//var name = "zahrfos-actual-usti_nad_labem-2022.xml.gz";
var name = "sro-actual-praha-2022.xml.gz";
var response = await client.GetAsync($"file/{name}",HttpCompletionOption.ResponseHeadersRead);
response.EnsureSuccessStatusCode();

var dataStream = await response.Content.ReadAsStreamAsync();
var decompressor = new GZipStream(dataStream, CompressionMode.Decompress);

//var fileStream = File.Create($@"./../../../Download/{Path.GetFileNameWithoutExtension(name)}");
//await decompressor.CopyToAsync(fileStream);

var xmlSerializer = new XmlSerializer(typeof(xml));


var data = (xml)xmlSerializer.Deserialize( decompressor);

var outputs = data.Subjekt.Select(x => {
	var adresaUdaj = x.udaje.FirstOrDefault(udaj => udaj.udajTyp.kod == "SIDLO")?.adresa;
	return new Output()
	{
		Name = x.nazev,
		BusinessID = x.ico,
		AddressStreet = adresaUdaj?.ulice,
		AddressStreetNr = adresaUdaj?.cisloPo,
		AddressHouseNr = adresaUdaj?.cisloOr,
		AddressZIP = adresaUdaj?.psc,
		LegalForm = x.udaje.FirstOrDefault(udaj => udaj.udajTyp.kod == "PRAVNI_FORMA")?.pravniForma.nazev
	};
	});

//File.WriteAllBytes($@"./../../../Download/{Path.GetFileNameWithoutExtension(name)}.gz", await response.Content.ReadAsByteArrayAsync());

Console.WriteLine("done");
