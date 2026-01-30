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
		private int vallomasDatum;

		public Witness(Person person, string vallomasSzoveg, int vallomasDatum)
		{
			this.person = person;
			this.vallomasSzoveg = vallomasSzoveg;
			this.vallomasDatum = vallomasDatum;
		}

		public string VallomasSzoveg { get => vallomasSzoveg; set => vallomasSzoveg = value; }
		public int VallomasDatum { get => vallomasDatum; set => vallomasDatum = value; }
		internal Person Person { get => person; set => person = value; }
	}
}
