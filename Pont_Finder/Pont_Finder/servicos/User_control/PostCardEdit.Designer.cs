namespace Pont_Finder.servicos
{
    partial class PostCardEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.pb_user = new System.Windows.Forms.PictureBox();
            this.bt_obter = new System.Windows.Forms.Button();
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_like = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.lb_deslike = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_deslike);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lb_data);
            this.panel1.Controls.Add(this.lb_descricao);
            this.panel1.Controls.Add(this.pb_down);
            this.panel1.Controls.Add(this.pb_up);
            this.panel1.Controls.Add(this.lb_username);
            this.panel1.Controls.Add(this.pb_user);
            this.panel1.Controls.Add(this.bt_obter);
            this.panel1.Controls.Add(this.lb_valor);
            this.panel1.Controls.Add(this.lb_like);
            this.panel1.Controls.Add(this.lb_titulo);
            this.panel1.Controls.Add(this.pb_icone);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 200);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(886, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(886, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 28);
            this.button3.TabIndex = 31;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(26, 169);
            this.lb_data.MaximumSize = new System.Drawing.Size(200, 16);
            this.lb_data.MinimumSize = new System.Drawing.Size(200, 16);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(200, 16);
            this.lb_data.TabIndex = 30;
            this.lb_data.Text = "Postado em:";
            // 
            // lb_descricao
            // 
            this.lb_descricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_descricao.Location = new System.Drawing.Point(228, 26);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(450, 159);
            this.lb_descricao.TabIndex = 29;
            this.lb_descricao.Text = "descricao";
            // 
            // pb_down
            // 
            this.pb_down.BackgroundImage = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_down.Image = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.Location = new System.Drawing.Point(701, 70);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(25, 25);
            this.pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_down.TabIndex = 28;
            this.pb_down.TabStop = false;
            // 
            // pb_up
            // 
            this.pb_up.BackgroundImage = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_up.Image = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.Location = new System.Drawing.Point(701, 35);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(25, 25);
            this.pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_up.TabIndex = 27;
            this.pb_up.TabStop = false;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(835, 10);
            this.lb_username.MaximumSize = new System.Drawing.Size(150, 50);
            this.lb_username.MinimumSize = new System.Drawing.Size(150, 50);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(150, 50);
            this.lb_username.TabIndex = 25;
            this.lb_username.Text = "user";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_user
            // 
            this.pb_user.Location = new System.Drawing.Point(785, 10);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(50, 50);
            this.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_user.TabIndex = 24;
            this.pb_user.TabStop = false;
            // 
            // bt_obter
            // 
            this.bt_obter.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_obter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bt_obter.ForeColor = System.Drawing.Color.White;
            this.bt_obter.Location = new System.Drawing.Point(701, 150);
            this.bt_obter.Name = "bt_obter";
            this.bt_obter.Size = new System.Drawing.Size(127, 35);
            this.bt_obter.TabIndex = 23;
            this.bt_obter.Text = "Visualizar";
            this.bt_obter.UseVisualStyleBackColor = false;
            this.bt_obter.Click += new System.EventHandler(this.bt_obter_Click);
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.ForeColor = System.Drawing.Color.Green;
            this.lb_valor.Location = new System.Drawing.Point(696, 112);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(55, 26);
            this.lb_valor.TabIndex = 22;
            this.lb_valor.Text = "valor";
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_like.Location = new System.Drawing.Point(732, 45);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(27, 14);
            this.lb_like.TabIndex = 20;
            this.lb_like.Text = "Like";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(228, 3);
            this.lb_titulo.MaximumSize = new System.Drawing.Size(450, 20);
            this.lb_titulo.MinimumSize = new System.Drawing.Size(450, 20);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(450, 20);
            this.lb_titulo.TabIndex = 15;
            this.lb_titulo.Text = "titulo";
            this.lb_titulo.Click += new System.EventHandler(this.Lb_titulo_Click);
            // 
            // pb_icone
            // 
            this.pb_icone.Location = new System.Drawing.Point(26, 26);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(200, 140);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 14;
            this.pb_icone.TabStop = false;
            // 
            // lb_deslike
            // 
            this.lb_deslike.AutoSize = true;
            this.lb_deslike.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lb_deslike.Location = new System.Drawing.Point(732, 79);
            this.lb_deslike.Name = "lb_deslike";
            this.lb_deslike.Size = new System.Drawing.Size(44, 14);
            this.lb_deslike.TabIndex = 33;
            this.lb_deslike.Text = "Deslike";
            // 
            // PostCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PostCardEdit";
            this.Size = new System.Drawing.Size(1000, 200);
            this.Load += new System.EventHandler(this.PostCardEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private System.Windows.Forms.Button bt_obter;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.PictureBox pb_user;
        private System.Windows.Forms.Label lb_deslike;
    }
}
