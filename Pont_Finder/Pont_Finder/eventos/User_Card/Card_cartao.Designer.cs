namespace Pont_Finder.eventos.User_Card
{
    partial class Card_cartao
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
            this.mkb_cartao_CPF = new System.Windows.Forms.MaskedTextBox();
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
            this.bt_limpar = new System.Windows.Forms.Button();
            this.bt_finalizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mkb_cartao_CPF
            // 
            this.mkb_cartao_CPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mkb_cartao_CPF.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_cartao_CPF.Location = new System.Drawing.Point(124, 423);
            this.mkb_cartao_CPF.Mask = "000.000.000-00";
            this.mkb_cartao_CPF.Name = "mkb_cartao_CPF";
            this.mkb_cartao_CPF.Size = new System.Drawing.Size(150, 24);
            this.mkb_cartao_CPF.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 42;
            this.label6.Text = "CPF do titular:";
            // 
            // tb_cartao_titular
            // 
            this.tb_cartao_titular.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cartao_titular.Location = new System.Drawing.Point(123, 354);
            this.tb_cartao_titular.Name = "tb_cartao_titular";
            this.tb_cartao_titular.Size = new System.Drawing.Size(250, 24);
            this.tb_cartao_titular.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Titular:";
            // 
            // cb_cartao_cod
            // 
            this.cb_cartao_cod.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cartao_cod.Location = new System.Drawing.Point(123, 300);
            this.cb_cartao_cod.Name = "cb_cartao_cod";
            this.cb_cartao_cod.Size = new System.Drawing.Size(250, 24);
            this.cb_cartao_cod.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Cod. Segurança:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Vencimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 27);
            this.label2.TabIndex = 36;
            this.label2.Text = "Preencha os dados do cartão";
            // 
            // mkb_cartao_vencimento
            // 
            this.mkb_cartao_vencimento.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_cartao_vencimento.Location = new System.Drawing.Point(123, 237);
            this.mkb_cartao_vencimento.Mask = "00/00";
            this.mkb_cartao_vencimento.Name = "mkb_cartao_vencimento";
            this.mkb_cartao_vencimento.Size = new System.Drawing.Size(88, 24);
            this.mkb_cartao_vencimento.TabIndex = 35;
            this.mkb_cartao_vencimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tb_cartao_num
            // 
            this.tb_cartao_num.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cartao_num.Location = new System.Drawing.Point(123, 178);
            this.tb_cartao_num.Name = "tb_cartao_num";
            this.tb_cartao_num.Size = new System.Drawing.Size(250, 24);
            this.tb_cartao_num.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Número:";
            // 
            // cb_qtd_parcelas
            // 
            this.cb_qtd_parcelas.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_qtd_parcelas.FormattingEnabled = true;
            this.cb_qtd_parcelas.Location = new System.Drawing.Point(333, 82);
            this.cb_qtd_parcelas.Name = "cb_qtd_parcelas";
            this.cb_qtd_parcelas.Size = new System.Drawing.Size(170, 25);
            this.cb_qtd_parcelas.TabIndex = 32;
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
            this.cb_select_cartao.Location = new System.Drawing.Point(123, 82);
            this.cb_select_cartao.Name = "cb_select_cartao";
            this.cb_select_cartao.Size = new System.Drawing.Size(150, 25);
            this.cb_select_cartao.TabIndex = 31;
            this.cb_select_cartao.Text = "Selecione o cartão";
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.bt_limpar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.ForeColor = System.Drawing.Color.White;
            this.bt_limpar.Location = new System.Drawing.Point(324, 479);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(200, 50);
            this.bt_limpar.TabIndex = 45;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.Bt_limpar_Click);
            // 
            // bt_finalizar
            // 
            this.bt_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.bt_finalizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_finalizar.ForeColor = System.Drawing.Color.White;
            this.bt_finalizar.Location = new System.Drawing.Point(109, 479);
            this.bt_finalizar.Name = "bt_finalizar";
            this.bt_finalizar.Size = new System.Drawing.Size(200, 50);
            this.bt_finalizar.TabIndex = 44;
            this.bt_finalizar.Text = "Finalizar compra";
            this.bt_finalizar.UseVisualStyleBackColor = false;
            this.bt_finalizar.Click += new System.EventHandler(this.Bt_finalizar_Click);
            // 
            // Card_cartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_finalizar);
            this.Controls.Add(this.mkb_cartao_CPF);
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
            this.Name = "Card_cartao";
            this.Size = new System.Drawing.Size(623, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mkb_cartao_CPF;
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
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Button bt_finalizar;
    }
}
