namespace Pont_Finder
{
    partial class formAlimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAlimentos));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CategoriaBox = new System.Windows.Forms.ComboBox();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.PesquisaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Top5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ListarEmpresas = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Filtrar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(325, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 61);
            this.panel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restaurantes:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.Filtrar);
            this.panel2.Controls.Add(this.CategoriaBox);
            this.panel2.Controls.Add(this.Pesquisar);
            this.panel2.Controls.Add(this.lbCategoria);
            this.panel2.Controls.Add(this.PesquisaBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 267);
            this.panel2.TabIndex = 13;
            // 
            // CategoriaBox
            // 
            this.CategoriaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriaBox.FormattingEnabled = true;
            this.CategoriaBox.Items.AddRange(new object[] {
            "Hambúrgueria",
            "Comida Italiana",
            "Comida Japonesa",
            "Pizzaria",
            "Sorveteria",
            "Petiscaria",
            "Churrascaria",
            "Frutos do Mar",
            "Convencional"});
            this.CategoriaBox.Location = new System.Drawing.Point(22, 163);
            this.CategoriaBox.Name = "CategoriaBox";
            this.CategoriaBox.Size = new System.Drawing.Size(172, 21);
            this.CategoriaBox.TabIndex = 11;
            this.CategoriaBox.Visible = false;
            this.CategoriaBox.SelectedValueChanged += new System.EventHandler(this.CategoriaBox_SelectedValueChanged);
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.Pesquisar.FlatAppearance.BorderSize = 0;
            this.Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Pesquisar.Location = new System.Drawing.Point(200, 84);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(103, 28);
            this.Pesquisar.TabIndex = 9;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.Location = new System.Drawing.Point(19, 133);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(76, 18);
            this.lbCategoria.TabIndex = 3;
            this.lbCategoria.Text = "Categoria:";
            this.lbCategoria.Visible = false;
            // 
            // PesquisaBox
            // 
            this.PesquisaBox.Location = new System.Drawing.Point(22, 90);
            this.PesquisaBox.Name = "PesquisaBox";
            this.PesquisaBox.Size = new System.Drawing.Size(172, 20);
            this.PesquisaBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // Top5
            // 
            this.Top5.BackColor = System.Drawing.Color.White;
            this.Top5.Location = new System.Drawing.Point(22, 75);
            this.Top5.Name = "Top5";
            this.Top5.Size = new System.Drawing.Size(270, 270);
            this.Top5.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Top 5 Restaurantes Melhor Avaliados";
            // 
            // ListarEmpresas
            // 
            this.ListarEmpresas.AutoSize = true;
            this.ListarEmpresas.BackColor = System.Drawing.Color.White;
            this.ListarEmpresas.Location = new System.Drawing.Point(325, 394);
            this.ListarEmpresas.Name = "ListarEmpresas";
            this.ListarEmpresas.Size = new System.Drawing.Size(625, 201);
            this.ListarEmpresas.TabIndex = 16;
            this.ListarEmpresas.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 720);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1265, 100);
            this.panel9.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.Top5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(955, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 392);
            this.panel4.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(477, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Confira o que temos para você!";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(1021, 247);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(212, 36);
            this.button8.TabIndex = 20;
            this.button8.Text = "Cadastrar Estabelecimento";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1265, 200);
            this.panel10.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 12;
            // 
            // Filtrar
            // 
            this.Filtrar.BackColor = System.Drawing.Color.Transparent;
            this.Filtrar.FlatAppearance.BorderSize = 0;
            this.Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Filtrar.Location = new System.Drawing.Point(202, 159);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(103, 27);
            this.Filtrar.TabIndex = 12;
            this.Filtrar.Text = "Filtrar por:";
            this.Filtrar.UseVisualStyleBackColor = false;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // formAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListarEmpresas);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "formAlimentos";
            this.Text = "formAlimentos";
            this.Load += new System.EventHandler(this.FormAlimentos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CategoriaBox;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox PesquisaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Top5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel ListarEmpresas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Filtrar;
    }
}