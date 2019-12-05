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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitar_Sevico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_solicitar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_cep = new System.Windows.Forms.MaskedTextBox();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_rua = new System.Windows.Forms.TextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_icone = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bt_solicitar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_descricao);
            this.panel1.Controls.Add(this.tb_data);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(531, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 531);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(465, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 35);
            this.button2.TabIndex = 42;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bt_solicitar
            // 
            this.bt_solicitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(172)))), ((int)(((byte)(20)))));
            this.bt_solicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_solicitar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_solicitar.ForeColor = System.Drawing.Color.White;
            this.bt_solicitar.Location = new System.Drawing.Point(465, 430);
            this.bt_solicitar.Name = "bt_solicitar";
            this.bt_solicitar.Size = new System.Drawing.Size(130, 35);
            this.bt_solicitar.TabIndex = 41;
            this.bt_solicitar.Text = "Solicitar Serviço";
            this.bt_solicitar.UseVisualStyleBackColor = false;
            this.bt_solicitar.Click += new System.EventHandler(this.Bt_solicitar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 23);
            this.label6.MaximumSize = new System.Drawing.Size(300, 0);
            this.label6.MinimumSize = new System.Drawing.Size(300, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 27);
            this.label6.TabIndex = 40;
            this.label6.Text = "Descrição do Problema";
            // 
            // tb_descricao
            // 
            this.tb_descricao.BackColor = System.Drawing.Color.White;
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descricao.Location = new System.Drawing.Point(32, 50);
            this.tb_descricao.MaxLength = 1200;
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_descricao.Size = new System.Drawing.Size(563, 353);
            this.tb_descricao.TabIndex = 39;
            // 
            // tb_data
            // 
            this.tb_data.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_data.Location = new System.Drawing.Point(32, 482);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(313, 28);
            this.tb_data.TabIndex = 36;
            this.tb_data.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Agendar Para o Dia";
            // 
            // tb_cep
            // 
            this.tb_cep.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cep.Location = new System.Drawing.Point(208, 433);
            this.tb_cep.Mask = "00.000-000";
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(165, 32);
            this.tb_cep.TabIndex = 31;
            this.tb_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tb_numero
            // 
            this.tb_numero.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numero.Location = new System.Drawing.Point(33, 433);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(165, 32);
            this.tb_numero.TabIndex = 30;
            // 
            // pb_icone
            // 
            this.pb_icone.BackColor = System.Drawing.Color.Gainsboro;
            this.pb_icone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_icone.Location = new System.Drawing.Point(56, 54);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(300, 225);
            this.pb_icone.TabIndex = 0;
            this.pb_icone.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bairro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(204, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 24);
            this.label13.TabIndex = 27;
            this.label13.Text = "CEP";
            // 
            // tb_rua
            // 
            this.tb_rua.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rua.Location = new System.Drawing.Point(33, 309);
            this.tb_rua.Name = "tb_rua";
            this.tb_rua.Size = new System.Drawing.Size(340, 32);
            this.tb_rua.TabIndex = 26;
            // 
            // tb_bairro
            // 
            this.tb_bairro.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bairro.Location = new System.Drawing.Point(33, 371);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(340, 32);
            this.tb_bairro.TabIndex = 25;
            this.tb_bairro.TextChanged += new System.EventHandler(this.tbBairro_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Rua";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.bt_icone);
            this.panel3.Controls.Add(this.pb_icone);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.tb_cep);
            this.panel3.Controls.Add(this.tb_bairro);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tb_numero);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tb_rua);
            this.panel3.Location = new System.Drawing.Point(111, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 531);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(172)))), ((int)(((byte)(20)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(139, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 42;
            this.button1.Text = "Ver no Mapa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 24);
            this.label4.MaximumSize = new System.Drawing.Size(300, 0);
            this.label4.MinimumSize = new System.Drawing.Size(300, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 27);
            this.label4.TabIndex = 40;
            this.label4.Text = "Imagem do Problema";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_icone
            // 
            this.bt_icone.BackColor = System.Drawing.Color.White;
            this.bt_icone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_icone.BackgroundImage")));
            this.bt_icone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_icone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_icone.FlatAppearance.BorderSize = 0;
            this.bt_icone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_icone.Location = new System.Drawing.Point(333, 263);
            this.bt_icone.Name = "bt_icone";
            this.bt_icone.Size = new System.Drawing.Size(40, 30);
            this.bt_icone.TabIndex = 39;
            this.bt_icone.UseVisualStyleBackColor = false;
            this.bt_icone.Click += new System.EventHandler(this.Bt_icone_Click);
            // 
            // Solicitar_Sevico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel3);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox tb_cep;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_rua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker tb_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_icone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button bt_solicitar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}