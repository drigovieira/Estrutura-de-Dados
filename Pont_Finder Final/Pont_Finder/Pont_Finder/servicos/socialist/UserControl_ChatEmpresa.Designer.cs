namespace Pont_Finder.servicos.socialist
{
    partial class UserControl_ChatEmpresa
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
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.lb_empresa = new System.Windows.Forms.Label();
            this.lb_servico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_icone
            // 
            this.pb_icone.Location = new System.Drawing.Point(5, 5);
            this.pb_icone.Margin = new System.Windows.Forms.Padding(5);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(70, 70);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 0;
            this.pb_icone.TabStop = false;
            // 
            // lb_empresa
            // 
            this.lb_empresa.AutoSize = true;
            this.lb_empresa.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empresa.Location = new System.Drawing.Point(83, 5);
            this.lb_empresa.Name = "lb_empresa";
            this.lb_empresa.Size = new System.Drawing.Size(58, 16);
            this.lb_empresa.TabIndex = 1;
            this.lb_empresa.Text = "Empresa: ";
            // 
            // lb_servico
            // 
            this.lb_servico.AutoSize = true;
            this.lb_servico.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_servico.Location = new System.Drawing.Point(83, 38);
            this.lb_servico.Name = "lb_servico";
            this.lb_servico.Size = new System.Drawing.Size(52, 16);
            this.lb_servico.TabIndex = 2;
            this.lb_servico.Text = "Serviço: ";
            // 
            // UserControl_ChatEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.lb_servico);
            this.Controls.Add(this.lb_empresa);
            this.Controls.Add(this.pb_icone);
            this.Name = "UserControl_ChatEmpresa";
            this.Size = new System.Drawing.Size(369, 80);
            this.Load += new System.EventHandler(this.UserControl_ChatEmpresa_Load);
            this.Click += new System.EventHandler(this.UserControl_ChatEmpresa_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Label lb_empresa;
        private System.Windows.Forms.Label lb_servico;
    }
}
