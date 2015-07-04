using System;
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
		Conta conta;
		public Form1 ()
		{
			InitializeComponent ();
		}

		private void depositaButton_Click (object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty (valorText.Text)) {
				MessageBox.Show ("Por favor informar o valor a ser depositado");
				return;
			}

			double valor = Convert.ToDouble (valorText.Text);
			conta.Deposita (valor);

			AtualizaSaldoDaConta ();
		}

		private void sacaButton_Click (object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty (valorText.Text)) {
				MessageBox.Show ("Por favor informar o valor a ser sacado");
				return;
			}

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

		void AtualizaSaldoDaConta ()
		{
			valorText.Text = "";

			saldoText.Text = Convert.ToString (conta.Saldo);
		}

		private void Form1_Load (object sender, EventArgs e)
		{
			// Form1_Load é chamado quando exibimos o nosso Form pela primeira vez
			this.conta = new ContaCorrente(1);
			this.conta.Titular.Nome = "Anders Hejlsberg";
			this.conta.Deposita(1000.1);

			titularText.Text = conta.Titular.Nome;
			numeroText.Text = Convert.ToString(conta.Numero);

			AtualizaSaldoDaConta ();
		}
	}
}
