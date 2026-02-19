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

					beker = int.Parse(Console.ReadLine());


				switch (beker)
				{
					case 1: // Ügyek kezelése
						c1.Menu();
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

									for (int i = 0;d1.Bizonyitekok.Count > i; i++)
									{
										if (d1.Bizonyitekok[i].Azonosito == bizonyitekBekeres)
										{
											e1.RemoveEvidence(d1.Bizonyitekok[i]);
										}
										else
										{
                                            Console.WriteLine("Nincs ilyen bizonyíték");
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
