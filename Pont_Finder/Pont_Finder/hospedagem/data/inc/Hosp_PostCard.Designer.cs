namespace Pont_Finder.hospedagem
{
    partial class Hosp_PostCard
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
            this.lb_rs = new System.Windows.Forms.Label();
            this.lb_txt_diária = new System.Windows.Forms.Label();
            this.lb_empresa = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.pb_hotel = new System.Windows.Forms.PictureBox();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.pn_icons_hotel = new System.Windows.Forms.Panel();
            this.lb_txt2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_rs
            // 
            this.lb_rs.AutoSize = true;
            this.lb_rs.BackColor = System.Drawing.Color.Transparent;
            this.lb_rs.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.lb_rs.Location = new System.Drawing.Point(491, 40);
            this.lb_rs.Name = "lb_rs";
            this.lb_rs.Size = new System.Drawing.Size(57, 42);
            this.lb_rs.TabIndex = 32;
            this.lb_rs.Text = "R$";
            this.lb_rs.Click += new System.EventHandler(this.lb_rs_Click);
            // 
            // lb_txt_diária
            // 
            this.lb_txt_diária.AutoSize = true;
            this.lb_txt_diária.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt_diária.Location = new System.Drawing.Point(528, 15);
            this.lb_txt_diária.Name = "lb_txt_diária";
            this.lb_txt_diária.Size = new System.Drawing.Size(37, 14);
            this.lb_txt_diária.TabIndex = 31;
            this.lb_txt_diária.Text = "Diária";
            // 
            // lb_empresa
            // 
            this.lb_empresa.AutoSize = true;
            this.lb_empresa.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empresa.Location = new System.Drawing.Point(179, 40);
            this.lb_empresa.Name = "lb_empresa";
            this.lb_empresa.Size = new System.Drawing.Size(63, 17);
            this.lb_empresa.TabIndex = 30;
            this.lb_empresa.Text = "Endereço";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(178, 10);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(56, 21);
            this.lb_nome.TabIndex = 29;
            this.lb_nome.Text = "Name";
            // 
            // pb_hotel
            // 
            this.pb_hotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_hotel.Location = new System.Drawing.Point(15, 15);
            this.pb_hotel.Name = "pb_hotel";
            this.pb_hotel.Size = new System.Drawing.Size(150, 130);
            this.pb_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hotel.TabIndex = 1;
            this.pb_hotel.TabStop = false;
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_visualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_visualizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_visualizar.ForeColor = System.Drawing.Color.White;
            this.bt_visualizar.Location = new System.Drawing.Point(498, 109);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(110, 36);
            this.bt_visualizar.TabIndex = 28;
            this.bt_visualizar.Text = "Visualizar";
            this.bt_visualizar.UseVisualStyleBackColor = false;
            this.bt_visualizar.Click += new System.EventHandler(this.bt_visualizar_Click);
            // 
            // pn_icons_hotel
            // 
            this.pn_icons_hotel.AutoSize = true;
            this.pn_icons_hotel.Location = new System.Drawing.Point(183, 120);
            this.pn_icons_hotel.Name = "pn_icons_hotel";
            this.pn_icons_hotel.Size = new System.Drawing.Size(25, 25);
            this.pn_icons_hotel.TabIndex = 53;
            this.pn_icons_hotel.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_icons_hotel_Paint);
            // 
            // lb_txt2
            // 
            this.lb_txt2.AutoSize = true;
            this.lb_txt2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt2.Location = new System.Drawing.Point(180, 89);
            this.lb_txt2.Name = "lb_txt2";
            this.lb_txt2.Size = new System.Drawing.Size(168, 17);
            this.lb_txt2.TabIndex = 76;
            this.lb_txt2.Text = "Serviços inclusos no quarto";
            // 
            // Hosp_PostCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_txt2);
            this.Controls.Add(this.pn_icons_hotel);
            this.Controls.Add(this.lb_txt_diária);
            this.Controls.Add(this.lb_rs);
            this.Controls.Add(this.lb_empresa);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.bt_visualizar);
            this.Controls.Add(this.pb_hotel);
            this.Name = "Hosp_PostCard";
            this.Size = new System.Drawing.Size(623, 158);
            this.Load += new System.EventHandler(this.Hosp_PostCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_hotel;
        private System.Windows.Forms.Label lb_rs;
        private System.Windows.Forms.Label lb_txt_diária;
        private System.Windows.Forms.Label lb_empresa;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Button bt_visualizar;
        private System.Windows.Forms.Panel pn_icons_hotel;
        private System.Windows.Forms.Label lb_txt2;
    }
}
