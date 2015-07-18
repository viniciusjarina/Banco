using Banco.Busca;
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
	public partial class EditarConta : Form
	{
		private ICollection<string> devedores;
		public EditarConta ()
		{
			InitializeComponent ();

			GeradorDeDevedores gerador = new GeradorDeDevedores ();
			devedores = gerador.GeraList ();
		}

		private void okButton_Click (object sender, EventArgs e)
		{
			string nome = titularNome.Text;
			bool devedor = devedores.Contains (nome);
			if (!devedor) {
				DialogResult = DialogResult.OK;
				Close ();
				return;
			}
			MessageBox.Show ("Cliente devedor, não é possível criar conta");
		}
	}
}
