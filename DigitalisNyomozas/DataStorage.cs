using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class DataStorage
	{
		private List<Felhasznalo> felhasznalo;
		private List<Case> ugyek;
		private List<Person> szemelyek;
		private List<Evidence> bizonyitekok;

		public DataStorage(List<Felhasznalo> felhasznalo, List<Case> ugyek, List<Person> szemelyek, List<Evidence> bizonyitekok)
		{
			this.felhasznalo = felhasznalo;
			this.ugyek = ugyek;
			this.szemelyek = szemelyek;
			this.bizonyitekok = bizonyitekok;
		}

		internal List<Felhasznalo> Felhasznalo { get => felhasznalo; set => felhasznalo = value; }
		internal List<Case> Ugyek { get => ugyek; set => ugyek = value; }
		internal List<Person> Szemelyek { get => szemelyek; set => szemelyek = value; }
		internal List<Evidence> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
	}
}
