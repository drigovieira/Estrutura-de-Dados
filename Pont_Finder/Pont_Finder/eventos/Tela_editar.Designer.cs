namespace Pont_Finder.eventos
{
    partial class Tela_editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_editar));
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.pb_img_1 = new System.Windows.Forms.PictureBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtb_hora = new System.Windows.Forms.MaskedTextBox();
            this.tb_ingresso_total = new System.Windows.Forms.TextBox();
            this.tb_ingresso_disponivel = new System.Windows.Forms.TextBox();
            this.lb_ingresso_disponivel = new System.Windows.Forms.Label();
            this.lb_ingresso_total = new System.Windows.Forms.Label();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.Bdata = new System.Windows.Forms.MaskedTextBox();
            this.CBfaixaetaria = new System.Windows.Forms.ComboBox();
            this.Blocal = new System.Windows.Forms.TextBox();
            this.Bvalor = new System.Windows.Forms.TextBox();
            this.Bpatrocionadores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_tecnologia = new System.Windows.Forms.RadioButton();
            this.rb_esporte = new System.Windows.Forms.RadioButton();
            this.rb_gastronomia = new System.Windows.Forms.RadioButton();
            this.rb_cultural = new System.Windows.Forms.RadioButton();
            this.rb_workshop = new System.Windows.Forms.RadioButton();
            this.rb_musica = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(80, -240);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 43);
            this.btn_back.TabIndex = 65;
            this.btn_back.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(411, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 21);
            this.label11.TabIndex = 42;
            this.label11.Text = "Categoria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(268, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(414, 38);
            this.label7.TabIndex = 32;
            this.label7.Text = "Informe os dados do evento!";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(389, 312);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(136, 51);
            this.Button1.TabIndex = 31;
            this.Button1.Text = "Adicionar Foto";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Bt_imagem_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(240, 433);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(415, 22);
            this.tb_nome.TabIndex = 0;
            // 
            // pb_img_1
            // 
            this.pb_img_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_img_1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_img_1.InitialImage")));
            this.pb_img_1.Location = new System.Drawing.Point(228, 64);
            this.pb_img_1.Name = "pb_img_1";
            this.pb_img_1.Size = new System.Drawing.Size(450, 225);
            this.pb_img_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img_1.TabIndex = 30;
            this.pb_img_1.TabStop = false;
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.ForeColor = System.Drawing.Color.White;
            this.bt_cadastrar.Location = new System.Drawing.Point(391, 972);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(127, 49);
            this.bt_cadastrar.TabIndex = 6;
            this.bt_cadastrar.Text = "Alterar";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.Bt_cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o nome do evento: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.mtb_hora);
            this.panel2.Controls.Add(this.tb_ingresso_total);
            this.panel2.Controls.Add(this.tb_ingresso_disponivel);
            this.panel2.Controls.Add(this.lb_ingresso_disponivel);
            this.panel2.Controls.Add(this.lb_ingresso_total);
            this.panel2.Controls.Add(this.lb_descricao);
            this.panel2.Controls.Add(this.tb_descricao);
            this.panel2.Controls.Add(this.Bdata);
            this.panel2.Controls.Add(this.CBfaixaetaria);
            this.panel2.Controls.Add(this.Blocal);
            this.panel2.Controls.Add(this.Bvalor);
            this.panel2.Controls.Add(this.Bpatrocionadores);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Button1);
            this.panel2.Controls.Add(this.tb_nome);
            this.panel2.Controls.Add(this.pb_img_1);
            this.panel2.Controls.Add(this.bt_cadastrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(210, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 1054);
            this.panel2.TabIndex = 64;
            // 
            // mtb_hora
            // 
            this.mtb_hora.Location = new System.Drawing.Point(249, 918);
            this.mtb_hora.Mask = "00:00";
            this.mtb_hora.Name = "mtb_hora";
            this.mtb_hora.Size = new System.Drawing.Size(104, 20);
            this.mtb_hora.TabIndex = 62;
            this.mtb_hora.ValidatingType = typeof(System.DateTime);
            // 
            // tb_ingresso_total
            // 
            this.tb_ingresso_total.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ingresso_total.Location = new System.Drawing.Point(271, 797);
            this.tb_ingresso_total.Name = "tb_ingresso_total";
            this.tb_ingresso_total.Size = new System.Drawing.Size(100, 24);
            this.tb_ingresso_total.TabIndex = 45;
            // 
            // tb_ingresso_disponivel
            // 
            this.tb_ingresso_disponivel.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ingresso_disponivel.Location = new System.Drawing.Point(309, 834);
            this.tb_ingresso_disponivel.Name = "tb_ingresso_disponivel";
            this.tb_ingresso_disponivel.Size = new System.Drawing.Size(100, 24);
            this.tb_ingresso_disponivel.TabIndex = 46;
            // 
            // lb_ingresso_disponivel
            // 
            this.lb_ingresso_disponivel.AutoSize = true;
            this.lb_ingresso_disponivel.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ingresso_disponivel.Location = new System.Drawing.Point(174, 834);
            this.lb_ingresso_disponivel.Name = "lb_ingresso_disponivel";
            this.lb_ingresso_disponivel.Size = new System.Drawing.Size(136, 20);
            this.lb_ingresso_disponivel.TabIndex = 61;
            this.lb_ingresso_disponivel.Text = "Ingresso disponível";
            // 
            // lb_ingresso_total
            // 
            this.lb_ingresso_total.AutoSize = true;
            this.lb_ingresso_total.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ingresso_total.Location = new System.Drawing.Point(172, 795);
            this.lb_ingresso_total.Name = "lb_ingresso_total";
            this.lb_ingresso_total.Size = new System.Drawing.Size(99, 20);
            this.lb_ingresso_total.TabIndex = 60;
            this.lb_ingresso_total.Text = "Ingresso total";
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descricao.Location = new System.Drawing.Point(169, 753);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(74, 20);
            this.lb_descricao.TabIndex = 59;
            this.lb_descricao.Text = "Descrição";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descricao.Location = new System.Drawing.Point(275, 753);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(132, 24);
            this.tb_descricao.TabIndex = 44;
            // 
            // Bdata
            // 
            this.Bdata.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdata.Location = new System.Drawing.Point(222, 874);
            this.Bdata.Mask = "00/00/0000";
            this.Bdata.Name = "Bdata";
            this.Bdata.Size = new System.Drawing.Size(113, 24);
            this.Bdata.TabIndex = 47;
            this.Bdata.ValidatingType = typeof(System.DateTime);
            // 
            // CBfaixaetaria
            // 
            this.CBfaixaetaria.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBfaixaetaria.FormattingEnabled = true;
            this.CBfaixaetaria.Items.AddRange(new object[] {
            "L",
            "12 ",
            "16 ",
            "18+"});
            this.CBfaixaetaria.Location = new System.Drawing.Point(521, 829);
            this.CBfaixaetaria.Name = "CBfaixaetaria";
            this.CBfaixaetaria.Size = new System.Drawing.Size(121, 25);
            this.CBfaixaetaria.TabIndex = 50;
            // 
            // Blocal
            // 
            this.Blocal.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blocal.Location = new System.Drawing.Point(488, 745);
            this.Blocal.Multiline = true;
            this.Blocal.Name = "Blocal";
            this.Blocal.Size = new System.Drawing.Size(266, 25);
            this.Blocal.TabIndex = 48;
            // 
            // Bvalor
            // 
            this.Bvalor.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bvalor.Location = new System.Drawing.Point(484, 869);
            this.Bvalor.Name = "Bvalor";
            this.Bvalor.Size = new System.Drawing.Size(118, 24);
            this.Bvalor.TabIndex = 51;
            // 
            // Bpatrocionadores
            // 
            this.Bpatrocionadores.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpatrocionadores.Location = new System.Drawing.Point(543, 793);
            this.Bpatrocionadores.Name = "Bpatrocionadores";
            this.Bpatrocionadores.Size = new System.Drawing.Size(210, 24);
            this.Bpatrocionadores.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 793);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Patrocinadores";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(434, 868);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(434, 829);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Faixa etária";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(434, 751);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Local";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 915);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Horario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 873);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 698);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Novas informações";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rb_tecnologia);
            this.panel3.Controls.Add(this.rb_esporte);
            this.panel3.Controls.Add(this.rb_gastronomia);
            this.panel3.Controls.Add(this.rb_cultural);
            this.panel3.Controls.Add(this.rb_workshop);
            this.panel3.Controls.Add(this.rb_musica);
            this.panel3.Location = new System.Drawing.Point(215, 526);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 150);
            this.panel3.TabIndex = 43;
            // 
            // rb_tecnologia
            // 
            this.rb_tecnologia.AutoSize = true;
            this.rb_tecnologia.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tecnologia.Location = new System.Drawing.Point(359, 91);
            this.rb_tecnologia.Name = "rb_tecnologia";
            this.rb_tecnologia.Size = new System.Drawing.Size(101, 24);
            this.rb_tecnologia.TabIndex = 5;
            this.rb_tecnologia.TabStop = true;
            this.rb_tecnologia.Text = "Tecnologia";
            this.rb_tecnologia.UseVisualStyleBackColor = true;
            // 
            // rb_esporte
            // 
            this.rb_esporte.AutoSize = true;
            this.rb_esporte.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_esporte.Location = new System.Drawing.Point(214, 91);
            this.rb_esporte.Name = "rb_esporte";
            this.rb_esporte.Size = new System.Drawing.Size(77, 24);
            this.rb_esporte.TabIndex = 4;
            this.rb_esporte.TabStop = true;
            this.rb_esporte.Text = "Esporte";
            this.rb_esporte.UseVisualStyleBackColor = true;
            // 
            // rb_gastronomia
            // 
            this.rb_gastronomia.AutoSize = true;
            this.rb_gastronomia.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_gastronomia.Location = new System.Drawing.Point(26, 91);
            this.rb_gastronomia.Name = "rb_gastronomia";
            this.rb_gastronomia.Size = new System.Drawing.Size(112, 24);
            this.rb_gastronomia.TabIndex = 3;
            this.rb_gastronomia.TabStop = true;
            this.rb_gastronomia.Text = "Gastronomia";
            this.rb_gastronomia.UseVisualStyleBackColor = true;
            // 
            // rb_cultural
            // 
            this.rb_cultural.AutoSize = true;
            this.rb_cultural.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cultural.Location = new System.Drawing.Point(359, 21);
            this.rb_cultural.Name = "rb_cultural";
            this.rb_cultural.Size = new System.Drawing.Size(78, 24);
            this.rb_cultural.TabIndex = 2;
            this.rb_cultural.TabStop = true;
            this.rb_cultural.Text = "Cultural";
            this.rb_cultural.UseVisualStyleBackColor = true;
            // 
            // rb_workshop
            // 
            this.rb_workshop.AutoSize = true;
            this.rb_workshop.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_workshop.Location = new System.Drawing.Point(214, 21);
            this.rb_workshop.Name = "rb_workshop";
            this.rb_workshop.Size = new System.Drawing.Size(94, 24);
            this.rb_workshop.TabIndex = 1;
            this.rb_workshop.TabStop = true;
            this.rb_workshop.Text = "Workshop";
            this.rb_workshop.UseVisualStyleBackColor = true;
            // 
            // rb_musica
            // 
            this.rb_musica.AutoSize = true;
            this.rb_musica.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_musica.Location = new System.Drawing.Point(26, 21);
            this.rb_musica.Name = "rb_musica";
            this.rb_musica.Size = new System.Drawing.Size(73, 24);
            this.rb_musica.TabIndex = 0;
            this.rb_musica.TabStop = true;
            this.rb_musica.Text = "Música";
            this.rb_musica.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1078);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 100);
            this.panel1.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(76, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // openIcone
            // 
            this.openIcone.FileName = "openIcone";
            // 
            // Tela_editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "Tela_editar";
            this.Text = "Tela_editar";
            this.Load += new System.EventHandler(this.Tela_editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img_1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.PictureBox pb_img_1;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rb_tecnologia;
        private System.Windows.Forms.RadioButton rb_esporte;
        private System.Windows.Forms.RadioButton rb_gastronomia;
        private System.Windows.Forms.RadioButton rb_cultural;
        private System.Windows.Forms.RadioButton rb_workshop;
        private System.Windows.Forms.RadioButton rb_musica;
        private System.Windows.Forms.MaskedTextBox mtb_hora;
        private System.Windows.Forms.TextBox tb_ingresso_total;
        private System.Windows.Forms.TextBox tb_ingresso_disponivel;
        private System.Windows.Forms.Label lb_ingresso_disponivel;
        private System.Windows.Forms.Label lb_ingresso_total;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.MaskedTextBox Bdata;
        private System.Windows.Forms.ComboBox CBfaixaetaria;
        private System.Windows.Forms.TextBox Blocal;
        private System.Windows.Forms.TextBox Bvalor;
        private System.Windows.Forms.TextBox Bpatrocionadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openIcone;
    }
}