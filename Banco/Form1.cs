﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
	public partial class Form1 : Form
	{
		Conta [] contas;
		int contaSelectionada = -1;

		public Form1 ()
		{
			InitializeComponent ();
		}

		private void depositaButton_Click (object sender, EventArgs e)
		{
			if (contaSelectionada == -1) {
				MessageBox.Show ("Por favor selecione alguma conta para realizar a operação");
				return;
			}

			if (string.IsNullOrEmpty (valorText.Text)) {
				MessageBox.Show ("Por favor informar o valor a ser depositado");
				return;
			}

			Conta conta = contas [contaSelectionada];

			double valor = Convert.ToDouble (valorText.Text);
			conta.Deposita (valor);

			AtualizaSaldoDaConta ();
		}

		private void sacaButton_Click (object sender, EventArgs e)
		{
			if (contaSelectionada == -1) {
				MessageBox.Show ("Por favor selecione alguma conta para realizar a operação");
				return;
			}

			if (string.IsNullOrEmpty (valorText.Text)) {
				MessageBox.Show ("Por favor informar o valor a ser sacado");
				return;
			}

			Conta conta = contas [contaSelectionada];

			double valor = Convert.ToDouble (valorText.Text);
			bool saqueOk = conta.Saca (valor);
			if (!saqueOk) {
				MessageBox.Show ("Não foi possível sacar, verifique o saldo");
				return;
			}

			AtualizaSaldoDaConta ();
		}

		private void totalizarContasButton_Click (object sender, EventArgs e)
		{
			// Rotina de teste do TotalizadorDeContas
			Conta conta1 = new ContaCorrente ();
			conta1.Deposita (100);

			Conta conta2 = new ContaCorrente ();
			conta2.Deposita (300);

			Conta conta3 = new ContaPoupanca ();
			conta3.Deposita (1000);

			var totalizador = new TotalizadorDeContas ();
			totalizador.Soma (conta1);
			totalizador.Soma (conta2);
			totalizador.Soma (conta3);
		}

		void AtualizarDadosDaConta ()
		{
			titularText.Text = "";
			numeroText.Text = "";
			// Se nenhuma conta esta selecionada só apaga o campo Valor.
			if (contaSelectionada == -1)
				return;

			Conta conta = contas [contaSelectionada];

			titularText.Text = conta.Titular.Nome;
			numeroText.Text = Convert.ToString (conta.Numero);
		}


		void AtualizaSaldoDaConta ()
		{
			valorText.Text = "";
			// Se nenhuma conta esta selecionada só apaga o campo Valor.
			if (contaSelectionada == -1)
				return;

			Conta conta = contas [contaSelectionada];
			saldoText.Text = Convert.ToString (conta.Saldo);
		}

		void AtualizaConta ()
		{
			AtualizarDadosDaConta ();
			AtualizaSaldoDaConta ();
		}

		void AtualizaComboContas ()
		{
			foreach (Conta conta in contas) {
				if (conta == null)
					break;
				comboContas.Items.Add (conta.Titular.Nome);
			}
		}

		private void Form1_Load (object sender, EventArgs e)
		{
			contas = new Conta [10];
			// Form1_Load é chamado quando exibimos o nosso Form pela primeira vez
			this.contas [0] = new ContaCorrente (1);
			this.contas [0].Titular.Nome = "Anders Hejlsberg";
			this.contas [0].Deposita (1000.1);

			this.contas [1] = new ContaCorrente (2);
			this.contas [1].Titular.Nome = "Guilherme Silveira";
			this.contas [1].Deposita (200);

			this.contas [2] = new ContaPoupanca (3);
			this.contas [2].Titular.Nome = "Mauricio Aniche";
			this.contas [2].Deposita (300);

			this.contas [3] = new ContaCorrente (4);
			this.contas [3].Titular.Nome = "Victor Harada";

			AtualizaConta ();
			AtualizaComboContas ();

			comboContas.SelectedIndex = 0;
		}

		private void comboContas_SelectedIndexChanged (object sender, EventArgs e)
		{
			contaSelectionada = comboContas.SelectedIndex;

			AtualizaConta ();
		}
	}
}