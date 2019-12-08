namespace Pont_Finder.eventos.User_Card
{
    partial class comentarios_eventos
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
            this.comentarios = new System.Windows.Forms.RichTextBox();
            this.imagem = new Pont_Finder.classes.CircularPicBox();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.lb_deslike = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.lb_like = new System.Windows.Forms.Label();
            this.datapost = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            this.SuspendLayout();
            // 
            // comentarios
            // 
            this.comentarios.Enabled = false;
            this.comentarios.Location = new System.Drawing.Point(48, 96);
            this.comentarios.Name = "comentarios";
            this.comentarios.Size = new System.Drawing.Size(310, 118);
            this.comentarios.TabIndex = 60;
            this.comentarios.Text = "";
            // 
            // imagem
            // 
            this.imagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagem.Location = new System.Drawing.Point(45, 5);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(52, 48);
            this.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem.TabIndex = 59;
            this.imagem.TabStop = false;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(394, 125);
            this.bt_editar.Margin = new System.Windows.Forms.Padding(5);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(86, 28);
            this.bt_editar.TabIndex = 58;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Visible = false;
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover.ForeColor = System.Drawing.Color.White;
            this.bt_remover.Location = new System.Drawing.Point(394, 186);
            this.bt_remover.Margin = new System.Windows.Forms.Padding(5);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(86, 28);
            this.bt_remover.TabIndex = 57;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            // 
            // lb_deslike
            // 
            this.lb_deslike.AutoSize = true;
            this.lb_deslike.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deslike.Location = new System.Drawing.Point(465, 56);
            this.lb_deslike.Name = "lb_deslike";
            this.lb_deslike.Size = new System.Drawing.Size(15, 16);
            this.lb_deslike.TabIndex = 56;
            this.lb_deslike.Text = "0";
            // 
            // pb_down
            // 
            this.pb_down.BackgroundImage = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_down.Image = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.Location = new System.Drawing.Point(422, 47);
            this.pb_down.Margin = new System.Windows.Forms.Padding(15);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(25, 25);
            this.pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_down.TabIndex = 55;
            this.pb_down.TabStop = false;
            // 
            // pb_up
            // 
            this.pb_up.BackgroundImage = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_up.Image = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.Location = new System.Drawing.Point(422, 8);
            this.pb_up.Margin = new System.Windows.Forms.Padding(15);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(25, 25);
            this.pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_up.TabIndex = 54;
            this.pb_up.TabStop = false;
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_like.Location = new System.Drawing.Point(465, 17);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(15, 16);
            this.lb_like.TabIndex = 53;
            this.lb_like.Text = "0";
            // 
            // datapost
            // 
            this.datapost.AutoSize = true;
            this.datapost.BackColor = System.Drawing.Color.Transparent;
            this.datapost.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datapost.Location = new System.Drawing.Point(45, 74);
            this.datapost.Margin = new System.Windows.Forms.Padding(5);
            this.datapost.Name = "datapost";
            this.datapost.Size = new System.Drawing.Size(66, 14);
            this.datapost.TabIndex = 52;
            this.datapost.Text = "Postado em:";
            this.datapost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(103, 5);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(30, 16);
            this.nome.TabIndex = 51;
            this.nome.Text = "user";
            // 
            // comentarios_eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comentarios);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.lb_deslike);
            this.Controls.Add(this.pb_down);
            this.Controls.Add(this.pb_up);
            this.Controls.Add(this.lb_like);
            this.Controls.Add(this.datapost);
            this.Controls.Add(this.nome);
            this.Name = "comentarios_eventos";
            this.Size = new System.Drawing.Size(525, 219);
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox comentarios;
        private Pont_Finder.classes.CircularPicBox imagem;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Label lb_deslike;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.Label datapost;
        private System.Windows.Forms.Label nome;
    }
}
