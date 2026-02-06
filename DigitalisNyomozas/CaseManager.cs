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
			ugyek.Add(new Case(ugyAzonosito, cim, leiras, allapot));
		}

		public void CaseStatus(Case a)
		{

			string aktualisStatusz = "";
			aktualisStatusz = a.Allapot;
			Console.WriteLine($"Case aktuális státusza: {aktualisStatusz}");
			Console.WriteLine("Szeretnéd megváltotani az allapotot?");
			string x = Console.ReadLine();
			if (x == "i")
			{
				Console.WriteLine("Mire szeretnéd megváltoztatni? (N-nyitott, F-folymatban, L-lezart)");
				string y = Console.ReadLine();
				if (y == "N")
				{
					aktualisStatusz = "Nyitott";
					a.Allapot = aktualisStatusz;
					Console.WriteLine("Állapot megváltoztatva Nyitottra");
				}
				else if (y == "F")
				{
					aktualisStatusz = "Folyamatban";
					a.Allapot= aktualisStatusz;
					Console.WriteLine("Állapot megváltoztatva Folyamatban lévőre");
				}
				else if (y == "L")
				{
					aktualisStatusz = "Lezárt";
					a.Allapot = aktualisStatusz;
					Console.WriteLine("Állapot megváltoztatva Lezárt állapotra");
				}
			}

		}
	}
}
