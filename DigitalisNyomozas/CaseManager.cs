using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class CaseManager
	{
		List<Person> szemely = new List<Person>();
        DataStorage d1 = null;


        public CaseManager(DataStorage d1)
		{
			this.d1 = d1;
		}

		public List<Case> Ugyek { get => d1.Ugyek;}


		public void UgyLetrehozas()//string ugyAzonosito, string cim, string leiras, string allapot)
		{
            Console.WriteLine("Adja meg az ügy Azonosítóját: ");
            string ugyazonosito = Console.ReadLine();
            Console.WriteLine("Adja meg az ügy címét: ");
            string ugycim = Console.ReadLine();
            Console.WriteLine("Adja meg az ügy leírását: ");
            string ugyleiras = Console.ReadLine();
            Console.WriteLine("Adja meg az ügy állapotát: ");
            string ugyallapot = Console.ReadLine();
            d1.Ugyek.Add(new Case(ugyazonosito, ugycim, ugyleiras, ugyallapot));
		}

		public void SzemelyHozzaadas()//string name, int age, string megjegyzes)
		{
            Console.WriteLine("Személy felvételét választotta.");
            Console.WriteLine("Adja meg a személy nevét");
            string szemelyneve = Console.ReadLine();
            Console.WriteLine("Adja meg a személy életkorát");
            int szemelyeletkora = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a személy megjegyzését");
            string szemelymegjegyzese = Console.ReadLine();
            d1.Szemelyek.Add(new Person(szemelyneve, szemelyeletkora, szemelymegjegyzese));
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
		public void ListCases()
		{
            Console.WriteLine("Ügy kilistázását választotta.");
            foreach (var item in d1.Ugyek)
            {
                Console.WriteLine(item);
            }
        }

		public void ListFelhasznalo()
		{
            Console.WriteLine("Felhasználok kilistázását választotta.");
            foreach (var item in d1.Szemelyek)
            {
                Console.WriteLine(item);
            }
        }
    }
}
