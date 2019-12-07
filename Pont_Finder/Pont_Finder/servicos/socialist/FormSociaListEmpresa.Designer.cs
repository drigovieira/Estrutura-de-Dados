namespace Pont_Finder.servicos.socialist
{
    partial class FormSociaListEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSociaListEmpresa));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_empresa = new System.Windows.Forms.PictureBox();
            this.lb_empresa = new System.Windows.Forms.Label();
            this.panel_chat = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_username = new System.Windows.Forms.Label();
            this.pb_usericone = new System.Windows.Forms.PictureBox();
            this.tb_mensagens = new System.Windows.Forms.RichTextBox();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.tb_mensagem = new System.Windows.Forms.RichTextBox();
            this.bt_enviar = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empresa)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usericone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 150);
            this.panel3.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(416, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aproveite nossos serviços!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pb_empresa);
            this.panel1.Controls.Add(this.lb_empresa);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 70);
            this.panel1.TabIndex = 44;
            // 
            // pb_empresa
            // 
            this.pb_empresa.Location = new System.Drawing.Point(10, 10);
            this.pb_empresa.Margin = new System.Windows.Forms.Padding(10);
            this.pb_empresa.Name = "pb_empresa";
            this.pb_empresa.Size = new System.Drawing.Size(50, 50);
            this.pb_empresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_empresa.TabIndex = 0;
            this.pb_empresa.TabStop = false;
            // 
            // lb_empresa
            // 
            this.lb_empresa.AutoSize = true;
            this.lb_empresa.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empresa.Location = new System.Drawing.Point(73, 17);
            this.lb_empresa.Name = "lb_empresa";
            this.lb_empresa.Size = new System.Drawing.Size(209, 36);
            this.lb_empresa.TabIndex = 1;
            this.lb_empresa.Text = "Nome Empresa";
            // 
            // panel_chat
            // 
            this.panel_chat.AutoScroll = true;
            this.panel_chat.BackColor = System.Drawing.Color.White;
            this.panel_chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_chat.Location = new System.Drawing.Point(10, 90);
            this.panel_chat.Margin = new System.Windows.Forms.Padding(10);
            this.panel_chat.Name = "panel_chat";
            this.panel_chat.Size = new System.Drawing.Size(395, 384);
            this.panel_chat.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel_chat);
            this.panel4.Location = new System.Drawing.Point(110, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(415, 484);
            this.panel4.TabIndex = 46;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.tb_mensagens);
            this.panel6.Controls.Add(this.bt_limpar);
            this.panel6.Controls.Add(this.tb_mensagem);
            this.panel6.Controls.Add(this.bt_enviar);
            this.panel6.Location = new System.Drawing.Point(531, 158);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(624, 484);
            this.panel6.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lb_username);
            this.panel5.Controls.Add(this.pb_usericone);
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(604, 70);
            this.panel5.TabIndex = 6;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(73, 17);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(199, 36);
            this.lb_username.TabIndex = 5;
            this.lb_username.Text = "Nome Usuario";
            // 
            // pb_usericone
            // 
            this.pb_usericone.Location = new System.Drawing.Point(10, 8);
            this.pb_usericone.Margin = new System.Windows.Forms.Padding(10);
            this.pb_usericone.Name = "pb_usericone";
            this.pb_usericone.Size = new System.Drawing.Size(50, 50);
            this.pb_usericone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_usericone.TabIndex = 4;
            this.pb_usericone.TabStop = false;
            this.pb_usericone.Click += new System.EventHandler(this.Pb_usericone_Click);
            // 
            // tb_mensagens
            // 
            this.tb_mensagens.BackColor = System.Drawing.Color.White;
            this.tb_mensagens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mensagens.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mensagens.Location = new System.Drawing.Point(10, 90);
            this.tb_mensagens.Margin = new System.Windows.Forms.Padding(10);
            this.tb_mensagens.Name = "tb_mensagens";
            this.tb_mensagens.ReadOnly = true;
            this.tb_mensagens.Size = new System.Drawing.Size(604, 257);
            this.tb_mensagens.TabIndex = 3;
            this.tb_mensagens.Text = "";
            this.tb_mensagens.TextChanged += new System.EventHandler(this.Tb_mensagens_TextChanged);
            // 
            // bt_limpar
            // 
            this.bt_limpar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_limpar.Location = new System.Drawing.Point(10, 439);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(130, 35);
            this.bt_limpar.TabIndex = 2;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.Bt_limpar_Click);
            // 
            // tb_mensagem
            // 
            this.tb_mensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mensagem.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mensagem.Location = new System.Drawing.Point(10, 358);
            this.tb_mensagem.Margin = new System.Windows.Forms.Padding(10);
            this.tb_mensagem.Name = "tb_mensagem";
            this.tb_mensagem.Size = new System.Drawing.Size(604, 74);
            this.tb_mensagem.TabIndex = 0;
            this.tb_mensagem.Text = "";
            // 
            // bt_enviar
            // 
            this.bt_enviar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_enviar.Location = new System.Drawing.Point(484, 439);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.Size = new System.Drawing.Size(130, 35);
            this.bt_enviar.TabIndex = 1;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(32, 183);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 47;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // FormSociaListEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSociaListEmpresa";
            this.Text = "FormSociaListEmpresa";
            this.Load += new System.EventHandler(this.FormSociaListEmpresa_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empresa)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usericone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_empresa;
        private System.Windows.Forms.PictureBox pb_empresa;
        private System.Windows.Forms.Panel panel_chat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.PictureBox pb_usericone;
        private System.Windows.Forms.RichTextBox tb_mensagens;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.RichTextBox tb_mensagem;
        private System.Windows.Forms.Button bt_enviar;
        private System.Windows.Forms.PictureBox btn_back;
    }
}