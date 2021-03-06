﻿using Banco.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
	public abstract class Conta
	{
		static int numeroDeContas;

		public Conta ()
		{
			Conta.numeroDeContas++;
			Titular = new Cliente ();
			Numero = Conta.numeroDeContas;
		}

		public static int ProximaConta ()
		{
			return Conta.numeroDeContas + 1;
		}

		public int Numero { get; set; }

		public double  Saldo { get; set; }

		public Cliente Titular { get; set; }

		public abstract void Saca (double valor);

		public virtual void Deposita (double valor)
		{
			Saldo += valor;
		}

		public void Transfere (Conta destino, double valor)
		{
			Conta origem = this;
			// Primeiro faz o saque da própria conta (this)
			this.Saca (valor);
		 // origem.Saca (valor);

			destino.Deposita (valor);
		}

		public virtual void CalculaRendimento ()
		{

		}

		public override bool Equals (object obj)
		{
			Conta conta = obj as Conta;
			return conta != null && this.Numero == conta.Numero;
		}

		public override string ToString ()
		{
			return "Titular: " + Titular.Nome;
		}
	}
}
