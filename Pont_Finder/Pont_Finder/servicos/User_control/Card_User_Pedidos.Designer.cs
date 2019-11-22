namespace Pont_Finder.servicos.User_control
{
    partial class Card_User_Pedidos
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
            this.lb_Emp_Email = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_bairro = new System.Windows.Forms.Label();
            this.lb_cep = new System.Windows.Forms.Label();
            this.lb_rua = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.pb_icone = new System.Windows.Forms.PictureBox();
            this.lb_Empr_fanta = new System.Windows.Forms.Label();
            this.pb_empre = new System.Windows.Forms.PictureBox();
            this.bt_obter = new System.Windows.Forms.Button();
            this.bt_cancelar_pedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empre)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Emp_Email
            // 
            this.lb_Emp_Email.AutoSize = true;
            this.lb_Emp_Email.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Emp_Email.Location = new System.Drawing.Point(797, 50);
            this.lb_Emp_Email.Name = "lb_Emp_Email";
            this.lb_Emp_Email.Size = new System.Drawing.Size(47, 17);
            this.lb_Emp_Email.TabIndex = 59;
            this.lb_Emp_Email.Text = "E-mail:";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero.Location = new System.Drawing.Point(252, 51);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(56, 17);
            this.lb_numero.TabIndex = 58;
            this.lb_numero.Text = "Número";
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bairro.Location = new System.Drawing.Point(252, 34);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(43, 17);
            this.lb_bairro.TabIndex = 57;
            this.lb_bairro.Text = "Bairro";
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cep.Location = new System.Drawing.Point(251, 68);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(30, 17);
            this.lb_cep.TabIndex = 56;
            this.lb_cep.Text = "CEP";
            // 
            // lb_rua
            // 
            this.lb_rua.AutoSize = true;
            this.lb_rua.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rua.Location = new System.Drawing.Point(251, 17);
            this.lb_rua.Name = "lb_rua";
            this.lb_rua.Size = new System.Drawing.Size(30, 17);
            this.lb_rua.TabIndex = 55;
            this.lb_rua.Text = "Rua";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.BackColor = System.Drawing.Color.Transparent;
            this.lb_data.Font = new System.Drawing.Font("Dubai", 8F);
            this.lb_data.Location = new System.Drawing.Point(12, 167);
            this.lb_data.Margin = new System.Windows.Forms.Padding(5);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(100, 18);
            this.lb_data.TabIndex = 54;
            this.lb_data.Text = "Agendado para para";
            this.lb_data.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_descricao
            // 
            this.lb_descricao.BackColor = System.Drawing.Color.Transparent;
            this.lb_descricao.Font = new System.Drawing.Font("Dubai", 9F);
            this.lb_descricao.Location = new System.Drawing.Point(250, 102);
            this.lb_descricao.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.lb_descricao.MaximumSize = new System.Drawing.Size(500, 65);
            this.lb_descricao.MinimumSize = new System.Drawing.Size(500, 65);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(500, 65);
            this.lb_descricao.TabIndex = 53;
            this.lb_descricao.Text = "Descricao:";
            // 
            // pb_icone
            // 
            this.pb_icone.Location = new System.Drawing.Point(15, 14);
            this.pb_icone.Margin = new System.Windows.Forms.Padding(15, 15, 5, 15);
            this.pb_icone.Name = "pb_icone";
            this.pb_icone.Size = new System.Drawing.Size(200, 150);
            this.pb_icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icone.TabIndex = 49;
            this.pb_icone.TabStop = false;
            // 
            // lb_Empr_fanta
            // 
            this.lb_Empr_fanta.AutoSize = true;
            this.lb_Empr_fanta.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Empr_fanta.Location = new System.Drawing.Point(800, 25);
            this.lb_Empr_fanta.Name = "lb_Empr_fanta";
            this.lb_Empr_fanta.Size = new System.Drawing.Size(33, 17);
            this.lb_Empr_fanta.TabIndex = 52;
            this.lb_Empr_fanta.Text = "user";
            // 
            // pb_empre
            // 
            this.pb_empre.Location = new System.Drawing.Point(743, 17);
            this.pb_empre.Margin = new System.Windows.Forms.Padding(15);
            this.pb_empre.Name = "pb_empre";
            this.pb_empre.Size = new System.Drawing.Size(50, 50);
            this.pb_empre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_empre.TabIndex = 51;
            this.pb_empre.TabStop = false;
            // 
            // bt_obter
            // 
            this.bt_obter.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_obter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_obter.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_obter.ForeColor = System.Drawing.Color.White;
            this.bt_obter.Location = new System.Drawing.Point(840, 94);
            this.bt_obter.Margin = new System.Windows.Forms.Padding(15);
            this.bt_obter.Name = "bt_obter";
            this.bt_obter.Size = new System.Drawing.Size(155, 32);
            this.bt_obter.TabIndex = 50;
            this.bt_obter.Text = "Visualizar";
            this.bt_obter.UseVisualStyleBackColor = false;
            // 
            // bt_cancelar_pedido
            // 
            this.bt_cancelar_pedido.BackColor = System.Drawing.Color.OrangeRed;
            this.bt_cancelar_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar_pedido.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar_pedido.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar_pedido.Location = new System.Drawing.Point(840, 132);
            this.bt_cancelar_pedido.Margin = new System.Windows.Forms.Padding(15);
            this.bt_cancelar_pedido.Name = "bt_cancelar_pedido";
            this.bt_cancelar_pedido.Size = new System.Drawing.Size(155, 32);
            this.bt_cancelar_pedido.TabIndex = 50;
            this.bt_cancelar_pedido.Text = "Cancelar Pedido";
            this.bt_cancelar_pedido.UseVisualStyleBackColor = false;
            // 
            // Card_User_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_Emp_Email);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.lb_bairro);
            this.Controls.Add(this.lb_cep);
            this.Controls.Add(this.lb_rua);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_descricao);
            this.Controls.Add(this.pb_icone);
            this.Controls.Add(this.lb_Empr_fanta);
            this.Controls.Add(this.pb_empre);
            this.Controls.Add(this.bt_cancelar_pedido);
            this.Controls.Add(this.bt_obter);
            this.Name = "Card_User_Pedidos";
            this.Size = new System.Drawing.Size(1010, 190);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_empre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Emp_Email;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.Label lb_cep;
        private System.Windows.Forms.Label lb_rua;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.PictureBox pb_icone;
        private System.Windows.Forms.Label lb_Empr_fanta;
        private System.Windows.Forms.PictureBox pb_empre;
        private System.Windows.Forms.Button bt_obter;
        private System.Windows.Forms.Button bt_cancelar_pedido;
    }
}
