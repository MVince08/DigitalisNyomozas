using System.Linq;

namespace DigitalisNyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStorage d1 = new DataStorage();
            CaseManager c1 = new CaseManager(d1);
			EvidenceManager e1 = new EvidenceManager(d1);
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
										else
										{ 
											Console.WriteLine("Nincs ilyen ügy!");
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
							Console.WriteLine("1. Személy felvétele\n2. Személyek listázása\n3. Kilépés");
							do
							{
								beker = int.Parse(Console.ReadLine());
							}
							while (beker < 1 && beker > 5);
							switch (beker)
							{
								case 1://Személy létrehozása
                                    c1.SzemelyHozzaadas();
									break;
                                case 2://Személyek kilistázása
                                    c1.ListFelhasznalo();
                                    break;
                                case 3:
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
							Console.WriteLine("1. Bizonyítékok rögzítése\n2. Bizonyíték törlése\n3. Bizonyítékok kilistázása\n4. Kilépés");
							do
							{
								beker = int.Parse(Console.ReadLine());
							}
							while(beker < 1 && beker > 5);
							switch (beker)
							{
								case 1://Bizonyíték létrehozása
                                    e1.AddEvidence();
									break;
                                case 2://Bizonyíték törlése
                                    Console.WriteLine("Bizonyítékok törlését választotta.");
									Console.WriteLine("Melyik bizonyítékot akarja törölni? (Bizonyítékok azonosítója)");
									string bizonyitekBekeres = Console.ReadLine();

									for (int i = 0;e1.Evidence.Count > i; i++)
									{
										if (e1.Evidence[i].Azonosito == bizonyitekBekeres)
										{
											e1.RemoveEvidence(e1.Evidence[i]);
										}
                                    }

                                    break;
								case 3://Bizonyítékok kilistázása
                                    e1.ListEvidences();
									break;
                                case 4:
									Console.WriteLine("Byebye");
									isfut2 = false;
									break;
							}
						}
						while(isfut2);
						break;
					case 6: //Kilépés
                        Console.WriteLine("Byebye");
						isfut1 = false;
						break;
				}
			}
            while (isfut1);
        }
    }
}
