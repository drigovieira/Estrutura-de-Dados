namespace Pont_Finder.hospedagem
{
    partial class PostCard
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
            this.pictureB_card = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_card)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureB_card
            // 
            this.pictureB_card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureB_card.Location = new System.Drawing.Point(15, 15);
            this.pictureB_card.Name = "pictureB_card";
            this.pictureB_card.Size = new System.Drawing.Size(150, 130);
            this.pictureB_card.TabIndex = 1;
            this.pictureB_card.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(500, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "Visualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(525, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 54);
            this.label9.TabIndex = 32;
            this.label9.Text = "R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(498, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = "Descrição - Dia/Casal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Endereço";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.Location = new System.Drawing.Point(178, 10);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(52, 27);
            this.label_nome.TabIndex = 29;
            this.label_nome.Text = "Name";
            // 
            // PostCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureB_card);
            this.Name = "PostCard";
            this.Size = new System.Drawing.Size(625, 160);
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureB_card;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_nome;
    }
}
