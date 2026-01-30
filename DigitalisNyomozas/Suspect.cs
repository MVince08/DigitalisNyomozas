using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Suspect
	{
		private Person person;
		private int gyanusitasiSzint; //0-100
		private string status; //szabad/megfigyelt/őrizetben

		public Suspect(Person person, int gyanusitasiSzint, string status)
		{
			this.person = person;
			this.gyanusitasiSzint = gyanusitasiSzint;
			this.status = status;
		}

		public int GyanusitasiSzint { get => gyanusitasiSzint; set => gyanusitasiSzint = value; }
		public string Status { get => status; set => status = value; }
		internal Person Person { get => person; set => person = value; }
	}
}
