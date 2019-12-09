namespace Pont_Finder.eventos.User_Card
{
    partial class Card_boleto
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
            this.lb_txt4_boleto = new System.Windows.Forms.Label();
            this.mkb_boleto_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lb_txt3_boleto = new System.Windows.Forms.Label();
            this.lb_txt2_boleto = new System.Windows.Forms.Label();
            this.tb_boleto_email = new System.Windows.Forms.TextBox();
            this.lb_txt1_boleto_ = new System.Windows.Forms.Label();
            this.mkb_boleto_RG = new System.Windows.Forms.MaskedTextBox();
            this.lb_txt_boleto_titulo = new System.Windows.Forms.Label();
            this.tb_boleto_nome = new System.Windows.Forms.TextBox();
            this.bt_finalizar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_txt4_boleto
            // 
            this.lb_txt4_boleto.AutoSize = true;
            this.lb_txt4_boleto.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt4_boleto.Location = new System.Drawing.Point(102, 290);
            this.lb_txt4_boleto.Name = "lb_txt4_boleto";
            this.lb_txt4_boleto.Size = new System.Drawing.Size(40, 21);
            this.lb_txt4_boleto.TabIndex = 35;
            this.lb_txt4_boleto.Text = "CPF:";
            // 
            // mkb_boleto_CPF
            // 
            this.mkb_boleto_CPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mkb_boleto_CPF.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_boleto_CPF.Location = new System.Drawing.Point(106, 314);
            this.mkb_boleto_CPF.Mask = "000.000.000-00";
            this.mkb_boleto_CPF.Name = "mkb_boleto_CPF";
            this.mkb_boleto_CPF.Size = new System.Drawing.Size(150, 24);
            this.mkb_boleto_CPF.TabIndex = 3;
            this.mkb_boleto_CPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_txt3_boleto
            // 
            this.lb_txt3_boleto.AutoSize = true;
            this.lb_txt3_boleto.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt3_boleto.Location = new System.Drawing.Point(102, 224);
            this.lb_txt3_boleto.Name = "lb_txt3_boleto";
            this.lb_txt3_boleto.Size = new System.Drawing.Size(34, 21);
            this.lb_txt3_boleto.TabIndex = 33;
            this.lb_txt3_boleto.Text = "RG:";
            // 
            // lb_txt2_boleto
            // 
            this.lb_txt2_boleto.AutoSize = true;
            this.lb_txt2_boleto.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt2_boleto.Location = new System.Drawing.Point(102, 163);
            this.lb_txt2_boleto.Name = "lb_txt2_boleto";
            this.lb_txt2_boleto.Size = new System.Drawing.Size(57, 21);
            this.lb_txt2_boleto.TabIndex = 32;
            this.lb_txt2_boleto.Text = "E-mail:";
            // 
            // tb_boleto_email
            // 
            this.tb_boleto_email.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_boleto_email.Location = new System.Drawing.Point(106, 187);
            this.tb_boleto_email.Name = "tb_boleto_email";
            this.tb_boleto_email.Size = new System.Drawing.Size(415, 24);
            this.tb_boleto_email.TabIndex = 1;
            // 
            // lb_txt1_boleto_
            // 
            this.lb_txt1_boleto_.AutoSize = true;
            this.lb_txt1_boleto_.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt1_boleto_.Location = new System.Drawing.Point(102, 95);
            this.lb_txt1_boleto_.Name = "lb_txt1_boleto_";
            this.lb_txt1_boleto_.Size = new System.Drawing.Size(125, 21);
            this.lb_txt1_boleto_.TabIndex = 30;
            this.lb_txt1_boleto_.Text = "Nome completo:";
            // 
            // mkb_boleto_RG
            // 
            this.mkb_boleto_RG.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mkb_boleto_RG.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_boleto_RG.Location = new System.Drawing.Point(106, 248);
            this.mkb_boleto_RG.Mask = "00.000.000-0";
            this.mkb_boleto_RG.Name = "mkb_boleto_RG";
            this.mkb_boleto_RG.Size = new System.Drawing.Size(150, 24);
            this.mkb_boleto_RG.TabIndex = 2;
            this.mkb_boleto_RG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lb_txt_boleto_titulo
            // 
            this.lb_txt_boleto_titulo.AutoSize = true;
            this.lb_txt_boleto_titulo.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt_boleto_titulo.Location = new System.Drawing.Point(180, 20);
            this.lb_txt_boleto_titulo.Name = "lb_txt_boleto_titulo";
            this.lb_txt_boleto_titulo.Size = new System.Drawing.Size(297, 27);
            this.lb_txt_boleto_titulo.TabIndex = 28;
            this.lb_txt_boleto_titulo.Text = "Preencha os dados do boleto";
            // 
            // tb_boleto_nome
            // 
            this.tb_boleto_nome.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_boleto_nome.Location = new System.Drawing.Point(106, 119);
            this.tb_boleto_nome.Name = "tb_boleto_nome";
            this.tb_boleto_nome.Size = new System.Drawing.Size(415, 24);
            this.tb_boleto_nome.TabIndex = 0;
            // 
            // bt_finalizar
            // 
            this.bt_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.bt_finalizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_finalizar.ForeColor = System.Drawing.Color.White;
            this.bt_finalizar.Location = new System.Drawing.Point(106, 368);
            this.bt_finalizar.Name = "bt_finalizar";
            this.bt_finalizar.Size = new System.Drawing.Size(200, 50);
            this.bt_finalizar.TabIndex = 4;
            this.bt_finalizar.Text = "Finalizar compra";
            this.bt_finalizar.UseVisualStyleBackColor = false;
            this.bt_finalizar.Click += new System.EventHandler(this.Bt_finalizar_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.bt_limpar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.ForeColor = System.Drawing.Color.White;
            this.bt_limpar.Location = new System.Drawing.Point(321, 368);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(200, 50);
            this.bt_limpar.TabIndex = 5;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.Bt_limpar_Click);
            // 
            // Card_boleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_finalizar);
            this.Controls.Add(this.lb_txt4_boleto);
            this.Controls.Add(this.mkb_boleto_CPF);
            this.Controls.Add(this.lb_txt3_boleto);
            this.Controls.Add(this.lb_txt2_boleto);
            this.Controls.Add(this.tb_boleto_email);
            this.Controls.Add(this.lb_txt1_boleto_);
            this.Controls.Add(this.mkb_boleto_RG);
            this.Controls.Add(this.lb_txt_boleto_titulo);
            this.Controls.Add(this.tb_boleto_nome);
            this.Name = "Card_boleto";
            this.Size = new System.Drawing.Size(623, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_txt4_boleto;
        private System.Windows.Forms.MaskedTextBox mkb_boleto_CPF;
        private System.Windows.Forms.Label lb_txt3_boleto;
        private System.Windows.Forms.Label lb_txt2_boleto;
        private System.Windows.Forms.TextBox tb_boleto_email;
        private System.Windows.Forms.Label lb_txt1_boleto_;
        private System.Windows.Forms.MaskedTextBox mkb_boleto_RG;
        private System.Windows.Forms.Label lb_txt_boleto_titulo;
        private System.Windows.Forms.TextBox tb_boleto_nome;
        private System.Windows.Forms.Button bt_finalizar;
        private System.Windows.Forms.Button bt_limpar;
    }
}
