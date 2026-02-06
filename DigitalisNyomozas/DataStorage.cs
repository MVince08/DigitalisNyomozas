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

		public DataStorage()
		{
			this.felhasznalo = [];
			this.ugyek = [];
			this.szemelyek = [];
			this.bizonyitekok = [];
		}

		public List<Felhasznalo> Felhasznalo { get => felhasznalo; set => felhasznalo = value; }
		public List<Case> Ugyek { get { return ugyek; } }
		public List<Person> Szemelyek { get => szemelyek; set => szemelyek = value; }
		public List<Evidence> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
	}
}
