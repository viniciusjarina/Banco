﻿namespace EditorDeTexto
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
			this.textoConteudo = new System.Windows.Forms.TextBox();
			this.gravarButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textoBusca = new System.Windows.Forms.TextBox();
			this.botaoBusca = new System.Windows.Forms.Button();
			this.textoReplace = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.botaoReplace = new System.Windows.Forms.Button();
			this.botaoUpper = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textoConteudo
			// 
			this.textoConteudo.Location = new System.Drawing.Point(13, 13);
			this.textoConteudo.Multiline = true;
			this.textoConteudo.Name = "textoConteudo";
			this.textoConteudo.Size = new System.Drawing.Size(395, 238);
			this.textoConteudo.TabIndex = 0;
			// 
			// gravarButton
			// 
			this.gravarButton.Location = new System.Drawing.Point(13, 264);
			this.gravarButton.Name = "gravarButton";
			this.gravarButton.Size = new System.Drawing.Size(75, 23);
			this.gravarButton.TabIndex = 1;
			this.gravarButton.Text = "&Gravar";
			this.gravarButton.UseVisualStyleBackColor = true;
			this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.botaoReplace);
			this.groupBox1.Controls.Add(this.textoReplace);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.botaoBusca);
			this.groupBox1.Controls.Add(this.textoBusca);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(94, 264);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(314, 103);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "&Find and Replace";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Find:";
			// 
			// textoBusca
			// 
			this.textoBusca.Location = new System.Drawing.Point(57, 20);
			this.textoBusca.Name = "textoBusca";
			this.textoBusca.Size = new System.Drawing.Size(251, 20);
			this.textoBusca.TabIndex = 1;
			// 
			// botaoBusca
			// 
			this.botaoBusca.Location = new System.Drawing.Point(9, 72);
			this.botaoBusca.Name = "botaoBusca";
			this.botaoBusca.Size = new System.Drawing.Size(75, 23);
			this.botaoBusca.TabIndex = 2;
			this.botaoBusca.Text = "Find...";
			this.botaoBusca.UseVisualStyleBackColor = true;
			this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
			// 
			// textoReplace
			// 
			this.textoReplace.Location = new System.Drawing.Point(57, 44);
			this.textoReplace.Name = "textoReplace";
			this.textoReplace.Size = new System.Drawing.Size(251, 20);
			this.textoReplace.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Replace:";
			// 
			// botaoReplace
			// 
			this.botaoReplace.Location = new System.Drawing.Point(91, 72);
			this.botaoReplace.Name = "botaoReplace";
			this.botaoReplace.Size = new System.Drawing.Size(75, 23);
			this.botaoReplace.TabIndex = 5;
			this.botaoReplace.Text = "&Replace...";
			this.botaoReplace.UseVisualStyleBackColor = true;
			this.botaoReplace.Click += new System.EventHandler(this.botaoReplace_Click);
			// 
			// botaoUpper
			// 
			this.botaoUpper.Location = new System.Drawing.Point(13, 336);
			this.botaoUpper.Name = "botaoUpper";
			this.botaoUpper.Size = new System.Drawing.Size(75, 23);
			this.botaoUpper.TabIndex = 3;
			this.botaoUpper.Text = "&Maiúsculas";
			this.botaoUpper.UseVisualStyleBackColor = true;
			this.botaoUpper.Click += new System.EventHandler(this.botaoUpper_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 379);
			this.Controls.Add(this.botaoUpper);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gravarButton);
			this.Controls.Add(this.textoConteudo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textoConteudo;
		private System.Windows.Forms.Button gravarButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button botaoBusca;
		private System.Windows.Forms.TextBox textoBusca;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button botaoReplace;
		private System.Windows.Forms.TextBox textoReplace;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button botaoUpper;
	}
}

