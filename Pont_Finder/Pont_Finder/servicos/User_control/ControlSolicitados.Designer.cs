namespace Pont_Finder.servicos.User_control
{
    partial class ControlSolicitados
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
            this.button3 = new System.Windows.Forms.Button();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.bt_obter = new System.Windows.Forms.Button();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_empresa = new System.Windows.Forms.Label();
            this.pb_user = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(675, 135);
            this.button3.Margin = new System.Windows.Forms.Padding(20, 9, 20, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 35);
            this.button3.TabIndex = 43;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // pb_icone
            // 
            this.pb_icone.Location = new System.Drawing.Point(20, 8);
            this.pb_icone.Margin = new System.Windows.Forms.Padding(20, 9, 20, 9);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(230, 170);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 34;
            this.pb_icone.TabStop = false;
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.BackColor = System.Drawing.Color.Transparent;
            this.lb_data.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(274, 56);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(123, 21);
            this.lb_data.TabIndex = 42;
            this.lb_data.Text = "Agendado Para: ";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(274, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(137, 21);
            this.lb_titulo.TabIndex = 35;
            this.lb_titulo.Text = "Nome do Serviço: ";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(172)))), ((int)(((byte)(20)))));
            this.lb_valor.Location = new System.Drawing.Point(273, 152);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(110, 27);
            this.lb_valor.TabIndex = 37;
            this.lb_valor.Text = "R$ 000,00";
            // 
            // bt_obter
            // 
            this.bt_obter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            this.bt_obter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_obter.ForeColor = System.Drawing.Color.White;
            this.bt_obter.Location = new System.Drawing.Point(675, 82);
            this.bt_obter.Margin = new System.Windows.Forms.Padding(20, 9, 20, 9);
            this.bt_obter.Name = "bt_obter";
            this.bt_obter.Size = new System.Drawing.Size(130, 35);
            this.bt_obter.TabIndex = 38;
            this.bt_obter.Text = "Visualizar";
            this.bt_obter.UseVisualStyleBackColor = false;
            this.bt_obter.Click += new System.EventHandler(this.Bt_obter_Click_1);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.BackColor = System.Drawing.Color.Transparent;
            this.lb_status.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(274, 106);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(60, 21);
            this.lb_status.TabIndex = 46;
            this.lb_status.Text = "Status: ";
            // 
            // lb_empresa
            // 
            this.lb_empresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_empresa.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_empresa.Location = new System.Drawing.Point(629, 27);
            this.lb_empresa.Name = "lb_empresa";
            this.lb_empresa.Size = new System.Drawing.Size(121, 16);
            this.lb_empresa.TabIndex = 48;
            this.lb_empresa.Text = "empresa";
            this.lb_empresa.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pb_user
            // 
            this.pb_user.Location = new System.Drawing.Point(755, 9);
            this.pb_user.Margin = new System.Windows.Forms.Padding(15);
            this.pb_user.Name = "pb_user";
            this.pb_user.Size = new System.Drawing.Size(50, 50);
            this.pb_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_user.TabIndex = 47;
            this.pb_user.TabStop = false;
            // 
            // ControlSolicitados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_empresa);
            this.Controls.Add(this.pb_user);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pb_icone);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.bt_obter);
            this.Name = "ControlSolicitados";
            this.Size = new System.Drawing.Size(825, 188);
            this.Load += new System.EventHandler(this.ControlSolicitados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Button bt_obter;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_empresa;
        private System.Windows.Forms.PictureBox pb_user;
    }
}
