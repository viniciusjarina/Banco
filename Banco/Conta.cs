using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
	public class Conta
	{
		public Conta ()
		{
			Titular = new Cliente ();
		}

		public Conta (int numero):this()
		{
			Numero = numero;
		}
		public int Numero { get; set; }

		public double  Saldo { get; private set; }

		public Cliente Titular { get; set; }

		public virtual bool Saca (double valor)
		{
			if (valor > Saldo)
				return false;
			Saldo -= valor;
			return true;
		}

		public virtual void Deposita (double valor)
		{
			Saldo += valor;
		}

		public bool Transfere (Conta destino, double valor)
		{
			Conta origem = this;
			// Primeiro faz o saque da própria conta (this)
			bool saqueOk = this.Saca (valor);
		 // bool saqueOk = origem.Saca (valor);
			if (!saqueOk)
				return false; // Caso o saque tenha falhado.
			destino.Deposita (valor);
			return true;
		}

		public virtual void CalculaRendimento ()
		{

		}
	}
}
