using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class Person
	{
		private string name;
		private int age;
		private string megjegyzes;

		public Person(string name, int age, string megjegyzes)
		{
			this.name = name;
			this.age = age;
			this.megjegyzes = megjegyzes;
		}

		public string Name { get => name; set => name = value; }
		public int Age { get => age; set => age = value; }
		public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }
	}
}
