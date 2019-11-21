namespace Pont_Finder.hospedagem.data.inc
{
    partial class Img_list
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
            this.pb_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_img
            // 
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_img.Location = new System.Drawing.Point(0, 0);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(100, 50);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img.TabIndex = 1;
            this.pb_img.TabStop = false;
            this.pb_img.Click += new System.EventHandler(this.pb_img_Click);
            // 
            // Img_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pb_img);
            this.Name = "Img_list";
            this.Size = new System.Drawing.Size(100, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_img;
    }
}
