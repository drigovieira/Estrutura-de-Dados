﻿namespace Pont_Finder.hospedagem.data.inc
{
    partial class Reserva_cartao
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
            this.mkb_boleto_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_cartao_titular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_cartao_cod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mkb_cartao_vencimento = new System.Windows.Forms.MaskedTextBox();
            this.tb_cartao_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_qtd_parcelas = new System.Windows.Forms.ComboBox();
            this.cb_select_cartao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // mkb_boleto_CPF
            // 
            this.mkb_boleto_CPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mkb_boleto_CPF.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_boleto_CPF.Location = new System.Drawing.Point(124, 416);
            this.mkb_boleto_CPF.Mask = "000.000.000-00";
            this.mkb_boleto_CPF.Name = "mkb_boleto_CPF";
            this.mkb_boleto_CPF.Size = new System.Drawing.Size(150, 24);
            this.mkb_boleto_CPF.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "CPF do titular:";
            // 
            // tb_cartao_titular
            // 
            this.tb_cartao_titular.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cartao_titular.Location = new System.Drawing.Point(123, 347);
            this.tb_cartao_titular.Name = "tb_cartao_titular";
            this.tb_cartao_titular.Size = new System.Drawing.Size(250, 24);
            this.tb_cartao_titular.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Titular:";
            // 
            // cb_cartao_cod
            // 
            this.cb_cartao_cod.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cartao_cod.Location = new System.Drawing.Point(123, 293);
            this.cb_cartao_cod.Name = "cb_cartao_cod";
            this.cb_cartao_cod.Size = new System.Drawing.Size(250, 24);
            this.cb_cartao_cod.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cod. Segurança:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Vencimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Preencha os dados do cartão";
            // 
            // mkb_cartao_vencimento
            // 
            this.mkb_cartao_vencimento.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_cartao_vencimento.Location = new System.Drawing.Point(123, 230);
            this.mkb_cartao_vencimento.Mask = "00/00";
            this.mkb_cartao_vencimento.Name = "mkb_cartao_vencimento";
            this.mkb_cartao_vencimento.Size = new System.Drawing.Size(88, 24);
            this.mkb_cartao_vencimento.TabIndex = 22;
            this.mkb_cartao_vencimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tb_cartao_num
            // 
            this.tb_cartao_num.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cartao_num.Location = new System.Drawing.Point(123, 171);
            this.tb_cartao_num.Name = "tb_cartao_num";
            this.tb_cartao_num.Size = new System.Drawing.Size(250, 24);
            this.tb_cartao_num.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Número:";
            // 
            // cb_qtd_parcelas
            // 
            this.cb_qtd_parcelas.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_qtd_parcelas.FormattingEnabled = true;
            this.cb_qtd_parcelas.Location = new System.Drawing.Point(333, 75);
            this.cb_qtd_parcelas.Name = "cb_qtd_parcelas";
            this.cb_qtd_parcelas.Size = new System.Drawing.Size(170, 25);
            this.cb_qtd_parcelas.TabIndex = 19;
            this.cb_qtd_parcelas.Text = "Quantidade de parcelas";
            // 
            // cb_select_cartao
            // 
            this.cb_select_cartao.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_select_cartao.FormattingEnabled = true;
            this.cb_select_cartao.Items.AddRange(new object[] {
            "MasterCard",
            "Visa",
            "Elo",
            "Diners Club",
            "American Express"});
            this.cb_select_cartao.Location = new System.Drawing.Point(123, 75);
            this.cb_select_cartao.Name = "cb_select_cartao";
            this.cb_select_cartao.Size = new System.Drawing.Size(150, 25);
            this.cb_select_cartao.TabIndex = 18;
            this.cb_select_cartao.Text = "Selecione o cartão";
            // 
            // Reserva_cartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mkb_boleto_CPF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_cartao_titular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_cartao_cod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mkb_cartao_vencimento);
            this.Controls.Add(this.tb_cartao_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_qtd_parcelas);
            this.Controls.Add(this.cb_select_cartao);
            this.Name = "Reserva_cartao";
            this.Size = new System.Drawing.Size(623, 468);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mkb_boleto_CPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_cartao_titular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cb_cartao_cod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkb_cartao_vencimento;
        private System.Windows.Forms.TextBox tb_cartao_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_qtd_parcelas;
        private System.Windows.Forms.ComboBox cb_select_cartao;
    }
}
