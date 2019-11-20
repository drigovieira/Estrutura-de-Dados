namespace Pont_Finder.hospedagem
{
    partial class Editar_Empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Empresa));
            this.radio_hotel = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.ckb_lugarPet = new System.Windows.Forms.CheckBox();
            this.ckb_academia = new System.Windows.Forms.CheckBox();
            this.ckb_salaJogos = new System.Windows.Forms.CheckBox();
            this.ckb_piscina = new System.Windows.Forms.CheckBox();
            this.ckb_estacionamento = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pn_galery = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_tipoHosp = new System.Windows.Forms.Panel();
            this.radio_pousada = new System.Windows.Forms.RadioButton();
            this.ckb_wifi = new System.Windows.Forms.CheckBox();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_add_img = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mkb_phone = new System.Windows.Forms.MaskedTextBox();
            this.mkb_cep = new System.Windows.Forms.MaskedTextBox();
            this.mkb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nameFantasy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_nameEmp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_descricaoHotel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnl_ambDisp = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_img1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_tipoHosp.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_ambDisp.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img1)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_hotel
            // 
            this.radio_hotel.AutoSize = true;
            this.radio_hotel.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_hotel.Location = new System.Drawing.Point(24, 13);
            this.radio_hotel.Name = "radio_hotel";
            this.radio_hotel.Size = new System.Drawing.Size(57, 21);
            this.radio_hotel.TabIndex = 11;
            this.radio_hotel.TabStop = true;
            this.radio_hotel.Text = "Hotel";
            this.radio_hotel.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(151, 500);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(304, 25);
            this.label17.TabIndex = 16;
            this.label17.Text = "Selecione o tipo de Hospedagem";
            // 
            // ckb_lugarPet
            // 
            this.ckb_lugarPet.AutoSize = true;
            this.ckb_lugarPet.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_lugarPet.Location = new System.Drawing.Point(72, 89);
            this.ckb_lugarPet.Name = "ckb_lugarPet";
            this.ckb_lugarPet.Size = new System.Drawing.Size(114, 21);
            this.ckb_lugarPet.TabIndex = 24;
            this.ckb_lugarPet.Text = "Lugar para pet";
            this.ckb_lugarPet.UseVisualStyleBackColor = true;
            this.ckb_lugarPet.CheckedChanged += new System.EventHandler(this.ckb_lugarPet_CheckedChanged);
            // 
            // ckb_academia
            // 
            this.ckb_academia.AutoSize = true;
            this.ckb_academia.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_academia.Location = new System.Drawing.Point(292, 55);
            this.ckb_academia.Name = "ckb_academia";
            this.ckb_academia.Size = new System.Drawing.Size(84, 21);
            this.ckb_academia.TabIndex = 23;
            this.ckb_academia.Text = "Academia";
            this.ckb_academia.UseVisualStyleBackColor = true;
            this.ckb_academia.CheckedChanged += new System.EventHandler(this.ckb_academia_CheckedChanged);
            // 
            // ckb_salaJogos
            // 
            this.ckb_salaJogos.AutoSize = true;
            this.ckb_salaJogos.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_salaJogos.Location = new System.Drawing.Point(292, 89);
            this.ckb_salaJogos.Name = "ckb_salaJogos";
            this.ckb_salaJogos.Size = new System.Drawing.Size(109, 21);
            this.ckb_salaJogos.TabIndex = 22;
            this.ckb_salaJogos.Text = "Sala de Jogos";
            this.ckb_salaJogos.UseVisualStyleBackColor = true;
            this.ckb_salaJogos.CheckedChanged += new System.EventHandler(this.ckb_salaJogos_CheckedChanged);
            // 
            // ckb_piscina
            // 
            this.ckb_piscina.AutoSize = true;
            this.ckb_piscina.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_piscina.Location = new System.Drawing.Point(72, 55);
            this.ckb_piscina.Name = "ckb_piscina";
            this.ckb_piscina.Size = new System.Drawing.Size(66, 21);
            this.ckb_piscina.TabIndex = 21;
            this.ckb_piscina.Text = "Piscina";
            this.ckb_piscina.UseVisualStyleBackColor = true;
            this.ckb_piscina.CheckedChanged += new System.EventHandler(this.ckb_piscina_CheckedChanged);
            // 
            // ckb_estacionamento
            // 
            this.ckb_estacionamento.AutoSize = true;
            this.ckb_estacionamento.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_estacionamento.Location = new System.Drawing.Point(72, 22);
            this.ckb_estacionamento.Name = "ckb_estacionamento";
            this.ckb_estacionamento.Size = new System.Drawing.Size(119, 21);
            this.ckb_estacionamento.TabIndex = 20;
            this.ckb_estacionamento.Text = "Estacionamento";
            this.ckb_estacionamento.UseVisualStyleBackColor = true;
            this.ckb_estacionamento.CheckedChanged += new System.EventHandler(this.ckb_estacionamento_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(505, 999);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(282, 36);
            this.label16.TabIndex = 68;
            this.label16.Text = "Detalhes da Empresa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(448, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(395, 36);
            this.label15.TabIndex = 67;
            this.label15.Text = "Alterar dados da sua Empresa";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // pn_galery
            // 
            this.pn_galery.AutoScroll = true;
            this.pn_galery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_galery.Location = new System.Drawing.Point(73, 296);
            this.pn_galery.Name = "pn_galery";
            this.pn_galery.Size = new System.Drawing.Size(450, 87);
            this.pn_galery.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(335, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Adicionar Logo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnl_tipoHosp
            // 
            this.pnl_tipoHosp.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_tipoHosp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_tipoHosp.Controls.Add(this.radio_pousada);
            this.pnl_tipoHosp.Controls.Add(this.radio_hotel);
            this.pnl_tipoHosp.Location = new System.Drawing.Point(183, 542);
            this.pnl_tipoHosp.Name = "pnl_tipoHosp";
            this.pnl_tipoHosp.Size = new System.Drawing.Size(237, 51);
            this.pnl_tipoHosp.TabIndex = 10;
            // 
            // radio_pousada
            // 
            this.radio_pousada.AutoSize = true;
            this.radio_pousada.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_pousada.Location = new System.Drawing.Point(141, 13);
            this.radio_pousada.Name = "radio_pousada";
            this.radio_pousada.Size = new System.Drawing.Size(76, 21);
            this.radio_pousada.TabIndex = 12;
            this.radio_pousada.TabStop = true;
            this.radio_pousada.Text = "Pousada";
            this.radio_pousada.UseVisualStyleBackColor = true;
            // 
            // ckb_wifi
            // 
            this.ckb_wifi.AutoSize = true;
            this.ckb_wifi.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_wifi.Location = new System.Drawing.Point(292, 22);
            this.ckb_wifi.Name = "ckb_wifi";
            this.ckb_wifi.Size = new System.Drawing.Size(49, 21);
            this.ckb_wifi.TabIndex = 25;
            this.ckb_wifi.Text = "Wifi";
            this.ckb_wifi.UseVisualStyleBackColor = true;
            this.ckb_wifi.CheckedChanged += new System.EventHandler(this.ckb_wifi_CheckedChanged);
            // 
            // bt_alterar
            // 
            this.bt_alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alterar.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterar.ForeColor = System.Drawing.Color.White;
            this.bt_alterar.Location = new System.Drawing.Point(196, 1147);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(220, 50);
            this.bt_alterar.TabIndex = 24;
            this.bt_alterar.Text = "Alterar";
            this.bt_alterar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 942);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marque os serviços disponíveis para os hospedes";
            // 
            // bt_add_img
            // 
            this.bt_add_img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_add_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_img.ForeColor = System.Drawing.Color.White;
            this.bt_add_img.Location = new System.Drawing.Point(219, 410);
            this.bt_add_img.Name = "bt_add_img";
            this.bt_add_img.Size = new System.Drawing.Size(187, 55);
            this.bt_add_img.TabIndex = 9;
            this.bt_add_img.Text = "Adicionar imagem";
            this.bt_add_img.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.button1);
            this.panel11.Controls.Add(this.pictureBox1);
            this.panel11.Controls.Add(this.mkb_phone);
            this.panel11.Controls.Add(this.mkb_cep);
            this.panel11.Controls.Add(this.mkb_cnpj);
            this.panel11.Controls.Add(this.tb_email);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.tb_nameFantasy);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.tb_endereco);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.tb_nameEmp);
            this.panel11.Controls.Add(this.label12);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Location = new System.Drawing.Point(320, 302);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(625, 656);
            this.panel11.TabIndex = 61;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(146, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 125);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // mkb_phone
            // 
            this.mkb_phone.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_phone.Location = new System.Drawing.Point(345, 523);
            this.mkb_phone.Mask = "(99) 000-0000";
            this.mkb_phone.Name = "mkb_phone";
            this.mkb_phone.Size = new System.Drawing.Size(170, 28);
            this.mkb_phone.TabIndex = 6;
            this.mkb_phone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mkb_cep
            // 
            this.mkb_cep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mkb_cep.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_cep.Location = new System.Drawing.Point(100, 523);
            this.mkb_cep.Mask = "00.000-000";
            this.mkb_cep.Name = "mkb_cep";
            this.mkb_cep.Size = new System.Drawing.Size(170, 28);
            this.mkb_cep.TabIndex = 5;
            this.mkb_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mkb_cnpj
            // 
            this.mkb_cnpj.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkb_cnpj.Location = new System.Drawing.Point(100, 372);
            this.mkb_cnpj.Mask = "99.999.999/9999-99";
            this.mkb_cnpj.Name = "mkb_cnpj";
            this.mkb_cnpj.Size = new System.Drawing.Size(415, 28);
            this.mkb_cnpj.TabIndex = 3;
            this.mkb_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(100, 596);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(415, 28);
            this.tb_email.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Endereço";
            // 
            // tb_nameFantasy
            // 
            this.tb_nameFantasy.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nameFantasy.Location = new System.Drawing.Point(100, 296);
            this.tb_nameFantasy.Name = "tb_nameFantasy";
            this.tb_nameFantasy.Size = new System.Drawing.Size(415, 28);
            this.tb_nameFantasy.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email\r\n";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(100, 450);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(415, 28);
            this.tb_endereco.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(345, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nome fantasia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(100, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "CNPJ";
            // 
            // tb_nameEmp
            // 
            this.tb_nameEmp.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nameEmp.Location = new System.Drawing.Point(100, 221);
            this.tb_nameEmp.Name = "tb_nameEmp";
            this.tb_nameEmp.Size = new System.Drawing.Size(415, 28);
            this.tb_nameEmp.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(100, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nome da empresa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(100, 493);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "CEP";
            // 
            // tb_descricaoHotel
            // 
            this.tb_descricaoHotel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_descricaoHotel.Location = new System.Drawing.Point(73, 679);
            this.tb_descricaoHotel.Multiline = true;
            this.tb_descricaoHotel.Name = "tb_descricaoHotel";
            this.tb_descricaoHotel.Size = new System.Drawing.Size(460, 220);
            this.tb_descricaoHotel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "De uma breve descrição do Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adicone imagens do Hotel";
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 2269);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1265, 100);
            this.panel9.TabIndex = 66;
            // 
            // pnl_ambDisp
            // 
            this.pnl_ambDisp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_ambDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_ambDisp.Controls.Add(this.ckb_wifi);
            this.pnl_ambDisp.Controls.Add(this.ckb_lugarPet);
            this.pnl_ambDisp.Controls.Add(this.ckb_academia);
            this.pnl_ambDisp.Controls.Add(this.ckb_salaJogos);
            this.pnl_ambDisp.Controls.Add(this.ckb_piscina);
            this.pnl_ambDisp.Controls.Add(this.ckb_estacionamento);
            this.pnl_ambDisp.Location = new System.Drawing.Point(73, 977);
            this.pnl_ambDisp.Name = "pnl_ambDisp";
            this.pnl_ambDisp.Size = new System.Drawing.Size(460, 133);
            this.pnl_ambDisp.TabIndex = 19;
            this.pnl_ambDisp.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_ambDisp_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pn_galery);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.pnl_tipoHosp);
            this.panel3.Controls.Add(this.bt_alterar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pnl_ambDisp);
            this.panel3.Controls.Add(this.tb_descricaoHotel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pb_img1);
            this.panel3.Controls.Add(this.bt_add_img);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(320, 1045);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 1224);
            this.panel3.TabIndex = 62;
            // 
            // pb_img1
            // 
            this.pb_img1.BackColor = System.Drawing.SystemColors.Control;
            this.pb_img1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_img1.InitialImage = global::Pont_Finder.Properties.Resources.downgrey;
            this.pb_img1.Location = new System.Drawing.Point(73, 65);
            this.pb_img1.Name = "pb_img1";
            this.pb_img1.Size = new System.Drawing.Size(450, 225);
            this.pb_img1.TabIndex = 3;
            this.pb_img1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1265, 200);
            this.panel7.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(473, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(377, 46);
            this.label10.TabIndex = 2;
            this.label10.Text = "Vamos evoluir juntos!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 0;
            // 
            // Editar_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "Editar_Empresa";
            this.Text = "Editar_Empresa";
            this.pnl_tipoHosp.ResumeLayout(false);
            this.pnl_tipoHosp.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_ambDisp.ResumeLayout(false);
            this.pnl_ambDisp.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_hotel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox ckb_lugarPet;
        private System.Windows.Forms.CheckBox ckb_academia;
        private System.Windows.Forms.CheckBox ckb_salaJogos;
        private System.Windows.Forms.CheckBox ckb_piscina;
        private System.Windows.Forms.CheckBox ckb_estacionamento;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Panel pn_galery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_tipoHosp;
        private System.Windows.Forms.RadioButton radio_pousada;
        private System.Windows.Forms.CheckBox ckb_wifi;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_add_img;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.MaskedTextBox mkb_phone;
        private System.Windows.Forms.MaskedTextBox mkb_cep;
        private System.Windows.Forms.MaskedTextBox mkb_cnpj;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nameFantasy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_nameEmp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_descricaoHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_img1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel pnl_ambDisp;
        private System.Windows.Forms.Panel panel3;
    }
}