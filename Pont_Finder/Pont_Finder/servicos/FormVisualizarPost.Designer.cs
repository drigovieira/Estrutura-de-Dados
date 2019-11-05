namespace Pont_Finder.servicos
{
    partial class FormVisualizarPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizarPost));
            this.pb_wallpaper = new System.Windows.Forms.PictureBox();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lb__titulo = new System.Windows.Forms.Label();
            this.lb_rs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_fantasia = new System.Windows.Forms.Label();
            this.tb_cnpj = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.Label();
            this.tb_Endereco = new System.Windows.Forms.Label();
            this.tb_Telefone = new System.Windows.Forms.Label();
            this.tb_cep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wallpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_wallpaper
            // 
            this.pb_wallpaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_wallpaper.BackgroundImage")));
            this.pb_wallpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_wallpaper.Location = new System.Drawing.Point(0, 0);
            this.pb_wallpaper.Name = "pb_wallpaper";
            this.pb_wallpaper.Size = new System.Drawing.Size(1265, 150);
            this.pb_wallpaper.TabIndex = 19;
            this.pb_wallpaper.TabStop = false;
            // 
            // pb_icon
            // 
            this.pb_icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_icon.Location = new System.Drawing.Point(131, 202);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(400, 300);
            this.pb_icon.TabIndex = 20;
            this.pb_icon.TabStop = false;
            this.pb_icon.Click += new System.EventHandler(this.pb_icon_Click);
            // 
            // lb__titulo
            // 
            this.lb__titulo.AutoSize = true;
            this.lb__titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb__titulo.Location = new System.Drawing.Point(954, 203);
            this.lb__titulo.Name = "lb__titulo";
            this.lb__titulo.Size = new System.Drawing.Size(87, 31);
            this.lb__titulo.TabIndex = 21;
            this.lb__titulo.Text = "Titulo";
            // 
            // lb_rs
            // 
            this.lb_rs.AutoSize = true;
            this.lb_rs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rs.Location = new System.Drawing.Point(973, 346);
            this.lb_rs.Name = "lb_rs";
            this.lb_rs.Size = new System.Drawing.Size(51, 31);
            this.lb_rs.TabIndex = 22;
            this.lb_rs.Text = "R$";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 100);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_descricao);
            this.panel2.Location = new System.Drawing.Point(131, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 431);
            this.panel2.TabIndex = 24;
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descricao.Location = new System.Drawing.Point(50, 24);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(162, 25);
            this.lb_descricao.TabIndex = 0;
            this.lb_descricao.Text = "Descrição geral";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(131, 983);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 217);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tb_cep);
            this.panel4.Controls.Add(this.tb_Telefone);
            this.panel4.Controls.Add(this.tb_Endereco);
            this.panel4.Controls.Add(this.tb_email);
            this.panel4.Controls.Add(this.tb_cnpj);
            this.panel4.Controls.Add(this.lb_fantasia);
            this.panel4.Location = new System.Drawing.Point(337, 983);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(849, 217);
            this.panel4.TabIndex = 26;
            // 
            // lb_fantasia
            // 
            this.lb_fantasia.AutoSize = true;
            this.lb_fantasia.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fantasia.Location = new System.Drawing.Point(15, 11);
            this.lb_fantasia.Name = "lb_fantasia";
            this.lb_fantasia.Size = new System.Drawing.Size(160, 29);
            this.lb_fantasia.TabIndex = 0;
            this.lb_fantasia.Text = "Nome fantasia";
            this.lb_fantasia.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_cnpj
            // 
            this.tb_cnpj.AutoSize = true;
            this.tb_cnpj.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cnpj.Location = new System.Drawing.Point(15, 50);
            this.tb_cnpj.Name = "tb_cnpj";
            this.tb_cnpj.Size = new System.Drawing.Size(62, 29);
            this.tb_cnpj.TabIndex = 1;
            this.tb_cnpj.Text = "CNPJ";
            // 
            // tb_email
            // 
            this.tb_email.AutoSize = true;
            this.tb_email.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(15, 180);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(76, 29);
            this.tb_email.TabIndex = 2;
            this.tb_email.Text = "E-mail";
            // 
            // tb_Endereco
            // 
            this.tb_Endereco.AutoSize = true;
            this.tb_Endereco.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Endereco.Location = new System.Drawing.Point(15, 92);
            this.tb_Endereco.Name = "tb_Endereco";
            this.tb_Endereco.Size = new System.Drawing.Size(107, 29);
            this.tb_Endereco.TabIndex = 3;
            this.tb_Endereco.Text = "Endereco";
            this.tb_Endereco.Click += new System.EventHandler(this.tb_Endereco_Click);
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.AutoSize = true;
            this.tb_Telefone.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Telefone.Location = new System.Drawing.Point(231, 135);
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(99, 29);
            this.tb_Telefone.TabIndex = 4;
            this.tb_Telefone.Text = "Telefone";
            // 
            // tb_cep
            // 
            this.tb_cep.AutoSize = true;
            this.tb_cep.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cep.Location = new System.Drawing.Point(15, 135);
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(51, 29);
            this.tb_cep.TabIndex = 5;
            this.tb_cep.Text = "CEP";
            // 
            // FormVisualizarPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_rs);
            this.Controls.Add(this.lb__titulo);
            this.Controls.Add(this.pb_icon);
            this.Controls.Add(this.pb_wallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisualizarPost";
            this.Text = "FormVisualizarPost";
            this.Load += new System.EventHandler(this.FormVisualizarPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_wallpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_wallpaper;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label lb__titulo;
        private System.Windows.Forms.Label lb_rs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_fantasia;
        private System.Windows.Forms.Label tb_email;
        private System.Windows.Forms.Label tb_cnpj;
        private System.Windows.Forms.Label tb_Endereco;
        private System.Windows.Forms.Label tb_cep;
        private System.Windows.Forms.Label tb_Telefone;
    }
}