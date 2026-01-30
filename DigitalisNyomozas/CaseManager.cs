using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class CaseManager
	{
		List<Case> ugyek;

		public CaseManager(List<Case> ugyek)
		{
			this.ugyek = ugyek;
		}

		public List<Case> Ugyek { get => ugyek; set => ugyek = value; }
	}
}
