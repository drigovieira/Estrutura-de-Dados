namespace Lista_quartos
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
            this.input_tipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_qtdpessoas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_qtdquarto = new System.Windows.Forms.TextBox();
            this.input_servicos = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input_valor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.input_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_tipo
            // 
            this.input_tipo.Location = new System.Drawing.Point(31, 110);
            this.input_tipo.Name = "input_tipo";
            this.input_tipo.Size = new System.Drawing.Size(219, 20);
            this.input_tipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o tipo (nome) do quarto: ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // input_qtdpessoas
            // 
            this.input_qtdpessoas.FormattingEnabled = true;
            this.input_qtdpessoas.Items.AddRange(new object[] {
            "1 Pessoa",
            "2 Pessoas",
            "3 Pessoas",
            "4 Pessoas"});
            this.input_qtdpessoas.Location = new System.Drawing.Point(31, 173);
            this.input_qtdpessoas.Name = "input_qtdpessoas";
            this.input_qtdpessoas.Size = new System.Drawing.Size(219, 21);
            this.input_qtdpessoas.TabIndex = 4;
            this.input_qtdpessoas.Text = "Selecione a quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade de pessoas suportadas:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade de quartos existentes: ";
            // 
            // input_qtdquarto
            // 
            this.input_qtdquarto.Location = new System.Drawing.Point(31, 236);
            this.input_qtdquarto.Name = "input_qtdquarto";
            this.input_qtdquarto.Size = new System.Drawing.Size(219, 20);
            this.input_qtdquarto.TabIndex = 6;
            // 
            // input_servicos
            // 
            this.input_servicos.FormattingEnabled = true;
            this.input_servicos.Items.AddRange(new object[] {
            "Café da manhã",
            "Estacionamento",
            "Almoço",
            "Café da Tarde",
            "TV a cabo",
            "Wi-fi",
            "Espaço PET"});
            this.input_servicos.Location = new System.Drawing.Point(31, 302);
            this.input_servicos.Name = "input_servicos";
            this.input_servicos.Size = new System.Drawing.Size(219, 109);
            this.input_servicos.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serviços disponiveis para este quarto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Informe o valor da diária:";
            // 
            // input_valor
            // 
            this.input_valor.Location = new System.Drawing.Point(49, 453);
            this.input_valor.Name = "input_valor";
            this.input_valor.Size = new System.Drawing.Size(201, 20);
            this.input_valor.TabIndex = 10;
            this.input_valor.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "R$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 55);
            this.button1.TabIndex = 13;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // input_id
            // 
            this.input_id.Location = new System.Drawing.Point(31, 51);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(219, 20);
            this.input_id.TabIndex = 14;
            this.input_id.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 581);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_valor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_servicos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_qtdquarto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_qtdpessoas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_tipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox input_qtdpessoas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_qtdquarto;
        private System.Windows.Forms.CheckedListBox input_servicos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input_valor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input_id;
    }
}

