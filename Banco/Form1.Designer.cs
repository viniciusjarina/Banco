﻿namespace Banco
{
	partial class Form1
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
			this.totalizarTributosButton = new System.Windows.Forms.Button();
			this.totalizarContasButton = new System.Windows.Forms.Button();
			this.sacaButton = new System.Windows.Forms.Button();
			this.depositaButton = new System.Windows.Forms.Button();
			this.valorText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.numeroText = new System.Windows.Forms.TextBox();
			this.saldoText = new System.Windows.Forms.TextBox();
			this.titularText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cadastrarContaButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.comboContas = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBuscaTitular = new System.Windows.Forms.TextBox();
			this.buscaButton = new System.Windows.Forms.Button();
			this.relatorioButton = new System.Windows.Forms.Button();
			this.buttonXML = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonXML);
			this.groupBox1.Controls.Add(this.relatorioButton);
			this.groupBox1.Controls.Add(this.totalizarTributosButton);
			this.groupBox1.Controls.Add(this.totalizarContasButton);
			this.groupBox1.Controls.Add(this.sacaButton);
			this.groupBox1.Controls.Add(this.depositaButton);
			this.groupBox1.Controls.Add(this.valorText);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.numeroText);
			this.groupBox1.Controls.Add(this.saldoText);
			this.groupBox1.Controls.Add(this.titularText);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(17, 95);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(409, 269);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Conta";
			// 
			// totalizarTributosButton
			// 
			this.totalizarTributosButton.Location = new System.Drawing.Point(291, 239);
			this.totalizarTributosButton.Name = "totalizarTributosButton";
			this.totalizarTributosButton.Size = new System.Drawing.Size(104, 23);
			this.totalizarTributosButton.TabIndex = 11;
			this.totalizarTributosButton.Text = "Tota&lizar Tributos";
			this.totalizarTributosButton.UseVisualStyleBackColor = true;
			this.totalizarTributosButton.Click += new System.EventHandler(this.totalizarTributosButton_Click);
			// 
			// totalizarContasButton
			// 
			this.totalizarContasButton.Location = new System.Drawing.Point(291, 205);
			this.totalizarContasButton.Name = "totalizarContasButton";
			this.totalizarContasButton.Size = new System.Drawing.Size(104, 23);
			this.totalizarContasButton.TabIndex = 10;
			this.totalizarContasButton.Text = "T&otalizar Contas";
			this.totalizarContasButton.UseVisualStyleBackColor = true;
			this.totalizarContasButton.Click += new System.EventHandler(this.totalizarContasButton_Click);
			// 
			// sacaButton
			// 
			this.sacaButton.Location = new System.Drawing.Point(105, 205);
			this.sacaButton.Name = "sacaButton";
			this.sacaButton.Size = new System.Drawing.Size(75, 23);
			this.sacaButton.TabIndex = 9;
			this.sacaButton.Text = "S&aca";
			this.sacaButton.UseVisualStyleBackColor = true;
			this.sacaButton.Click += new System.EventHandler(this.sacaButton_Click);
			// 
			// depositaButton
			// 
			this.depositaButton.Location = new System.Drawing.Point(21, 205);
			this.depositaButton.Name = "depositaButton";
			this.depositaButton.Size = new System.Drawing.Size(75, 23);
			this.depositaButton.TabIndex = 8;
			this.depositaButton.Text = "&Depositar";
			this.depositaButton.UseVisualStyleBackColor = true;
			this.depositaButton.Click += new System.EventHandler(this.depositaButton_Click);
			// 
			// valorText
			// 
			this.valorText.Location = new System.Drawing.Point(80, 157);
			this.valorText.Name = "valorText";
			this.valorText.Size = new System.Drawing.Size(315, 20);
			this.valorText.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "&Valor";
			// 
			// numeroText
			// 
			this.numeroText.Location = new System.Drawing.Point(80, 60);
			this.numeroText.Name = "numeroText";
			this.numeroText.ReadOnly = true;
			this.numeroText.Size = new System.Drawing.Size(315, 20);
			this.numeroText.TabIndex = 3;
			// 
			// saldoText
			// 
			this.saldoText.Location = new System.Drawing.Point(80, 95);
			this.saldoText.Name = "saldoText";
			this.saldoText.ReadOnly = true;
			this.saldoText.Size = new System.Drawing.Size(315, 20);
			this.saldoText.TabIndex = 5;
			// 
			// titularText
			// 
			this.titularText.Location = new System.Drawing.Point(80, 27);
			this.titularText.Name = "titularText";
			this.titularText.ReadOnly = true;
			this.titularText.Size = new System.Drawing.Size(315, 20);
			this.titularText.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "&Saldo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Número";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Titular";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buscaButton);
			this.groupBox2.Controls.Add(this.textBuscaTitular);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.cadastrarContaButton);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.comboContas);
			this.groupBox2.Location = new System.Drawing.Point(17, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(409, 76);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "&Busca";
			// 
			// cadastrarContaButton
			// 
			this.cadastrarContaButton.Location = new System.Drawing.Point(320, 19);
			this.cadastrarContaButton.Name = "cadastrarContaButton";
			this.cadastrarContaButton.Size = new System.Drawing.Size(75, 23);
			this.cadastrarContaButton.TabIndex = 2;
			this.cadastrarContaButton.Text = "Cadastrar...";
			this.cadastrarContaButton.UseVisualStyleBackColor = true;
			this.cadastrarContaButton.Click += new System.EventHandler(this.cadastrarContaButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Conta";
			// 
			// comboContas
			// 
			this.comboContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboContas.FormattingEnabled = true;
			this.comboContas.Location = new System.Drawing.Point(118, 20);
			this.comboContas.Name = "comboContas";
			this.comboContas.Size = new System.Drawing.Size(196, 21);
			this.comboContas.TabIndex = 1;
			this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(22, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "&Busca por Nome:";
			// 
			// textBuscaTitular
			// 
			this.textBuscaTitular.Location = new System.Drawing.Point(118, 48);
			this.textBuscaTitular.Name = "textBuscaTitular";
			this.textBuscaTitular.Size = new System.Drawing.Size(196, 20);
			this.textBuscaTitular.TabIndex = 4;
			// 
			// buscaButton
			// 
			this.buscaButton.Location = new System.Drawing.Point(320, 46);
			this.buscaButton.Name = "buscaButton";
			this.buscaButton.Size = new System.Drawing.Size(75, 23);
			this.buscaButton.TabIndex = 5;
			this.buscaButton.Text = "B&uscar";
			this.buscaButton.UseVisualStyleBackColor = true;
			this.buscaButton.Click += new System.EventHandler(this.buscaButton_Click);
			// 
			// relatorioButton
			// 
			this.relatorioButton.Location = new System.Drawing.Point(21, 238);
			this.relatorioButton.Name = "relatorioButton";
			this.relatorioButton.Size = new System.Drawing.Size(75, 23);
			this.relatorioButton.TabIndex = 12;
			this.relatorioButton.Text = "&Relatório...";
			this.relatorioButton.UseVisualStyleBackColor = true;
			this.relatorioButton.Click += new System.EventHandler(this.relatorioButton_Click);
			// 
			// buttonXML
			// 
			this.buttonXML.Location = new System.Drawing.Point(105, 238);
			this.buttonXML.Name = "buttonXML";
			this.buttonXML.Size = new System.Drawing.Size(93, 23);
			this.buttonXML.TabIndex = 13;
			this.buttonXML.Text = "&Como XML...";
			this.buttonXML.UseVisualStyleBackColor = true;
			this.buttonXML.Click += new System.EventHandler(this.buttonXML_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 376);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Banco Caelum";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox numeroText;
		private System.Windows.Forms.TextBox saldoText;
		private System.Windows.Forms.TextBox titularText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox valorText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button totalizarContasButton;
		private System.Windows.Forms.Button sacaButton;
		private System.Windows.Forms.Button depositaButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboContas;
		private System.Windows.Forms.Button cadastrarContaButton;
		private System.Windows.Forms.Button totalizarTributosButton;
		private System.Windows.Forms.Button buscaButton;
		private System.Windows.Forms.TextBox textBuscaTitular;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button relatorioButton;
		private System.Windows.Forms.Button buttonXML;
	}
}

