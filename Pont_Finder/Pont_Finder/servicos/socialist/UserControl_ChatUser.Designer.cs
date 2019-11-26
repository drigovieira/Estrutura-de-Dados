namespace Pont_Finder.servicos.socialist
{
    partial class UserControl_ChatUser
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_servico = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mensagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(112, 72);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(43, 13);
            this.lb_status.TabIndex = 8;
            this.lb_status.Text = "Status: ";
            // 
            // lb_servico
            // 
            this.lb_servico.AutoSize = true;
            this.lb_servico.Location = new System.Drawing.Point(112, 40);
            this.lb_servico.Name = "lb_servico";
            this.lb_servico.Size = new System.Drawing.Size(98, 13);
            this.lb_servico.TabIndex = 7;
            this.lb_servico.Text = "Serviço Solicitado: ";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(112, 5);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(95, 13);
            this.lb_username.TabIndex = 6;
            this.lb_username.Text = "Nome do Usuário: ";
            // 
            // pb_icone
            // 
            this.pb_icone.Location = new System.Drawing.Point(5, 5);
            this.pb_icone.Margin = new System.Windows.Forms.Padding(5);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(100, 80);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 5;
            this.pb_icone.TabStop = false;
            // 
            // UserControl_ChatUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_servico);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.pb_icone);
            this.Name = "UserControl_ChatUser";
            this.Size = new System.Drawing.Size(470, 90);
            this.Load += new System.EventHandler(this.UserControl_ChatUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_servico;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.PictureBox pb_icone;
    }
}
