using System.Linq;

namespace DigitalisNyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Evidence e1 = new Evidence("ABC123", "fotó", "Foto az elkövetőről elv.", 3);
            CaseManager c1 = new CaseManager();
            DataStorage d1 = new DataStorage();
            bool isfut1 = true;
            bool isfut2 = true;


			//Menürendszer:
            do
            {
				int beker = 0;
				Console.WriteLine("Válasszon a lehetőségek közül:\n\t1. Ügyek kezelése\n\t2. Személyek kezelése\n\t3. Bizonyítékok kezelése\n\t4. Idővonal megtekintése\n\t5. Elemzés / döntések\n\t6. Kilépés");
				do
				{
					beker = int.Parse(Console.ReadLine());
				}
				while (beker < 1 && beker > 5);

				switch (beker)
				{
					case 1:
						do
						{ 
						Console.WriteLine("Mit szeretnecsinálni");
						Console.WriteLine("1. Ügy felvétele\n2. Ügy állapota\n3. Kilépés");
						do
						{
							beker = int.Parse(Console.ReadLine());
						}
						while (beker < 1 && beker > 5);
							switch (beker)
							{

								case 1: // Ügy létrehozása
									Console.WriteLine("Adja meg az ügy Azonosítóját: ");
									string ugyazonosito = Console.ReadLine();
									Console.WriteLine("Adja meg az ügy címét: ");
									string ugycim = Console.ReadLine();
									Console.WriteLine("Adja meg az ügy leírását: ");
									string ugyleiras = Console.ReadLine();
									Console.WriteLine("Adja meg az ügy állapotát: ");
									string ugyallapot = Console.ReadLine();
									c1.UgyLetrehozas(ugyazonosito, ugycim, ugyleiras, ugyallapot);

									Case newcase = new(ugyazonosito, ugycim, ugyleiras, ugyallapot);
									d1.Ugyek.Add(newcase);
									break;
								case 2: //Állapot megváltoztatása
									Console.WriteLine("Melyik case-t szeretnéd megváltoztatni?(Ugynek az Azonositóját kérem):  ");
									string ugyazonositoBekeres = Console.ReadLine();
									foreach (var item in d1.Ugyek)
									{
										if (d1.Ugyek.Contains(item))
										{
											c1.CaseStatus(item);
										}
									}
									break;
								case 3:
									Console.WriteLine("ByeBye");
									isfut2 = false;
									break;
							}
						}
						while (isfut2);
						break;
				}
			}
            while (isfut1);
                
        }
    }
}
