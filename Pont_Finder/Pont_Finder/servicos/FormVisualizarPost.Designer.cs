namespace Pont_Finder.servicos
{
    partial class FormVisualizarPost
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
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pb_empresa = new System.Windows.Forms.PictureBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.lb_endereco = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_fantasia = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_negociar = new System.Windows.Forms.Button();
            this.lb_categoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_icone
            // 
            this.pb_icone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_icone.Location = new System.Drawing.Point(131, 31);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(300, 225);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 20;
            this.pb_icone.TabStop = false;
            this.pb_icone.Click += new System.EventHandler(this.pb_icon_Click);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(454, 85);
            this.lb_titulo.MaximumSize = new System.Drawing.Size(320, 50);
            this.lb_titulo.MinimumSize = new System.Drawing.Size(320, 50);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(320, 50);
            this.lb_titulo.TabIndex = 21;
            this.lb_titulo.Text = "Nome do Serviço";
            this.lb_titulo.Click += new System.EventHandler(this.Lb_titulo_Click);
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.ForeColor = System.Drawing.Color.Green;
            this.lb_valor.Location = new System.Drawing.Point(452, 173);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(53, 38);
            this.lb_valor.TabIndex = 22;
            this.lb_valor.Text = "R$";
            this.lb_valor.Click += new System.EventHandler(this.Lb_valor_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 684);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 100);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_descricao);
            this.panel2.Location = new System.Drawing.Point(131, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 400);
            this.panel2.TabIndex = 24;
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descricao.Location = new System.Drawing.Point(51, 10);
            this.lb_descricao.MaximumSize = new System.Drawing.Size(950, 0);
            this.lb_descricao.MinimumSize = new System.Drawing.Size(950, 0);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(950, 27);
            this.lb_descricao.TabIndex = 0;
            this.lb_descricao.Text = "Descrição geral";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.pb_empresa);
            this.panel4.Controls.Add(this.lb_telefone);
            this.panel4.Controls.Add(this.lb_endereco);
            this.panel4.Controls.Add(this.lb_email);
            this.panel4.Controls.Add(this.lb_fantasia);
            this.panel4.Location = new System.Drawing.Point(799, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(387, 145);
            this.panel4.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 35;
            this.button2.Text = "Visualizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pb_empresa
            // 
            this.pb_empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_empresa.Location = new System.Drawing.Point(3, 3);
            this.pb_empresa.Name = "pb_empresa";
            this.pb_empresa.Size = new System.Drawing.Size(100, 100);
            this.pb_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_empresa.TabIndex = 27;
            this.pb_empresa.TabStop = false;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telefone.Location = new System.Drawing.Point(109, 118);
            this.lb_telefone.MaximumSize = new System.Drawing.Size(265, 0);
            this.lb_telefone.MinimumSize = new System.Drawing.Size(265, 0);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(265, 18);
            this.lb_telefone.TabIndex = 4;
            this.lb_telefone.Text = "Telefone: ";
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_endereco.Location = new System.Drawing.Point(109, 40);
            this.lb_endereco.MaximumSize = new System.Drawing.Size(265, 36);
            this.lb_endereco.MinimumSize = new System.Drawing.Size(265, 36);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(265, 36);
            this.lb_endereco.TabIndex = 3;
            this.lb_endereco.Text = "Endereço: ";
            this.lb_endereco.Click += new System.EventHandler(this.tb_Endereco_Click);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(109, 78);
            this.lb_email.MaximumSize = new System.Drawing.Size(265, 36);
            this.lb_email.MinimumSize = new System.Drawing.Size(265, 36);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(265, 36);
            this.lb_email.TabIndex = 2;
            this.lb_email.Text = "E-mail: ";
            this.lb_email.Click += new System.EventHandler(this.Lb_email_Click);
            // 
            // lb_fantasia
            // 
            this.lb_fantasia.AutoSize = true;
            this.lb_fantasia.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fantasia.Location = new System.Drawing.Point(109, 3);
            this.lb_fantasia.MaximumSize = new System.Drawing.Size(265, 36);
            this.lb_fantasia.MinimumSize = new System.Drawing.Size(265, 36);
            this.lb_fantasia.Name = "lb_fantasia";
            this.lb_fantasia.Size = new System.Drawing.Size(265, 36);
            this.lb_fantasia.TabIndex = 0;
            this.lb_fantasia.Text = "Nome: ";
            this.lb_fantasia.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(41, 31);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 13;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            this.btn_back.MouseLeave += new System.EventHandler(this.Btn_back_MouseLeave);
            this.btn_back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_back_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1007, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 51);
            this.button1.TabIndex = 33;
            this.button1.Text = "Solicitar serviço";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_negociar
            // 
            this.bt_negociar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_negociar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_negociar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_negociar.ForeColor = System.Drawing.Color.White;
            this.bt_negociar.Location = new System.Drawing.Point(821, 205);
            this.bt_negociar.Name = "bt_negociar";
            this.bt_negociar.Size = new System.Drawing.Size(157, 51);
            this.bt_negociar.TabIndex = 34;
            this.bt_negociar.Text = "Negociar Serviço";
            this.bt_negociar.UseVisualStyleBackColor = false;
            this.bt_negociar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoria.Location = new System.Drawing.Point(454, 31);
            this.lb_categoria.MaximumSize = new System.Drawing.Size(320, 50);
            this.lb_categoria.MinimumSize = new System.Drawing.Size(320, 50);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(320, 50);
            this.lb_categoria.TabIndex = 35;
            this.lb_categoria.Text = "Categoria";
            // 
            // FormVisualizarPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.lb_categoria);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bt_negociar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.pb_icone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "FormVisualizarPost";
            this.Text = "\'";
            this.Load += new System.EventHandler(this.FormVisualizarPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_fantasia;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.PictureBox pb_empresa;
        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_negociar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_categoria;
    }
}