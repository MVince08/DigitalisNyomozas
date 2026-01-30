using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Witness
	{
		private Person person;
		private string vallomasSzoveg;
		private string vallomasDatum;

		public Witness(Person person, string vallomasSzoveg, string vallomasDatum)
		{
			this.person = person;
			this.vallomasSzoveg = vallomasSzoveg;
			this.vallomasDatum = vallomasDatum;
		}

		public string VallomasSzoveg { get => vallomasSzoveg; set => vallomasSzoveg = value; }
		public string VallomasDatum1 { get => vallomasDatum; set => vallomasDatum = value; }
		internal Person Person { get => person; set => person = value; }
	}
}
