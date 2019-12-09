namespace Pont_Finder.servicos.User_control
{
    partial class ControlTops
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
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_servico = new System.Windows.Forms.Label();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_icone
            // 
            this.pb_icone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_icone.Location = new System.Drawing.Point(4, 3);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(60, 60);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 0;
            this.pb_icone.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do serviço";
            // 
            // lb_servico
            // 
            this.lb_servico.AutoSize = true;
            this.lb_servico.Location = new System.Drawing.Point(73, 20);
            this.lb_servico.Name = "lb_servico";
            this.lb_servico.Size = new System.Drawing.Size(33, 13);
            this.lb_servico.TabIndex = 2;
            this.lb_servico.Text = "value";
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Location = new System.Drawing.Point(73, 52);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(33, 13);
            this.lb_categoria.TabIndex = 4;
            this.lb_categoria.Text = "value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoria";
            // 
            // ControlTops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_servico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_icone);
            this.Name = "ControlTops";
            this.Size = new System.Drawing.Size(298, 68);
            this.Load += new System.EventHandler(this.ControlTops_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ControlTops_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_servico;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.Label label3;
    }
}
