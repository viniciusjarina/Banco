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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 299);
			this.Controls.Add(this.gravarButton);
			this.Controls.Add(this.textoConteudo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textoConteudo;
		private System.Windows.Forms.Button gravarButton;
	}
}

