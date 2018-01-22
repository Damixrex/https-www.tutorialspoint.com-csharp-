using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141293
{
	class Pizza : Iprzepis
	{
		private List<string> przepis = new List<string>();

		public void DodajDoPrzepisu()
		{
			przepis.Add("przykladowy");
			
		}
		public void Wypisz()
		{
			foreach (var e in przepis)
			{
				Console.WriteLine(e);
			}
		}
	}
}
