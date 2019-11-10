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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hosp_PostCard));
            this.pb_hotel = new System.Windows.Forms.PictureBox();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.lb_rs = new System.Windows.Forms.Label();
            this.lb_detalhe = new System.Windows.Forms.Label();
            this.lb_empresa = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.pb_wifi = new System.Windows.Forms.PictureBox();
            this.pb__duo = new System.Windows.Forms.PictureBox();
            this.pb_almoco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wifi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb__duo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_almoco)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_hotel
            // 
            this.pb_hotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_hotel.Location = new System.Drawing.Point(15, 15);
            this.pb_hotel.Name = "pb_hotel";
            this.pb_hotel.Size = new System.Drawing.Size(150, 130);
            this.pb_hotel.TabIndex = 1;
            this.pb_hotel.TabStop = false;
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_visualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.bt_visualizar.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_visualizar.ForeColor = System.Drawing.Color.White;
            this.bt_visualizar.Location = new System.Drawing.Point(500, 111);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(110, 34);
            this.bt_visualizar.TabIndex = 28;
            this.bt_visualizar.Text = "Visualizar";
            this.bt_visualizar.UseVisualStyleBackColor = false;
            this.bt_visualizar.Click += new System.EventHandler(this.bt_visualizar_Click);
            // 
            // lb_rs
            // 
            this.lb_rs.AutoSize = true;
            this.lb_rs.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rs.ForeColor = System.Drawing.Color.LimeGreen;
            this.lb_rs.Location = new System.Drawing.Point(525, 51);
            this.lb_rs.Name = "lb_rs";
            this.lb_rs.Size = new System.Drawing.Size(59, 54);
            this.lb_rs.TabIndex = 32;
            this.lb_rs.Text = "R$";
            this.lb_rs.Click += new System.EventHandler(this.lb_rs_Click);
            // 
            // lb_detalhe
            // 
            this.lb_detalhe.AutoSize = true;
            this.lb_detalhe.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_detalhe.Location = new System.Drawing.Point(532, 13);
            this.lb_detalhe.Name = "lb_detalhe";
            this.lb_detalhe.Size = new System.Drawing.Size(33, 18);
            this.lb_detalhe.TabIndex = 31;
            this.lb_detalhe.Text = "Diária";
            // 
            // lb_empresa
            // 
            this.lb_empresa.AutoSize = true;
            this.lb_empresa.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empresa.Location = new System.Drawing.Point(179, 40);
            this.lb_empresa.Name = "lb_empresa";
            this.lb_empresa.Size = new System.Drawing.Size(60, 21);
            this.lb_empresa.TabIndex = 30;
            this.lb_empresa.Text = "Endereço";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(178, 10);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(52, 27);
            this.lb_nome.TabIndex = 29;
            this.lb_nome.Text = "Name";
            // 
            // pb_wifi
            // 
            this.pb_wifi.Image = ((System.Drawing.Image)(resources.GetObject("pb_wifi.Image")));
            this.pb_wifi.Location = new System.Drawing.Point(185, 119);
            this.pb_wifi.Name = "pb_wifi";
            this.pb_wifi.Size = new System.Drawing.Size(25, 25);
            this.pb_wifi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_wifi.TabIndex = 33;
            this.pb_wifi.TabStop = false;
            // 
            // pb__duo
            // 
            this.pb__duo.Image = ((System.Drawing.Image)(resources.GetObject("pb__duo.Image")));
            this.pb__duo.Location = new System.Drawing.Point(216, 119);
            this.pb__duo.Name = "pb__duo";
            this.pb__duo.Size = new System.Drawing.Size(25, 25);
            this.pb__duo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb__duo.TabIndex = 34;
            this.pb__duo.TabStop = false;
            // 
            // pb_almoco
            // 
            this.pb_almoco.Image = ((System.Drawing.Image)(resources.GetObject("pb_almoco.Image")));
            this.pb_almoco.Location = new System.Drawing.Point(247, 119);
            this.pb_almoco.Name = "pb_almoco";
            this.pb_almoco.Size = new System.Drawing.Size(25, 25);
            this.pb_almoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_almoco.TabIndex = 35;
            this.pb_almoco.TabStop = false;
            // 
            // Hosp_PostCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pb_almoco);
            this.Controls.Add(this.pb__duo);
            this.Controls.Add(this.pb_wifi);
            this.Controls.Add(this.lb_rs);
            this.Controls.Add(this.lb_detalhe);
            this.Controls.Add(this.lb_empresa);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.bt_visualizar);
            this.Controls.Add(this.pb_hotel);
            this.Name = "Hosp_PostCard";
            this.Size = new System.Drawing.Size(625, 160);
            this.Load += new System.EventHandler(this.Hosp_PostCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wifi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb__duo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_almoco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_hotel;
        private System.Windows.Forms.Button bt_visualizar;
        private System.Windows.Forms.Label lb_rs;
        private System.Windows.Forms.Label lb_detalhe;
        private System.Windows.Forms.Label lb_empresa;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.PictureBox pb_wifi;
        private System.Windows.Forms.PictureBox pb__duo;
        private System.Windows.Forms.PictureBox pb_almoco;
    }
}
