using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class EvidenceManager
	{
		List<Evidence> evidence = new List<Evidence>();

		public EvidenceManager()
		{

		}

		public List<Evidence> Evidence { get => evidence; set => evidence = value; }

		public void AddEvidence(string azonosito, string tipus, string leiras, int megbizhatosag)
		{
			evidence.Add(new Evidence(azonosito, tipus, leiras, megbizhatosag));
		}

		public void RemoveEvidence(Evidence e)
		{
			//evidenceList.Remove(e);
		}
	}
}
