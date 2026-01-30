using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class CaseManager
	{
		List<Case> ugyek = new List<Case>();

		public CaseManager()
		{

		}

		public List<Case> Ugyek { get => ugyek; set => ugyek = value; }


		public void UgyLetrehozas(string ugyAzonosito, string cim, string leiras, string allapot)
		{
			ugyek.Add(new Case( ugyAzonosito, cim, leiras, allapot));
        }

    }
}
