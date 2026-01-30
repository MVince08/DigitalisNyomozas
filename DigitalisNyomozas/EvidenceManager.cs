using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class EvidenceManager
	{
		private List<Evidence> evidenceList;

		public EvidenceManager(List<Evidence> evidenceList)
		{
			this.evidenceList = evidenceList;
		}

		internal List<Evidence> EvidenceList { get => evidenceList; set => evidenceList = value; }

	}
}
