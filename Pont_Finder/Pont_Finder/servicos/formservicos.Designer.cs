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
            this.panel_center = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pb_pesquisar = new System.Windows.Forms.PictureBox();
            this.panel_left = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_pesquisar = new System.Windows.Forms.TextBox();
            this.pb_wallpaper = new System.Windows.Forms.PictureBox();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).BeginInit();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_center
            // 
            this.panel_center.BackColor = System.Drawing.Color.Transparent;
            this.panel_center.Location = new System.Drawing.Point(315, 200);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(625, 700);
            this.panel_center.TabIndex = 17;
            this.panel_center.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.Transparent;
            this.panel_right.Controls.Add(this.button5);
            this.panel_right.Controls.Add(this.button4);
            this.panel_right.Location = new System.Drawing.Point(945, 200);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(304, 700);
            this.panel_right.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(112, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Load";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // pb_pesquisar
            // 
            this.pb_pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_pesquisar.BackgroundImage")));
            this.pb_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pesquisar.Location = new System.Drawing.Point(258, 53);
            this.pb_pesquisar.Name = "pb_pesquisar";
            this.pb_pesquisar.Size = new System.Drawing.Size(35, 35);
            this.pb_pesquisar.TabIndex = 1;
            this.pb_pesquisar.TabStop = false;
            this.pb_pesquisar.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.Transparent;
            this.panel_left.Controls.Add(this.button3);
            this.panel_left.Controls.Add(this.button2);
            this.panel_left.Controls.Add(this.button1);
            this.panel_left.Controls.Add(this.pb_pesquisar);
            this.panel_left.Controls.Add(this.tb_pesquisar);
            this.panel_left.Location = new System.Drawing.Point(0, 200);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(310, 700);
            this.panel_left.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(283, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "Solicitar Serviço";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cadastrar Empresa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Publicar Servicos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // tb_pesquisar
            // 
            this.tb_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pesquisar.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_pesquisar.Location = new System.Drawing.Point(12, 51);
            this.tb_pesquisar.Name = "tb_pesquisar";
            this.tb_pesquisar.Size = new System.Drawing.Size(283, 40);
            this.tb_pesquisar.TabIndex = 0;
            this.tb_pesquisar.Tag = "";
            this.tb_pesquisar.Text = "Pesquisar";
            this.tb_pesquisar.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            this.tb_pesquisar.Enter += new System.EventHandler(this.Tb_pesquisa_Enter);
            this.tb_pesquisar.Leave += new System.EventHandler(this.Tb_pesquisa_Leave);
            // 
            // pb_wallpaper
            // 
            this.pb_wallpaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_wallpaper.BackgroundImage")));
            this.pb_wallpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_wallpaper.Location = new System.Drawing.Point(0, 0);
            this.pb_wallpaper.Name = "pb_wallpaper";
            this.pb_wallpaper.Size = new System.Drawing.Size(1282, 200);
            this.pb_wallpaper.TabIndex = 18;
            this.pb_wallpaper.TabStop = false;
            // 
            // FormServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.pb_wallpaper);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicos";
            this.Text = "servicos";
            this.Load += new System.EventHandler(this.Formservicos_Load);
            this.panel_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).EndInit();
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wallpaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.PictureBox pb_pesquisar;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.TextBox tb_pesquisar;
        private System.Windows.Forms.PictureBox pb_wallpaper;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}