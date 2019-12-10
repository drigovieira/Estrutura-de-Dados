namespace Pont_Finder.servicos
{
    partial class FormCadServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadServico));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.publicar = new System.Windows.Forms.Button();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_icone = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_combinar = new System.Windows.Forms.CheckBox();
            this.tb_valor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_valor)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 24);
            this.label5.MaximumSize = new System.Drawing.Size(1040, 0);
            this.label5.MinimumSize = new System.Drawing.Size(1040, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1040, 31);
            this.label5.TabIndex = 44;
            this.label5.Text = "Cadastre seu serviço!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 20);
            this.label4.MaximumSize = new System.Drawing.Size(300, 0);
            this.label4.MinimumSize = new System.Drawing.Size(300, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição";
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
            this.tb_descricao.Size = new System.Drawing.Size(563, 333);
            this.tb_descricao.TabIndex = 4;
            // 
            // pb_icone
            // 
            this.pb_icone.BackColor = System.Drawing.Color.Transparent;
            this.pb_icone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_icone.Image = global::Pont_Finder.Properties.Resources.offImage1;
            this.pb_icone.InitialImage = global::Pont_Finder.Properties.Resources.offImage;
            this.pb_icone.Location = new System.Drawing.Point(54, 54);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(300, 225);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 9;
            this.pb_icone.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 319);
            this.label3.MaximumSize = new System.Drawing.Size(300, 0);
            this.label3.MinimumSize = new System.Drawing.Size(300, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome Do Serviço";
            // 
            // tb_titulo
            // 
            this.tb_titulo.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_titulo.Location = new System.Drawing.Point(54, 349);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.Size = new System.Drawing.Size(300, 34);
            this.tb_titulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 398);
            this.label2.MaximumSize = new System.Drawing.Size(300, 0);
            this.label2.MinimumSize = new System.Drawing.Size(300, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor do Serviço";
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.White;
            this.cancelar.Location = new System.Drawing.Point(32, 427);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(130, 35);
            this.cancelar.TabIndex = 6;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // publicar
            // 
            this.publicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(172)))), ((int)(((byte)(20)))));
            this.publicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publicar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicar.ForeColor = System.Drawing.Color.White;
            this.publicar.Location = new System.Drawing.Point(465, 427);
            this.publicar.Name = "publicar";
            this.publicar.Size = new System.Drawing.Size(130, 35);
            this.publicar.TabIndex = 5;
            this.publicar.Text = "Cadastrar";
            this.publicar.UseVisualStyleBackColor = false;
            this.publicar.Click += new System.EventHandler(this.Publicar_Click);
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 575);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 100);
            this.panel2.TabIndex = 45;
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
            this.bt_icone.TabIndex = 11;
            this.bt_icone.UseVisualStyleBackColor = false;
            this.bt_icone.Click += new System.EventHandler(this.Bt_icone_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cb_combinar);
            this.panel4.Controls.Add(this.tb_valor);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.bt_icone);
            this.panel4.Controls.Add(this.pb_icone);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tb_titulo);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(111, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 493);
            this.panel4.TabIndex = 43;
            // 
            // cb_combinar
            // 
            this.cb_combinar.AutoSize = true;
            this.cb_combinar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F);
            this.cb_combinar.Location = new System.Drawing.Point(216, 428);
            this.cb_combinar.Name = "cb_combinar";
            this.cb_combinar.Size = new System.Drawing.Size(141, 31);
            this.cb_combinar.TabIndex = 44;
            this.cb_combinar.Text = "A Combinar";
            this.cb_combinar.UseVisualStyleBackColor = true;
            this.cb_combinar.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // tb_valor
            // 
            this.tb_valor.DecimalPlaces = 2;
            this.tb_valor.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(54, 428);
            this.tb_valor.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.tb_valor.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(153, 34);
            this.tb_valor.TabIndex = 43;
            this.tb_valor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.MaximumSize = new System.Drawing.Size(300, 0);
            this.label1.MinimumSize = new System.Drawing.Size(300, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alterar Imagem ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.cancelar);
            this.panel6.Controls.Add(this.tb_descricao);
            this.panel6.Controls.Add(this.publicar);
            this.panel6.Location = new System.Drawing.Point(531, 74);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(624, 493);
            this.panel6.TabIndex = 46;
            // 
            // FormCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "FormCadServico";
            this.Text = "FormCadServico";
            this.Load += new System.EventHandler(this.FormCadServico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_valor)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button publicar;
        private System.Windows.Forms.OpenFileDialog openIcone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_icone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown tb_valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cb_combinar;
    }
}