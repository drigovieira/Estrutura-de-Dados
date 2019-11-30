namespace Pont_Finder.hospedagem.data.inc
{
    partial class User_Cartao
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
            this.lb_txt1 = new System.Windows.Forms.Label();
            this.tb_cartao_num = new System.Windows.Forms.TextBox();
            this.lb_txt2 = new System.Windows.Forms.Label();
            this.mkb_cartao_vencimento = new System.Windows.Forms.MaskedTextBox();
            this.tb_cartao_cod = new System.Windows.Forms.TextBox();
            this.lb_txt3 = new System.Windows.Forms.Label();
            this.lb_txt4 = new System.Windows.Forms.Label();
            this.tb_cartao_titular = new System.Windows.Forms.TextBox();
            this.lb_txt5 = new System.Windows.Forms.Label();
            this.lb_txt = new System.Windows.Forms.Label();
            this.mkb_cartao_cpf = new System.Windows.Forms.MaskedTextBox();
            this.cb_cartão = new System.Windows.Forms.ComboBox();
            this.cb_parcelas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_txt1
            // 
            this.lb_txt1.AutoSize = true;
            this.lb_txt1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt1.Location = new System.Drawing.Point(50, 156);
            this.lb_txt1.Name = "lb_txt1";
            this.lb_txt1.Size = new System.Drawing.Size(68, 21);
            this.lb_txt1.TabIndex = 0;
            this.lb_txt1.Text = "Número";
            // 
            // tb_cartao_num
            // 
            this.tb_cartao_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cartao_num.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cartao_num.Location = new System.Drawing.Point(53, 180);
            this.tb_cartao_num.Name = "tb_cartao_num";
            this.tb_cartao_num.Size = new System.Drawing.Size(301, 24);
            this.tb_cartao_num.TabIndex = 1;
            // 
            // lb_txt2
            // 
            this.lb_txt2.AutoSize = true;
            this.lb_txt2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt2.Location = new System.Drawing.Point(50, 213);
            this.lb_txt2.Name = "lb_txt2";
            this.lb_txt2.Size = new System.Drawing.Size(93, 21);
            this.lb_txt2.TabIndex = 2;
            this.lb_txt2.Text = "Vencimento";
            // 
            // mkb_cartao_vencimento
            // 
            this.mkb_cartao_vencimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkb_cartao_vencimento.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_cartao_vencimento.Location = new System.Drawing.Point(53, 237);
            this.mkb_cartao_vencimento.Mask = "00/00";
            this.mkb_cartao_vencimento.Name = "mkb_cartao_vencimento";
            this.mkb_cartao_vencimento.Size = new System.Drawing.Size(136, 24);
            this.mkb_cartao_vencimento.TabIndex = 3;
            this.mkb_cartao_vencimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tb_cartao_cod
            // 
            this.tb_cartao_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cartao_cod.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cartao_cod.Location = new System.Drawing.Point(53, 294);
            this.tb_cartao_cod.Name = "tb_cartao_cod";
            this.tb_cartao_cod.Size = new System.Drawing.Size(136, 24);
            this.tb_cartao_cod.TabIndex = 4;
            // 
            // lb_txt3
            // 
            this.lb_txt3.AutoSize = true;
            this.lb_txt3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt3.Location = new System.Drawing.Point(49, 270);
            this.lb_txt3.Name = "lb_txt3";
            this.lb_txt3.Size = new System.Drawing.Size(118, 21);
            this.lb_txt3.TabIndex = 5;
            this.lb_txt3.Text = "Cód. Segurança";
            // 
            // lb_txt4
            // 
            this.lb_txt4.AutoSize = true;
            this.lb_txt4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt4.Location = new System.Drawing.Point(50, 325);
            this.lb_txt4.Name = "lb_txt4";
            this.lb_txt4.Size = new System.Drawing.Size(54, 21);
            this.lb_txt4.TabIndex = 7;
            this.lb_txt4.Text = "Titular";
            // 
            // tb_cartao_titular
            // 
            this.tb_cartao_titular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cartao_titular.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cartao_titular.Location = new System.Drawing.Point(53, 349);
            this.tb_cartao_titular.Name = "tb_cartao_titular";
            this.tb_cartao_titular.Size = new System.Drawing.Size(301, 24);
            this.tb_cartao_titular.TabIndex = 6;
            // 
            // lb_txt5
            // 
            this.lb_txt5.AutoSize = true;
            this.lb_txt5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt5.Location = new System.Drawing.Point(50, 388);
            this.lb_txt5.Name = "lb_txt5";
            this.lb_txt5.Size = new System.Drawing.Size(107, 21);
            this.lb_txt5.TabIndex = 9;
            this.lb_txt5.Text = "CPF do Titular";
            // 
            // lb_txt
            // 
            this.lb_txt.AutoSize = true;
            this.lb_txt.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt.Location = new System.Drawing.Point(177, 14);
            this.lb_txt.Name = "lb_txt";
            this.lb_txt.Size = new System.Drawing.Size(268, 25);
            this.lb_txt.TabIndex = 44;
            this.lb_txt.Text = "Preencha os dados do cartão";
            // 
            // mkb_cartao_cpf
            // 
            this.mkb_cartao_cpf.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_cartao_cpf.Location = new System.Drawing.Point(54, 412);
            this.mkb_cartao_cpf.Mask = "000.000.000-00";
            this.mkb_cartao_cpf.Name = "mkb_cartao_cpf";
            this.mkb_cartao_cpf.Size = new System.Drawing.Size(300, 24);
            this.mkb_cartao_cpf.TabIndex = 45;
            this.mkb_cartao_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cb_cartão
            // 
            this.cb_cartão.FormattingEnabled = true;
            this.cb_cartão.Items.AddRange(new object[] {
            "MasterCard",
            "Visa",
            "Elo",
            "Hipercard",
            "Diners Club",
            "American Express"});
            this.cb_cartão.Location = new System.Drawing.Point(100, 82);
            this.cb_cartão.Name = "cb_cartão";
            this.cb_cartão.Size = new System.Drawing.Size(153, 21);
            this.cb_cartão.TabIndex = 46;
            this.cb_cartão.Text = "Selecione o cartão";
            // 
            // cb_parcelas
            // 
            this.cb_parcelas.FormattingEnabled = true;
            this.cb_parcelas.Location = new System.Drawing.Point(340, 82);
            this.cb_parcelas.Name = "cb_parcelas";
            this.cb_parcelas.Size = new System.Drawing.Size(196, 21);
            this.cb_parcelas.TabIndex = 47;
            this.cb_parcelas.Text = "Selecione a quantidade de parcelas";
            // 
            // User_Cartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cb_parcelas);
            this.Controls.Add(this.cb_cartão);
            this.Controls.Add(this.mkb_cartao_cpf);
            this.Controls.Add(this.lb_txt);
            this.Controls.Add(this.lb_txt5);
            this.Controls.Add(this.lb_txt4);
            this.Controls.Add(this.tb_cartao_titular);
            this.Controls.Add(this.lb_txt3);
            this.Controls.Add(this.tb_cartao_cod);
            this.Controls.Add(this.mkb_cartao_vencimento);
            this.Controls.Add(this.lb_txt2);
            this.Controls.Add(this.tb_cartao_num);
            this.Controls.Add(this.lb_txt1);
            this.Name = "User_Cartao";
            this.Size = new System.Drawing.Size(625, 478);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_txt1;
        private System.Windows.Forms.TextBox tb_cartao_num;
        private System.Windows.Forms.Label lb_txt2;
        private System.Windows.Forms.MaskedTextBox mkb_cartao_vencimento;
        private System.Windows.Forms.TextBox tb_cartao_cod;
        private System.Windows.Forms.Label lb_txt3;
        private System.Windows.Forms.Label lb_txt4;
        private System.Windows.Forms.TextBox tb_cartao_titular;
        private System.Windows.Forms.Label lb_txt5;
        private System.Windows.Forms.Label lb_txt;
        private System.Windows.Forms.MaskedTextBox mkb_cartao_cpf;
        private System.Windows.Forms.ComboBox cb_cartão;
        private System.Windows.Forms.ComboBox cb_parcelas;
    }
}
