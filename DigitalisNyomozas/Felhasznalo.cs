using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Felhasznalo
	{
		private string name;
		private string azonosito;
		private string description;

		public Felhasznalo(string name, string azonosito, string description)
		{
			this.name = name;
			this.azonosito = azonosito;
			this.description = description;
		}

		public string Name { get => name; set => name = value; }
		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Description { get => description; set => description = value; }
	}
}
