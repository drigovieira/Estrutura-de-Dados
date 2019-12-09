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
            this.bt_addLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Excluir = new System.Windows.Forms.Button();
            this.Quant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pb_alimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quant)).BeginInit();
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
            this.qtdComida.Location = new System.Drawing.Point(200, 122);
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
            this.lb_rs.Location = new System.Drawing.Point(485, 81);
            this.lb_rs.Name = "lb_rs";
            this.lb_rs.Size = new System.Drawing.Size(59, 54);
            this.lb_rs.TabIndex = 33;
            this.lb_rs.Text = "R$";
            // 
            // bt_addLista
            // 
            this.bt_addLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.bt_addLista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_addLista.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_addLista.ForeColor = System.Drawing.Color.White;
            this.bt_addLista.Location = new System.Drawing.Point(494, 138);
            this.bt_addLista.Name = "bt_addLista";
            this.bt_addLista.Size = new System.Drawing.Size(110, 34);
            this.bt_addLista.TabIndex = 34;
            this.bt_addLista.Text = "Pedir";
            this.bt_addLista.UseVisualStyleBackColor = false;
            this.bt_addLista.Click += new System.EventHandler(this.Bt_addLista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Quantidade";
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.Red;
            this.Excluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Excluir.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.Color.White;
            this.Excluir.Location = new System.Drawing.Point(494, 138);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(110, 34);
            this.Excluir.TabIndex = 37;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Quant
            // 
            this.Quant.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quant.Location = new System.Drawing.Point(293, 149);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(46, 28);
            this.Quant.TabIndex = 38;
            this.Quant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quant.ValueChanged += new System.EventHandler(this.Quant_ValueChanged);
            // 
            // Item_Alimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_rs);
            this.Controls.Add(this.CategoriasPrato);
            this.Controls.Add(this.pb_alimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomeComida);
            this.Controls.Add(this.IngredienteComida);
            this.Controls.Add(this.qtdComida);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.bt_addLista);
            this.Name = "Item_Alimentos";
            this.Size = new System.Drawing.Size(623, 188);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Item_Alimentos_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb_alimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quant)).EndInit();
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
        private System.Windows.Forms.Button bt_addLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.NumericUpDown Quant;
    }
}
