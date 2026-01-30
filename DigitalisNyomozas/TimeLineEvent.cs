using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalisNyomozas
{
	internal class TimeLineEvent
	{
		private string date;
		private string esemenyLeiras;

		public TimeLineEvent(string date, string esemenyLeiras)
		{
			this.date = date;
			this.esemenyLeiras = esemenyLeiras;
		}

		public string Date { get => date; set => date = value; }
		public string EsemenyLeiras { get => esemenyLeiras; set => esemenyLeiras = value; }
	}
}
