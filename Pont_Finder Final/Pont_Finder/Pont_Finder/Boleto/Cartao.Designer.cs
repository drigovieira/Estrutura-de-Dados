namespace Pont_Finder.Boleto
{
    partial class Cartao
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_cartao_titular
            // 
            this.tb_cartao_titular.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cartao_titular.Location = new System.Drawing.Point(153, 92);
            this.tb_cartao_titular.Name = "tb_cartao_titular";
            this.tb_cartao_titular.Size = new System.Drawing.Size(344, 28);
            this.tb_cartao_titular.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Nome do Titular";
            // 
            // cb_cartao_cod
            // 
            this.cb_cartao_cod.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cartao_cod.Location = new System.Drawing.Point(265, 240);
            this.cb_cartao_cod.Name = "cb_cartao_cod";
            this.cb_cartao_cod.Size = new System.Drawing.Size(232, 28);
            this.cb_cartao_cod.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Cod. Segurança:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Vencimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 27);
            this.label2.TabIndex = 36;
            this.label2.Text = "Preencha os dados do cartão";
            // 
            // mkb_cartao_vencimento
            // 
            this.mkb_cartao_vencimento.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_cartao_vencimento.Location = new System.Drawing.Point(153, 240);
            this.mkb_cartao_vencimento.Mask = "00/00";
            this.mkb_cartao_vencimento.Name = "mkb_cartao_vencimento";
            this.mkb_cartao_vencimento.Size = new System.Drawing.Size(106, 28);
            this.mkb_cartao_vencimento.TabIndex = 35;
            this.mkb_cartao_vencimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tb_cartao_num
            // 
            this.tb_cartao_num.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cartao_num.Location = new System.Drawing.Point(153, 166);
            this.tb_cartao_num.Name = "tb_cartao_num";
            this.tb_cartao_num.Size = new System.Drawing.Size(343, 28);
            this.tb_cartao_num.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Número do Cartão";
            // 
            // cb_qtd_parcelas
            // 
            this.cb_qtd_parcelas.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_qtd_parcelas.FormattingEnabled = true;
            this.cb_qtd_parcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.cb_qtd_parcelas.Location = new System.Drawing.Point(153, 320);
            this.cb_qtd_parcelas.Name = "cb_qtd_parcelas";
            this.cb_qtd_parcelas.Size = new System.Drawing.Size(343, 29);
            this.cb_qtd_parcelas.TabIndex = 32;
            // 
            // cb_select_cartao
            // 
            this.cb_select_cartao.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_select_cartao.FormattingEnabled = true;
            this.cb_select_cartao.Items.AddRange(new object[] {
            "MasterCard",
            "Visa",
            "Elo",
            "Diners Club",
            "American Express"});
            this.cb_select_cartao.Location = new System.Drawing.Point(153, 403);
            this.cb_select_cartao.Name = "cb_select_cartao";
            this.cb_select_cartao.Size = new System.Drawing.Size(343, 29);
            this.cb_select_cartao.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(153, 473);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 35);
            this.button4.TabIndex = 127;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(172)))), ((int)(((byte)(20)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(366, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 35);
            this.button3.TabIndex = 126;
            this.button3.Text = "Aceitar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(150, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 21);
            this.label7.TabIndex = 128;
            this.label7.Text = "Quantidade de Parcelas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(150, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 21);
            this.label8.TabIndex = 129;
            this.label8.Text = "Selecione o Cartão";
            // 
            // Cartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 532);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
            this.Name = "Cartao";
            this.Text = "Cartao";
            this.Load += new System.EventHandler(this.Cartao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}