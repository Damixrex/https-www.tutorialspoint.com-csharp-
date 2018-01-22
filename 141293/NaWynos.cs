using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141293
{
	class NaWynos:Zamowienie
	{
		public override bool PoprawnyCzas(string czasDostawy)
		{
			if (czasDostawy == "jutro")
				return true;

			return false;
		}
	}
}
