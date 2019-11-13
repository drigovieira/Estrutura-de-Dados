namespace Pont_Finder.alimentos
{
    partial class Item_Alimentos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeEmpresa = new System.Windows.Forms.Label();
            this.pb_hotel = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_rs = new System.Windows.Forms.Label();
            this.bt_visualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingredientes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamanho";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preço";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NomeEmpresa
            // 
            this.NomeEmpresa.AutoSize = true;
            this.NomeEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeEmpresa.Location = new System.Drawing.Point(199, 12);
            this.NomeEmpresa.Name = "NomeEmpresa";
            this.NomeEmpresa.Size = new System.Drawing.Size(55, 20);
            this.NomeEmpresa.TabIndex = 1;
            this.NomeEmpresa.Text = "Nome";
            this.NomeEmpresa.Click += new System.EventHandler(this.NomeEmpresa_Click);
            // 
            // pb_hotel
            // 
            this.pb_hotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_hotel.Location = new System.Drawing.Point(12, 12);
            this.pb_hotel.Name = "pb_hotel";
            this.pb_hotel.Size = new System.Drawing.Size(150, 130);
            this.pb_hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hotel.TabIndex = 4;
            this.pb_hotel.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Value";
            // 
            // lb_rs
            // 
            this.lb_rs.AutoSize = true;
            this.lb_rs.BackColor = System.Drawing.Color.Transparent;
            this.lb_rs.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.lb_rs.Location = new System.Drawing.Point(485, 60);
            this.lb_rs.Name = "lb_rs";
            this.lb_rs.Size = new System.Drawing.Size(59, 54);
            this.lb_rs.TabIndex = 33;
            this.lb_rs.Text = "R$";
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.bt_visualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_visualizar.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_visualizar.ForeColor = System.Drawing.Color.White;
            this.bt_visualizar.Location = new System.Drawing.Point(494, 138);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(110, 34);
            this.bt_visualizar.TabIndex = 34;
            this.bt_visualizar.Text = "Reservar";
            this.bt_visualizar.UseVisualStyleBackColor = false;
            // 
            // Item_Alimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.bt_visualizar);
            this.Controls.Add(this.lb_rs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_hotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomeEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Item_Alimentos";
            this.Size = new System.Drawing.Size(625, 190);
            this.Load += new System.EventHandler(this.Item_Alimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NomeEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_hotel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_rs;
        private System.Windows.Forms.Button bt_visualizar;
    }
}
