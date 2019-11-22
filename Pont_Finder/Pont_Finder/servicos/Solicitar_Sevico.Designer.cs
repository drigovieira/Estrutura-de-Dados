namespace Pont_Finder.servicos
{
    partial class Solicitar_Sevico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_continuar = new System.Windows.Forms.Button();
            this.tb_descricaoHotel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mkb_Cep = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.bt_continuar);
            this.panel1.Controls.Add(this.tb_descricaoHotel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mkb_Cep);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbNum);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tbRua);
            this.panel1.Controls.Add(this.tbBairro);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(210, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 1261);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Agendar para o dia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(335, 432);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 28);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // bt_continuar
            // 
            this.bt_continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_continuar.ForeColor = System.Drawing.Color.White;
            this.bt_continuar.Location = new System.Drawing.Point(337, 1168);
            this.bt_continuar.Name = "bt_continuar";
            this.bt_continuar.Size = new System.Drawing.Size(220, 50);
            this.bt_continuar.TabIndex = 35;
            this.bt_continuar.Text = "Continuar";
            this.bt_continuar.UseVisualStyleBackColor = false;
            this.bt_continuar.Click += new System.EventHandler(this.Bt_continuar_Click);
            // 
            // tb_descricaoHotel
            // 
            this.tb_descricaoHotel.BackColor = System.Drawing.Color.LightGray;
            this.tb_descricaoHotel.Location = new System.Drawing.Point(218, 607);
            this.tb_descricaoHotel.Multiline = true;
            this.tb_descricaoHotel.Name = "tb_descricaoHotel";
            this.tb_descricaoHotel.Size = new System.Drawing.Size(460, 220);
            this.tb_descricaoHotel.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = " Descreva o problema";
            // 
            // mkb_Cep
            // 
            this.mkb_Cep.Location = new System.Drawing.Point(483, 1103);
            this.mkb_Cep.Mask = "00.000-000";
            this.mkb_Cep.Name = "mkb_Cep";
            this.mkb_Cep.Size = new System.Drawing.Size(170, 20);
            this.mkb_Cep.TabIndex = 31;
            this.mkb_Cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(384, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 51);
            this.button1.TabIndex = 32;
            this.button1.Text = "Adicionar Foto";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbNum
            // 
            this.tbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum.Location = new System.Drawing.Point(238, 1103);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(170, 22);
            this.tbNum.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(218, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 1073);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 927);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bairro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(479, 1073);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "CEP";
            // 
            // tbRua
            // 
            this.tbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRua.Location = new System.Drawing.Point(238, 1028);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(415, 22);
            this.tbRua.TabIndex = 26;
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBairro.Location = new System.Drawing.Point(238, 957);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(415, 22);
            this.tbBairro.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 995);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Rua";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 100);
            this.panel2.TabIndex = 1;
            // 
            // Solicitar_Sevico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "Solicitar_Sevico";
            this.Text = "Solicitar_Sevico";
            this.Load += new System.EventHandler(this.Solicitar_Sevico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mkb_Cep;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_descricaoHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_continuar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
    }
}