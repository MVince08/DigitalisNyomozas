using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class CaseStatus
	{
		private string aktualisStatus;

		public CaseStatus(string aktualisStatus)
		{
			this.aktualisStatus = aktualisStatus;
		}

		public string AktualisStatus { get => aktualisStatus; set => aktualisStatus = value; }
	}
}
