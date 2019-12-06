namespace Pont_Finder.alimentos.controls
{
    partial class itemPedido
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
            this.Item = new System.Windows.Forms.Label();
            this.Remover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.Location = new System.Drawing.Point(13, 15);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(57, 21);
            this.Item.TabIndex = 2;
            this.Item.Text = "Nome";
            // 
            // Remover
            // 
            this.Remover.BackColor = System.Drawing.Color.Red;
            this.Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remover.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remover.ForeColor = System.Drawing.Color.White;
            this.Remover.Location = new System.Drawing.Point(173, 10);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(94, 30);
            this.Remover.TabIndex = 4;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = false;
            // 
            // itemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.Item);
            this.Name = "itemPedido";
            this.Size = new System.Drawing.Size(270, 50);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemPedido_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.Button Remover;
    }
}
