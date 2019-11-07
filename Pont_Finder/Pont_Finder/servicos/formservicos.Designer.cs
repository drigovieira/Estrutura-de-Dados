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
            this.tb_pesquisar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_cadEmpresa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_center = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.Transparent;
            this.panel_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_right.Location = new System.Drawing.Point(950, 278);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(304, 259);
            this.panel_right.TabIndex = 16;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.Transparent;
            this.panel_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_left.Controls.Add(this.pb_pesquisar);
            this.panel_left.Controls.Add(this.tb_pesquisar);
            this.panel_left.Location = new System.Drawing.Point(5, 278);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(310, 259);
            this.panel_left.TabIndex = 15;
            // 
            // pb_pesquisar
            // 
            this.pb_pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_pesquisar.BackgroundImage")));
            this.pb_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pesquisar.Location = new System.Drawing.Point(257, 25);
            this.pb_pesquisar.Name = "pb_pesquisar";
            this.pb_pesquisar.Size = new System.Drawing.Size(35, 35);
            this.pb_pesquisar.TabIndex = 1;
            this.pb_pesquisar.TabStop = false;
            this.pb_pesquisar.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // tb_pesquisar
            // 
            this.tb_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pesquisar.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_pesquisar.Location = new System.Drawing.Point(13, 23);
            this.tb_pesquisar.Name = "tb_pesquisar";
            this.tb_pesquisar.Size = new System.Drawing.Size(283, 40);
            this.tb_pesquisar.TabIndex = 0;
            this.tb_pesquisar.Tag = "";
            this.tb_pesquisar.Text = "Pesquisar";
            this.tb_pesquisar.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            this.tb_pesquisar.Enter += new System.EventHandler(this.Tb_pesquisa_Enter);
            this.tb_pesquisar.Leave += new System.EventHandler(this.Tb_pesquisa_Leave);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(656, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 22);
            this.button3.TabIndex = 4;
            this.button3.Text = "Solicitar Serviço";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(319, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Publicar Servicos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bt_cadEmpresa);
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 40);
            this.panel1.TabIndex = 19;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(824, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 22);
            this.button6.TabIndex = 7;
            this.button6.Text = "Gerenciar Serviços";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 683);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 100);
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Veja o que temos para você!";
            // 
            // panel_center
            // 
            this.panel_center.AutoScroll = true;
            this.panel_center.BackColor = System.Drawing.Color.Transparent;
            this.panel_center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_center.Location = new System.Drawing.Point(320, 278);
            this.panel_center.MaximumSize = new System.Drawing.Size(625, 405);
            this.panel_center.MinimumSize = new System.Drawing.Size(625, 405);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(625, 405);
            this.panel_center.TabIndex = 17;
            this.panel_center.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 54);
            this.label2.TabIndex = 37;
            this.label2.Text = "label2";
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
            // FormServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox tb_pesquisar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_cadEmpresa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}