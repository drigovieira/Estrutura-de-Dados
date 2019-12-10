namespace Pont_Finder.eventos
{
    partial class CadEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEmpresa));
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Bemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Bnomefantasia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bendereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Bnomeempresa = new System.Windows.Forms.TextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.ckb_termos_uso = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.mkb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mkb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.bt_imagem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Bimagem = new System.Windows.Forms.PictureBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 200);
            this.panel1.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(478, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(377, 46);
            this.label10.TabIndex = 2;
            this.label10.Text = "Vamos evoluir juntos!";
            // 
            // Bemail
            // 
            this.Bemail.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bemail.Location = new System.Drawing.Point(103, 564);
            this.Bemail.Name = "Bemail";
            this.Bemail.Size = new System.Drawing.Size(415, 24);
            this.Bemail.TabIndex = 5;
            this.Bemail.TextChanged += new System.EventHandler(this.Bemail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço";
            // 
            // Bnomefantasia
            // 
            this.Bnomefantasia.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnomefantasia.Location = new System.Drawing.Point(103, 264);
            this.Bnomefantasia.Name = "Bnomefantasia";
            this.Bnomefantasia.Size = new System.Drawing.Size(415, 24);
            this.Bnomefantasia.TabIndex = 1;
            this.Bnomefantasia.TextChanged += new System.EventHandler(this.Bnomefantasia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email\r\n";
            // 
            // Bendereco
            // 
            this.Bendereco.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bendereco.Location = new System.Drawing.Point(103, 411);
            this.Bendereco.Name = "Bendereco";
            this.Bendereco.Size = new System.Drawing.Size(415, 24);
            this.Bendereco.TabIndex = 3;
            this.Bendereco.TextChanged += new System.EventHandler(this.Bendereco_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefone";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(950, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 428);
            this.panel2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome fantasia";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(179, 885);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "CNPJ";
            // 
            // Bnomeempresa
            // 
            this.Bnomeempresa.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnomeempresa.Location = new System.Drawing.Point(103, 189);
            this.Bnomeempresa.Name = "Bnomeempresa";
            this.Bnomeempresa.Size = new System.Drawing.Size(415, 24);
            this.Bnomeempresa.TabIndex = 0;
            this.Bnomeempresa.TextChanged += new System.EventHandler(this.Bnomeempresa_TextChanged);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.Red;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Location = new System.Drawing.Point(347, 885);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(120, 40);
            this.bt_cancelar.TabIndex = 7;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da empresa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(346, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(646, 36);
            this.label11.TabIndex = 36;
            this.label11.Text = "Cadastre sua empresa para divulgar seus serviços";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 1253);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1265, 100);
            this.panel5.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(5, 303);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 428);
            this.panel4.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bt_imagem);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Bimagem);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.ckb_termos_uso);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.mkb_telefone);
            this.panel3.Controls.Add(this.mkb_cnpj);
            this.panel3.Controls.Add(this.Bemail);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Bnomefantasia);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Bendereco);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.Bnomeempresa);
            this.panel3.Controls.Add(this.bt_cancelar);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(320, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 950);
            this.panel3.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(90, 605);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 21);
            this.label18.TabIndex = 119;
            this.label18.Text = "Termos de uso:";
            // 
            // ckb_termos_uso
            // 
            this.ckb_termos_uso.AutoSize = true;
            this.ckb_termos_uso.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_termos_uso.Location = new System.Drawing.Point(94, 834);
            this.ckb_termos_uso.Name = "ckb_termos_uso";
            this.ckb_termos_uso.Size = new System.Drawing.Size(257, 25);
            this.ckb_termos_uso.TabIndex = 117;
            this.ckb_termos_uso.Text = "Concordo com os termos de uso.";
            this.ckb_termos_uso.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lb_descricao);
            this.panel6.Location = new System.Drawing.Point(94, 630);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(460, 200);
            this.panel6.TabIndex = 118;
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.BackColor = System.Drawing.Color.Transparent;
            this.lb_descricao.Font = new System.Drawing.Font("Dubai", 9F);
            this.lb_descricao.Location = new System.Drawing.Point(4, 2);
            this.lb_descricao.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.lb_descricao.MaximumSize = new System.Drawing.Size(430, 1000);
            this.lb_descricao.MinimumSize = new System.Drawing.Size(430, 187);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(430, 651);
            this.lb_descricao.TabIndex = 69;
            this.lb_descricao.Text = resources.GetString("lb_descricao.Text");
            // 
            // mkb_telefone
            // 
            this.mkb_telefone.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_telefone.Location = new System.Drawing.Point(103, 499);
            this.mkb_telefone.Mask = "(99) 0000-00000";
            this.mkb_telefone.Name = "mkb_telefone";
            this.mkb_telefone.Size = new System.Drawing.Size(415, 22);
            this.mkb_telefone.TabIndex = 4;
            this.mkb_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mkb_cnpj
            // 
            this.mkb_cnpj.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_cnpj.Location = new System.Drawing.Point(107, 351);
            this.mkb_cnpj.Mask = "99.999.999/9999-99";
            this.mkb_cnpj.Name = "mkb_cnpj";
            this.mkb_cnpj.Size = new System.Drawing.Size(411, 22);
            this.mkb_cnpj.TabIndex = 2;
            this.mkb_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(64, 225);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 37;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // bt_imagem
            // 
            this.bt_imagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_imagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_imagem.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_imagem.ForeColor = System.Drawing.Color.White;
            this.bt_imagem.Location = new System.Drawing.Point(259, 71);
            this.bt_imagem.Name = "bt_imagem";
            this.bt_imagem.Size = new System.Drawing.Size(184, 34);
            this.bt_imagem.TabIndex = 125;
            this.bt_imagem.Text = "Selecionar imagem";
            this.bt_imagem.UseVisualStyleBackColor = false;
            this.bt_imagem.Click += new System.EventHandler(this.Bt_imagem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 21);
            this.label6.TabIndex = 124;
            this.label6.Text = "Logo da empresa";
            // 
            // Bimagem
            // 
            this.Bimagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bimagem.Location = new System.Drawing.Point(103, 30);
            this.Bimagem.Name = "Bimagem";
            this.Bimagem.Size = new System.Drawing.Size(150, 120);
            this.Bimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bimagem.TabIndex = 123;
            this.Bimagem.TabStop = false;
            // 
            // openIcone
            // 
            this.openIcone.FileName = "openIcone";
            // 
            // CadEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "CadEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadEmpresa";
            this.Load += new System.EventHandler(this.CadEmpresa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox Bemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Bnomefantasia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Bendereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Bnomeempresa;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox mkb_cnpj;
        private System.Windows.Forms.MaskedTextBox mkb_telefone;
        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox ckb_termos_uso;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.Button bt_imagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Bimagem;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.OpenFileDialog openIcone;
    }
}