namespace Pont_Finder.hospedagem
{
    partial class CardListQuarto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardListQuarto));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.pb_almoco = new System.Windows.Forms.PictureBox();
            this.pb__duo = new System.Windows.Forms.PictureBox();
            this.pb_wifi = new System.Windows.Forms.PictureBox();
            this.lb_rs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_qtd_pessoas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_qtd_quartos = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_almoco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb__duo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wifi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_qtd_quartos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lb_qtd_pessoas);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pb_almoco);
            this.panel2.Controls.Add(this.pb__duo);
            this.panel2.Controls.Add(this.pb_wifi);
            this.panel2.Controls.Add(this.lb_rs);
            this.panel2.Controls.Add(this.bt_editar);
            this.panel2.Controls.Add(this.bt_remover);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lb_name);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 160);
            this.panel2.TabIndex = 6;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(904, 37);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(86, 28);
            this.bt_editar.TabIndex = 2;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.ForeColor = System.Drawing.Color.White;
            this.bt_remover.Location = new System.Drawing.Point(904, 77);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(86, 28);
            this.bt_remover.TabIndex = 3;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(186, 15);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(53, 27);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "Nome";
            // 
            // pb_almoco
            // 
            this.pb_almoco.Image = ((System.Drawing.Image)(resources.GetObject("pb_almoco.Image")));
            this.pb_almoco.Location = new System.Drawing.Point(253, 120);
            this.pb_almoco.Name = "pb_almoco";
            this.pb_almoco.Size = new System.Drawing.Size(25, 25);
            this.pb_almoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_almoco.TabIndex = 39;
            this.pb_almoco.TabStop = false;
            // 
            // pb__duo
            // 
            this.pb__duo.Image = ((System.Drawing.Image)(resources.GetObject("pb__duo.Image")));
            this.pb__duo.Location = new System.Drawing.Point(222, 120);
            this.pb__duo.Name = "pb__duo";
            this.pb__duo.Size = new System.Drawing.Size(25, 25);
            this.pb__duo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb__duo.TabIndex = 38;
            this.pb__duo.TabStop = false;
            // 
            // pb_wifi
            // 
            this.pb_wifi.Image = ((System.Drawing.Image)(resources.GetObject("pb_wifi.Image")));
            this.pb_wifi.Location = new System.Drawing.Point(191, 120);
            this.pb_wifi.Name = "pb_wifi";
            this.pb_wifi.Size = new System.Drawing.Size(25, 25);
            this.pb_wifi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_wifi.TabIndex = 37;
            this.pb_wifi.TabStop = false;
            // 
            // lb_rs
            // 
            this.lb_rs.AutoSize = true;
            this.lb_rs.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rs.ForeColor = System.Drawing.Color.LimeGreen;
            this.lb_rs.Location = new System.Drawing.Point(682, 51);
            this.lb_rs.Name = "lb_rs";
            this.lb_rs.Size = new System.Drawing.Size(59, 54);
            this.lb_rs.TabIndex = 36;
            this.lb_rs.Text = "R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Quantidade de pessoas:";
            // 
            // lb_qtd_pessoas
            // 
            this.lb_qtd_pessoas.AutoSize = true;
            this.lb_qtd_pessoas.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtd_pessoas.Location = new System.Drawing.Point(328, 50);
            this.lb_qtd_pessoas.Name = "lb_qtd_pessoas";
            this.lb_qtd_pessoas.Size = new System.Drawing.Size(40, 21);
            this.lb_qtd_pessoas.TabIndex = 41;
            this.lb_qtd_pessoas.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Quantidade de quartos existentes:";
            // 
            // lb_qtd_quartos
            // 
            this.lb_qtd_quartos.AutoSize = true;
            this.lb_qtd_quartos.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtd_quartos.Location = new System.Drawing.Point(386, 77);
            this.lb_qtd_quartos.Name = "lb_qtd_quartos";
            this.lb_qtd_quartos.Size = new System.Drawing.Size(40, 21);
            this.lb_qtd_quartos.TabIndex = 43;
            this.lb_qtd_quartos.Text = "Value";
            // 
            // CardListQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Name = "CardListQuarto";
            this.Size = new System.Drawing.Size(1010, 160);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_almoco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb__duo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wifi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pb_almoco;
        private System.Windows.Forms.PictureBox pb__duo;
        private System.Windows.Forms.PictureBox pb_wifi;
        private System.Windows.Forms.Label lb_rs;
        private System.Windows.Forms.Label lb_qtd_pessoas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_qtd_quartos;
        private System.Windows.Forms.Label label2;
    }
}
