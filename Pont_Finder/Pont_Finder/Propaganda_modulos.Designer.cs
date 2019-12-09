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
            this.pb_propaganda2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_propaganda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_propaganda2)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_propaganda1
            // 
            this.pb_propaganda1.Location = new System.Drawing.Point(23, 20);
            this.pb_propaganda1.Name = "pb_propaganda1";
            this.pb_propaganda1.Size = new System.Drawing.Size(250, 140);
            this.pb_propaganda1.TabIndex = 0;
            this.pb_propaganda1.TabStop = false;
            // 
            // pb_propaganda2
            // 
            this.pb_propaganda2.Location = new System.Drawing.Point(23, 184);
            this.pb_propaganda2.Name = "pb_propaganda2";
            this.pb_propaganda2.Size = new System.Drawing.Size(256, 140);
            this.pb_propaganda2.TabIndex = 1;
            this.pb_propaganda2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Propaganda_modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_propaganda2);
            this.Controls.Add(this.pb_propaganda1);
            this.Name = "Propaganda_modulos";
            this.Size = new System.Drawing.Size(310, 350);
            this.Load += new System.EventHandler(this.Propaganda_modulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_propaganda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_propaganda2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_propaganda1;
        private System.Windows.Forms.PictureBox pb_propaganda2;
        private System.Windows.Forms.Timer timer1;
    }
}
