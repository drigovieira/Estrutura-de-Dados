namespace Pont_Finder.avalie
{
    partial class ViewPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_resposta = new System.Windows.Forms.RichTextBox();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            this.bt_postar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.NomePos = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_localizacao = new System.Windows.Forms.TextBox();
            this.tb_problema = new System.Windows.Forms.TextBox();
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.imagemuser = new Pont_Finder.classes.CircularPicBox();
            this.lb_deslike = new System.Windows.Forms.Label();
            this.lb_like = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_resposta
            // 
            this.tb_resposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_resposta.Location = new System.Drawing.Point(16, 903);
            this.tb_resposta.Name = "tb_resposta";
            this.tb_resposta.Size = new System.Drawing.Size(558, 119);
            this.tb_resposta.TabIndex = 69;
            this.tb_resposta.Text = "";
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            // 
            // bt_postar
            // 
            this.bt_postar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_postar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_postar.ForeColor = System.Drawing.Color.White;
            this.bt_postar.Location = new System.Drawing.Point(16, 1039);
            this.bt_postar.Name = "bt_postar";
            this.bt_postar.Size = new System.Drawing.Size(86, 28);
            this.bt_postar.TabIndex = 89;
            this.bt_postar.Text = "Postar";
            this.bt_postar.UseVisualStyleBackColor = false;
            this.bt_postar.Click += new System.EventHandler(this.bt_postar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(251, 1039);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(86, 28);
            this.bt_editar.TabIndex = 88;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.ForeColor = System.Drawing.Color.White;
            this.bt_remover.Location = new System.Drawing.Point(485, 1037);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(86, 28);
            this.bt_remover.TabIndex = 87;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lb_data.Location = new System.Drawing.Point(52, 263);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(115, 13);
            this.lb_data.TabIndex = 84;
            this.lb_data.Text = "Data da Postagem:";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lb_hora.Location = new System.Drawing.Point(144, 264);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(32, 13);
            this.lb_hora.TabIndex = 82;
            this.lb_hora.Text = "hora";
            // 
            // NomePos
            // 
            this.NomePos.AutoSize = true;
            this.NomePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomePos.Location = new System.Drawing.Point(143, 3);
            this.NomePos.Name = "NomePos";
            this.NomePos.Size = new System.Drawing.Size(51, 16);
            this.NomePos.TabIndex = 83;
            this.NomePos.Text = "label4";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_descricao.Enabled = false;
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_descricao.Location = new System.Drawing.Point(354, 199);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.ReadOnly = true;
            this.tb_descricao.Size = new System.Drawing.Size(259, 50);
            this.tb_descricao.TabIndex = 78;
            // 
            // tb_localizacao
            // 
            this.tb_localizacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_localizacao.Enabled = false;
            this.tb_localizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_localizacao.Location = new System.Drawing.Point(354, 143);
            this.tb_localizacao.Name = "tb_localizacao";
            this.tb_localizacao.ReadOnly = true;
            this.tb_localizacao.Size = new System.Drawing.Size(259, 20);
            this.tb_localizacao.TabIndex = 77;
            // 
            // tb_problema
            // 
            this.tb_problema.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_problema.Enabled = false;
            this.tb_problema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_problema.Location = new System.Drawing.Point(354, 79);
            this.tb_problema.Name = "tb_problema";
            this.tb_problema.ReadOnly = true;
            this.tb_problema.Size = new System.Drawing.Size(259, 20);
            this.tb_problema.TabIndex = 75;
            // 
            // pb_imagem
            // 
            this.pb_imagem.Location = new System.Drawing.Point(55, 79);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(263, 170);
            this.pb_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagem.TabIndex = 76;
            this.pb_imagem.TabStop = false;
            this.pb_imagem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "Tipo do Problema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Localização";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Descrição";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1198, 100);
            this.panel2.TabIndex = 24;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "icone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(468, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 91;
            this.label6.Text = "Comentarios:";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bt_editar);
            this.panel3.Controls.Add(this.tb_resposta);
            this.panel3.Controls.Add(this.bt_postar);
            this.panel3.Controls.Add(this.bt_remover);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(112, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1055, 1166);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(8, 457);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1020, 397);
            this.panel4.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 31);
            this.label4.TabIndex = 86;
            this.label4.Text = "Postagem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 874);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "Comentar:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.imagemuser);
            this.panel5.Controls.Add(this.lb_deslike);
            this.panel5.Controls.Add(this.lb_like);
            this.panel5.Controls.Add(this.pb_down);
            this.panel5.Controls.Add(this.pb_up);
            this.panel5.Controls.Add(this.gMapControl1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.NomePos);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pb_imagem);
            this.panel5.Controls.Add(this.lb_data);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lb_hora);
            this.panel5.Controls.Add(this.tb_problema);
            this.panel5.Controls.Add(this.tb_descricao);
            this.panel5.Controls.Add(this.tb_localizacao);
            this.panel5.Location = new System.Drawing.Point(8, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1020, 375);
            this.panel5.TabIndex = 85;
            // 
            // imagemuser
            // 
            this.imagemuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemuser.Location = new System.Drawing.Point(57, 3);
            this.imagemuser.Name = "imagemuser";
            this.imagemuser.Size = new System.Drawing.Size(68, 68);
            this.imagemuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemuser.TabIndex = 109;
            this.imagemuser.TabStop = false;
            // 
            // lb_deslike
            // 
            this.lb_deslike.AutoSize = true;
            this.lb_deslike.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deslike.Location = new System.Drawing.Point(200, 326);
            this.lb_deslike.Name = "lb_deslike";
            this.lb_deslike.Size = new System.Drawing.Size(15, 16);
            this.lb_deslike.TabIndex = 108;
            this.lb_deslike.Text = "0";
            this.lb_deslike.Click += new System.EventHandler(this.lb_deslike_Click);
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_like.Location = new System.Drawing.Point(99, 326);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(15, 16);
            this.lb_like.TabIndex = 105;
            this.lb_like.Text = "0";
            this.lb_like.Click += new System.EventHandler(this.lb_like_Click);
            // 
            // pb_down
            // 
            this.pb_down.BackgroundImage = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_down.Image = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.Location = new System.Drawing.Point(157, 326);
            this.pb_down.Margin = new System.Windows.Forms.Padding(15);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(37, 32);
            this.pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_down.TabIndex = 107;
            this.pb_down.TabStop = false;
            this.pb_down.Click += new System.EventHandler(this.pb_down_Click);
            // 
            // pb_up
            // 
            this.pb_up.BackgroundImage = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_up.Image = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.Location = new System.Drawing.Point(55, 326);
            this.pb_up.Margin = new System.Windows.Forms.Padding(15);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(37, 32);
            this.pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_up.TabIndex = 106;
            this.pb_up.TabStop = false;
            this.pb_up.Click += new System.EventHandler(this.pb_up_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(634, 23);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 14;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(369, 334);
            this.gMapControl1.TabIndex = 85;
            this.gMapControl1.Zoom = 14D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(66, -209);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 28;
            this.btn_back.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "icone";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "icone";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(66, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // ViewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPost";
            this.Text = "ViewPost";
            this.Load += new System.EventHandler(this.ViewPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox tb_resposta;
        private System.Windows.Forms.OpenFileDialog openIcone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NomePos;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.TextBox tb_localizacao;
        private System.Windows.Forms.TextBox tb_problema;
        private System.Windows.Forms.PictureBox pb_imagem;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button bt_postar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label lb_deslike;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private Pont_Finder.classes.CircularPicBox imagemuser;
    }
}