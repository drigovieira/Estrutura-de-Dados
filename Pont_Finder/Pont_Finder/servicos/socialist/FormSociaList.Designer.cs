namespace Pont_Finder.servicos.socialist
{
    partial class FormSociaList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSociaList));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_chat = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_username = new System.Windows.Forms.Label();
            this.pb_userimage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_mensagem = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_mensagens = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userimage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 150);
            this.panel3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(416, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aproveite nossos serviços!";
            // 
            // panel_chat
            // 
            this.panel_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panel_chat.Location = new System.Drawing.Point(5, 238);
            this.panel_chat.Margin = new System.Windows.Forms.Padding(5);
            this.panel_chat.Name = "panel_chat";
            this.panel_chat.Size = new System.Drawing.Size(490, 425);
            this.panel_chat.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lb_username);
            this.panel1.Controls.Add(this.pb_userimage);
            this.panel1.Location = new System.Drawing.Point(5, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 70);
            this.panel1.TabIndex = 41;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(73, 16);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(199, 36);
            this.lb_username.TabIndex = 1;
            this.lb_username.Text = "Nome Usuário";
            // 
            // pb_userimage
            // 
            this.pb_userimage.Location = new System.Drawing.Point(10, 10);
            this.pb_userimage.Margin = new System.Windows.Forms.Padding(10);
            this.pb_userimage.Name = "pb_userimage";
            this.pb_userimage.Size = new System.Drawing.Size(50, 50);
            this.pb_userimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_userimage.TabIndex = 0;
            this.pb_userimage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.tb_mensagens);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tb_mensagem);
            this.panel2.Location = new System.Drawing.Point(505, 158);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 505);
            this.panel2.TabIndex = 41;
            // 
            // tb_mensagem
            // 
            this.tb_mensagem.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mensagem.Location = new System.Drawing.Point(3, 377);
            this.tb_mensagem.Name = "tb_mensagem";
            this.tb_mensagem.Size = new System.Drawing.Size(749, 96);
            this.tb_mensagem.TabIndex = 0;
            this.tb_mensagem.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tb_mensagens
            // 
            this.tb_mensagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.tb_mensagens.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mensagens.Location = new System.Drawing.Point(3, 3);
            this.tb_mensagens.Name = "tb_mensagens";
            this.tb_mensagens.ReadOnly = true;
            this.tb_mensagens.Size = new System.Drawing.Size(749, 368);
            this.tb_mensagens.TabIndex = 3;
            this.tb_mensagens.Text = "";
            // 
            // FormSociaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_chat);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSociaList";
            this.Text = "FormSociaList";
            this.Load += new System.EventHandler(this.FormSociaList_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userimage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_chat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.PictureBox pb_userimage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox tb_mensagem;
        private System.Windows.Forms.RichTextBox tb_mensagens;
    }
}