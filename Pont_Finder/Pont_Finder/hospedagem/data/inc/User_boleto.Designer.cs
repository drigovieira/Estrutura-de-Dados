namespace Pont_Finder.hospedagem.data.inc
{
    partial class User_boleto
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
            this.mkb_boleto_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_boleto_email = new System.Windows.Forms.TextBox();
            this.lb_txt1 = new System.Windows.Forms.Label();
            this.lb_txt2 = new System.Windows.Forms.Label();
            this.tb_boleto_nome = new System.Windows.Forms.TextBox();
            this.lb_txt4 = new System.Windows.Forms.Label();
            this.mkb_boleto_rg = new System.Windows.Forms.MaskedTextBox();
            this.lb_txt3 = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mkb_boleto_cpf
            // 
            this.mkb_boleto_cpf.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_boleto_cpf.Location = new System.Drawing.Point(62, 312);
            this.mkb_boleto_cpf.Mask = "000.000.000-00";
            this.mkb_boleto_cpf.Name = "mkb_boleto_cpf";
            this.mkb_boleto_cpf.Size = new System.Drawing.Size(300, 24);
            this.mkb_boleto_cpf.TabIndex = 36;
            this.mkb_boleto_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tb_boleto_email
            // 
            this.tb_boleto_email.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_boleto_email.Location = new System.Drawing.Point(62, 168);
            this.tb_boleto_email.Name = "tb_boleto_email";
            this.tb_boleto_email.Size = new System.Drawing.Size(500, 24);
            this.tb_boleto_email.TabIndex = 37;
            // 
            // lb_txt1
            // 
            this.lb_txt1.AutoSize = true;
            this.lb_txt1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt1.Location = new System.Drawing.Point(58, 64);
            this.lb_txt1.Name = "lb_txt1";
            this.lb_txt1.Size = new System.Drawing.Size(125, 21);
            this.lb_txt1.TabIndex = 38;
            this.lb_txt1.Text = "Nome completo:";
            // 
            // lb_txt2
            // 
            this.lb_txt2.AutoSize = true;
            this.lb_txt2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt2.Location = new System.Drawing.Point(65, 144);
            this.lb_txt2.Name = "lb_txt2";
            this.lb_txt2.Size = new System.Drawing.Size(57, 21);
            this.lb_txt2.TabIndex = 40;
            this.lb_txt2.Text = "E-mail:";
            // 
            // tb_boleto_nome
            // 
            this.tb_boleto_nome.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_boleto_nome.Location = new System.Drawing.Point(62, 88);
            this.tb_boleto_nome.Name = "tb_boleto_nome";
            this.tb_boleto_nome.Size = new System.Drawing.Size(500, 24);
            this.tb_boleto_nome.TabIndex = 35;
            this.tb_boleto_nome.Tag = "";
            // 
            // lb_txt4
            // 
            this.lb_txt4.AutoSize = true;
            this.lb_txt4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt4.Location = new System.Drawing.Point(65, 288);
            this.lb_txt4.Name = "lb_txt4";
            this.lb_txt4.Size = new System.Drawing.Size(40, 21);
            this.lb_txt4.TabIndex = 39;
            this.lb_txt4.Text = "CPF:";
            // 
            // mkb_boleto_rg
            // 
            this.mkb_boleto_rg.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_boleto_rg.Location = new System.Drawing.Point(62, 239);
            this.mkb_boleto_rg.Mask = "00.000.000-0";
            this.mkb_boleto_rg.Name = "mkb_boleto_rg";
            this.mkb_boleto_rg.Size = new System.Drawing.Size(300, 24);
            this.mkb_boleto_rg.TabIndex = 41;
            this.mkb_boleto_rg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_txt3
            // 
            this.lb_txt3.AutoSize = true;
            this.lb_txt3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt3.Location = new System.Drawing.Point(65, 215);
            this.lb_txt3.Name = "lb_txt3";
            this.lb_txt3.Size = new System.Drawing.Size(34, 21);
            this.lb_txt3.TabIndex = 42;
            this.lb_txt3.Text = "RG:";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(163, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(270, 25);
            this.lb_titulo.TabIndex = 43;
            this.lb_titulo.Text = "Preencha os dados do boleto";
            // 
            // User_boleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.mkb_boleto_rg);
            this.Controls.Add(this.lb_txt3);
            this.Controls.Add(this.mkb_boleto_cpf);
            this.Controls.Add(this.tb_boleto_email);
            this.Controls.Add(this.lb_txt1);
            this.Controls.Add(this.lb_txt2);
            this.Controls.Add(this.tb_boleto_nome);
            this.Controls.Add(this.lb_txt4);
            this.Name = "User_boleto";
            this.Size = new System.Drawing.Size(625, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mkb_boleto_cpf;
        private System.Windows.Forms.TextBox tb_boleto_email;
        private System.Windows.Forms.Label lb_txt1;
        private System.Windows.Forms.Label lb_txt2;
        private System.Windows.Forms.TextBox tb_boleto_nome;
        private System.Windows.Forms.Label lb_txt4;
        private System.Windows.Forms.MaskedTextBox mkb_boleto_rg;
        private System.Windows.Forms.Label lb_txt3;
        private System.Windows.Forms.Label lb_titulo;
    }
}
