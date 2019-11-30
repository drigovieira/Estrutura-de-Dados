namespace Pont_Finder.alimentos
{
    partial class Item_Alimentos
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
            this.label3 = new System.Windows.Forms.Label();
            this.IngredienteComida = new System.Windows.Forms.Label();
            this.qtdComida = new System.Windows.Forms.Label();
            this.NomeComida = new System.Windows.Forms.Label();
            this.pb_alimento = new System.Windows.Forms.PictureBox();
            this.CategoriasPrato = new System.Windows.Forms.Label();
            this.lb_rs = new System.Windows.Forms.Label();
            this.bt_visualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alimento)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria:";
            // 
            // IngredienteComida
            // 
            this.IngredienteComida.AutoSize = true;
            this.IngredienteComida.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredienteComida.Location = new System.Drawing.Point(200, 47);
            this.IngredienteComida.Name = "IngredienteComida";
            this.IngredienteComida.Size = new System.Drawing.Size(91, 20);
            this.IngredienteComida.TabIndex = 3;
            this.IngredienteComida.Text = "Ingredientes";
            this.IngredienteComida.Click += new System.EventHandler(this.label4_Click);
            // 
            // qtdComida
            // 
            this.qtdComida.AutoSize = true;
            this.qtdComida.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdComida.Location = new System.Drawing.Point(200, 81);
            this.qtdComida.Name = "qtdComida";
            this.qtdComida.Size = new System.Drawing.Size(71, 20);
            this.qtdComida.TabIndex = 2;
            this.qtdComida.Text = "Tamanho";
            this.qtdComida.Click += new System.EventHandler(this.label2_Click);
            // 
            // NomeComida
            // 
            this.NomeComida.AutoSize = true;
            this.NomeComida.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeComida.Location = new System.Drawing.Point(199, 12);
            this.NomeComida.Name = "NomeComida";
            this.NomeComida.Size = new System.Drawing.Size(57, 21);
            this.NomeComida.TabIndex = 1;
            this.NomeComida.Text = "Nome";
            // 
            // pb_alimento
            // 
            this.pb_alimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_alimento.Location = new System.Drawing.Point(12, 12);
            this.pb_alimento.Name = "pb_alimento";
            this.pb_alimento.Size = new System.Drawing.Size(150, 130);
            this.pb_alimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_alimento.TabIndex = 4;
            this.pb_alimento.TabStop = false;
            // 
            // CategoriasPrato
            // 
            this.CategoriasPrato.AutoSize = true;
            this.CategoriasPrato.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriasPrato.Location = new System.Drawing.Point(101, 154);
            this.CategoriasPrato.Name = "CategoriasPrato";
            this.CategoriasPrato.Size = new System.Drawing.Size(46, 20);
            this.CategoriasPrato.TabIndex = 5;
            this.CategoriasPrato.Text = "Value";
            // 
            // lb_rs
            // 
            this.lb_rs.AutoSize = true;
            this.lb_rs.BackColor = System.Drawing.Color.Transparent;
            this.lb_rs.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.lb_rs.Location = new System.Drawing.Point(485, 60);
            this.lb_rs.Name = "lb_rs";
            this.lb_rs.Size = new System.Drawing.Size(59, 54);
            this.lb_rs.TabIndex = 33;
            this.lb_rs.Text = "R$";
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.bt_visualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_visualizar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_visualizar.ForeColor = System.Drawing.Color.White;
            this.bt_visualizar.Location = new System.Drawing.Point(494, 138);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(110, 34);
            this.bt_visualizar.TabIndex = 34;
            this.bt_visualizar.Text = "Reservar";
            this.bt_visualizar.UseVisualStyleBackColor = false;
            // 
            // Item_Alimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.bt_visualizar);
            this.Controls.Add(this.lb_rs);
            this.Controls.Add(this.CategoriasPrato);
            this.Controls.Add(this.pb_alimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomeComida);
            this.Controls.Add(this.IngredienteComida);
            this.Controls.Add(this.qtdComida);
            this.Name = "Item_Alimentos";
            this.Size = new System.Drawing.Size(625, 190);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Item_Alimentos_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb_alimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NomeComida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IngredienteComida;
        private System.Windows.Forms.Label qtdComida;
        private System.Windows.Forms.PictureBox pb_alimento;
        private System.Windows.Forms.Label CategoriasPrato;
        private System.Windows.Forms.Label lb_rs;
        private System.Windows.Forms.Button bt_visualizar;
    }
}
