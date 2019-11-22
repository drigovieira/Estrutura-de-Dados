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
            this.label1 = new System.Windows.Forms.Label();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bt_postar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_hora = new System.Windows.Forms.Label();
            this.NomePos = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_localizacao = new System.Windows.Forms.TextBox();
            this.tb_problema = new System.Windows.Forms.TextBox();
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_resposta
            // 
            this.tb_resposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_resposta.Location = new System.Drawing.Point(28, 342);
            this.tb_resposta.Name = "tb_resposta";
            this.tb_resposta.Size = new System.Drawing.Size(558, 119);
            this.tb_resposta.TabIndex = 69;
            this.tb_resposta.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 66;
            this.label1.Text = "Resposta";
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.bt_postar);
            this.panel6.Controls.Add(this.bt_editar);
            this.panel6.Controls.Add(this.bt_remover);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.lb_data);
            this.panel6.Controls.Add(this.lb_hora);
            this.panel6.Controls.Add(this.NomePos);
            this.panel6.Controls.Add(this.tb_descricao);
            this.panel6.Controls.Add(this.tb_localizacao);
            this.panel6.Controls.Add(this.tb_problema);
            this.panel6.Controls.Add(this.pb_imagem);
            this.panel6.Controls.Add(this.tb_resposta);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Location = new System.Drawing.Point(305, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(614, 669);
            this.panel6.TabIndex = 23;
            // 
            // bt_postar
            // 
            this.bt_postar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_postar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_postar.ForeColor = System.Drawing.Color.White;
            this.bt_postar.Location = new System.Drawing.Point(28, 467);
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
            this.bt_editar.Location = new System.Drawing.Point(268, 467);
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
            this.bt_remover.Location = new System.Drawing.Point(500, 467);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(86, 28);
            this.bt_remover.TabIndex = 87;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = false;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 31);
            this.label11.TabIndex = 86;
            this.label11.Text = "Postagem";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Dubai", 8F, System.Drawing.FontStyle.Bold);
            this.lb_data.Location = new System.Drawing.Point(21, 255);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(93, 20);
            this.lb_data.TabIndex = 84;
            this.lb_data.Text = "Data da Postagem:";
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.Font = new System.Drawing.Font("Dubai", 8F, System.Drawing.FontStyle.Bold);
            this.lb_hora.Location = new System.Drawing.Point(113, 256);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(30, 20);
            this.lb_hora.TabIndex = 82;
            this.lb_hora.Text = "hora";
            // 
            // NomePos
            // 
            this.NomePos.AutoSize = true;
            this.NomePos.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomePos.Location = new System.Drawing.Point(24, 56);
            this.NomePos.Name = "NomePos";
            this.NomePos.Size = new System.Drawing.Size(42, 22);
            this.NomePos.TabIndex = 83;
            this.NomePos.Text = "label4";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_descricao.Enabled = false;
            this.tb_descricao.Font = new System.Drawing.Font("Dubai", 8F);
            this.tb_descricao.Location = new System.Drawing.Point(327, 201);
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
            this.tb_localizacao.Font = new System.Drawing.Font("Dubai", 8F);
            this.tb_localizacao.Location = new System.Drawing.Point(327, 146);
            this.tb_localizacao.Name = "tb_localizacao";
            this.tb_localizacao.ReadOnly = true;
            this.tb_localizacao.Size = new System.Drawing.Size(259, 26);
            this.tb_localizacao.TabIndex = 77;
            // 
            // tb_problema
            // 
            this.tb_problema.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_problema.Enabled = false;
            this.tb_problema.Font = new System.Drawing.Font("Dubai", 8F);
            this.tb_problema.Location = new System.Drawing.Point(327, 92);
            this.tb_problema.Name = "tb_problema";
            this.tb_problema.ReadOnly = true;
            this.tb_problema.Size = new System.Drawing.Size(259, 26);
            this.tb_problema.TabIndex = 75;
            // 
            // pb_imagem
            // 
            this.pb_imagem.Location = new System.Drawing.Point(21, 79);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(263, 170);
            this.pb_imagem.TabIndex = 76;
            this.pb_imagem.TabStop = false;
            this.pb_imagem.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 248);
            this.panel1.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 79;
            this.label5.Text = "Tipo do Problema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 81;
            this.label3.Text = "Localização";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 80;
            this.label2.Text = "Descrição";
            // 
            // ViewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1249, 749);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPost";
            this.Text = "ViewPost";
            this.Load += new System.EventHandler(this.ViewPost_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox tb_resposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openIcone;
        private System.Windows.Forms.Panel panel6;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Button bt_postar;
    }
}