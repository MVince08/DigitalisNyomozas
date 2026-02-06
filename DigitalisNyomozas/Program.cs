using System.Linq;

namespace DigitalisNyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStorage d1 = new DataStorage();
            CaseManager c1 = new CaseManager(d1);
			EvidenceManager e1 = new EvidenceManager();
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
					case 1: // Ügyek kezelése
						do
						{ 
						Console.WriteLine("Mit szeretne csinálni?");
						Console.WriteLine("1. Ügy felvétele\n2. Ügy állapota\n3. Ügy listázása\n4. Kilépés");
						do
						{
							beker = int.Parse(Console.ReadLine());
						}
						while (beker < 1 && beker > 5);
							switch (beker)
							{

								case 1: // Ügy létrehozása
									c1.UgyLetrehozas();
									
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

								case 3://Ügy kilistázása
									c1.ListCases();
                                    break;

                                case 4:
									Console.WriteLine("ByeBye");
									isfut2 = false;
									break;
							}
						}
						while (isfut2);
						break;
					case 2: //Személyek kezelése

						do
						{
							Console.WriteLine("Mit szeretne csinálni?");
							Console.WriteLine("1. Személy felvétele\n2. Kilépés");
							do
							{
								beker = int.Parse(Console.ReadLine());
							}
							while (beker < 1 && beker > 5);
							switch (beker)
							{
								case 1:
									c1.SzemelyHozzaadas();
									break;
								case 2:
									Console.WriteLine("ByeBye");
									isfut2 = false;
									break;
							}
						}
						while (isfut2);
						break;
					case 3: // bizonyítékok kezelése
						do
						{
							Console.WriteLine("Bizonyítékok kezelését választotta. Mit szeretne csinálni? ");
							Console.WriteLine("1. Bizonyítékok rögzítése\n2. Bizonyíték törlése\n3. Kilépés");
							do
							{
								beker = int.Parse(Console.ReadLine());
							}
							while(beker < 1 && beker > 5);
							switch (beker)
							{
								case 1:
									Console.WriteLine("A Bizonyítékok rögzítését választotta.");
									Console.WriteLine("Adja meg a bizonyíték azonosítóját: ");
									string bizonyitekAzonosito = Console.ReadLine();
									Console.WriteLine("Adja meg a bizonyíték típusát: ");
									string bizonyitekTipus = Console.ReadLine();
									Console.WriteLine("Adja meg a bizonyíték leírását: ");
									string bizonyitekLeiras = Console.ReadLine();
									Console.WriteLine("Adja meg a bizonyíték megbízhatóságát");
									int bizonyitekMegbizhatosag = int.Parse(Console.ReadLine());
									e1.AddEvidence(bizonyitekAzonosito, bizonyitekTipus, bizonyitekLeiras, bizonyitekMegbizhatosag);

									Evidence newcase = new(bizonyitekAzonosito, bizonyitekTipus, bizonyitekLeiras, bizonyitekMegbizhatosag);
									d1.Bizonyitekok.Add(newcase);
									break;
								case 2:
									Console.WriteLine("Bizonyítékok törlését választotta.");
									Console.WriteLine("Melyik bizonyítékot akarja törölni? (Bizonyítékok azonosítója)");
									string bizonyitekBekeres = Console.ReadLine();

									foreach (var item in d1.Bizonyitekok)
									{
										if (d1.Bizonyitekok.Contains(item))
										{
											d1.Bizonyitekok.Remove(item);
											e1.RemoveEvidence(item);
										}
									}

									break;
								case 3:
									Console.WriteLine("Byebye");
									isfut2 = false;
									break;
							}
						}
						while(isfut2);
						break;
				}
			}
            while (isfut1);
                 
        }
    }
}
