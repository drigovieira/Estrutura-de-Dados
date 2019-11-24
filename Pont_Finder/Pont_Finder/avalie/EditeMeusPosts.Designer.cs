namespace Pont_Finder.avalie
{
    partial class EditeMeusPosts
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_postar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label5 = new System.Windows.Forms.Label();
            this.NomePos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.tb_problema = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_localizacao = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-101, -403);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(568, 277);
            this.bt_editar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(115, 34);
            this.bt_editar.TabIndex = 97;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click_1);
            // 
            // bt_postar
            // 
            this.bt_postar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_postar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_postar.ForeColor = System.Drawing.Color.White;
            this.bt_postar.Location = new System.Drawing.Point(445, 277);
            this.bt_postar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_postar.Name = "bt_postar";
            this.bt_postar.Size = new System.Drawing.Size(115, 34);
            this.bt_postar.TabIndex = 98;
            this.bt_postar.Text = "Postar";
            this.bt_postar.UseVisualStyleBackColor = false;
            this.bt_postar.Click += new System.EventHandler(this.bt_postar_Click_1);
            // 
            // bt_remover
            // 
            this.bt_remover.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.ForeColor = System.Drawing.Color.White;
            this.bt_remover.Location = new System.Drawing.Point(691, 277);
            this.bt_remover.Margin = new System.Windows.Forms.Padding(4);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(115, 34);
            this.bt_remover.TabIndex = 96;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.bt_editar);
            this.panel5.Controls.Add(this.gMapControl1);
            this.panel5.Controls.Add(this.bt_postar);
            this.panel5.Controls.Add(this.bt_remover);
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
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1244, 628);
            this.panel5.TabIndex = 95;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(853, 12);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(4);
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
            this.gMapControl1.Size = new System.Drawing.Size(377, 374);
            this.gMapControl1.TabIndex = 85;
            this.gMapControl1.Zoom = 14D;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(486, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Tipo do Problema";
            // 
            // NomePos
            // 
            this.NomePos.AutoSize = true;
            this.NomePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomePos.Location = new System.Drawing.Point(-80, 52);
            this.NomePos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomePos.Name = "NomePos";
            this.NomePos.Size = new System.Drawing.Size(59, 20);
            this.NomePos.TabIndex = 83;
            this.NomePos.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Localização";
            // 
            // pb_imagem
            // 
            this.pb_imagem.Location = new System.Drawing.Point(90, 50);
            this.pb_imagem.Margin = new System.Windows.Forms.Padding(4);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(351, 209);
            this.pb_imagem.TabIndex = 76;
            this.pb_imagem.TabStop = false;
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lb_data.Location = new System.Drawing.Point(87, 277);
            this.lb_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(146, 17);
            this.lb_data.TabIndex = 84;
            this.lb_data.Text = "Data da Postagem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "Descrição";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lb_hora.Location = new System.Drawing.Point(241, 277);
            this.lb_hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(41, 17);
            this.lb_hora.TabIndex = 82;
            this.lb_hora.Text = "hora";
            // 
            // tb_problema
            // 
            this.tb_problema.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_problema.Enabled = false;
            this.tb_problema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_problema.Location = new System.Drawing.Point(491, 50);
            this.tb_problema.Margin = new System.Windows.Forms.Padding(4);
            this.tb_problema.Name = "tb_problema";
            this.tb_problema.ReadOnly = true;
            this.tb_problema.Size = new System.Drawing.Size(344, 23);
            this.tb_problema.TabIndex = 75;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_descricao.Enabled = false;
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_descricao.Location = new System.Drawing.Point(491, 198);
            this.tb_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.ReadOnly = true;
            this.tb_descricao.Size = new System.Drawing.Size(344, 61);
            this.tb_descricao.TabIndex = 78;
            // 
            // tb_localizacao
            // 
            this.tb_localizacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_localizacao.Enabled = false;
            this.tb_localizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tb_localizacao.Location = new System.Drawing.Point(491, 129);
            this.tb_localizacao.Margin = new System.Windows.Forms.Padding(4);
            this.tb_localizacao.Name = "tb_localizacao";
            this.tb_localizacao.ReadOnly = true;
            this.tb_localizacao.Size = new System.Drawing.Size(344, 23);
            this.tb_localizacao.TabIndex = 77;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-79, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Postagem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "label4";
            // 
            // EditeMeusPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 628);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1262, 675);
            this.Name = "EditeMeusPosts";
            this.Text = "EditeMeusPosts";
            this.Load += new System.EventHandler(this.EditeMeusPosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_postar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Panel panel5;
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}