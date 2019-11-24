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
            this.panel11 = new System.Windows.Forms.Panel();
            this.mb_phone = new System.Windows.Forms.MaskedTextBox();
            this.cb_servico = new System.Windows.Forms.ComboBox();
            this.mb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.AddFotoEmpresa = new System.Windows.Forms.Button();
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
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.mb_phone);
            this.panel11.Controls.Add(this.cb_servico);
            this.panel11.Controls.Add(this.mb_cep);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.mb_cnpj);
            this.panel11.Controls.Add(this.AddFotoEmpresa);
            this.panel11.Controls.Add(this.pb_icone);
            this.panel11.Controls.Add(this.tb_email);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.tb_fantasia);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.tb_endereco);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.button3);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.tb_nome);
            this.panel11.Controls.Add(this.button4);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Location = new System.Drawing.Point(320, 263);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(625, 897);
            this.panel11.TabIndex = 63;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel11_Paint);
            // 
            // mb_phone
            // 
            this.mb_phone.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mb_phone.Location = new System.Drawing.Point(345, 575);
            this.mb_phone.Mask = "(99) 00000-0000";
            this.mb_phone.Name = "mb_phone";
            this.mb_phone.Size = new System.Drawing.Size(170, 22);
            this.mb_phone.TabIndex = 68;
            this.mb_phone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cb_servico
            // 
            this.cb_servico.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_servico.FormattingEnabled = true;
            this.cb_servico.Location = new System.Drawing.Point(104, 721);
            this.cb_servico.Name = "cb_servico";
            this.cb_servico.Size = new System.Drawing.Size(411, 22);
            this.cb_servico.TabIndex = 19;
            // 
            // mb_cep
            // 
            this.mb_cep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mb_cep.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mb_cep.Location = new System.Drawing.Point(100, 575);
            this.mb_cep.Mask = "00.000-000";
            this.mb_cep.Name = "mb_cep";
            this.mb_cep.Size = new System.Drawing.Size(170, 22);
            this.mb_cep.TabIndex = 67;
            this.mb_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 694);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Categoria";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // mb_cnpj
            // 
            this.mb_cnpj.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mb_cnpj.Location = new System.Drawing.Point(104, 416);
            this.mb_cnpj.Mask = "99.999.999/9999-99";
            this.mb_cnpj.Name = "mb_cnpj";
            this.mb_cnpj.Size = new System.Drawing.Size(415, 22);
            this.mb_cnpj.TabIndex = 66;
            this.mb_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // AddFotoEmpresa
            // 
            this.AddFotoEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.AddFotoEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFotoEmpresa.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFotoEmpresa.ForeColor = System.Drawing.Color.White;
            this.AddFotoEmpresa.Location = new System.Drawing.Point(341, 87);
            this.AddFotoEmpresa.Name = "AddFotoEmpresa";
            this.AddFotoEmpresa.Size = new System.Drawing.Size(174, 55);
            this.AddFotoEmpresa.TabIndex = 16;
            this.AddFotoEmpresa.Text = "Adcionar foto de perfil";
            this.AddFotoEmpresa.UseVisualStyleBackColor = false;
            this.AddFotoEmpresa.Click += new System.EventHandler(this.AddFotoEmpresa_Click);
            // 
            // pb_icone
            // 
            this.pb_icone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_icone.Image = global::Pont_Finder.Properties.Resources.offImage1;
            this.pb_icone.Location = new System.Drawing.Point(100, 12);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(200, 200);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 15;
            this.pb_icone.TabStop = false;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(100, 646);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(415, 24);
            this.tb_email.TabIndex = 6;
            this.tb_email.TextChanged += new System.EventHandler(this.Tb_email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Endereço";
            // 
            // tb_fantasia
            // 
            this.tb_fantasia.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fantasia.Location = new System.Drawing.Point(100, 346);
            this.tb_fantasia.Name = "tb_fantasia";
            this.tb_fantasia.Size = new System.Drawing.Size(415, 24);
            this.tb_fantasia.TabIndex = 1;
            this.tb_fantasia.TextChanged += new System.EventHandler(this.Tb_fantasia_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email\r\n";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(100, 500);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(415, 24);
            this.tb_endereco.TabIndex = 3;
            this.tb_endereco.TextChanged += new System.EventHandler(this.Tb_endereco_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nome fantasia";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(150, 790);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Continuar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(100, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "CNPJ";
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(100, 271);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(415, 24);
            this.tb_nome.TabIndex = 0;
            this.tb_nome.TextChanged += new System.EventHandler(this.Tb_nome_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(345, 790);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(100, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nome da empresa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(100, 543);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "CEP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(298, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(646, 36);
            this.label15.TabIndex = 64;
            this.label15.Text = "Cadastre sua empresa para divulgar seus serviços";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(950, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 576);
            this.panel2.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(5, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 576);
            this.panel1.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 1160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 100);
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
            this.label10.Location = new System.Drawing.Point(473, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(377, 46);
            this.label10.TabIndex = 2;
            this.label10.Text = "Vamos evoluir juntos!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 0;
            // 
            // FormCadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "FormCadEmpresa";
            this.Text = "FormCadEmpresa";
            this.Load += new System.EventHandler(this.FormCadEmpresa_Load);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Button AddFotoEmpresa;
        private System.Windows.Forms.OpenFileDialog openIcone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_servico;
        private System.Windows.Forms.MaskedTextBox mb_phone;
        private System.Windows.Forms.MaskedTextBox mb_cep;
        private System.Windows.Forms.MaskedTextBox mb_cnpj;
    }
}