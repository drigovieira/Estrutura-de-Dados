namespace Pont_Finder
{
    partial class Propaganda_modulos
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
            this.components = new System.ComponentModel.Container();
            this.pb_propaganda1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_texto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_propaganda1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_propaganda1
            // 
            this.pb_propaganda1.Location = new System.Drawing.Point(23, 20);
            this.pb_propaganda1.Name = "pb_propaganda1";
            this.pb_propaganda1.Size = new System.Drawing.Size(250, 140);
            this.pb_propaganda1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_propaganda1.TabIndex = 0;
            this.pb_propaganda1.TabStop = false;
            this.pb_propaganda1.Click += new System.EventHandler(this.Pb_propaganda1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.Location = new System.Drawing.Point(23, 183);
            this.lb_texto.MaximumSize = new System.Drawing.Size(250, 0);
            this.lb_texto.MinimumSize = new System.Drawing.Size(250, 0);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(250, 17);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "label1";
            this.lb_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Propaganda_modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.pb_propaganda1);
            this.Name = "Propaganda_modulos";
            this.Size = new System.Drawing.Size(310, 231);
            this.Load += new System.EventHandler(this.Propaganda_modulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_propaganda1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_propaganda1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_texto;
    }
}
