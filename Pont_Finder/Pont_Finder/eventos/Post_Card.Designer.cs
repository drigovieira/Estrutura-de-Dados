namespace Pont_Finder.eventos
{
    partial class Post_Card
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
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_ingresso = new System.Windows.Forms.Label();
            this.lb_ingressos = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_visualizar.ForeColor = System.Drawing.Color.White;
            this.bt_visualizar.Location = new System.Drawing.Point(504, 103);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(85, 35);
            this.bt_visualizar.TabIndex = 13;
            this.bt_visualizar.Text = "Visualizar";
            this.bt_visualizar.UseVisualStyleBackColor = false;
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoria.Location = new System.Drawing.Point(190, 97);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(125, 18);
            this.lb_categoria.TabIndex = 12;
            this.lb_categoria.Text = "Categoria: Festas";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(194)))), ((int)(((byte)(72)))));
            this.lb_valor.Location = new System.Drawing.Point(498, 55);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(83, 24);
            this.lb_valor.TabIndex = 11;
            this.lb_valor.Text = "R$ 20,00";
            // 
            // lb_ingresso
            // 
            this.lb_ingresso.AutoSize = true;
            this.lb_ingresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ingresso.Location = new System.Drawing.Point(498, 23);
            this.lb_ingresso.Name = "lb_ingresso";
            this.lb_ingresso.Size = new System.Drawing.Size(80, 24);
            this.lb_ingresso.TabIndex = 10;
            this.lb_ingresso.Text = "Entrada:";
            // 
            // lb_ingressos
            // 
            this.lb_ingressos.AutoSize = true;
            this.lb_ingressos.BackColor = System.Drawing.Color.Transparent;
            this.lb_ingressos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ingressos.ForeColor = System.Drawing.Color.Blue;
            this.lb_ingressos.Location = new System.Drawing.Point(191, 55);
            this.lb_ingressos.Name = "lb_ingressos";
            this.lb_ingressos.Size = new System.Drawing.Size(160, 20);
            this.lb_ingressos.TabIndex = 9;
            this.lb_ingressos.Text = "Ingressos disponíveis";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(188, 19);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(312, 25);
            this.lb_nome.TabIndex = 8;
            this.lb_nome.Text = "Comemoração de fim de ano";
            // 
            // pb_imagem
            // 
            this.pb_imagem.Location = new System.Drawing.Point(22, 13);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(165, 125);
            this.pb_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagem.TabIndex = 7;
            this.pb_imagem.TabStop = false;
            // 
            // Post_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_visualizar);
            this.Controls.Add(this.lb_categoria);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.lb_ingresso);
            this.Controls.Add(this.lb_ingressos);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.pb_imagem);
            this.Name = "Post_Card";
            this.Size = new System.Drawing.Size(610, 150);
            this.Load += new System.EventHandler(this.Post_Card_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_visualizar;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_ingresso;
        private System.Windows.Forms.Label lb_ingressos;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.PictureBox pb_imagem;
    }
}
