namespace Pont_Finder.avalie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userboxdescricao = new System.Windows.Forms.TextBox();
            this.userboxlocalizacao = new System.Windows.Forms.TextBox();
            this.userboxproblema = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userhora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 279);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DESCRIÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LOCALIZAÇÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PROBLEMA";
            // 
            // userboxdescricao
            // 
            this.userboxdescricao.Location = new System.Drawing.Point(16, 169);
            this.userboxdescricao.Multiline = true;
            this.userboxdescricao.Name = "userboxdescricao";
            this.userboxdescricao.ReadOnly = true;
            this.userboxdescricao.Size = new System.Drawing.Size(194, 68);
            this.userboxdescricao.TabIndex = 4;
            // 
            // userboxlocalizacao
            // 
            this.userboxlocalizacao.Location = new System.Drawing.Point(16, 117);
            this.userboxlocalizacao.Name = "userboxlocalizacao";
            this.userboxlocalizacao.ReadOnly = true;
            this.userboxlocalizacao.Size = new System.Drawing.Size(194, 20);
            this.userboxlocalizacao.TabIndex = 3;
            // 
            // userboxproblema
            // 
            this.userboxproblema.Location = new System.Drawing.Point(16, 64);
            this.userboxproblema.Name = "userboxproblema";
            this.userboxproblema.ReadOnly = true;
            this.userboxproblema.Size = new System.Drawing.Size(194, 20);
            this.userboxproblema.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(29, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.userhora);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.userboxdescricao);
            this.panel2.Controls.Add(this.userboxlocalizacao);
            this.panel2.Controls.Add(this.userboxproblema);
            this.panel2.Location = new System.Drawing.Point(336, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 279);
            this.panel2.TabIndex = 10;
            // 
            // userhora
            // 
            this.userhora.AutoSize = true;
            this.userhora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userhora.Location = new System.Drawing.Point(13, 10);
            this.userhora.Name = "userhora";
            this.userhora.Size = new System.Drawing.Size(0, 13);
            this.userhora.TabIndex = 9;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(573, 279);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox userboxdescricao;
        public System.Windows.Forms.TextBox userboxlocalizacao;
        public System.Windows.Forms.TextBox userboxproblema;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userhora;
    }
}
