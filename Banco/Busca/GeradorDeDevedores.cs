using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Busca
{
	public class GeradorDeDevedores
	{
		public HashSet<string> GeraList()
		{
			HashSet<string> nomes = new HashSet<string> (); for (int i = 0 ; i < 30000 ; i++)
				nomes.Add ("devedor " + i);
			
			return nomes;
		}
	}
}
