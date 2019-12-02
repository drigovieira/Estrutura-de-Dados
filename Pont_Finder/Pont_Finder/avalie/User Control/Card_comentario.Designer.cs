namespace Pont_Finder.avalie.User_Control
{
    partial class Card_comentario
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
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_comentario = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.lb_deslike = new System.Windows.Forms.Label();
            this.lb_like = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_user = new Pont_Finder.classes.CircularPicBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(63, 5);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(30, 16);
            this.lb_username.TabIndex = 27;
            this.lb_username.Text = "user";
            // 
            // lb_comentario
            // 
            this.lb_comentario.BackColor = System.Drawing.Color.Transparent;
            this.lb_comentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_comentario.Font = new System.Drawing.Font("Dubai", 9F);
            this.lb_comentario.Location = new System.Drawing.Point(5, 98);
            this.lb_comentario.Margin = new System.Windows.Forms.Padding(5);
            this.lb_comentario.Name = "lb_comentario";
            this.lb_comentario.Size = new System.Drawing.Size(367, 118);
            this.lb_comentario.TabIndex = 30;
            this.lb_comentario.Text = "Descricao:";
            this.lb_comentario.Click += new System.EventHandler(this.lb_comentario_Click);
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.BackColor = System.Drawing.Color.Transparent;
            this.lb_data.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(5, 74);
            this.lb_data.Margin = new System.Windows.Forms.Padding(5);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(66, 14);
            this.lb_data.TabIndex = 31;
            this.lb_data.Text = "Postado em:";
            this.lb_data.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pb_down
            // 
            this.pb_down.BackgroundImage = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_down.Image = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.Location = new System.Drawing.Point(382, 47);
            this.pb_down.Margin = new System.Windows.Forms.Padding(15);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(25, 25);
            this.pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_down.TabIndex = 34;
            this.pb_down.TabStop = false;
            // 
            // pb_up
            // 
            this.pb_up.BackgroundImage = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_up.Image = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.Location = new System.Drawing.Point(382, 8);
            this.pb_up.Margin = new System.Windows.Forms.Padding(15);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(25, 25);
            this.pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_up.TabIndex = 33;
            this.pb_up.TabStop = false;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(382, 140);
            this.bt_editar.Margin = new System.Windows.Forms.Padding(5);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(86, 28);
            this.bt_editar.TabIndex = 37;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover.ForeColor = System.Drawing.Color.White;
            this.bt_remover.Location = new System.Drawing.Point(382, 188);
            this.bt_remover.Margin = new System.Windows.Forms.Padding(5);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(86, 28);
            this.bt_remover.TabIndex = 36;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            // 
            // lb_deslike
            // 
            this.lb_deslike.AutoSize = true;
            this.lb_deslike.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deslike.Location = new System.Drawing.Point(425, 56);
            this.lb_deslike.Name = "lb_deslike";
            this.lb_deslike.Size = new System.Drawing.Size(15, 16);
            this.lb_deslike.TabIndex = 35;
            this.lb_deslike.Text = "0";
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_like.Location = new System.Drawing.Point(425, 17);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(15, 16);
            this.lb_like.TabIndex = 32;
            this.lb_like.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(382, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pb_user
            // 
            this.pb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_user.Location = new System.Drawing.Point(5, 5);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(52, 48);
            this.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_user.TabIndex = 39;
            this.pb_user.TabStop = false;
            // 
            // Card_comentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pb_user);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.lb_deslike);
            this.Controls.Add(this.pb_down);
            this.Controls.Add(this.pb_up);
            this.Controls.Add(this.lb_like);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_comentario);
            this.Controls.Add(this.lb_username);
            this.Name = "Card_comentario";
            this.Size = new System.Drawing.Size(498, 221);
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_comentario;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Label lb_deslike;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.Button button1;
        private Pont_Finder.classes.CircularPicBox pb_user;
    }
}
