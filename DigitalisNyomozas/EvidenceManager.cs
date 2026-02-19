using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class EvidenceManager
	{
		DataStorage d1 = null;

        public EvidenceManager(DataStorage d1)
		{
			this.d1 = d1;
        }

        public void AddEvidence()//string ugyAzonosito, string cim, string leiras, string allapot)
        {
            Console.WriteLine("Adja meg a bizonyíték azonosítóját: ");
            string evidenceAzonosito= Console.ReadLine();
            Console.WriteLine("Adja meg a bizonyíték típusát: ");
            string evidenceTipus= Console.ReadLine();
            Console.WriteLine("Adja meg a bizonyíték leírását: ");
            string evidenceLeiras = Console.ReadLine();
            Console.WriteLine("Adja meg a bizonyíték megbizhatóságát(1-5): ");
            int evidenceAllapot = int.Parse(Console.ReadLine());
            d1.Bizonyitekok.Add(new Evidence(evidenceAzonosito, evidenceTipus, evidenceLeiras, evidenceAllapot));
        }

        public void RemoveEvidence(Evidence e)
		{
			d1.Bizonyitekok.Remove(e);
        }

        public void ListEvidences()
        {
            Console.WriteLine("Bizonyítékok kilistázását választotta.");
            foreach (var item in d1.Bizonyitekok)
            {
                Console.WriteLine(item);
            }
        }
    }
}
