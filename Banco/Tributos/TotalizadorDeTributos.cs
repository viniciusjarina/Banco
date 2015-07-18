using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Tributos
{
	public class TotalizadorDeTributos
	{
		public double Total { get; private set; }
		public void Adiciona (ITributavel t)
		{
			this.Total += t.CalculaTributos ();
		}
	}
}
