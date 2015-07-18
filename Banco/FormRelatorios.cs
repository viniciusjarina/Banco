using Banco.Contas;
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
	public partial class FormRelatorios : Form
	{
		List<Conta> contas;

		public FormRelatorios (List<Conta> contas)
		{
			InitializeComponent ();
			this.contas = contas;
		}

		private void buttonFiltroSaldo_Click (object sender, EventArgs e)
		{
			listResultado.Items.Clear ();
			var resultado = contas.Where (c => c.Saldo > 5000).OrderBy (c => c.Titular.Nome);
			// Ou ainda poderíamos utilizar Sintaxe de Query:
// 			var resultado = from c in contas where c.Saldo > 5000 
// 										     orderby c.Titular.Nome
// 											 select c;

			if (resultado.Count () == 0) {
				listResultado.Items.Add ("Nenhuma conta encontrada");
				labelSaldoTotal.Text = "";
				labelMaiorSaldo.Text = "";
				return;
			}

			foreach (var conta in resultado)
				listResultado.Items.Add (conta);

			double saldoTotal = resultado.Sum (conta => conta.Saldo);
			double maiorSaldo = resultado.Max (conta => conta.Saldo);

			labelSaldoTotal.Text = Convert.ToString (saldoTotal);
			labelMaiorSaldo.Text = Convert.ToString (maiorSaldo);
		}

		private void FormRelatorios_Load (object sender, EventArgs e)
		{
		}

		private void buttonAntigas_Click (object sender, EventArgs e)
		{
			listResultado.Items.Clear ();
			var resultado = contas.Where (c => c.Numero < 10 && c.Saldo > 1000 );
			foreach (var conta in resultado)
				listResultado.Items.Add (conta);

			double saldoTotal = resultado.Sum (conta => conta.Saldo);
			double maiorSaldo = resultado.Max (conta => conta.Saldo);

			labelSaldoTotal.Text = Convert.ToString (saldoTotal);
			labelMaiorSaldo.Text = Convert.ToString (maiorSaldo);
		}
	}
}
