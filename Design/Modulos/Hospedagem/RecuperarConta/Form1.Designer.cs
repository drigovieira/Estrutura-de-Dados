namespace RecuperarSenha
{
    partial class Form1
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
            this.button_recuperar = new System.Windows.Forms.Button();
            this.textB_senha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textB_email = new System.Windows.Forms.TextBox();
            this.textB_cpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_recuperar
            // 
            this.button_recuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button_recuperar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.button_recuperar.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_recuperar.ForeColor = System.Drawing.Color.White;
            this.button_recuperar.Location = new System.Drawing.Point(234, 469);
            this.button_recuperar.Name = "button_recuperar";
            this.button_recuperar.Size = new System.Drawing.Size(148, 42);
            this.button_recuperar.TabIndex = 36;
            this.button_recuperar.Text = "Recuperar";
            this.button_recuperar.UseVisualStyleBackColor = false;
            // 
            // textB_senha
            // 
            this.textB_senha.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_senha.Location = new System.Drawing.Point(165, 398);
            this.textB_senha.Name = "textB_senha";
            this.textB_senha.Size = new System.Drawing.Size(300, 29);
            this.textB_senha.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nova senha:";
            // 
            // textB_email
            // 
            this.textB_email.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_email.Location = new System.Drawing.Point(165, 317);
            this.textB_email.Name = "textB_email";
            this.textB_email.Size = new System.Drawing.Size(300, 29);
            this.textB_email.TabIndex = 33;
            // 
            // textB_cpf
            // 
            this.textB_cpf.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textB_cpf.Location = new System.Drawing.Point(165, 239);
            this.textB_cpf.Name = "textB_cpf";
            this.textB_cpf.Size = new System.Drawing.Size(300, 29);
            this.textB_cpf.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 45);
            this.label7.TabIndex = 26;
            this.label7.Text = "Recuperar conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "Recupere sua conta para utilizar novamente nossos serviços ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_recuperar);
            this.Controls.Add(this.textB_senha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textB_email);
            this.Controls.Add(this.textB_cpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_recuperar;
        private System.Windows.Forms.TextBox textB_senha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textB_email;
        private System.Windows.Forms.TextBox textB_cpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}

