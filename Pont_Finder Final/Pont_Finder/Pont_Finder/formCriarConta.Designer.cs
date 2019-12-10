namespace Pont_Finder
{
    partial class formCriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCriarConta));
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.textB_senha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textB_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textB_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            this.mkb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.pb_versenha = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_versenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button_Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.button_Cadastrar.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cadastrar.ForeColor = System.Drawing.Color.White;
            this.button_Cadastrar.Location = new System.Drawing.Point(241, 566);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(148, 42);
            this.button_Cadastrar.TabIndex = 5;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = false;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // textB_senha
            // 
            this.textB_senha.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_senha.Location = new System.Drawing.Point(165, 499);
            this.textB_senha.Name = "textB_senha";
            this.textB_senha.Size = new System.Drawing.Size(300, 29);
            this.textB_senha.TabIndex = 4;
            this.textB_senha.UseSystemPasswordChar = true;
            this.textB_senha.TextChanged += new System.EventHandler(this.TextB_senha_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Senha:";
            // 
            // textB_email
            // 
            this.textB_email.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_email.Location = new System.Drawing.Point(165, 430);
            this.textB_email.Name = "textB_email";
            this.textB_email.Size = new System.Drawing.Size(300, 29);
            this.textB_email.TabIndex = 3;
            this.textB_email.TextChanged += new System.EventHandler(this.TextB_email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "CPF:";
            // 
            // textB_nome
            // 
            this.textB_nome.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_nome.Location = new System.Drawing.Point(165, 291);
            this.textB_nome.Name = "textB_nome";
            this.textB_nome.Size = new System.Drawing.Size(300, 29);
            this.textB_nome.TabIndex = 1;
            this.textB_nome.Tag = "";
            this.textB_nome.TextChanged += new System.EventHandler(this.TextB_nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nome completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Crie uma conta para utilizar os serviços Point Finder!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Criar conta";
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            this.openIcone.Filter = "\"Image|*.jpg;*.jpeg;*.bmp\"";
            // 
            // mkb_cpf
            // 
            this.mkb_cpf.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_cpf.Location = new System.Drawing.Point(165, 360);
            this.mkb_cpf.Mask = "000.000.000-00";
            this.mkb_cpf.Name = "mkb_cpf";
            this.mkb_cpf.Size = new System.Drawing.Size(300, 29);
            this.mkb_cpf.TabIndex = 2;
            this.mkb_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // pb_versenha
            // 
            this.pb_versenha.BackColor = System.Drawing.Color.Transparent;
            this.pb_versenha.Image = global::Pont_Finder.Properties.Resources.noview_icon_1;
            this.pb_versenha.Location = new System.Drawing.Point(438, 501);
            this.pb_versenha.Name = "pb_versenha";
            this.pb_versenha.Size = new System.Drawing.Size(25, 25);
            this.pb_versenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_versenha.TabIndex = 27;
            this.pb_versenha.TabStop = false;
            this.pb_versenha.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(374, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pb_icone
            // 
            this.pb_icone.Image = ((System.Drawing.Image)(resources.GetObject("pb_icone.Image")));
            this.pb_icone.InitialImage = null;
            this.pb_icone.Location = new System.Drawing.Point(240, 96);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(150, 150);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 26;
            this.pb_icone.TabStop = false;
            this.pb_icone.WaitOnLoad = true;
            // 
            // formCriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 630);
            this.Controls.Add(this.pb_versenha);
            this.Controls.Add(this.mkb_cpf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.textB_senha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textB_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textB_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_icone);
            this.Name = "formCriarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Conta";
            this.Load += new System.EventHandler(this.formCriarConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_versenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.TextBox textB_senha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textB_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textB_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openIcone;
        private System.Windows.Forms.MaskedTextBox mkb_cpf;
        private System.Windows.Forms.PictureBox pb_versenha;
    }
}