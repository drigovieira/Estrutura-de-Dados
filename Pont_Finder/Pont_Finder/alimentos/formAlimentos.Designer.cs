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
            this.panel2 = new System.Windows.Forms.Panel();
            this.remFiltro = new System.Windows.Forms.Button();
            this.pb_pesquisar = new System.Windows.Forms.PictureBox();
            this.PesquisaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Top5 = new System.Windows.Forms.Panel();
            this.lbTop5 = new System.Windows.Forms.Label();
            this.ListarEmpresas = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Edit_Empresa = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rbOutros = new System.Windows.Forms.RadioButton();
            this.rbFrutosDoMar = new System.Windows.Forms.RadioButton();
            this.rbHambúrgueria = new System.Windows.Forms.RadioButton();
            this.rbSorveteria = new System.Windows.Forms.RadioButton();
            this.rbComidaJaponesa = new System.Windows.Forms.RadioButton();
            this.rbComidaItaliana = new System.Windows.Forms.RadioButton();
            this.rbPetiscaria = new System.Windows.Forms.RadioButton();
            this.rbPizzaria = new System.Windows.Forms.RadioButton();
            this.rbChurrascaria = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_pag = new System.Windows.Forms.Label();
            this.bt_proxFull = new System.Windows.Forms.Button();
            this.bt_antFull = new System.Windows.Forms.Button();
            this.bt_prox = new System.Windows.Forms.Button();
            this.bt_ant = new System.Windows.Forms.Button();
            this.btn_Config = new System.Windows.Forms.PictureBox();
            this.lbConfig1 = new System.Windows.Forms.Label();
            this.lbConfig2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Config)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.remFiltro);
            this.panel2.Controls.Add(this.pb_pesquisar);
            this.panel2.Controls.Add(this.PesquisaBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(5, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 172);
            this.panel2.TabIndex = 13;
            // 
            // remFiltro
            // 
            this.remFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.remFiltro.FlatAppearance.BorderSize = 0;
            this.remFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remFiltro.ForeColor = System.Drawing.Color.White;
            this.remFiltro.Location = new System.Drawing.Point(200, 109);
            this.remFiltro.Name = "remFiltro";
            this.remFiltro.Size = new System.Drawing.Size(103, 37);
            this.remFiltro.TabIndex = 45;
            this.remFiltro.Text = "Sem Filtro";
            this.remFiltro.UseVisualStyleBackColor = false;
            this.remFiltro.Visible = false;
            this.remFiltro.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pb_pesquisar
            // 
            this.pb_pesquisar.BackColor = System.Drawing.Color.White;
            this.pb_pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_pesquisar.BackgroundImage")));
            this.pb_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pesquisar.Location = new System.Drawing.Point(244, 58);
            this.pb_pesquisar.Name = "pb_pesquisar";
            this.pb_pesquisar.Size = new System.Drawing.Size(30, 30);
            this.pb_pesquisar.TabIndex = 44;
            this.pb_pesquisar.TabStop = false;
            this.pb_pesquisar.Click += new System.EventHandler(this.pb_pesquisar_Click);
            // 
            // PesquisaBox
            // 
            this.PesquisaBox.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisaBox.Location = new System.Drawing.Point(22, 56);
            this.PesquisaBox.Name = "PesquisaBox";
            this.PesquisaBox.Size = new System.Drawing.Size(254, 35);
            this.PesquisaBox.TabIndex = 2;
            this.PesquisaBox.TextChanged += new System.EventHandler(this.PesquisaBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome do Restaurante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // Top5
            // 
            this.Top5.BackColor = System.Drawing.Color.PapayaWhip;
            this.Top5.Location = new System.Drawing.Point(950, 318);
            this.Top5.Name = "Top5";
            this.Top5.Size = new System.Drawing.Size(310, 392);
            this.Top5.TabIndex = 6;
            this.Top5.Paint += new System.Windows.Forms.PaintEventHandler(this.Top5_Paint);
            // 
            // lbTop5
            // 
            this.lbTop5.AutoSize = true;
            this.lbTop5.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTop5.Location = new System.Drawing.Point(1015, 279);
            this.lbTop5.Name = "lbTop5";
            this.lbTop5.Size = new System.Drawing.Size(206, 27);
            this.lbTop5.TabIndex = 5;
            this.lbTop5.Text = "Top 5 Restaurantes ";
            // 
            // ListarEmpresas
            // 
            this.ListarEmpresas.AutoSize = true;
            this.ListarEmpresas.BackColor = System.Drawing.Color.White;
            this.ListarEmpresas.Location = new System.Drawing.Point(320, 360);
            this.ListarEmpresas.Name = "ListarEmpresas";
            this.ListarEmpresas.Size = new System.Drawing.Size(627, 205);
            this.ListarEmpresas.TabIndex = 16;
            this.ListarEmpresas.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 1208);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1265, 100);
            this.panel9.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(476, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(416, 36);
            this.label8.TabIndex = 19;
            this.label8.Text = "Confira o que temos para você!";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.Controls.Add(this.label6);
            this.panel10.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1265, 200);
            this.panel10.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(265, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(789, 46);
            this.label6.TabIndex = 1;
            this.label6.Text = "Encontre o Restaurante ideal para o seu gosto!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-1, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 12;
            // 
            // Btn_Edit_Empresa
            // 
            this.Btn_Edit_Empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.Btn_Edit_Empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit_Empresa.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit_Empresa.ForeColor = System.Drawing.Color.White;
            this.Btn_Edit_Empresa.Location = new System.Drawing.Point(18, 215);
            this.Btn_Edit_Empresa.Name = "Btn_Edit_Empresa";
            this.Btn_Edit_Empresa.Size = new System.Drawing.Size(196, 35);
            this.Btn_Edit_Empresa.TabIndex = 43;
            this.Btn_Edit_Empresa.Text = "Cadastrar Empresa";
            this.Btn_Edit_Empresa.UseVisualStyleBackColor = false;
            this.Btn_Edit_Empresa.Click += new System.EventHandler(this.Btn_Edit_Empresa_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(950, 883);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(310, 325);
            this.panel8.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(84, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 21);
            this.label15.TabIndex = 1;
            this.label15.Text = "Propaganda modulos";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(950, 716);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 160);
            this.panel5.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Propaganda Externa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(116, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 27);
            this.label10.TabIndex = 46;
            this.label10.Text = "Filtros";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.rbOutros);
            this.panel11.Controls.Add(this.rbFrutosDoMar);
            this.panel11.Controls.Add(this.rbHambúrgueria);
            this.panel11.Controls.Add(this.rbSorveteria);
            this.panel11.Controls.Add(this.rbComidaJaponesa);
            this.panel11.Controls.Add(this.rbComidaItaliana);
            this.panel11.Controls.Add(this.rbPetiscaria);
            this.panel11.Controls.Add(this.rbPizzaria);
            this.panel11.Controls.Add(this.rbChurrascaria);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(5, 558);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(310, 324);
            this.panel11.TabIndex = 47;
            // 
            // rbOutros
            // 
            this.rbOutros.AutoSize = true;
            this.rbOutros.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOutros.Location = new System.Drawing.Point(81, 288);
            this.rbOutros.Name = "rbOutros";
            this.rbOutros.Size = new System.Drawing.Size(76, 25);
            this.rbOutros.TabIndex = 15;
            this.rbOutros.TabStop = true;
            this.rbOutros.Text = "Outros";
            this.rbOutros.UseVisualStyleBackColor = true;
            this.rbOutros.CheckedChanged += new System.EventHandler(this.RbOutros_CheckedChanged);
            // 
            // rbFrutosDoMar
            // 
            this.rbFrutosDoMar.AutoSize = true;
            this.rbFrutosDoMar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFrutosDoMar.Location = new System.Drawing.Point(81, 257);
            this.rbFrutosDoMar.Name = "rbFrutosDoMar";
            this.rbFrutosDoMar.Size = new System.Drawing.Size(126, 25);
            this.rbFrutosDoMar.TabIndex = 14;
            this.rbFrutosDoMar.TabStop = true;
            this.rbFrutosDoMar.Text = "Frutos do Mar";
            this.rbFrutosDoMar.UseVisualStyleBackColor = true;
            this.rbFrutosDoMar.CheckedChanged += new System.EventHandler(this.RbFrutosDoMar_CheckedChanged);
            // 
            // rbHambúrgueria
            // 
            this.rbHambúrgueria.AutoSize = true;
            this.rbHambúrgueria.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHambúrgueria.Location = new System.Drawing.Point(81, 225);
            this.rbHambúrgueria.Name = "rbHambúrgueria";
            this.rbHambúrgueria.Size = new System.Drawing.Size(129, 25);
            this.rbHambúrgueria.TabIndex = 13;
            this.rbHambúrgueria.TabStop = true;
            this.rbHambúrgueria.Text = "Hambúrgueria";
            this.rbHambúrgueria.UseVisualStyleBackColor = true;
            this.rbHambúrgueria.CheckedChanged += new System.EventHandler(this.RbHambúrgueria_CheckedChanged);
            // 
            // rbSorveteria
            // 
            this.rbSorveteria.AutoSize = true;
            this.rbSorveteria.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSorveteria.Location = new System.Drawing.Point(81, 193);
            this.rbSorveteria.Name = "rbSorveteria";
            this.rbSorveteria.Size = new System.Drawing.Size(99, 25);
            this.rbSorveteria.TabIndex = 12;
            this.rbSorveteria.TabStop = true;
            this.rbSorveteria.Text = "Sorveteria";
            this.rbSorveteria.UseVisualStyleBackColor = true;
            this.rbSorveteria.CheckedChanged += new System.EventHandler(this.RbSorveteria_CheckedChanged);
            // 
            // rbComidaJaponesa
            // 
            this.rbComidaJaponesa.AutoSize = true;
            this.rbComidaJaponesa.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComidaJaponesa.Location = new System.Drawing.Point(81, 161);
            this.rbComidaJaponesa.Name = "rbComidaJaponesa";
            this.rbComidaJaponesa.Size = new System.Drawing.Size(150, 25);
            this.rbComidaJaponesa.TabIndex = 11;
            this.rbComidaJaponesa.TabStop = true;
            this.rbComidaJaponesa.Text = "Comida Japonesa";
            this.rbComidaJaponesa.UseVisualStyleBackColor = true;
            this.rbComidaJaponesa.CheckedChanged += new System.EventHandler(this.RbComidaJaponesa_CheckedChanged);
            // 
            // rbComidaItaliana
            // 
            this.rbComidaItaliana.AutoSize = true;
            this.rbComidaItaliana.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComidaItaliana.Location = new System.Drawing.Point(81, 129);
            this.rbComidaItaliana.Name = "rbComidaItaliana";
            this.rbComidaItaliana.Size = new System.Drawing.Size(136, 25);
            this.rbComidaItaliana.TabIndex = 10;
            this.rbComidaItaliana.TabStop = true;
            this.rbComidaItaliana.Text = "Comida Italiana";
            this.rbComidaItaliana.UseVisualStyleBackColor = true;
            this.rbComidaItaliana.CheckedChanged += new System.EventHandler(this.RbComidaItaliana_CheckedChanged);
            // 
            // rbPetiscaria
            // 
            this.rbPetiscaria.AutoSize = true;
            this.rbPetiscaria.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPetiscaria.Location = new System.Drawing.Point(81, 97);
            this.rbPetiscaria.Name = "rbPetiscaria";
            this.rbPetiscaria.Size = new System.Drawing.Size(94, 25);
            this.rbPetiscaria.TabIndex = 9;
            this.rbPetiscaria.TabStop = true;
            this.rbPetiscaria.Text = "Petiscaria";
            this.rbPetiscaria.UseVisualStyleBackColor = true;
            this.rbPetiscaria.CheckedChanged += new System.EventHandler(this.RbPetiscaria_CheckedChanged);
            // 
            // rbPizzaria
            // 
            this.rbPizzaria.AutoSize = true;
            this.rbPizzaria.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPizzaria.Location = new System.Drawing.Point(81, 65);
            this.rbPizzaria.Name = "rbPizzaria";
            this.rbPizzaria.Size = new System.Drawing.Size(81, 25);
            this.rbPizzaria.TabIndex = 8;
            this.rbPizzaria.TabStop = true;
            this.rbPizzaria.Text = "Pizzaria";
            this.rbPizzaria.UseVisualStyleBackColor = true;
            this.rbPizzaria.CheckedChanged += new System.EventHandler(this.RbPizzaria_CheckedChanged);
            // 
            // rbChurrascaria
            // 
            this.rbChurrascaria.AutoSize = true;
            this.rbChurrascaria.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChurrascaria.Location = new System.Drawing.Point(81, 33);
            this.rbChurrascaria.Name = "rbChurrascaria";
            this.rbChurrascaria.Size = new System.Drawing.Size(116, 25);
            this.rbChurrascaria.TabIndex = 7;
            this.rbChurrascaria.TabStop = true;
            this.rbChurrascaria.Text = "Churrascaria";
            this.rbChurrascaria.UseVisualStyleBackColor = true;
            this.rbChurrascaria.CheckedChanged += new System.EventHandler(this.RbChurrascaria_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "Categorias:";
            // 
            // lb_pag
            // 
            this.lb_pag.AutoSize = true;
            this.lb_pag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_pag.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pag.ForeColor = System.Drawing.Color.Black;
            this.lb_pag.Location = new System.Drawing.Point(433, 318);
            this.lb_pag.MaximumSize = new System.Drawing.Size(400, 33);
            this.lb_pag.MinimumSize = new System.Drawing.Size(400, 33);
            this.lb_pag.Name = "lb_pag";
            this.lb_pag.Size = new System.Drawing.Size(400, 33);
            this.lb_pag.TabIndex = 51;
            this.lb_pag.Text = "lb_pag";
            this.lb_pag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_proxFull
            // 
            this.bt_proxFull.BackColor = System.Drawing.Color.Transparent;
            this.bt_proxFull.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_proxFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_proxFull.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proxFull.ForeColor = System.Drawing.Color.Black;
            this.bt_proxFull.Location = new System.Drawing.Point(839, 318);
            this.bt_proxFull.Name = "bt_proxFull";
            this.bt_proxFull.Size = new System.Drawing.Size(50, 33);
            this.bt_proxFull.TabIndex = 53;
            this.bt_proxFull.Text = "↠";
            this.bt_proxFull.UseVisualStyleBackColor = false;
            this.bt_proxFull.Click += new System.EventHandler(this.Bt_proxFull_Click);
            // 
            // bt_antFull
            // 
            this.bt_antFull.BackColor = System.Drawing.Color.Transparent;
            this.bt_antFull.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_antFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_antFull.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_antFull.ForeColor = System.Drawing.Color.Black;
            this.bt_antFull.Location = new System.Drawing.Point(377, 318);
            this.bt_antFull.Name = "bt_antFull";
            this.bt_antFull.Size = new System.Drawing.Size(50, 33);
            this.bt_antFull.TabIndex = 52;
            this.bt_antFull.Text = "↞";
            this.bt_antFull.UseVisualStyleBackColor = false;
            this.bt_antFull.Click += new System.EventHandler(this.Bt_antFull_Click);
            // 
            // bt_prox
            // 
            this.bt_prox.BackColor = System.Drawing.Color.Transparent;
            this.bt_prox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prox.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prox.ForeColor = System.Drawing.Color.Black;
            this.bt_prox.Location = new System.Drawing.Point(895, 318);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(50, 33);
            this.bt_prox.TabIndex = 50;
            this.bt_prox.Text = "→";
            this.bt_prox.UseVisualStyleBackColor = false;
            this.bt_prox.Click += new System.EventHandler(this.Bt_prox_Click);
            // 
            // bt_ant
            // 
            this.bt_ant.BackColor = System.Drawing.Color.Transparent;
            this.bt_ant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ant.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ant.ForeColor = System.Drawing.Color.Black;
            this.bt_ant.Location = new System.Drawing.Point(321, 318);
            this.bt_ant.Name = "bt_ant";
            this.bt_ant.Size = new System.Drawing.Size(50, 33);
            this.bt_ant.TabIndex = 49;
            this.bt_ant.Text = "←";
            this.bt_ant.UseVisualStyleBackColor = false;
            this.bt_ant.Click += new System.EventHandler(this.Bt_ant_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.BackColor = System.Drawing.Color.White;
            this.btn_Config.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Config.BackgroundImage")));
            this.btn_Config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Config.Location = new System.Drawing.Point(1181, 215);
            this.btn_Config.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(40, 35);
            this.btn_Config.TabIndex = 69;
            this.btn_Config.TabStop = false;
            this.btn_Config.Visible = false;
            this.btn_Config.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // lbConfig1
            // 
            this.lbConfig1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.lbConfig1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbConfig1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.lbConfig1.ForeColor = System.Drawing.Color.White;
            this.lbConfig1.Location = new System.Drawing.Point(995, 215);
            this.lbConfig1.Name = "lbConfig1";
            this.lbConfig1.Size = new System.Drawing.Size(184, 25);
            this.lbConfig1.TabIndex = 70;
            this.lbConfig1.Text = "Gerenciar Empresa";
            this.lbConfig1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbConfig1.Visible = false;
            this.lbConfig1.Click += new System.EventHandler(this.LbConfig1_Click);
            this.lbConfig1.MouseLeave += new System.EventHandler(this.LbConfig1_MouseLeave);
            this.lbConfig1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LbConfig1_MouseMove);
            // 
            // lbConfig2
            // 
            this.lbConfig2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.lbConfig2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbConfig2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.lbConfig2.ForeColor = System.Drawing.Color.White;
            this.lbConfig2.Location = new System.Drawing.Point(995, 240);
            this.lbConfig2.Name = "lbConfig2";
            this.lbConfig2.Size = new System.Drawing.Size(184, 25);
            this.lbConfig2.TabIndex = 71;
            this.lbConfig2.Text = "Gerenciar Cardápio";
            this.lbConfig2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbConfig2.Visible = false;
            this.lbConfig2.Click += new System.EventHandler(this.LbConfig2_Click);
            this.lbConfig2.MouseLeave += new System.EventHandler(this.LbConfig2_MouseLeave);
            this.lbConfig2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LbConfig2_MouseMove);
            // 
            // formAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.lbConfig2);
            this.Controls.Add(this.lbConfig1);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.lb_pag);
            this.Controls.Add(this.bt_proxFull);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.bt_antFull);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_prox);
            this.Controls.Add(this.Top5);
            this.Controls.Add(this.bt_ant);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.lbTop5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Btn_Edit_Empresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListarEmpresas);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "formAlimentos";
            this.Text = "formAlimentos";
            this.Load += new System.EventHandler(this.FormAlimentos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Config)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PesquisaBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Top5;
        private System.Windows.Forms.Label lbTop5;
        private System.Windows.Forms.Panel ListarEmpresas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Edit_Empresa;
        private System.Windows.Forms.PictureBox pb_pesquisar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton rbPizzaria;
        private System.Windows.Forms.RadioButton rbChurrascaria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbSorveteria;
        private System.Windows.Forms.RadioButton rbComidaJaponesa;
        private System.Windows.Forms.RadioButton rbComidaItaliana;
        private System.Windows.Forms.RadioButton rbPetiscaria;
        private System.Windows.Forms.RadioButton rbFrutosDoMar;
        private System.Windows.Forms.RadioButton rbHambúrgueria;
        private System.Windows.Forms.RadioButton rbOutros;
        private System.Windows.Forms.Button remFiltro;
        private System.Windows.Forms.Label lb_pag;
        private System.Windows.Forms.Button bt_proxFull;
        private System.Windows.Forms.Button bt_antFull;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Button bt_ant;
        private System.Windows.Forms.PictureBox btn_Config;
        private System.Windows.Forms.Label lbConfig1;
        private System.Windows.Forms.Label lbConfig2;
    }
}