namespace Pont_Finder.hospedagem.data.inc
{
    partial class amb
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
            this.pb_amb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_amb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_amb
            // 
            this.pb_amb.Location = new System.Drawing.Point(0, 0);
            this.pb_amb.Name = "pb_amb";
            this.pb_amb.Size = new System.Drawing.Size(25, 25);
            this.pb_amb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_amb.TabIndex = 51;
            this.pb_amb.TabStop = false;
            this.pb_amb.Click += new System.EventHandler(this.pb_icon_Click);
            // 
            // ambien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_amb);
            this.Name = "ambien";
            this.Size = new System.Drawing.Size(25, 25);
            ((System.ComponentModel.ISupportInitialize)(this.pb_amb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_amb;
    }
}
