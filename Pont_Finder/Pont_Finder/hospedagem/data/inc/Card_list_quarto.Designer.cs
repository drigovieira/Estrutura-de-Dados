namespace Pont_Finder.hospedagem
{
    partial class Card_list_quarto
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
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_qtd_pessoas = new System.Windows.Forms.Label();
            this.lb_qtd_quartos = new System.Windows.Forms.Label();
            this.lb_value_quartos = new System.Windows.Forms.Label();
            this.lb_value_pessoas = new System.Windows.Forms.Label();
            this.pb_hotel = new System.Windows.Forms.PictureBox();
            this.lb_rs = new System.Windows.Forms.Label();
            this.pn_icons_quarto = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_editar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(870, 25);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(100, 36);
            this.bt_editar.TabIndex = 4;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_remover.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover.ForeColor = System.Drawing.Color.White;
            this.bt_remover.Location = new System.Drawing.Point(870, 79);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(100, 36);
            this.bt_remover.TabIndex = 5;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(206, 14);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(57, 21);
            this.lb_nome.TabIndex = 6;
            this.lb_nome.Text = "Nome";
            // 
            // lb_qtd_pessoas
            // 
            this.lb_qtd_pessoas.AutoSize = true;
            this.lb_qtd_pessoas.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtd_pessoas.Location = new System.Drawing.Point(208, 44);
            this.lb_qtd_pessoas.Name = "lb_qtd_pessoas";
            this.lb_qtd_pessoas.Size = new System.Drawing.Size(150, 17);
            this.lb_qtd_pessoas.TabIndex = 7;
            this.lb_qtd_pessoas.Text = "Quantidade de pessoas:";
            // 
            // lb_qtd_quartos
            // 
            this.lb_qtd_quartos.AutoSize = true;
            this.lb_qtd_quartos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtd_quartos.Location = new System.Drawing.Point(208, 69);
            this.lb_qtd_quartos.Name = "lb_qtd_quartos";
            this.lb_qtd_quartos.Size = new System.Drawing.Size(147, 17);
            this.lb_qtd_quartos.TabIndex = 8;
            this.lb_qtd_quartos.Text = "Quantidade de quartos:";
            this.lb_qtd_quartos.Click += new System.EventHandler(this.lb_qtd_quartos_Click);
            // 
            // lb_value_quartos
            // 
            this.lb_value_quartos.AutoSize = true;
            this.lb_value_quartos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_value_quartos.Location = new System.Drawing.Point(361, 69);
            this.lb_value_quartos.Name = "lb_value_quartos";
            this.lb_value_quartos.Size = new System.Drawing.Size(40, 17);
            this.lb_value_quartos.TabIndex = 10;
            this.lb_value_quartos.Text = "Value";
            // 
            // lb_value_pessoas
            // 
            this.lb_value_pessoas.AutoSize = true;
            this.lb_value_pessoas.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_value_pessoas.Location = new System.Drawing.Point(364, 44);
            this.lb_value_pessoas.Name = "lb_value_pessoas";
            this.lb_value_pessoas.Size = new System.Drawing.Size(40, 17);
            this.lb_value_pessoas.TabIndex = 11;
            this.lb_value_pessoas.Text = "Value";
            this.lb_value_pessoas.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb_hotel
            // 
            this.pb_hotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_hotel.Location = new System.Drawing.Point(19, 14);
            this.pb_hotel.Name = "pb_hotel";
            this.pb_hotel.Size = new System.Drawing.Size(150, 130);
            this.pb_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hotel.TabIndex = 2;
            this.pb_hotel.TabStop = false;
            // 
            // lb_rs
            // 
            this.lb_rs.AutoSize = true;
            this.lb_rs.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.lb_rs.Location = new System.Drawing.Point(636, 47);
            this.lb_rs.Name = "lb_rs";
            this.lb_rs.Size = new System.Drawing.Size(57, 42);
            this.lb_rs.TabIndex = 33;
            this.lb_rs.Text = "R$";
            // 
            // pn_icons_quarto
            // 
            this.pn_icons_quarto.AutoSize = true;
            this.pn_icons_quarto.Location = new System.Drawing.Point(212, 119);
            this.pn_icons_quarto.Name = "pn_icons_quarto";
            this.pn_icons_quarto.Size = new System.Drawing.Size(25, 25);
            this.pn_icons_quarto.TabIndex = 53;
            // 
            // Card_list_quarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pn_icons_quarto);
            this.Controls.Add(this.lb_rs);
            this.Controls.Add(this.lb_value_pessoas);
            this.Controls.Add(this.lb_value_quartos);
            this.Controls.Add(this.lb_qtd_quartos);
            this.Controls.Add(this.lb_qtd_pessoas);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.pb_hotel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Card_list_quarto";
            this.Size = new System.Drawing.Size(1000, 158);
            this.Load += new System.EventHandler(this.Card_list_quarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_hotel;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_qtd_pessoas;
        private System.Windows.Forms.Label lb_qtd_quartos;
        private System.Windows.Forms.Label lb_value_quartos;
        private System.Windows.Forms.Label lb_value_pessoas;
        private System.Windows.Forms.Label lb_rs;
        private System.Windows.Forms.Panel pn_icons_quarto;
    }
}
