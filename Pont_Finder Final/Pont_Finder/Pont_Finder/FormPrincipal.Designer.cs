﻿namespace Pont_Finder
{
    partial class FormPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_userIcone = new System.Windows.Forms.PictureBox();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.bt_FazerLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_CriarConta = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pb_userIcone);
            this.panel1.Controls.Add(this.bt_Sair);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.bt_FazerLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_CriarConta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 45);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pb_userIcone
            // 
            this.pb_userIcone.Location = new System.Drawing.Point(955, 2);
            this.pb_userIcone.Name = "pb_userIcone";
            this.pb_userIcone.Size = new System.Drawing.Size(40, 40);
            this.pb_userIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_userIcone.TabIndex = 8;
            this.pb_userIcone.TabStop = false;
            this.pb_userIcone.Click += new System.EventHandler(this.Pb_userIcone_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.BackColor = System.Drawing.Color.Transparent;
            this.bt_Sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.bt_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bt_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Sair.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.ForeColor = System.Drawing.Color.White;
            this.bt_Sair.Location = new System.Drawing.Point(1155, 10);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(95, 25);
            this.bt_Sair.TabIndex = 7;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.Bt_Sair_Click);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(998, 10);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(98, 24);
            this.username.TabIndex = 4;
            this.username.Text = "UserName";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_FazerLogin
            // 
            this.bt_FazerLogin.BackColor = System.Drawing.Color.Transparent;
            this.bt_FazerLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_FazerLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.bt_FazerLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bt_FazerLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_FazerLogin.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_FazerLogin.ForeColor = System.Drawing.Color.White;
            this.bt_FazerLogin.Location = new System.Drawing.Point(1048, 10);
            this.bt_FazerLogin.Name = "bt_FazerLogin";
            this.bt_FazerLogin.Size = new System.Drawing.Size(95, 25);
            this.bt_FazerLogin.TabIndex = 1;
            this.bt_FazerLogin.Text = "Fazer Login";
            this.bt_FazerLogin.UseVisualStyleBackColor = false;
            this.bt_FazerLogin.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // bt_CriarConta
            // 
            this.bt_CriarConta.BackColor = System.Drawing.Color.White;
            this.bt_CriarConta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_CriarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.bt_CriarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.bt_CriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_CriarConta.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CriarConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_CriarConta.Location = new System.Drawing.Point(1155, 10);
            this.bt_CriarConta.Name = "bt_CriarConta";
            this.bt_CriarConta.Size = new System.Drawing.Size(95, 25);
            this.bt_CriarConta.TabIndex = 2;
            this.bt_CriarConta.Text = "Criar Conta";
            this.bt_CriarConta.UseVisualStyleBackColor = false;
            this.bt_CriarConta.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelHome
            // 
            this.panelHome.Location = new System.Drawing.Point(42, 45);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1282, 675);
            this.panelHome.TabIndex = 3;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1382, 759);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point Finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_FazerLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_CriarConta;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.PictureBox pb_userIcone;
    }
}

