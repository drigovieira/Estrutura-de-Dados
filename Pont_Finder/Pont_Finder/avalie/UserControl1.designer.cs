﻿namespace Pont_Finder.avalie
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userboxdesc = new System.Windows.Forms.TextBox();
            this.userboxlocalizacao = new System.Windows.Forms.TextBox();
            this.userboxproblema = new System.Windows.Forms.TextBox();
            this.userhora = new System.Windows.Forms.Label();
            this.NomePos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_obter = new System.Windows.Forms.Button();
            this.checado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(289, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Localização";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(288, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(289, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo do Problema";
            // 
            // userboxdesc
            // 
            this.userboxdesc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userboxdesc.Enabled = false;
            this.userboxdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userboxdesc.Location = new System.Drawing.Point(283, 170);
            this.userboxdesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userboxdesc.Multiline = true;
            this.userboxdesc.Name = "userboxdesc";
            this.userboxdesc.ReadOnly = true;
            this.userboxdesc.Size = new System.Drawing.Size(344, 61);
            this.userboxdesc.TabIndex = 2;
            // 
            // userboxlocalizacao
            // 
            this.userboxlocalizacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userboxlocalizacao.Enabled = false;
            this.userboxlocalizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userboxlocalizacao.Location = new System.Drawing.Point(283, 100);
            this.userboxlocalizacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userboxlocalizacao.Name = "userboxlocalizacao";
            this.userboxlocalizacao.ReadOnly = true;
            this.userboxlocalizacao.Size = new System.Drawing.Size(344, 23);
            this.userboxlocalizacao.TabIndex = 1;
            // 
            // userboxproblema
            // 
            this.userboxproblema.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.userboxproblema.Enabled = false;
            this.userboxproblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.userboxproblema.Location = new System.Drawing.Point(283, 37);
            this.userboxproblema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userboxproblema.Name = "userboxproblema";
            this.userboxproblema.ReadOnly = true;
            this.userboxproblema.Size = new System.Drawing.Size(344, 23);
            this.userboxproblema.TabIndex = 0;
            // 
            // userhora
            // 
            this.userhora.AutoSize = true;
            this.userhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.userhora.Location = new System.Drawing.Point(130, 217);
            this.userhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userhora.Name = "userhora";
            this.userhora.Size = new System.Drawing.Size(52, 17);
            this.userhora.TabIndex = 6;
            this.userhora.Text = "label4";
            this.userhora.Click += new System.EventHandler(this.userhora_Click);
            // 
            // NomePos
            // 
            this.NomePos.AutoSize = true;
            this.NomePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.NomePos.Location = new System.Drawing.Point(4, 0);
            this.NomePos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomePos.Name = "NomePos";
            this.NomePos.Size = new System.Drawing.Size(52, 17);
            this.NomePos.TabIndex = 6;
            this.NomePos.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(-1, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Postagem:";
            // 
            // bt_obter
            // 
            this.bt_obter.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_obter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bt_obter.ForeColor = System.Drawing.Color.White;
            this.bt_obter.Location = new System.Drawing.Point(652, 192);
            this.bt_obter.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.bt_obter.Name = "bt_obter";
            this.bt_obter.Size = new System.Drawing.Size(169, 39);
            this.bt_obter.TabIndex = 24;
            this.bt_obter.Text = "Visualizar";
            this.bt_obter.UseVisualStyleBackColor = false;
            this.bt_obter.Click += new System.EventHandler(this.bt_obter_Click);
            // 
            // checado
            // 
            this.checado.Image = global::Pont_Finder.Properties.Resources.Checked_icon;
            this.checado.Location = new System.Drawing.Point(752, 30);
            this.checado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checado.Name = "checado";
            this.checado.Size = new System.Drawing.Size(49, 39);
            this.checado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.checado.TabIndex = 25;
            this.checado.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.checado);
            this.Controls.Add(this.bt_obter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomePos);
            this.Controls.Add(this.userboxdesc);
            this.Controls.Add(this.userboxlocalizacao);
            this.Controls.Add(this.userboxproblema);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(833, 241);
            ((System.ComponentModel.ISupportInitialize)(this.checado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userboxdesc;
        private System.Windows.Forms.TextBox userboxlocalizacao;
        private System.Windows.Forms.TextBox userboxproblema;
        private System.Windows.Forms.Label NomePos;
        private System.Windows.Forms.Label userhora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_obter;
        private System.Windows.Forms.PictureBox checado;
    }
}
