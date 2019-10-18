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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_tipo
            // 
            this.input_tipo.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_tipo.Location = new System.Drawing.Point(105, 110);
            this.input_tipo.Name = "input_tipo";
            this.input_tipo.Size = new System.Drawing.Size(415, 29);
            this.input_tipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o tipo (nome) do quarto: ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // input_qtdpessoas
            // 
            this.input_qtdpessoas.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_qtdpessoas.FormattingEnabled = true;
            this.input_qtdpessoas.Items.AddRange(new object[] {
            "1 Pessoa",
            "2 Pessoas",
            "3 Pessoas",
            "4 Pessoas"});
            this.input_qtdpessoas.Location = new System.Drawing.Point(212, 189);
            this.input_qtdpessoas.Name = "input_qtdpessoas";
            this.input_qtdpessoas.Size = new System.Drawing.Size(200, 30);
            this.input_qtdpessoas.TabIndex = 4;
            this.input_qtdpessoas.Text = "Selecione a quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade de pessoas suportadas:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade de quartos existentes: ";
            // 
            // input_qtdquarto
            // 
            this.input_qtdquarto.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_qtdquarto.Location = new System.Drawing.Point(212, 268);
            this.input_qtdquarto.Name = "input_qtdquarto";
            this.input_qtdquarto.Size = new System.Drawing.Size(200, 29);
            this.input_qtdquarto.TabIndex = 6;
            // 
            // input_servicos
            // 
            this.input_servicos.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_servicos.FormattingEnabled = true;
            this.input_servicos.Items.AddRange(new object[] {
            "Café da manhã",
            "Estacionamento",
            "Almoço",
            "Café da Tarde",
            "TV a cabo",
            "Wi-fi",
            "Espaço PET"});
            this.input_servicos.Location = new System.Drawing.Point(177, 349);
            this.input_servicos.Name = "input_servicos";
            this.input_servicos.Size = new System.Drawing.Size(270, 124);
            this.input_servicos.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Serviços disponiveis para este quarto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Informe o valor da diária:";
            // 
            // input_valor
            // 
            this.input_valor.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_valor.Location = new System.Drawing.Point(212, 523);
            this.input_valor.Name = "input_valor";
            this.input_valor.Size = new System.Drawing.Size(200, 29);
            this.input_valor.TabIndex = 10;
            this.input_valor.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(171, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "R$";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(202, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // input_id
            // 
            this.input_id.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_id.Location = new System.Drawing.Point(454, 523);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(66, 29);
            this.input_id.TabIndex = 14;
            this.input_id.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.input_id);
            this.panel3.Controls.Add(this.input_valor);
            this.panel3.Controls.Add(this.input_servicos);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.input_qtdquarto);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.input_qtdpessoas);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.input_tipo);
            this.panel3.Location = new System.Drawing.Point(320, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 650);
            this.panel3.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(212, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 40);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cadastro de Quarto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(950, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 650);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 650);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}

