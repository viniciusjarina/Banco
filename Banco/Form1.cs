using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;
using Banco.Seguros;
using Banco.Tributos;

namespace Banco
{
	public partial class Form1 : Form
	{
		List<Conta> contas = new List<Conta> ();
		Conta contaSelectionada = null;

		public Form1 ()
		{
			InitializeComponent ();
		}

		private void depositaButton_Click (object sender, EventArgs e)
		{
			if (contaSelectionada == null) {
				MessageBox.Show ("Por favor selecione alguma conta para realizar a operação");
				return;
			}

			if (string.IsNullOrEmpty (valorText.Text)) {
				MessageBox.Show ("Por favor informar o valor a ser depositado");
				return;
			}

			Conta conta = contaSelectionada;

			double valor = Convert.ToDouble (valorText.Text);
			conta.Deposita (valor);

			AtualizaSaldoDaConta ();
		}

		private void sacaButton_Click (object sender, EventArgs e)
		{
			if (contaSelectionada == null) {
				MessageBox.Show ("Por favor selecione alguma conta para realizar a operação");
				return;
			}

			if (string.IsNullOrEmpty (valorText.Text)) {
				MessageBox.Show ("Por favor informar o valor a ser sacado");
				return;
			}

			Conta conta = contaSelectionada;

			double valor = Convert.ToDouble (valorText.Text);

			if (valor <= 0.0) {
				MessageBox.Show ("Valor inválido a ser sacado");
				return;
			}
			try {
				conta.Saca (valor);
			} catch (SaldoInsuficienteException) {
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
			if (contaSelectionada == null)
				return;

			Conta conta = contaSelectionada;

			titularText.Text = conta.Titular.Nome;
			numeroText.Text = Convert.ToString (conta.Numero);
		}


		void AtualizaSaldoDaConta ()
		{
			valorText.Text = "";
			// Se nenhuma conta esta selecionada só apaga o campo Valor.
			if (contaSelectionada == null)
				return;

			Conta conta = contaSelectionada;
			saldoText.Text = Convert.ToString (conta.Saldo);
		}

		void AtualizaConta ()
		{
			AtualizarDadosDaConta ();
			AtualizaSaldoDaConta ();
		}

		void AtualizaComboContas ()
		{
			// Remove os elementos existentes antes de atualizar.
			comboContas.Items.Clear ();

			foreach (Conta conta in contas)
				comboContas.Items.Add (conta);
		}

		private void Form1_Load (object sender, EventArgs e)
		{
			// Form1_Load é chamado quando exibimos o nosso Form pela primeira vez
			Conta conta = new ContaCorrente ();
			conta.Titular.Nome = "Anders Hejlsberg";
			conta.Deposita (1000.1);
			contas.Add (conta);

			conta = new ContaCorrente ();
			conta.Titular.Nome = "Guilherme Silveira";
			conta.Deposita (200);
			contas.Add (conta);

			conta = new ContaPoupanca ();
			conta.Titular.Nome = "Mauricio Aniche";
			conta.Deposita (300);
			contas.Add (conta);

			conta = new ContaCorrente ();
			conta.Titular.Nome = "Victor Harada";
			contas.Add (conta);

			AtualizaConta ();
			AtualizaComboContas ();

			comboContas.SelectedIndex = 0;
		}

		private void comboContas_SelectedIndexChanged (object sender, EventArgs e)
		{
			contaSelectionada = (Conta)comboContas.SelectedItem;

			AtualizaConta ();
		}

		private void cadastrarContaButton_Click (object sender, EventArgs e)
		{
			EditarConta editar = new EditarConta ();
			editar.numeroConta.Value = Conta.ProximaConta ();
			var result = editar.ShowDialog ();
			if (result != DialogResult.OK)
				return;

			Conta novaConta = new ContaCorrente ();
			novaConta.Titular.Nome = editar.titularNome.Text;
			contas.Add(novaConta);

			AtualizaComboContas ();
		}

		private void totalizarTributosButton_Click (object sender, EventArgs e)
		{
			ContaCorrente conta = new ContaCorrente (); conta.Deposita (200.0);

			SeguroDeVida sv = new SeguroDeVida ();
			TotalizadorDeTributos totalizador = new TotalizadorDeTributos (); 
			totalizador.Adiciona (conta);
			MessageBox.Show ("Total: " + totalizador.Total); 
			totalizador.Adiciona (sv);
			MessageBox.Show ("Total: " + totalizador.Total);
		}
	}
}
