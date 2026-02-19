using System.Diagnostics.Metrics;

namespace DigitalisNyomozas
{
    internal class CaseManager
    {
        DataStorage d1 = null;


        public CaseManager(DataStorage d1)
        {
            this.d1 = d1;
        }

        public List<Case> Ugyek { get => d1.Ugyek; }

        public void MenuUgy()
        {
            int beker = 0;
            bool isfut2 = true;
            do
            {
                Console.WriteLine("Mit szeretne csinálni?");
                Console.WriteLine("1. Ügy felvétele\n2. Ügy állapota\n3. Ügy listázása\n4. Esemény felvétele \n5. Kilépés");
                beker = int.Parse(Console.ReadLine());

                switch (beker)
                {

                    case 1: // Ügy létrehozása
                        UgyLetrehozas();

                        break;
                    case 2: //Állapot megváltoztatása
                        UgyModositas();
                        break;

                    case 3://Ügy kilistázása
                        ListCases();
                        break;
                    case 4://Esemény felvétele
                        EsemenyHozzaadas();
                        break;
                    case 5:
                        Console.WriteLine("ByeBye");
                        isfut2 = false;
                        break;
                }
            }
            while (isfut2);
        }

        public void MenuSzemely()
        {
            int beker = 0;
            bool isfut2 = true;
            do
            {
                Console.WriteLine("Mit szeretne csinálni?");
                Console.WriteLine("1. Személy felvétele\n2. Személyek listázása\n3. Kilépés");
                beker = int.Parse(Console.ReadLine());
                switch (beker)
                {
                    case 1://Személy létrehozása
                        SzemelyHozzaadas();
                        break;
                    case 2://Személyek kilistázása
                        ListFelhasznalo();
                        break;
                    case 3:
                        Console.WriteLine("ByeBye");
                        isfut2 = false;
                        break;
                }
            }
            while (isfut2);
        }

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
            Case ugy = UgyKereses();
            if (ugy == null)
            {
                return;
            }
            Console.WriteLine("Adja meg a személy nevét");
            string szemelyneve = Console.ReadLine();
            Console.WriteLine("Adja meg a személy életkorát");
            int szemelyeletkora = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a személy megjegyzését");
            string szemelymegjegyzese = Console.ReadLine();
            Person person = new Person(szemelyneve, szemelyeletkora, szemelymegjegyzese);
            d1.Szemelyek.Add(person);
            ugy.Szemelyek.Add(person);
        }

        public void EsemenyHozzaadas()//string name, int age, string megjegyzes)
        {
            Console.WriteLine("Esemény felvételét választotta.");
            Case ugy = UgyKereses();
            if (ugy == null)
            {
                return;
            }
            Console.WriteLine("Adja meg az esemény dátumát");
            string esemenydatum = Console.ReadLine();
            Console.WriteLine("Adja meg az esemény leírását");
            string leiras = Console.ReadLine();
            TimeLineEvent person = new TimeLineEvent(esemenydatum, leiras);
            ugy.Esemenyek.Add(person);
        }

        public void CaseStatus(Case a)
        {

            string aktualisStatusz = "";
            aktualisStatusz = a.Allapot;
            Console.WriteLine($"Case aktuális státusza: {aktualisStatusz}");
            Console.WriteLine("Szeretnéd megváltotani az allapotot?(i)");
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
                    a.Allapot = aktualisStatusz;
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

        public void UgyModositas()
        {
            Case ugy = UgyKereses();
            if (ugy != null)
            {
                CaseStatus(ugy);
            }
        }

        public Case UgyKereses()
        {
            Console.WriteLine("Ugynek az Azonositóját kérem:  ");
            string ugyazonositoBekeres = Console.ReadLine();
            foreach (var item in d1.Ugyek)
            {
                if (item.UgyAzonosito == ugyazonositoBekeres)
                {
                    return item;
                }
            }
            Console.WriteLine("Nincs ilyen ügy");
            return null;
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
