using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141293
{
	abstract class Zamowienie
	{
		protected string czasDostawy;


		public virtual bool PoprawnyCzas(string czasDostawy)
		{
			if (czasDostawy != null)
				return true;
			return false;
		}

		public void UstawCzasDostawy(string czasDostawy)
		{
			this.czasDostawy = czasDostawy;
		}
	}

}
