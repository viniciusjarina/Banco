namespace Banco
{
	partial class FormRelatorios
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listResultado = new System.Windows.Forms.ListBox();
			this.buttonFiltroSaldo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelSaldoTotal = new System.Windows.Forms.Label();
			this.labelMaiorSaldo = new System.Windows.Forms.Label();
			this.buttonAntigas = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonAntigas);
			this.groupBox1.Controls.Add(this.labelMaiorSaldo);
			this.groupBox1.Controls.Add(this.labelSaldoTotal);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.buttonFiltroSaldo);
			this.groupBox1.Controls.Add(this.listResultado);
			this.groupBox1.Location = new System.Drawing.Point(13, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(600, 242);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// listResultado
			// 
			this.listResultado.FormattingEnabled = true;
			this.listResultado.Location = new System.Drawing.Point(6, 19);
			this.listResultado.Name = "listResultado";
			this.listResultado.Size = new System.Drawing.Size(588, 134);
			this.listResultado.TabIndex = 0;
			// 
			// buttonFiltroSaldo
			// 
			this.buttonFiltroSaldo.Location = new System.Drawing.Point(6, 213);
			this.buttonFiltroSaldo.Name = "buttonFiltroSaldo";
			this.buttonFiltroSaldo.Size = new System.Drawing.Size(101, 23);
			this.buttonFiltroSaldo.TabIndex = 1;
			this.buttonFiltroSaldo.Text = "Saldo > 5000";
			this.buttonFiltroSaldo.UseVisualStyleBackColor = true;
			this.buttonFiltroSaldo.Click += new System.EventHandler(this.buttonFiltroSaldo_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Saldo Total:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(7, 183);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Maior Saldo:";
			// 
			// labelSaldoTotal
			// 
			this.labelSaldoTotal.AutoSize = true;
			this.labelSaldoTotal.Location = new System.Drawing.Point(121, 160);
			this.labelSaldoTotal.Name = "labelSaldoTotal";
			this.labelSaldoTotal.Size = new System.Drawing.Size(0, 13);
			this.labelSaldoTotal.TabIndex = 4;
			this.labelSaldoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelMaiorSaldo
			// 
			this.labelMaiorSaldo.AutoSize = true;
			this.labelMaiorSaldo.Location = new System.Drawing.Point(121, 183);
			this.labelMaiorSaldo.Name = "labelMaiorSaldo";
			this.labelMaiorSaldo.Size = new System.Drawing.Size(0, 13);
			this.labelMaiorSaldo.TabIndex = 5;
			this.labelMaiorSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonAntigas
			// 
			this.buttonAntigas.Location = new System.Drawing.Point(113, 213);
			this.buttonAntigas.Name = "buttonAntigas";
			this.buttonAntigas.Size = new System.Drawing.Size(101, 23);
			this.buttonAntigas.TabIndex = 6;
			this.buttonAntigas.Text = "Antigas";
			this.buttonAntigas.UseVisualStyleBackColor = true;
			this.buttonAntigas.Click += new System.EventHandler(this.buttonAntigas_Click);
			// 
			// FormRelatorios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(625, 258);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormRelatorios";
			this.Text = "FormRelatorios";
			this.Load += new System.EventHandler(this.FormRelatorios_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonFiltroSaldo;
		private System.Windows.Forms.ListBox listResultado;
		private System.Windows.Forms.Label labelMaiorSaldo;
		private System.Windows.Forms.Label labelSaldoTotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAntigas;
	}
}