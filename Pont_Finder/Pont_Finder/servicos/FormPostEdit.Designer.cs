namespace Pont_Finder.servicos
{
    partial class FormPostEdit
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
            System.Windows.Forms.Panel panel1;
            this.label4 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.bt_icone = new System.Windows.Forms.Button();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.publicar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(this.label4);
            panel1.Controls.Add(this.tb_descricao);
            panel1.Controls.Add(this.bt_icone);
            panel1.Controls.Add(this.pb_icone);
            panel1.Controls.Add(this.label3);
            panel1.Controls.Add(this.tb_titulo);
            panel1.Controls.Add(this.label2);
            panel1.Controls.Add(this.tb_valor);
            panel1.Controls.Add(this.cancelar);
            panel1.Controls.Add(this.publicar);
            panel1.Location = new System.Drawing.Point(353, 74);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(630, 781);
            panel1.TabIndex = 39;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // tb_descricao
            // 
            this.tb_descricao.BackColor = System.Drawing.SystemColors.Control;
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descricao.Location = new System.Drawing.Point(132, 509);
            this.tb_descricao.MaxLength = 1200;
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_descricao.Size = new System.Drawing.Size(390, 150);
            this.tb_descricao.TabIndex = 4;
            this.tb_descricao.TextChanged += new System.EventHandler(this.tb_descricao_TextChanged);
            // 
            // bt_icone
            // 
            this.bt_icone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_icone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_icone.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_icone.ForeColor = System.Drawing.Color.White;
            this.bt_icone.Location = new System.Drawing.Point(166, 242);
            this.bt_icone.Name = "bt_icone";
            this.bt_icone.Size = new System.Drawing.Size(300, 34);
            this.bt_icone.TabIndex = 1;
            this.bt_icone.Text = "Selecionar";
            this.bt_icone.UseVisualStyleBackColor = false;
            this.bt_icone.Click += new System.EventHandler(this.Bt_icone_Click);
            // 
            // pb_icone
            // 
            this.pb_icone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_icone.Image = global::Pont_Finder.Properties.Resources.offImage;
            this.pb_icone.InitialImage = global::Pont_Finder.Properties.Resources.offImage;
            this.pb_icone.Location = new System.Drawing.Point(166, 38);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(300, 225);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 9;
            this.pb_icone.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Título";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_titulo
            // 
            this.tb_titulo.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_titulo.Location = new System.Drawing.Point(132, 354);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(390, 24);
            this.tb_titulo.TabIndex = 2;
            this.tb_titulo.TextChanged += new System.EventHandler(this.tb_titulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_valor
            // 
            this.tb_valor.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(132, 419);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(390, 24);
            this.tb_valor.TabIndex = 3;
            this.tb_valor.TextChanged += new System.EventHandler(this.tb_valor_TextChanged);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.White;
            this.cancelar.Location = new System.Drawing.Point(347, 705);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(95, 34);
            this.cancelar.TabIndex = 6;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // publicar
            // 
            this.publicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.publicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publicar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicar.ForeColor = System.Drawing.Color.White;
            this.publicar.Location = new System.Drawing.Point(192, 705);
            this.publicar.Name = "publicar";
            this.publicar.Size = new System.Drawing.Size(99, 34);
            this.publicar.TabIndex = 5;
            this.publicar.Text = "Editar";
            this.publicar.UseVisualStyleBackColor = false;
            this.publicar.Click += new System.EventHandler(this.Publicar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cadastre seu serviço!";
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 855);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 100);
            this.panel2.TabIndex = 40;
            // 
            // FormPostEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(panel1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "FormPostEdit";
            this.Text = "FormPostEdit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button bt_icone;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button publicar;
        private System.Windows.Forms.OpenFileDialog openIcone;
        private System.Windows.Forms.Panel panel2;
    }
}