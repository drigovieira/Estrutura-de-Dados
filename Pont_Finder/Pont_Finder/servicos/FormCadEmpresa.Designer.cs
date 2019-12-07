namespace Pont_Finder.servicos
{
    partial class FormCadEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadEmpresa));
            this.tb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_servico = new System.Windows.Forms.ComboBox();
            this.tb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_fantasia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.bt_icone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_telefone
            // 
            this.tb_telefone.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.tb_telefone.Location = new System.Drawing.Point(37, 246);
            this.tb_telefone.Mask = "(99) 00000-0000";
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(270, 34);
            this.tb_telefone.TabIndex = 68;
            this.tb_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cb_servico
            // 
            this.cb_servico.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.cb_servico.FormattingEnabled = true;
            this.cb_servico.Location = new System.Drawing.Point(37, 69);
            this.cb_servico.Name = "cb_servico";
            this.cb_servico.Size = new System.Drawing.Size(270, 35);
            this.cb_servico.TabIndex = 19;
            // 
            // tb_cep
            // 
            this.tb_cep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tb_cep.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.tb_cep.Location = new System.Drawing.Point(317, 246);
            this.tb_cep.Mask = "00.000-000";
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(270, 34);
            this.tb_cep.TabIndex = 67;
            this.tb_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categoria";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // mb_cnpj
            // 
            this.mb_cnpj.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.mb_cnpj.Location = new System.Drawing.Point(317, 69);
            this.mb_cnpj.Mask = "99.999.999/9999-99";
            this.mb_cnpj.Name = "mb_cnpj";
            this.mb_cnpj.Size = new System.Drawing.Size(270, 34);
            this.mb_cnpj.TabIndex = 66;
            this.mb_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // pb_icone
            // 
            this.pb_icone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_icone.Image = global::Pont_Finder.Properties.Resources.offImage1;
            this.pb_icone.Location = new System.Drawing.Point(81, 39);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(250, 250);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 15;
            this.pb_icone.TabStop = false;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.tb_email.Location = new System.Drawing.Point(37, 154);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(550, 34);
            this.tb_email.TabIndex = 6;
            this.tb_email.TextChanged += new System.EventHandler(this.Tb_email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.label5.Location = new System.Drawing.Point(32, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Endereço";
            // 
            // tb_fantasia
            // 
            this.tb_fantasia.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.tb_fantasia.Location = new System.Drawing.Point(59, 407);
            this.tb_fantasia.Name = "tb_fantasia";
            this.tb_fantasia.Size = new System.Drawing.Size(300, 34);
            this.tb_fantasia.TabIndex = 1;
            this.tb_fantasia.TextChanged += new System.EventHandler(this.Tb_fantasia_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.label6.Location = new System.Drawing.Point(32, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email\r\n";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.tb_endereco.Location = new System.Drawing.Point(37, 339);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(550, 34);
            this.tb_endereco.TabIndex = 3;
            this.tb_endereco.TextChanged += new System.EventHandler(this.Tb_endereco_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.label7.Location = new System.Drawing.Point(32, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.label9.Location = new System.Drawing.Point(54, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nome fantasia";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(172)))), ((int)(((byte)(20)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(457, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Continuar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.label11.Location = new System.Drawing.Point(317, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 27);
            this.label11.TabIndex = 9;
            this.label11.Text = "CNPJ";
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.tb_nome.Location = new System.Drawing.Point(59, 339);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(300, 34);
            this.tb_nome.TabIndex = 0;
            this.tb_nome.TextChanged += new System.EventHandler(this.Tb_nome_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(37, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.label12.Location = new System.Drawing.Point(54, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 27);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nome da empresa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.label13.Location = new System.Drawing.Point(312, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 27);
            this.label13.TabIndex = 11;
            this.label13.Text = "CEP";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 635);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 50);
            this.panel3.TabIndex = 65;
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            this.openIcone.Filter = "\"Image|*.jpg;*.jpeg;*.bmp\"";
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1265, 150);
            this.panel7.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(199, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(830, 46);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cadastre sua empresa para divulgar seus serviços";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1160, 164);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 471);
            this.panel4.TabIndex = 77;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cb_servico);
            this.panel6.Controls.Add(this.tb_telefone);
            this.panel6.Controls.Add(this.tb_email);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.tb_endereco);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.tb_cep);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.mb_cnpj);
            this.panel6.Location = new System.Drawing.Point(530, 164);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(625, 471);
            this.panel6.TabIndex = 71;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel6_Paint);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.label2);
            this.panel16.Controls.Add(this.bt_icone);
            this.panel16.Controls.Add(this.pb_icone);
            this.panel16.Controls.Add(this.label12);
            this.panel16.Controls.Add(this.tb_nome);
            this.panel16.Controls.Add(this.label9);
            this.panel16.Controls.Add(this.tb_fantasia);
            this.panel16.Location = new System.Drawing.Point(110, 164);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(415, 471);
            this.panel16.TabIndex = 67;
            this.panel16.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel16_Paint);
            // 
            // panel17
            // 
            this.panel17.Location = new System.Drawing.Point(5, 164);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(100, 471);
            this.panel17.TabIndex = 66;
            // 
            // bt_icone
            // 
            this.bt_icone.BackColor = System.Drawing.Color.White;
            this.bt_icone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_icone.BackgroundImage")));
            this.bt_icone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_icone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_icone.FlatAppearance.BorderSize = 0;
            this.bt_icone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_icone.Location = new System.Drawing.Point(310, 272);
            this.bt_icone.Name = "bt_icone";
            this.bt_icone.Size = new System.Drawing.Size(40, 30);
            this.bt_icone.TabIndex = 12;
            this.bt_icone.UseVisualStyleBackColor = false;
            this.bt_icone.Click += new System.EventHandler(this.Bt_icone_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Adicione Uma imagem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "FormCadEmpresa";
            this.Text = "FormCadEmpresa";
            this.Load += new System.EventHandler(this.FormCadEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_fantasia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.OpenFileDialog openIcone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_servico;
        private System.Windows.Forms.MaskedTextBox tb_telefone;
        private System.Windows.Forms.MaskedTextBox tb_cep;
        private System.Windows.Forms.MaskedTextBox mb_cnpj;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button bt_icone;
        private System.Windows.Forms.Label label2;
    }
}