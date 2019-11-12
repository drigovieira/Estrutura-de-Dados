namespace Pont_Finder.servicos
{
    partial class FormServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicos));
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.pb_pesquisar = new System.Windows.Forms.PictureBox();
            this.bt_solicitar = new System.Windows.Forms.Button();
            this.bt_cadEmpresa = new System.Windows.Forms.Button();
            this.bt_publicar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_gerenciar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_ant = new System.Windows.Forms.Button();
            this.bt_prox = new System.Windows.Forms.Button();
            this.lb_pag = new System.Windows.Forms.Label();
            this.panel_center = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pesquisar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panel_right.Location = new System.Drawing.Point(950, 282);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(304, 259);
            this.panel_right.TabIndex = 16;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel_left.Controls.Add(this.pb_pesquisar);
            this.panel_left.Controls.Add(this.tb_pesquisar);
            this.panel_left.Location = new System.Drawing.Point(5, 282);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(310, 259);
            this.panel_left.TabIndex = 15;
            // 
            // pb_pesquisar
            // 
            this.pb_pesquisar.BackColor = System.Drawing.Color.White;
            this.pb_pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_pesquisar.BackgroundImage")));
            this.pb_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pesquisar.Location = new System.Drawing.Point(262, 28);
            this.pb_pesquisar.Name = "pb_pesquisar";
            this.pb_pesquisar.Size = new System.Drawing.Size(30, 30);
            this.pb_pesquisar.TabIndex = 1;
            this.pb_pesquisar.TabStop = false;
            this.pb_pesquisar.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // bt_solicitar
            // 
            this.bt_solicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_solicitar.ForeColor = System.Drawing.Color.White;
            this.bt_solicitar.Location = new System.Drawing.Point(656, 8);
            this.bt_solicitar.Name = "bt_solicitar";
            this.bt_solicitar.Size = new System.Drawing.Size(120, 22);
            this.bt_solicitar.TabIndex = 4;
            this.bt_solicitar.Text = "Solicitar Serviço";
            this.bt_solicitar.UseVisualStyleBackColor = true;
            this.bt_solicitar.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_cadEmpresa
            // 
            this.bt_cadEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadEmpresa.ForeColor = System.Drawing.Color.White;
            this.bt_cadEmpresa.Location = new System.Drawing.Point(488, 8);
            this.bt_cadEmpresa.Name = "bt_cadEmpresa";
            this.bt_cadEmpresa.Size = new System.Drawing.Size(120, 22);
            this.bt_cadEmpresa.TabIndex = 3;
            this.bt_cadEmpresa.Text = "Cadastrar Empresa";
            this.bt_cadEmpresa.UseVisualStyleBackColor = true;
            this.bt_cadEmpresa.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bt_publicar
            // 
            this.bt_publicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_publicar.ForeColor = System.Drawing.Color.White;
            this.bt_publicar.Location = new System.Drawing.Point(319, 8);
            this.bt_publicar.Name = "bt_publicar";
            this.bt_publicar.Size = new System.Drawing.Size(120, 22);
            this.bt_publicar.TabIndex = 2;
            this.bt_publicar.Text = "Publicar Servicos";
            this.bt_publicar.UseVisualStyleBackColor = true;
            this.bt_publicar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_gerenciar);
            this.panel1.Controls.Add(this.bt_solicitar);
            this.panel1.Controls.Add(this.bt_publicar);
            this.panel1.Controls.Add(this.bt_cadEmpresa);
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 40);
            this.panel1.TabIndex = 19;
            // 
            // bt_gerenciar
            // 
            this.bt_gerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gerenciar.ForeColor = System.Drawing.Color.White;
            this.bt_gerenciar.Location = new System.Drawing.Point(824, 8);
            this.bt_gerenciar.Name = "bt_gerenciar";
            this.bt_gerenciar.Size = new System.Drawing.Size(120, 22);
            this.bt_gerenciar.TabIndex = 7;
            this.bt_gerenciar.Text = "Gerenciar Serviços";
            this.bt_gerenciar.UseVisualStyleBackColor = true;
            this.bt_gerenciar.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 100);
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Veja o que temos para você!";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 150);
            this.panel3.TabIndex = 38;
            // 
            // bt_ant
            // 
            this.bt_ant.BackColor = System.Drawing.Color.Transparent;
            this.bt_ant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ant.ForeColor = System.Drawing.Color.Black;
            this.bt_ant.Location = new System.Drawing.Point(320, 254);
            this.bt_ant.Name = "bt_ant";
            this.bt_ant.Size = new System.Drawing.Size(75, 23);
            this.bt_ant.TabIndex = 39;
            this.bt_ant.Text = "<<";
            this.bt_ant.UseVisualStyleBackColor = false;
            this.bt_ant.Click += new System.EventHandler(this.Bt_ant_Click);
            // 
            // bt_prox
            // 
            this.bt_prox.BackColor = System.Drawing.Color.Transparent;
            this.bt_prox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prox.ForeColor = System.Drawing.Color.Black;
            this.bt_prox.Location = new System.Drawing.Point(870, 254);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(75, 23);
            this.bt_prox.TabIndex = 40;
            this.bt_prox.Text = ">>";
            this.bt_prox.UseVisualStyleBackColor = false;
            this.bt_prox.Click += new System.EventHandler(this.Bt_prox_Click);
            // 
            // lb_pag
            // 
            this.lb_pag.AutoSize = true;
            this.lb_pag.Location = new System.Drawing.Point(608, 256);
            this.lb_pag.Name = "lb_pag";
            this.lb_pag.Size = new System.Drawing.Size(39, 13);
            this.lb_pag.TabIndex = 41;
            this.lb_pag.Text = "lb_pag";
            // 
            // panel_center
            // 
            this.panel_center.AutoSize = true;
            this.panel_center.BackColor = System.Drawing.Color.Transparent;
            this.panel_center.Location = new System.Drawing.Point(320, 277);
            this.panel_center.MaximumSize = new System.Drawing.Size(625, 0);
            this.panel_center.MinimumSize = new System.Drawing.Size(625, 0);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(625, 0);
            this.panel_center.TabIndex = 17;
            this.panel_center.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_center_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(416, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aproveite nossos serviços!";
            // 
            // tb_pesquisar
            // 
            this.tb_pesquisar.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pesquisar.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_pesquisar.Location = new System.Drawing.Point(13, 23);
            this.tb_pesquisar.Name = "tb_pesquisar";
            this.tb_pesquisar.Size = new System.Drawing.Size(283, 40);
            this.tb_pesquisar.TabIndex = 0;
            this.tb_pesquisar.Tag = "";
            this.tb_pesquisar.Text = "Pesquisar";
            this.tb_pesquisar.TextChanged += new System.EventHandler(this.Tb_pesquisar_TextChanged);
            this.tb_pesquisar.Enter += new System.EventHandler(this.Tb_pesquisa_Enter);
            this.tb_pesquisar.Leave += new System.EventHandler(this.Tb_pesquisa_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 36);
            this.label5.TabIndex = 42;
            this.label5.Text = "Pesquisar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1039, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 36);
            this.label16.TabIndex = 43;
            this.label16.Text = "Top 5 Serviços";
            // 
            // FormServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_ant);
            this.Controls.Add(this.lb_pag);
            this.Controls.Add(this.bt_prox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "FormServicos";
            this.Text = "servicos";
            this.Load += new System.EventHandler(this.Formservicos_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.PictureBox pb_pesquisar;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button bt_publicar;
        private System.Windows.Forms.Button bt_cadEmpresa;
        private System.Windows.Forms.Button bt_solicitar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_gerenciar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_ant;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.TextBox tb_pesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_pag;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
    }
}