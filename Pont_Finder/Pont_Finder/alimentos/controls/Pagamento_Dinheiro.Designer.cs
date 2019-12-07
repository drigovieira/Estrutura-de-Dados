namespace Pont_Finder.alimentos
{
    partial class Pagamento_Dinheiro
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
            this.cancelar = new System.Windows.Forms.Button();
            this.Solicitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(324, 38);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(135, 49);
            this.cancelar.TabIndex = 44;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            // 
            // Solicitar
            // 
            this.Solicitar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Solicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Solicitar.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solicitar.Location = new System.Drawing.Point(143, 38);
            this.Solicitar.Name = "Solicitar";
            this.Solicitar.Size = new System.Drawing.Size(135, 49);
            this.Solicitar.TabIndex = 43;
            this.Solicitar.Text = "Fazer Pedido";
            this.Solicitar.UseVisualStyleBackColor = false;
            this.Solicitar.Click += new System.EventHandler(this.Solicitar_Click);
            // 
            // Pagamento_Dinheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.Solicitar);
            this.Name = "Pagamento_Dinheiro";
            this.Size = new System.Drawing.Size(625, 129);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button Solicitar;
    }
}
