namespace Front_do_Projeto
{
    partial class FormLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCriarC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textLoginSenha = new System.Windows.Forms.TextBox();
            this.textLoginEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.buttonLogin.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(216, 478);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(132, 36);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Fazer Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonCriarC
            // 
            this.buttonCriarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.buttonCriarC.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarC.ForeColor = System.Drawing.Color.White;
            this.buttonCriarC.Location = new System.Drawing.Point(216, 408);
            this.buttonCriarC.Name = "buttonCriarC";
            this.buttonCriarC.Size = new System.Drawing.Size(132, 36);
            this.buttonCriarC.TabIndex = 14;
            this.buttonCriarC.Text = "Criar Conta";
            this.buttonCriarC.UseVisualStyleBackColor = false;
            this.buttonCriarC.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Senha:";
            // 
            // textLoginSenha
            // 
            this.textLoginSenha.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoginSenha.Location = new System.Drawing.Point(133, 282);
            this.textLoginSenha.Multiline = true;
            this.textLoginSenha.Name = "textLoginSenha";
            this.textLoginSenha.Size = new System.Drawing.Size(300, 30);
            this.textLoginSenha.TabIndex = 12;
            this.textLoginSenha.Text = "Digite sua senha";
            // 
            // textLoginEmail
            // 
            this.textLoginEmail.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoginEmail.Location = new System.Drawing.Point(134, 176);
            this.textLoginEmail.Multiline = true;
            this.textLoginEmail.Name = "textLoginEmail";
            this.textLoginEmail.Size = new System.Drawing.Size(300, 30);
            this.textLoginEmail.TabIndex = 11;
            this.textLoginEmail.Tag = "";
            this.textLoginEmail.Text = "Digite o e-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Você pode fazer o login usando a sua conta para acessar nossos serviços.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonCriarC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLoginSenha);
            this.Controls.Add(this.textLoginEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fazer Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCriarC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textLoginSenha;
        private System.Windows.Forms.TextBox textLoginEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}