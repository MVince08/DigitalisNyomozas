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
		private List<Person> szemelyek = [];
		private List<TimeLineEvent> esemenyek = [];
        private List<Case> bizonyitekok;


		public Case(string ugyAzonosito, string cim, string leiras, string allapot, List<Person> szemelyek, List<Case> bizonyitekok)
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
		public List<Person> Szemelyek { get => szemelyek; set => szemelyek = value; }
		public List<Case> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
        public List<TimeLineEvent> Esemenyek { get => esemenyek; set => esemenyek = value; }

        public override string ToString()
        {
			string s = $"\nÜgy Azonosítója: {this.ugyAzonosito}, Ügy Címe: {this.cim}, Ügy Leírása: {leiras}, Ügy Állapota: {allapot}\n";
			if(esemenyek.Count > 0)
			{
                s += $"\tÜgyhöz kapcsolódó események:";
            }
			foreach (var item in esemenyek)
			{
				s += $"{item}\n";
            }
            return s;
        }
	}
}
