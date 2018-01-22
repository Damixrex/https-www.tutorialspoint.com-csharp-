using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141293
{
	class Skladnik:IComparable<Skladnik>
	{
		protected string nazwaSkladnika;
		protected double cenaSkladnika;

		public Skladnik(string nazwa, double cena)
		{
			this.nazwaSkladnika = nazwa;
			this.cenaSkladnika = cena;

		}
		public override string ToString()
		{
			return "Skladnik: " +
				"" + nazwaSkladnika + " Cena: " + cenaSkladnika;
		}
		public double PobierzCene()
		{
			return cenaSkladnika;
		}

		public int CompareTo(Skladnik other)
		{
			return cenaSkladnika.CompareTo(cenaSkladnika);
		}
	}
}
