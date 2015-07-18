using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorDeTexto
{
	public partial class Form1 : Form
	{
		public Form1 ()
		{
			InitializeComponent ();
		}

		private void gravarButton_Click (object sender, EventArgs e)
		{
			using (Stream saida = File.Open ("texto.txt", FileMode.Create)) {
				using (StreamWriter escritor = new StreamWriter (saida)) {
					escritor.Write (textoConteudo.Text);
				}
			}
			
			// Ou ainda
			// File.WriteAllText ("texto.txt", textoConteudo.Text);
		}

		private void Form1_Load (object sender, EventArgs e)
		{
			if (!File.Exists ("texto.txt"))
				return;

			using (Stream entrada = File.Open ("texto.txt", FileMode.Open)) {
				using (StreamReader leitor = new StreamReader (entrada)) {
					string conteudo = leitor.ReadToEnd ();
					textoConteudo.Text = conteudo;
				}
			}

			// Ou poderíamos usar ReadAddText se o arquivo fosse pequeno.
			// textoConteudo.Text = File.ReadAllText ("texto.txt");
		}
	}
}
