using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Case
	{
		private string ugyAzonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Case> szemelyek;
		private List<Case> bizonyitekok;

		public Case(string ugyAzonosito, string cim, string leiras, string allapot, List<Case> szemelyek, List<Case> bizonyitekok)
		{
			this.ugyAzonosito = ugyAzonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemelyek = szemelyek;
			this.bizonyitekok = bizonyitekok;
		}
        public Case(string ugyAzonosito, string cim, string leiras, string allapot)
        {
            this.ugyAzonosito = ugyAzonosito;
            this.cim = cim;
            this.leiras = leiras;
            this.allapot = allapot;
        }
        public string UgyAzonosito { get => ugyAzonosito; set => ugyAzonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		public List<Case> Szemelyek { get => szemelyek; set => szemelyek = value; }
		public List<Case> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }


        public override string ToString()
        {
			return $"\nÜgy Azonosítója: {this.ugyAzonosito}, Ügy Címe: {this.cim}, Ügy Leírása: {leiras}, Ügy Állapota: {allapot}\n";
        }
	}
}
