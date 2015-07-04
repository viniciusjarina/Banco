using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class Cliente
	{
		public Cliente ()
		{

		}

		public Cliente (string nome)
		{
			Nome = nome;
		}
		public string Nome { get; set; }

		public int Idade { get; set; }
		public string  CPF { get; set; }
	}
}
