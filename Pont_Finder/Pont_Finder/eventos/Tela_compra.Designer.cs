namespace Pont_Finder.eventos
{
    partial class Tela_compra
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.senhabox = new System.Windows.Forms.TextBox();
            this.qntbox = new System.Windows.Forms.TextBox();
            this.cbbox = new System.Windows.Forms.ComboBox();
            this.bt_comprar = new System.Windows.Forms.Button();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 100);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Método de pagamento\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // senhabox
            // 
            this.senhabox.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhabox.Location = new System.Drawing.Point(747, 367);
            this.senhabox.Name = "senhabox";
            this.senhabox.Size = new System.Drawing.Size(154, 32);
            this.senhabox.TabIndex = 11;
            this.senhabox.TextChanged += new System.EventHandler(this.senhabox_TextChanged);
            // 
            // qntbox
            // 
            this.qntbox.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qntbox.Location = new System.Drawing.Point(747, 329);
            this.qntbox.Name = "qntbox";
            this.qntbox.Size = new System.Drawing.Size(154, 28);
            this.qntbox.TabIndex = 12;
            this.qntbox.TextChanged += new System.EventHandler(this.qntbox_TextChanged);
            // 
            // cbbox
            // 
            this.cbbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbox.FormattingEnabled = true;
            this.cbbox.Items.AddRange(new object[] {
            "Cartão de crédito",
            "Boleto"});
            this.cbbox.Location = new System.Drawing.Point(747, 294);
            this.cbbox.Name = "cbbox";
            this.cbbox.Size = new System.Drawing.Size(154, 28);
            this.cbbox.TabIndex = 13;
            this.cbbox.SelectedIndexChanged += new System.EventHandler(this.cbbox_SelectedIndexChanged);
            // 
            // bt_comprar
            // 
            this.bt_comprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_comprar.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_comprar.ForeColor = System.Drawing.Color.White;
            this.bt_comprar.Location = new System.Drawing.Point(542, 429);
            this.bt_comprar.Name = "bt_comprar";
            this.bt_comprar.Size = new System.Drawing.Size(121, 42);
            this.bt_comprar.TabIndex = 14;
            this.bt_comprar.Text = "Comprar";
            this.bt_comprar.UseVisualStyleBackColor = false;
            this.bt_comprar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_limpar
            // 
            this.bt_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_limpar.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.ForeColor = System.Drawing.Color.White;
            this.bt_limpar.Location = new System.Drawing.Point(780, 429);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(121, 42);
            this.bt_limpar.TabIndex = 15;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = false;
            this.bt_limpar.Click += new System.EventHandler(this.Bt_limpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 34);
            this.label5.TabIndex = 17;
            this.label5.Text = "Selecione aqui a melhor opção de compra";
            // 
            // Tela_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.bt_comprar);
            this.Controls.Add(this.cbbox);
            this.Controls.Add(this.qntbox);
            this.Controls.Add(this.senhabox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "Tela_compra";
            this.Text = "Tela_compra";
            this.Load += new System.EventHandler(this.Tela_compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox senhabox;
        private System.Windows.Forms.TextBox qntbox;
        private System.Windows.Forms.ComboBox cbbox;
        private System.Windows.Forms.Button bt_comprar;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}