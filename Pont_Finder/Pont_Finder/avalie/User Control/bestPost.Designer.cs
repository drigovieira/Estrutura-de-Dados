namespace Pont_Finder.avalie.User_Control
{
    partial class bestPost
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_deslike = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.lb_like = new System.Windows.Forms.Label();
            this.lb_problema = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_deslike
            // 
            this.lb_deslike.AutoSize = true;
            this.lb_deslike.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deslike.Location = new System.Drawing.Point(162, 77);
            this.lb_deslike.Name = "lb_deslike";
            this.lb_deslike.Size = new System.Drawing.Size(15, 16);
            this.lb_deslike.TabIndex = 39;
            this.lb_deslike.Text = "0";
            // 
            // pb_down
            // 
            this.pb_down.BackgroundImage = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_down.Enabled = false;
            this.pb_down.Image = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.Location = new System.Drawing.Point(119, 68);
            this.pb_down.Margin = new System.Windows.Forms.Padding(15);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(25, 25);
            this.pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_down.TabIndex = 38;
            this.pb_down.TabStop = false;
            // 
            // pb_up
            // 
            this.pb_up.BackgroundImage = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_up.Enabled = false;
            this.pb_up.Image = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.Location = new System.Drawing.Point(119, 30);
            this.pb_up.Margin = new System.Windows.Forms.Padding(15);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(25, 25);
            this.pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_up.TabIndex = 37;
            this.pb_up.TabStop = false;
            this.pb_up.Click += new System.EventHandler(this.pb_up_Click);
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_like.Location = new System.Drawing.Point(162, 39);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(15, 16);
            this.lb_like.TabIndex = 36;
            this.lb_like.Text = "0";
            this.lb_like.Click += new System.EventHandler(this.lb_like_Click);
            // 
            // lb_problema
            // 
            this.lb_problema.AutoSize = true;
            this.lb_problema.Location = new System.Drawing.Point(116, 2);
            this.lb_problema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_problema.Name = "lb_problema";
            this.lb_problema.Size = new System.Drawing.Size(35, 13);
            this.lb_problema.TabIndex = 40;
            this.lb_problema.Text = "label1";
            // 
            // bestPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_problema);
            this.Controls.Add(this.lb_deslike);
            this.Controls.Add(this.pb_down);
            this.Controls.Add(this.pb_up);
            this.Controls.Add(this.lb_like);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "bestPost";
            this.Size = new System.Drawing.Size(261, 98);
            this.Load += new System.EventHandler(this.bestPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_deslike;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.Label lb_problema;
    }
}
