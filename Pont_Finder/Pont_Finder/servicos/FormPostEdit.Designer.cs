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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostEdit));
            System.Windows.Forms.Panel panel1;
            this.pb_wallpaper = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.bt_icone = new System.Windows.Forms.Button();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.publicar = new System.Windows.Forms.Button();
            this.tb_detalhes = new System.Windows.Forms.TextBox();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wallpaper)).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_wallpaper
            // 
            this.pb_wallpaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_wallpaper.BackgroundImage")));
            this.pb_wallpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_wallpaper.Location = new System.Drawing.Point(0, 0);
            this.pb_wallpaper.Name = "pb_wallpaper";
            this.pb_wallpaper.Size = new System.Drawing.Size(1265, 150);
            this.pb_wallpaper.TabIndex = 20;
            this.pb_wallpaper.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cadastre seu serviço!";
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
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.cancelar);
            panel1.Controls.Add(this.publicar);
            panel1.Controls.Add(this.tb_detalhes);
            panel1.Location = new System.Drawing.Point(353, 222);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(630, 791);
            panel1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição completa";
            // 
            // tb_descricao
            // 
            this.tb_descricao.BackColor = System.Drawing.SystemColors.Control;
            this.tb_descricao.Location = new System.Drawing.Point(132, 557);
            this.tb_descricao.MaxLength = 380;
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_descricao.Size = new System.Drawing.Size(390, 150);
            this.tb_descricao.TabIndex = 11;
            // 
            // bt_icone
            // 
            this.bt_icone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_icone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_icone.ForeColor = System.Drawing.Color.White;
            this.bt_icone.Location = new System.Drawing.Point(166, 213);
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
            this.pb_icone.Location = new System.Drawing.Point(166, 9);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(300, 225);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 9;
            this.pb_icone.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Título";
            // 
            // tb_titulo
            // 
            this.tb_titulo.Location = new System.Drawing.Point(132, 277);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(390, 20);
            this.tb_titulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor";
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(132, 316);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(390, 20);
            this.tb_valor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Detalhes Card";
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.ForeColor = System.Drawing.Color.White;
            this.cancelar.Location = new System.Drawing.Point(347, 731);
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
            this.publicar.ForeColor = System.Drawing.Color.White;
            this.publicar.Location = new System.Drawing.Point(192, 731);
            this.publicar.Name = "publicar";
            this.publicar.Size = new System.Drawing.Size(99, 34);
            this.publicar.TabIndex = 5;
            this.publicar.Text = "Editar";
            this.publicar.UseVisualStyleBackColor = false;
            this.publicar.Click += new System.EventHandler(this.Publicar_Click);
            // 
            // tb_detalhes
            // 
            this.tb_detalhes.BackColor = System.Drawing.SystemColors.Control;
            this.tb_detalhes.Location = new System.Drawing.Point(132, 371);
            this.tb_detalhes.MaxLength = 380;
            this.tb_detalhes.Multiline = true;
            this.tb_detalhes.Name = "tb_detalhes";
            this.tb_detalhes.Size = new System.Drawing.Size(390, 150);
            this.tb_detalhes.TabIndex = 4;
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            // 
            // FormPostEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_wallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "FormPostEdit";
            this.Text = "FormPostEdit";
            ((System.ComponentModel.ISupportInitialize)(this.pb_wallpaper)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_wallpaper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button bt_icone;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button publicar;
        private System.Windows.Forms.TextBox tb_detalhes;
        private System.Windows.Forms.OpenFileDialog openIcone;
    }
}