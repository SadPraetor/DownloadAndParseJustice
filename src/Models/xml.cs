using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadAndParseJustice.Models
{

	// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class xml
	{

		private xmlSubjekt[] subjektField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Subjekt")]
		public xmlSubjekt[] Subjekt
		{
			get
			{
				return this.subjektField;
			}
			set
			{
				this.subjektField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjekt
	{

		private string nazevField;

		private int icoField;

		private System.DateTime zapisDatumField;

		private System.DateTime vymazDatumField;

		private bool vymazDatumFieldSpecified;

		private xmlSubjektUdaj[] udajeField;

		/// <remarks/>
		public string nazev
		{
			get
			{
				return this.nazevField;
			}
			set
			{
				this.nazevField = value;
			}
		}

		/// <remarks/>
		public int ico
		{
			get
			{
				return this.icoField;
			}
			set
			{
				this.icoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime zapisDatum
		{
			get
			{
				return this.zapisDatumField;
			}
			set
			{
				this.zapisDatumField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime vymazDatum
		{
			get
			{
				return this.vymazDatumField;
			}
			set
			{
				this.vymazDatumField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool vymazDatumSpecified
		{
			get
			{
				return this.vymazDatumFieldSpecified;
			}
			set
			{
				this.vymazDatumFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("Udaj", IsNullable = false)]
		public xmlSubjektUdaj[] udaje
		{
			get
			{
				return this.udajeField;
			}
			set
			{
				this.udajeField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdaj
	{

		private string hlavickaField;

		private System.DateTime zapisDatumField;

		private xmlSubjektUdajHodnotaUdaje hodnotaUdajeField;

		private string hodnotaTextField;

		private xmlSubjektUdajUdajTyp udajTypField;

		private xmlSubjektUdajPravniForma pravniFormaField;

		private xmlSubjektUdajAdresa adresaField;

		private xmlSubjektUdajSpisZn spisZnField;

		private xmlSubjektUdajUdaj[] podudajeField;

		/// <remarks/>
		public string hlavicka
		{
			get
			{
				return this.hlavickaField;
			}
			set
			{
				this.hlavickaField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime zapisDatum
		{
			get
			{
				return this.zapisDatumField;
			}
			set
			{
				this.zapisDatumField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajHodnotaUdaje hodnotaUdaje
		{
			get
			{
				return this.hodnotaUdajeField;
			}
			set
			{
				this.hodnotaUdajeField = value;
			}
		}

		/// <remarks/>
		public string hodnotaText
		{
			get
			{
				return this.hodnotaTextField;
			}
			set
			{
				this.hodnotaTextField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajTyp udajTyp
		{
			get
			{
				return this.udajTypField;
			}
			set
			{
				this.udajTypField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajPravniForma pravniForma
		{
			get
			{
				return this.pravniFormaField;
			}
			set
			{
				this.pravniFormaField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajAdresa adresa
		{
			get
			{
				return this.adresaField;
			}
			set
			{
				this.adresaField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajSpisZn spisZn
		{
			get
			{
				return this.spisZnField;
			}
			set
			{
				this.spisZnField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("Udaj", IsNullable = false)]
		public xmlSubjektUdajUdaj[] podudaje
		{
			get
			{
				return this.podudajeField;
			}
			set
			{
				this.podudajeField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajHodnotaUdaje
	{

		private xmlSubjektUdajHodnotaUdajeVklad vkladField;

		private xmlSubjektUdajHodnotaUdajeSplaceni splaceniField;

		/// <remarks/>
		public xmlSubjektUdajHodnotaUdajeVklad vklad
		{
			get
			{
				return this.vkladField;
			}
			set
			{
				this.vkladField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajHodnotaUdajeSplaceni splaceni
		{
			get
			{
				return this.splaceniField;
			}
			set
			{
				this.splaceniField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajHodnotaUdajeVklad
	{

		private string typField;

		private string textValueField;

		/// <remarks/>
		public string typ
		{
			get
			{
				return this.typField;
			}
			set
			{
				this.typField = value;
			}
		}

		/// <remarks/>
		public string textValue
		{
			get
			{
				return this.textValueField;
			}
			set
			{
				this.textValueField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajHodnotaUdajeSplaceni
	{

		private string typField;

		/// <remarks/>
		public string typ
		{
			get
			{
				return this.typField;
			}
			set
			{
				this.typField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajTyp
	{

		private string kodField;

		private string nazevField;

		/// <remarks/>
		public string kod
		{
			get
			{
				return this.kodField;
			}
			set
			{
				this.kodField = value;
			}
		}

		/// <remarks/>
		public string nazev
		{
			get
			{
				return this.nazevField;
			}
			set
			{
				this.nazevField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajPravniForma
	{

		private string kodField;

		private string nazevField;

		private string zkratkaField;

		/// <remarks/>
		public string kod
		{
			get
			{
				return this.kodField;
			}
			set
			{
				this.kodField = value;
			}
		}

		/// <remarks/>
		public string nazev
		{
			get
			{
				return this.nazevField;
			}
			set
			{
				this.nazevField = value;
			}
		}

		/// <remarks/>
		public string zkratka
		{
			get
			{
				return this.zkratkaField;
			}
			set
			{
				this.zkratkaField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajAdresa
	{

		private string statNazevField;

		private string adresaTextField;

		private string obecField;

		private string castObceField;

		private string uliceField;

		private string cisloTextField;

		private int cisloPoField;

		private bool cisloPoFieldSpecified;

		private string cisloOrField;

		private string pscField;

		private bool pscFieldSpecified;

		private object doplnujiciTextField;

		private string okresField;

		/// <remarks/>
		public string statNazev
		{
			get
			{
				return this.statNazevField;
			}
			set
			{
				this.statNazevField = value;
			}
		}

		/// <remarks/>
		public string adresaText
		{
			get
			{
				return this.adresaTextField;
			}
			set
			{
				this.adresaTextField = value;
			}
		}

		/// <remarks/>
		public string obec
		{
			get
			{
				return this.obecField;
			}
			set
			{
				this.obecField = value;
			}
		}

		/// <remarks/>
		public string castObce
		{
			get
			{
				return this.castObceField;
			}
			set
			{
				this.castObceField = value;
			}
		}

		/// <remarks/>
		public string ulice
		{
			get
			{
				return this.uliceField;
			}
			set
			{
				this.uliceField = value;
			}
		}

		/// <remarks/>
		public string cisloText
		{
			get
			{
				return this.cisloTextField;
			}
			set
			{
				this.cisloTextField = value;
			}
		}

		/// <remarks/>
		public int cisloPo
		{
			get
			{
				return this.cisloPoField;
			}
			set
			{
				this.cisloPoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool cisloPoSpecified
		{
			get
			{
				return this.cisloPoFieldSpecified;
			}
			set
			{
				this.cisloPoFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string cisloOr
		{
			get
			{
				return this.cisloOrField;
			}
			set
			{
				this.cisloOrField = value;
			}
		}

		/// <remarks/>
		public string psc
		{
			get
			{
				return this.pscField;
			}
			set
			{
				this.pscField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pscSpecified
		{
			get
			{
				return this.pscFieldSpecified;
			}
			set
			{
				this.pscFieldSpecified = value;
			}
		}

		/// <remarks/>
		public object doplnujiciText
		{
			get
			{
				return this.doplnujiciTextField;
			}
			set
			{
				this.doplnujiciTextField = value;
			}
		}

		/// <remarks/>
		public string okres
		{
			get
			{
				return this.okresField;
			}
			set
			{
				this.okresField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajSpisZn
	{

		private xmlSubjektUdajSpisZnSoud soudField;

		private string oddilField;

		private int vlozkaField;

		/// <remarks/>
		public xmlSubjektUdajSpisZnSoud soud
		{
			get
			{
				return this.soudField;
			}
			set
			{
				this.soudField = value;
			}
		}

		/// <remarks/>
		public string oddil
		{
			get
			{
				return this.oddilField;
			}
			set
			{
				this.oddilField = value;
			}
		}

		/// <remarks/>
		public int vlozka
		{
			get
			{
				return this.vlozkaField;
			}
			set
			{
				this.vlozkaField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajSpisZnSoud
	{

		private string kodField;

		private string nazevField;

		/// <remarks/>
		public string kod
		{
			get
			{
				return this.kodField;
			}
			set
			{
				this.kodField = value;
			}
		}

		/// <remarks/>
		public string nazev
		{
			get
			{
				return this.nazevField;
			}
			set
			{
				this.nazevField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdaj
	{

		private string hlavickaField;

		private System.DateTime zapisDatumField;

		private System.DateTime vymazDatumField;

		private bool vymazDatumFieldSpecified;

		private string hodnotaTextField;

		private xmlSubjektUdajUdajHodnotaUdaje hodnotaUdajeField;

		private System.DateTime clenstviOdField;

		private bool clenstviOdFieldSpecified;

		private System.DateTime clenstviDoField;

		private bool clenstviDoFieldSpecified;

		private System.DateTime funkceOdField;

		private bool funkceOdFieldSpecified;

		private System.DateTime funkceDoField;

		private bool funkceDoFieldSpecified;

		private string funkceField;

		private xmlSubjektUdajUdajUdajTyp udajTypField;

		private xmlSubjektUdajUdajOsoba osobaField;

		private xmlSubjektUdajUdajAdresa adresaField;

		private xmlSubjektUdajUdajBydliste bydlisteField;

		private xmlSubjektUdajUdajPodudaje podudajeField;

		/// <remarks/>
		public string hlavicka
		{
			get
			{
				return this.hlavickaField;
			}
			set
			{
				this.hlavickaField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime zapisDatum
		{
			get
			{
				return this.zapisDatumField;
			}
			set
			{
				this.zapisDatumField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime vymazDatum
		{
			get
			{
				return this.vymazDatumField;
			}
			set
			{
				this.vymazDatumField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool vymazDatumSpecified
		{
			get
			{
				return this.vymazDatumFieldSpecified;
			}
			set
			{
				this.vymazDatumFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string hodnotaText
		{
			get
			{
				return this.hodnotaTextField;
			}
			set
			{
				this.hodnotaTextField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajHodnotaUdaje hodnotaUdaje
		{
			get
			{
				return this.hodnotaUdajeField;
			}
			set
			{
				this.hodnotaUdajeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime clenstviOd
		{
			get
			{
				return this.clenstviOdField;
			}
			set
			{
				this.clenstviOdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool clenstviOdSpecified
		{
			get
			{
				return this.clenstviOdFieldSpecified;
			}
			set
			{
				this.clenstviOdFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime clenstviDo
		{
			get
			{
				return this.clenstviDoField;
			}
			set
			{
				this.clenstviDoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool clenstviDoSpecified
		{
			get
			{
				return this.clenstviDoFieldSpecified;
			}
			set
			{
				this.clenstviDoFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime funkceOd
		{
			get
			{
				return this.funkceOdField;
			}
			set
			{
				this.funkceOdField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool funkceOdSpecified
		{
			get
			{
				return this.funkceOdFieldSpecified;
			}
			set
			{
				this.funkceOdFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime funkceDo
		{
			get
			{
				return this.funkceDoField;
			}
			set
			{
				this.funkceDoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool funkceDoSpecified
		{
			get
			{
				return this.funkceDoFieldSpecified;
			}
			set
			{
				this.funkceDoFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string funkce
		{
			get
			{
				return this.funkceField;
			}
			set
			{
				this.funkceField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajUdajTyp udajTyp
		{
			get
			{
				return this.udajTypField;
			}
			set
			{
				this.udajTypField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajOsoba osoba
		{
			get
			{
				return this.osobaField;
			}
			set
			{
				this.osobaField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajAdresa adresa
		{
			get
			{
				return this.adresaField;
			}
			set
			{
				this.adresaField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajBydliste bydliste
		{
			get
			{
				return this.bydlisteField;
			}
			set
			{
				this.bydlisteField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajPodudaje podudaje
		{
			get
			{
				return this.podudajeField;
			}
			set
			{
				this.podudajeField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdaje
	{

		private object[] itemsField;

		private ItemsChoiceType[] itemsElementNameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("T", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("autoprupis", typeof(bool))]
		[System.Xml.Serialization.XmlElementAttribute("jednaVeShodeSOsoby", typeof(object))]
		[System.Xml.Serialization.XmlElementAttribute("koncovyPrijemceText", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("nahradniSMOsoby", typeof(object))]
		[System.Xml.Serialization.XmlElementAttribute("pocetClenu", typeof(int))]
		[System.Xml.Serialization.XmlElementAttribute("postaveni", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("sestPoziceDozorciOrgan", typeof(bool))]
		[System.Xml.Serialization.XmlElementAttribute("sestPoziceRevizor", typeof(bool))]
		[System.Xml.Serialization.XmlElementAttribute("sestPoziceSpravniOrgan", typeof(bool))]
		[System.Xml.Serialization.XmlElementAttribute("sestPoziceZakladatel", typeof(bool))]
		[System.Xml.Serialization.XmlElementAttribute("skutecnymMajitelemOd", typeof(System.DateTime), DataType = "date")]
		[System.Xml.Serialization.XmlElementAttribute("spravce", typeof(bool))]
		[System.Xml.Serialization.XmlElementAttribute("strukturaVztahu", typeof(xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahu))]
		[System.Xml.Serialization.XmlElementAttribute("textZaOsobu", typeof(xmlSubjektUdajUdajHodnotaUdajeTextZaOsobu))]
		[System.Xml.Serialization.XmlElementAttribute("textZruseni", typeof(object))]
		[System.Xml.Serialization.XmlElementAttribute("typ", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("vklad", typeof(xmlSubjektUdajUdajHodnotaUdajeVklad))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ItemsChoiceType[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahu
	{

		private xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmap[] retezceField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("linked-hash-map", IsNullable = false)]
		public xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmap[] retezce
		{
			get
			{
				return this.retezceField;
			}
			set
			{
				this.retezceField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmap
	{

		private xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmap[] clankyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("linked-hash-map", IsNullable = false)]
		public xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmap[] clanky
		{
			get
			{
				return this.clankyField;
			}
			set
			{
				this.clankyField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmap
	{

		private string typClankuField;

		private xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapIdentifikace identifikaceField;

		private xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClanku vztahKPredchozimuClankuField;

		/// <remarks/>
		public string typClanku
		{
			get
			{
				return this.typClankuField;
			}
			set
			{
				this.typClankuField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapIdentifikace identifikace
		{
			get
			{
				return this.identifikaceField;
			}
			set
			{
				this.identifikaceField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClanku vztahKPredchozimuClanku
		{
			get
			{
				return this.vztahKPredchozimuClankuField;
			}
			set
			{
				this.vztahKPredchozimuClankuField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapIdentifikace
	{

		private string nameField;

		private string icoField;

		/// <remarks/>
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		public string ico
		{
			get
			{
				return this.icoField;
			}
			set
			{
				this.icoField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClanku
	{

		private bool vlastniPodilNaProspechuField;

		private bool vlastniPodilNaProspechuFieldSpecified;

		private xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuPodilNaProspechu podilNaProspechuField;

		private bool jednaVeShodeField;

		private bool jednaVeShodeFieldSpecified;

		private xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuJednaVeShodeSOsoby jednaVeShodeSOsobyField;

		private bool jinyVztahField;

		private bool jinyVztahFieldSpecified;

		private bool tichySpolecnikField;

		private bool tichySpolecnikFieldSpecified;

		private bool spoluvlastnictviField;

		private bool spoluvlastnictviFieldSpecified;

		private bool pravoVetaField;

		private bool pravoVetaFieldSpecified;

		private bool clenVolenehoOrganuField;

		private bool clenVolenehoOrganuFieldSpecified;

		private bool smlouvaField;

		private bool smlouvaFieldSpecified;

		private string obchodniKorporaceTextField;

		private bool vrcholoveVedeniField;

		private bool vrcholoveVedeniFieldSpecified;

		private bool poziceClenaVolenehoOrganuZakladateleField;

		private bool poziceClenaVolenehoOrganuZakladateleFieldSpecified;

		private bool poziceZakladateleUstavuField;

		private bool poziceZakladateleUstavuFieldSpecified;

		private bool poziceClenaVolenehoOrganuField;

		private bool poziceClenaVolenehoOrganuFieldSpecified;

		private bool poziceOsobyPodle6__1cField;

		private bool poziceOsobyPodle6__1cFieldSpecified;

		/// <remarks/>
		public bool vlastniPodilNaProspechu
		{
			get
			{
				return this.vlastniPodilNaProspechuField;
			}
			set
			{
				this.vlastniPodilNaProspechuField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool vlastniPodilNaProspechuSpecified
		{
			get
			{
				return this.vlastniPodilNaProspechuFieldSpecified;
			}
			set
			{
				this.vlastniPodilNaProspechuFieldSpecified = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuPodilNaProspechu podilNaProspechu
		{
			get
			{
				return this.podilNaProspechuField;
			}
			set
			{
				this.podilNaProspechuField = value;
			}
		}

		/// <remarks/>
		public bool jednaVeShode
		{
			get
			{
				return this.jednaVeShodeField;
			}
			set
			{
				this.jednaVeShodeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool jednaVeShodeSpecified
		{
			get
			{
				return this.jednaVeShodeFieldSpecified;
			}
			set
			{
				this.jednaVeShodeFieldSpecified = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuJednaVeShodeSOsoby jednaVeShodeSOsoby
		{
			get
			{
				return this.jednaVeShodeSOsobyField;
			}
			set
			{
				this.jednaVeShodeSOsobyField = value;
			}
		}

		/// <remarks/>
		public bool jinyVztah
		{
			get
			{
				return this.jinyVztahField;
			}
			set
			{
				this.jinyVztahField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool jinyVztahSpecified
		{
			get
			{
				return this.jinyVztahFieldSpecified;
			}
			set
			{
				this.jinyVztahFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool tichySpolecnik
		{
			get
			{
				return this.tichySpolecnikField;
			}
			set
			{
				this.tichySpolecnikField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool tichySpolecnikSpecified
		{
			get
			{
				return this.tichySpolecnikFieldSpecified;
			}
			set
			{
				this.tichySpolecnikFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool spoluvlastnictvi
		{
			get
			{
				return this.spoluvlastnictviField;
			}
			set
			{
				this.spoluvlastnictviField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool spoluvlastnictviSpecified
		{
			get
			{
				return this.spoluvlastnictviFieldSpecified;
			}
			set
			{
				this.spoluvlastnictviFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool pravoVeta
		{
			get
			{
				return this.pravoVetaField;
			}
			set
			{
				this.pravoVetaField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool pravoVetaSpecified
		{
			get
			{
				return this.pravoVetaFieldSpecified;
			}
			set
			{
				this.pravoVetaFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool clenVolenehoOrganu
		{
			get
			{
				return this.clenVolenehoOrganuField;
			}
			set
			{
				this.clenVolenehoOrganuField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool clenVolenehoOrganuSpecified
		{
			get
			{
				return this.clenVolenehoOrganuFieldSpecified;
			}
			set
			{
				this.clenVolenehoOrganuFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool smlouva
		{
			get
			{
				return this.smlouvaField;
			}
			set
			{
				this.smlouvaField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool smlouvaSpecified
		{
			get
			{
				return this.smlouvaFieldSpecified;
			}
			set
			{
				this.smlouvaFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string obchodniKorporaceText
		{
			get
			{
				return this.obchodniKorporaceTextField;
			}
			set
			{
				this.obchodniKorporaceTextField = value;
			}
		}

		/// <remarks/>
		public bool vrcholoveVedeni
		{
			get
			{
				return this.vrcholoveVedeniField;
			}
			set
			{
				this.vrcholoveVedeniField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool vrcholoveVedeniSpecified
		{
			get
			{
				return this.vrcholoveVedeniFieldSpecified;
			}
			set
			{
				this.vrcholoveVedeniFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool poziceClenaVolenehoOrganuZakladatele
		{
			get
			{
				return this.poziceClenaVolenehoOrganuZakladateleField;
			}
			set
			{
				this.poziceClenaVolenehoOrganuZakladateleField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool poziceClenaVolenehoOrganuZakladateleSpecified
		{
			get
			{
				return this.poziceClenaVolenehoOrganuZakladateleFieldSpecified;
			}
			set
			{
				this.poziceClenaVolenehoOrganuZakladateleFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool poziceZakladateleUstavu
		{
			get
			{
				return this.poziceZakladateleUstavuField;
			}
			set
			{
				this.poziceZakladateleUstavuField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool poziceZakladateleUstavuSpecified
		{
			get
			{
				return this.poziceZakladateleUstavuFieldSpecified;
			}
			set
			{
				this.poziceZakladateleUstavuFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool poziceClenaVolenehoOrganu
		{
			get
			{
				return this.poziceClenaVolenehoOrganuField;
			}
			set
			{
				this.poziceClenaVolenehoOrganuField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool poziceClenaVolenehoOrganuSpecified
		{
			get
			{
				return this.poziceClenaVolenehoOrganuFieldSpecified;
			}
			set
			{
				this.poziceClenaVolenehoOrganuFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool poziceOsobyPodle6__1c
		{
			get
			{
				return this.poziceOsobyPodle6__1cField;
			}
			set
			{
				this.poziceOsobyPodle6__1cField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool poziceOsobyPodle6__1cSpecified
		{
			get
			{
				return this.poziceOsobyPodle6__1cFieldSpecified;
			}
			set
			{
				this.poziceOsobyPodle6__1cFieldSpecified = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuPodilNaProspechu
	{

		private string typField;

		private decimal textValueField;

		/// <remarks/>
		public string typ
		{
			get
			{
				return this.typField;
			}
			set
			{
				this.typField = value;
			}
		}

		/// <remarks/>
		public decimal textValue
		{
			get
			{
				return this.textValueField;
			}
			set
			{
				this.textValueField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuJednaVeShodeSOsoby
	{

		private xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuJednaVeShodeSOsobyLinkedhashmap linkedhashmapField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("linked-hash-map")]
		public xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuJednaVeShodeSOsobyLinkedhashmap linkedhashmap
		{
			get
			{
				return this.linkedhashmapField;
			}
			set
			{
				this.linkedhashmapField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuJednaVeShodeSOsobyLinkedhashmap
	{

		private string jmenoField;

		private string prijmeniField;

		private xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuJednaVeShodeSOsobyLinkedhashmapPodilNaHlasovacichPravech podilNaHlasovacichPravechField;

		private string typOsobyField;

		/// <remarks/>
		public string jmeno
		{
			get
			{
				return this.jmenoField;
			}
			set
			{
				this.jmenoField = value;
			}
		}

		/// <remarks/>
		public string prijmeni
		{
			get
			{
				return this.prijmeniField;
			}
			set
			{
				this.prijmeniField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuJednaVeShodeSOsobyLinkedhashmapPodilNaHlasovacichPravech podilNaHlasovacichPravech
		{
			get
			{
				return this.podilNaHlasovacichPravechField;
			}
			set
			{
				this.podilNaHlasovacichPravechField = value;
			}
		}

		/// <remarks/>
		public string typOsoby
		{
			get
			{
				return this.typOsobyField;
			}
			set
			{
				this.typOsobyField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeStrukturaVztahuLinkedhashmapLinkedhashmapVztahKPredchozimuClankuJednaVeShodeSOsobyLinkedhashmapPodilNaHlasovacichPravech
	{

		private string typField;

		private int textValueField;

		/// <remarks/>
		public string typ
		{
			get
			{
				return this.typField;
			}
			set
			{
				this.typField = value;
			}
		}

		/// <remarks/>
		public int textValue
		{
			get
			{
				return this.textValueField;
			}
			set
			{
				this.textValueField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeTextZaOsobu
	{

		private string valueField;

		/// <remarks/>
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeVklad
	{

		private xmlSubjektUdajUdajHodnotaUdajeVkladVklad vkladField;

		private xmlSubjektUdajUdajHodnotaUdajeVkladSplaceni splaceniField;

		/// <remarks/>
		public xmlSubjektUdajUdajHodnotaUdajeVkladVklad vklad
		{
			get
			{
				return this.vkladField;
			}
			set
			{
				this.vkladField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajHodnotaUdajeVkladSplaceni splaceni
		{
			get
			{
				return this.splaceniField;
			}
			set
			{
				this.splaceniField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeVkladVklad
	{

		private string typField;

		private decimal textValueField;

		/// <remarks/>
		public string typ
		{
			get
			{
				return this.typField;
			}
			set
			{
				this.typField = value;
			}
		}

		/// <remarks/>
		public decimal textValue
		{
			get
			{
				return this.textValueField;
			}
			set
			{
				this.textValueField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajHodnotaUdajeVkladSplaceni
	{

		private string typField;

		private decimal textValueField;

		/// <remarks/>
		public string typ
		{
			get
			{
				return this.typField;
			}
			set
			{
				this.typField = value;
			}
		}

		/// <remarks/>
		public decimal textValue
		{
			get
			{
				return this.textValueField;
			}
			set
			{
				this.textValueField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
	public enum ItemsChoiceType
	{

		/// <remarks/>
		T,

		/// <remarks/>
		autoprupis,

		/// <remarks/>
		jednaVeShodeSOsoby,

		/// <remarks/>
		koncovyPrijemceText,

		/// <remarks/>
		nahradniSMOsoby,

		/// <remarks/>
		pocetClenu,

		/// <remarks/>
		postaveni,

		/// <remarks/>
		sestPoziceDozorciOrgan,

		/// <remarks/>
		sestPoziceRevizor,

		/// <remarks/>
		sestPoziceSpravniOrgan,

		/// <remarks/>
		sestPoziceZakladatel,

		/// <remarks/>
		skutecnymMajitelemOd,

		/// <remarks/>
		spravce,

		/// <remarks/>
		strukturaVztahu,

		/// <remarks/>
		textZaOsobu,

		/// <remarks/>
		textZruseni,

		/// <remarks/>
		typ,

		/// <remarks/>
		vklad,
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajUdajTyp
	{

		private string kodField;

		private string nazevField;

		/// <remarks/>
		public string kod
		{
			get
			{
				return this.kodField;
			}
			set
			{
				this.kodField = value;
			}
		}

		/// <remarks/>
		public string nazev
		{
			get
			{
				return this.nazevField;
			}
			set
			{
				this.nazevField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajOsoba
	{

		private string osobaTextField;

		private string nazevField;

		private int icoField;

		private bool icoFieldSpecified;

		private string jmenoField;

		private string prijmeniField;

		private System.DateTime narozDatumField;

		private bool narozDatumFieldSpecified;

		private string titulPredField;

		private string titulZaField;

		/// <remarks/>
		public string osobaText
		{
			get
			{
				return this.osobaTextField;
			}
			set
			{
				this.osobaTextField = value;
			}
		}

		/// <remarks/>
		public string nazev
		{
			get
			{
				return this.nazevField;
			}
			set
			{
				this.nazevField = value;
			}
		}

		/// <remarks/>
		public int ico
		{
			get
			{
				return this.icoField;
			}
			set
			{
				this.icoField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool icoSpecified
		{
			get
			{
				return this.icoFieldSpecified;
			}
			set
			{
				this.icoFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string jmeno
		{
			get
			{
				return this.jmenoField;
			}
			set
			{
				this.jmenoField = value;
			}
		}

		/// <remarks/>
		public string prijmeni
		{
			get
			{
				return this.prijmeniField;
			}
			set
			{
				this.prijmeniField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime narozDatum
		{
			get
			{
				return this.narozDatumField;
			}
			set
			{
				this.narozDatumField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool narozDatumSpecified
		{
			get
			{
				return this.narozDatumFieldSpecified;
			}
			set
			{
				this.narozDatumFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string titulPred
		{
			get
			{
				return this.titulPredField;
			}
			set
			{
				this.titulPredField = value;
			}
		}

		/// <remarks/>
		public string titulZa
		{
			get
			{
				return this.titulZaField;
			}
			set
			{
				this.titulZaField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajAdresa
	{

		private object[] itemsField;

		private ItemsChoiceType1[] itemsElementNameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("adresaText", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("castObce", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("cisloEv", typeof(int))]
		[System.Xml.Serialization.XmlElementAttribute("cisloOr", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("cisloPo", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("cisloText", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("obec", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("okres", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("psc", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("statNazev", typeof(string))]
		[System.Xml.Serialization.XmlElementAttribute("ulice", typeof(string))]
		[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public ItemsChoiceType1[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
	public enum ItemsChoiceType1
	{

		/// <remarks/>
		adresaText,

		/// <remarks/>
		castObce,

		/// <remarks/>
		cisloEv,

		/// <remarks/>
		cisloOr,

		/// <remarks/>
		cisloPo,

		/// <remarks/>
		cisloText,

		/// <remarks/>
		obec,

		/// <remarks/>
		okres,

		/// <remarks/>
		psc,

		/// <remarks/>
		statNazev,

		/// <remarks/>
		ulice,
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajBydliste
	{

		private string statNazevField;

		private string obecField;

		private string castObceField;

		private string uliceField;

		private int cisloPoField;

		private int cisloOrField;

		private bool cisloOrFieldSpecified;

		private string pscField;

		private string okresField;

		/// <remarks/>
		public string statNazev
		{
			get
			{
				return this.statNazevField;
			}
			set
			{
				this.statNazevField = value;
			}
		}

		/// <remarks/>
		public string obec
		{
			get
			{
				return this.obecField;
			}
			set
			{
				this.obecField = value;
			}
		}

		/// <remarks/>
		public string castObce
		{
			get
			{
				return this.castObceField;
			}
			set
			{
				this.castObceField = value;
			}
		}

		/// <remarks/>
		public string ulice
		{
			get
			{
				return this.uliceField;
			}
			set
			{
				this.uliceField = value;
			}
		}

		/// <remarks/>
		public int cisloPo
		{
			get
			{
				return this.cisloPoField;
			}
			set
			{
				this.cisloPoField = value;
			}
		}

		/// <remarks/>
		public int cisloOr
		{
			get
			{
				return this.cisloOrField;
			}
			set
			{
				this.cisloOrField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool cisloOrSpecified
		{
			get
			{
				return this.cisloOrFieldSpecified;
			}
			set
			{
				this.cisloOrFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string psc
		{
			get
			{
				return this.pscField;
			}
			set
			{
				this.pscField = value;
			}
		}

		/// <remarks/>
		public string okres
		{
			get
			{
				return this.okresField;
			}
			set
			{
				this.okresField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajPodudaje
	{

		private xmlSubjektUdajUdajPodudajeUdaj udajField;

		/// <remarks/>
		public xmlSubjektUdajUdajPodudajeUdaj Udaj
		{
			get
			{
				return this.udajField;
			}
			set
			{
				this.udajField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajPodudajeUdaj
	{

		private string hlavickaField;

		private System.DateTime zapisDatumField;

		private System.DateTime vymazDatumField;

		private bool vymazDatumFieldSpecified;

		private string hodnotaTextField;

		private xmlSubjektUdajUdajPodudajeUdajHodnotaUdaje hodnotaUdajeField;

		private xmlSubjektUdajUdajPodudajeUdajUdajTyp udajTypField;

		private xmlSubjektUdajUdajPodudajeUdajOsoba osobaField;

		private xmlSubjektUdajUdajPodudajeUdajAdresa adresaField;

		/// <remarks/>
		public string hlavicka
		{
			get
			{
				return this.hlavickaField;
			}
			set
			{
				this.hlavickaField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime zapisDatum
		{
			get
			{
				return this.zapisDatumField;
			}
			set
			{
				this.zapisDatumField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime vymazDatum
		{
			get
			{
				return this.vymazDatumField;
			}
			set
			{
				this.vymazDatumField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool vymazDatumSpecified
		{
			get
			{
				return this.vymazDatumFieldSpecified;
			}
			set
			{
				this.vymazDatumFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string hodnotaText
		{
			get
			{
				return this.hodnotaTextField;
			}
			set
			{
				this.hodnotaTextField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajPodudajeUdajHodnotaUdaje hodnotaUdaje
		{
			get
			{
				return this.hodnotaUdajeField;
			}
			set
			{
				this.hodnotaUdajeField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajPodudajeUdajUdajTyp udajTyp
		{
			get
			{
				return this.udajTypField;
			}
			set
			{
				this.udajTypField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajPodudajeUdajOsoba osoba
		{
			get
			{
				return this.osobaField;
			}
			set
			{
				this.osobaField = value;
			}
		}

		/// <remarks/>
		public xmlSubjektUdajUdajPodudajeUdajAdresa adresa
		{
			get
			{
				return this.adresaField;
			}
			set
			{
				this.adresaField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajPodudajeUdajHodnotaUdaje
	{

		private string tField;

		/// <remarks/>
		public string T
		{
			get
			{
				return this.tField;
			}
			set
			{
				this.tField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajPodudajeUdajUdajTyp
	{

		private string kodField;

		private string nazevField;

		/// <remarks/>
		public string kod
		{
			get
			{
				return this.kodField;
			}
			set
			{
				this.kodField = value;
			}
		}

		/// <remarks/>
		public string nazev
		{
			get
			{
				return this.nazevField;
			}
			set
			{
				this.nazevField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajPodudajeUdajOsoba
	{

		private string jmenoField;

		private string prijmeniField;

		private System.DateTime narozDatumField;

		private string titulPredField;

		/// <remarks/>
		public string jmeno
		{
			get
			{
				return this.jmenoField;
			}
			set
			{
				this.jmenoField = value;
			}
		}

		/// <remarks/>
		public string prijmeni
		{
			get
			{
				return this.prijmeniField;
			}
			set
			{
				this.prijmeniField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
		public System.DateTime narozDatum
		{
			get
			{
				return this.narozDatumField;
			}
			set
			{
				this.narozDatumField = value;
			}
		}

		/// <remarks/>
		public string titulPred
		{
			get
			{
				return this.titulPredField;
			}
			set
			{
				this.titulPredField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class xmlSubjektUdajUdajPodudajeUdajAdresa
	{

		private string statNazevField;

		private string obecField;

		private string castObceField;

		private string uliceField;

		private int cisloPoField;

		private string pscField;

		/// <remarks/>
		public string statNazev
		{
			get
			{
				return this.statNazevField;
			}
			set
			{
				this.statNazevField = value;
			}
		}

		/// <remarks/>
		public string obec
		{
			get
			{
				return this.obecField;
			}
			set
			{
				this.obecField = value;
			}
		}

		/// <remarks/>
		public string castObce
		{
			get
			{
				return this.castObceField;
			}
			set
			{
				this.castObceField = value;
			}
		}

		/// <remarks/>
		public string ulice
		{
			get
			{
				return this.uliceField;
			}
			set
			{
				this.uliceField = value;
			}
		}

		/// <remarks/>
		public int cisloPo
		{
			get
			{
				return this.cisloPoField;
			}
			set
			{
				this.cisloPoField = value;
			}
		}

		/// <remarks/>
		public string psc
		{
			get
			{
				return this.pscField;
			}
			set
			{
				this.pscField = value;
			}
		}
	}


}
