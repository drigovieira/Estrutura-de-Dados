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
            this.components = new System.ComponentModel.Container();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imagemuser = new Pont_Finder.classes.CircularPicBox();
            this.lb_deslike = new System.Windows.Forms.Label();
            this.lb_like = new System.Windows.Forms.Label();
            this.pb_down = new System.Windows.Forms.PictureBox();
            this.pb_up = new System.Windows.Forms.PictureBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_localizacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_problema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            this.NomePos = new System.Windows.Forms.Label();
            this.bt_prox = new System.Windows.Forms.Button();
            this.lb_pag = new System.Windows.Forms.Label();
            this.bt_ant = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.painelcoment = new System.Windows.Forms.Panel();
            this.bt_postar = new System.Windows.Forms.Button();
            this.tb_resposta = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "icone";
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
            this.pictureBox1.Location = new System.Drawing.Point(90, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.imagemuser);
            this.panel3.Controls.Add(this.lb_deslike);
            this.panel3.Controls.Add(this.lb_like);
            this.panel3.Controls.Add(this.pb_down);
            this.panel3.Controls.Add(this.pb_up);
            this.panel3.Controls.Add(this.gMapControl1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tb_localizacao);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lb_data);
            this.panel3.Controls.Add(this.lb_hora);
            this.panel3.Controls.Add(this.tb_descricao);
            this.panel3.Controls.Add(this.tb_problema);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pb_imagem);
            this.panel3.Controls.Add(this.NomePos);
            this.panel3.Location = new System.Drawing.Point(145, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 468);
            this.panel3.TabIndex = 93;
            // 
            // imagemuser
            // 
            this.imagemuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemuser.Location = new System.Drawing.Point(39, 42);
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
            this.lb_deslike.Location = new System.Drawing.Point(244, 382);
            this.lb_deslike.Name = "lb_deslike";
            this.lb_deslike.Size = new System.Drawing.Size(15, 16);
            this.lb_deslike.TabIndex = 108;
            this.lb_deslike.Text = "0";
            // 
            // lb_like
            // 
            this.lb_like.AutoSize = true;
            this.lb_like.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_like.Location = new System.Drawing.Point(143, 382);
            this.lb_like.Name = "lb_like";
            this.lb_like.Size = new System.Drawing.Size(15, 16);
            this.lb_like.TabIndex = 105;
            this.lb_like.Text = "0";
            // 
            // pb_down
            // 
            this.pb_down.BackgroundImage = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_down.Image = global::Pont_Finder.Properties.Resources.Deslike_null;
            this.pb_down.Location = new System.Drawing.Point(201, 382);
            this.pb_down.Margin = new System.Windows.Forms.Padding(15);
            this.pb_down.Name = "pb_down";
            this.pb_down.Size = new System.Drawing.Size(37, 32);
            this.pb_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_down.TabIndex = 107;
            this.pb_down.TabStop = false;
            // 
            // pb_up
            // 
            this.pb_up.BackgroundImage = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_up.Image = global::Pont_Finder.Properties.Resources.Like_null;
            this.pb_up.Location = new System.Drawing.Point(99, 382);
            this.pb_up.Margin = new System.Windows.Forms.Padding(15);
            this.pb_up.Name = "pb_up";
            this.pb_up.Size = new System.Drawing.Size(37, 32);
            this.pb_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_up.TabIndex = 106;
            this.pb_up.TabStop = false;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(628, 19);
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
            this.gMapControl1.Size = new System.Drawing.Size(369, 395);
            this.gMapControl1.TabIndex = 85;
            this.gMapControl1.Zoom = 14D;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 31);
            this.label4.TabIndex = 86;
            this.label4.Text = "Postagem";
            // 
            // tb_localizacao
            // 
            this.tb_localizacao.BackColor = System.Drawing.Color.White;
            this.tb_localizacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_localizacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_localizacao.Enabled = false;
            this.tb_localizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_localizacao.Location = new System.Drawing.Point(324, 130);
            this.tb_localizacao.Name = "tb_localizacao";
            this.tb_localizacao.ReadOnly = true;
            this.tb_localizacao.Size = new System.Drawing.Size(289, 19);
            this.tb_localizacao.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "Problema:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Localização:";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lb_data.Location = new System.Drawing.Point(43, 284);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(115, 13);
            this.lb_data.TabIndex = 84;
            this.lb_data.Text = "Data da Postagem:";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lb_hora.Location = new System.Drawing.Point(164, 284);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(32, 13);
            this.lb_hora.TabIndex = 82;
            this.lb_hora.Text = "hora";
            // 
            // tb_descricao
            // 
            this.tb_descricao.BackColor = System.Drawing.Color.White;
            this.tb_descricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_descricao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_descricao.Enabled = false;
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descricao.Location = new System.Drawing.Point(317, 271);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.ReadOnly = true;
            this.tb_descricao.Size = new System.Drawing.Size(289, 143);
            this.tb_descricao.TabIndex = 78;
            // 
            // tb_problema
            // 
            this.tb_problema.BackColor = System.Drawing.Color.White;
            this.tb_problema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_problema.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_problema.Enabled = false;
            this.tb_problema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_problema.Location = new System.Drawing.Point(324, 203);
            this.tb_problema.Name = "tb_problema";
            this.tb_problema.ReadOnly = true;
            this.tb_problema.Size = new System.Drawing.Size(289, 19);
            this.tb_problema.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Descrição:";
            // 
            // pb_imagem
            // 
            this.pb_imagem.Location = new System.Drawing.Point(39, 111);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(263, 170);
            this.pb_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagem.TabIndex = 76;
            this.pb_imagem.TabStop = false;
            // 
            // NomePos
            // 
            this.NomePos.AutoSize = true;
            this.NomePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomePos.Location = new System.Drawing.Point(187, 59);
            this.NomePos.Name = "NomePos";
            this.NomePos.Size = new System.Drawing.Size(51, 16);
            this.NomePos.TabIndex = 83;
            this.NomePos.Text = "label4";
            // 
            // bt_prox
            // 
            this.bt_prox.BackColor = System.Drawing.Color.Transparent;
            this.bt_prox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prox.ForeColor = System.Drawing.Color.Black;
            this.bt_prox.Location = new System.Drawing.Point(683, 197);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(75, 23);
            this.bt_prox.TabIndex = 85;
            this.bt_prox.Text = ">>";
            this.bt_prox.UseVisualStyleBackColor = false;
            this.bt_prox.Click += new System.EventHandler(this.bt_prox_Click);
            // 
            // lb_pag
            // 
            this.lb_pag.AutoSize = true;
            this.lb_pag.Location = new System.Drawing.Point(465, 207);
            this.lb_pag.Name = "lb_pag";
            this.lb_pag.Size = new System.Drawing.Size(39, 13);
            this.lb_pag.TabIndex = 86;
            this.lb_pag.Text = "lb_pag";
            // 
            // bt_ant
            // 
            this.bt_ant.BackColor = System.Drawing.Color.Transparent;
            this.bt_ant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ant.ForeColor = System.Drawing.Color.Black;
            this.bt_ant.Location = new System.Drawing.Point(233, 197);
            this.bt_ant.Name = "bt_ant";
            this.bt_ant.Size = new System.Drawing.Size(75, 23);
            this.bt_ant.TabIndex = 84;
            this.bt_ant.Text = "<<";
            this.bt_ant.UseVisualStyleBackColor = false;
            this.bt_ant.Click += new System.EventHandler(this.bt_ant_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(432, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 91;
            this.label6.Text = "Comentarios:";
            // 
            // painelcoment
            // 
            this.painelcoment.AutoScroll = true;
            this.painelcoment.AutoSize = true;
            this.painelcoment.BackColor = System.Drawing.Color.Transparent;
            this.painelcoment.Location = new System.Drawing.Point(233, 247);
            this.painelcoment.Name = "painelcoment";
            this.painelcoment.Size = new System.Drawing.Size(525, 24);
            this.painelcoment.TabIndex = 90;
            // 
            // bt_postar
            // 
            this.bt_postar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_postar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_postar.ForeColor = System.Drawing.Color.White;
            this.bt_postar.Location = new System.Drawing.Point(764, 84);
            this.bt_postar.Name = "bt_postar";
            this.bt_postar.Size = new System.Drawing.Size(86, 38);
            this.bt_postar.TabIndex = 89;
            this.bt_postar.Text = "Postar";
            this.bt_postar.UseVisualStyleBackColor = false;
            this.bt_postar.Visible = false;
            this.bt_postar.Click += new System.EventHandler(this.bt_postar_Click_1);
            // 
            // tb_resposta
            // 
            this.tb_resposta.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_resposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_resposta.Location = new System.Drawing.Point(233, 35);
            this.tb_resposta.Name = "tb_resposta";
            this.tb_resposta.Size = new System.Drawing.Size(525, 118);
            this.tb_resposta.TabIndex = 69;
            this.tb_resposta.Text = "";
            this.tb_resposta.Visible = false;
            this.tb_resposta.TextChanged += new System.EventHandler(this.tb_resposta_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_postar);
            this.panel1.Controls.Add(this.tb_resposta);
            this.panel1.Controls.Add(this.painelcoment);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bt_ant);
            this.panel1.Controls.Add(this.bt_prox);
            this.panel1.Controls.Add(this.lb_pag);
            this.panel1.Location = new System.Drawing.Point(145, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 325);
            this.panel1.TabIndex = 96;
            // 
            // ViewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1316, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPost";
            this.Text = "ViewPost";
            this.Load += new System.EventHandler(this.ViewPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openIcone;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private Pont_Finder.classes.CircularPicBox imagemuser;
        private System.Windows.Forms.Label lb_deslike;
        private System.Windows.Forms.Label lb_like;
        private System.Windows.Forms.PictureBox pb_down;
        private System.Windows.Forms.PictureBox pb_up;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NomePos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_imagem;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.TextBox tb_problema;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.TextBox tb_localizacao;
        private System.Windows.Forms.RichTextBox tb_resposta;
        private System.Windows.Forms.Button bt_postar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel painelcoment;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Label lb_pag;
        private System.Windows.Forms.Button bt_ant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}