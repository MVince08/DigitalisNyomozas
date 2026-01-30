using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Evidence
	{
		private string azonosito;
		private string tipus; //foto,dokumentum,digitalisadat
		private string leiras;
		private int megbizhatosagiErtek; //(1-5)

		public Evidence(string azonosito, string tipus, string leiras, int megbizhatosagiErtek)
		{
			this.azonosito = azonosito;
			this.tipus = tipus;
			this.leiras = leiras;
			this.megbizhatosagiErtek = megbizhatosagiErtek;
		}

		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public int MegbizhatosagiErtek { get => megbizhatosagiErtek; set => megbizhatosagiErtek = value; }
	}
}
