namespace Pont_Finder.servicos
{
    partial class FormServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicos));
            this.panel_right = new System.Windows.Forms.Panel();
            this.bt_solicitar = new System.Windows.Forms.Button();
            this.bt_empresa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditarPerfil = new System.Windows.Forms.Button();
            this.bt_solicitados = new System.Windows.Forms.Button();
            this.bt_mensagens = new System.Windows.Forms.Button();
            this.bt_servicos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_ant = new System.Windows.Forms.Button();
            this.bt_prox = new System.Windows.Forms.Button();
            this.lb_pag = new System.Windows.Forms.Label();
            this.panel_center = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_pesquisar = new System.Windows.Forms.TextBox();
            this.pb_pesquisar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_semfiltro = new System.Windows.Forms.RadioButton();
            this.rb_empresa = new System.Windows.Forms.RadioButton();
            this.rb_servico = new System.Windows.Forms.RadioButton();
            this.rb_recente = new System.Windows.Forms.RadioButton();
            this.rb_antigo = new System.Windows.Forms.RadioButton();
            this.panel_left = new System.Windows.Forms.Panel();
            this.rb_categoria = new System.Windows.Forms.RadioButton();
            this.bt_antFull = new System.Windows.Forms.Button();
            this.bt_proxFull = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).BeginInit();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            this.panel_right.Location = new System.Drawing.Point(950, 297);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(310, 259);
            this.panel_right.TabIndex = 16;
            // 
            // bt_solicitar
            // 
            this.bt_solicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_solicitar.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_solicitar.ForeColor = System.Drawing.Color.White;
            this.bt_solicitar.Location = new System.Drawing.Point(824, 5);
            this.bt_solicitar.Name = "bt_solicitar";
            this.bt_solicitar.Size = new System.Drawing.Size(122, 28);
            this.bt_solicitar.TabIndex = 4;
            this.bt_solicitar.Text = "Solicitar Serviço";
            this.bt_solicitar.UseVisualStyleBackColor = true;
            this.bt_solicitar.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_empresa
            // 
            this.bt_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_empresa.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_empresa.ForeColor = System.Drawing.Color.White;
            this.bt_empresa.Location = new System.Drawing.Point(312, 5);
            this.bt_empresa.Name = "bt_empresa";
            this.bt_empresa.Size = new System.Drawing.Size(122, 28);
            this.bt_empresa.TabIndex = 3;
            this.bt_empresa.Text = "Cadastrar Empresa";
            this.bt_empresa.UseVisualStyleBackColor = true;
            this.bt_empresa.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.EditarPerfil);
            this.panel1.Controls.Add(this.bt_solicitados);
            this.panel1.Controls.Add(this.bt_mensagens);
            this.panel1.Controls.Add(this.bt_servicos);
            this.panel1.Controls.Add(this.bt_solicitar);
            this.panel1.Controls.Add(this.bt_empresa);
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 40);
            this.panel1.TabIndex = 19;
            // 
            // EditarPerfil
            // 
            this.EditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarPerfil.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarPerfil.ForeColor = System.Drawing.Color.White;
            this.EditarPerfil.Location = new System.Drawing.Point(3, 5);
            this.EditarPerfil.Name = "EditarPerfil";
            this.EditarPerfil.Size = new System.Drawing.Size(122, 28);
            this.EditarPerfil.TabIndex = 11;
            this.EditarPerfil.Text = "Editar perfil";
            this.EditarPerfil.UseVisualStyleBackColor = true;
            this.EditarPerfil.Click += new System.EventHandler(this.EditarPerfil_Click);
            // 
            // bt_solicitados
            // 
            this.bt_solicitados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_solicitados.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_solicitados.ForeColor = System.Drawing.Color.White;
            this.bt_solicitados.Location = new System.Drawing.Point(696, 5);
            this.bt_solicitados.Name = "bt_solicitados";
            this.bt_solicitados.Size = new System.Drawing.Size(122, 28);
            this.bt_solicitados.TabIndex = 9;
            this.bt_solicitados.Text = "Serviços Solicitados";
            this.bt_solicitados.UseVisualStyleBackColor = true;
            this.bt_solicitados.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // bt_mensagens
            // 
            this.bt_mensagens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_mensagens.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mensagens.ForeColor = System.Drawing.Color.White;
            this.bt_mensagens.Location = new System.Drawing.Point(568, 5);
            this.bt_mensagens.Name = "bt_mensagens";
            this.bt_mensagens.Size = new System.Drawing.Size(122, 28);
            this.bt_mensagens.TabIndex = 8;
            this.bt_mensagens.Text = "Mensagens";
            this.bt_mensagens.UseVisualStyleBackColor = true;
            this.bt_mensagens.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bt_servicos
            // 
            this.bt_servicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_servicos.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_servicos.ForeColor = System.Drawing.Color.White;
            this.bt_servicos.Location = new System.Drawing.Point(440, 5);
            this.bt_servicos.Name = "bt_servicos";
            this.bt_servicos.Size = new System.Drawing.Size(122, 28);
            this.bt_servicos.TabIndex = 7;
            this.bt_servicos.Text = "Gerenciar Serviços";
            this.bt_servicos.UseVisualStyleBackColor = true;
            this.bt_servicos.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 100);
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Veja o que temos para você!";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 150);
            this.panel3.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(416, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aproveite nossos serviços!";
            // 
            // bt_ant
            // 
            this.bt_ant.BackColor = System.Drawing.Color.Transparent;
            this.bt_ant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ant.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ant.ForeColor = System.Drawing.Color.Black;
            this.bt_ant.Location = new System.Drawing.Point(320, 297);
            this.bt_ant.Name = "bt_ant";
            this.bt_ant.Size = new System.Drawing.Size(50, 33);
            this.bt_ant.TabIndex = 39;
            this.bt_ant.Text = "←";
            this.bt_ant.UseVisualStyleBackColor = false;
            this.bt_ant.Click += new System.EventHandler(this.Bt_ant_Click);
            // 
            // bt_prox
            // 
            this.bt_prox.BackColor = System.Drawing.Color.Transparent;
            this.bt_prox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prox.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prox.ForeColor = System.Drawing.Color.Black;
            this.bt_prox.Location = new System.Drawing.Point(894, 297);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(50, 33);
            this.bt_prox.TabIndex = 40;
            this.bt_prox.Text = "→";
            this.bt_prox.UseVisualStyleBackColor = false;
            this.bt_prox.Click += new System.EventHandler(this.Bt_prox_Click);
            // 
            // lb_pag
            // 
            this.lb_pag.AutoSize = true;
            this.lb_pag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_pag.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pag.ForeColor = System.Drawing.Color.Black;
            this.lb_pag.Location = new System.Drawing.Point(432, 297);
            this.lb_pag.MaximumSize = new System.Drawing.Size(400, 33);
            this.lb_pag.MinimumSize = new System.Drawing.Size(400, 33);
            this.lb_pag.Name = "lb_pag";
            this.lb_pag.Size = new System.Drawing.Size(400, 33);
            this.lb_pag.TabIndex = 41;
            this.lb_pag.Text = "lb_pag";
            this.lb_pag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_pag.Click += new System.EventHandler(this.Lb_pag_Click);
            // 
            // panel_center
            // 
            this.panel_center.AutoSize = true;
            this.panel_center.BackColor = System.Drawing.Color.Transparent;
            this.panel_center.Location = new System.Drawing.Point(320, 334);
            this.panel_center.MaximumSize = new System.Drawing.Size(625, 0);
            this.panel_center.MinimumSize = new System.Drawing.Size(625, 0);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(625, 0);
            this.panel_center.TabIndex = 17;
            this.panel_center.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_center_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1039, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 27);
            this.label16.TabIndex = 43;
            this.label16.Text = "Top 5 Serviços";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.panel8.Controls.Add(this.label15);
            this.panel8.Location = new System.Drawing.Point(950, 919);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(310, 350);
            this.panel8.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(84, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 21);
            this.label15.TabIndex = 1;
            this.label15.Text = "Propaganda modulos";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(950, 562);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 350);
            this.panel4.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Propaganda Externa";
            // 
            // tb_pesquisar
            // 
            this.tb_pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pesquisar.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pesquisar.ForeColor = System.Drawing.Color.Black;
            this.tb_pesquisar.Location = new System.Drawing.Point(13, 23);
            this.tb_pesquisar.Name = "tb_pesquisar";
            this.tb_pesquisar.Size = new System.Drawing.Size(283, 25);
            this.tb_pesquisar.TabIndex = 0;
            this.tb_pesquisar.Tag = "";
            this.tb_pesquisar.TextChanged += new System.EventHandler(this.Tb_pesquisar_TextChanged);
            this.tb_pesquisar.Enter += new System.EventHandler(this.Tb_pesquisa_Enter);
            this.tb_pesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_pesquisar_KeyPress);
            this.tb_pesquisar.Leave += new System.EventHandler(this.Tb_pesquisa_Leave);
            // 
            // pb_pesquisar
            // 
            this.pb_pesquisar.BackColor = System.Drawing.Color.White;
            this.pb_pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_pesquisar.BackgroundImage")));
            this.pb_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pesquisar.Location = new System.Drawing.Point(270, 23);
            this.pb_pesquisar.Name = "pb_pesquisar";
            this.pb_pesquisar.Size = new System.Drawing.Size(25, 25);
            this.pb_pesquisar.TabIndex = 1;
            this.pb_pesquisar.TabStop = false;
            this.pb_pesquisar.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "Filtros de Busca";
            // 
            // rb_semfiltro
            // 
            this.rb_semfiltro.AutoSize = true;
            this.rb_semfiltro.Checked = true;
            this.rb_semfiltro.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_semfiltro.Location = new System.Drawing.Point(16, 128);
            this.rb_semfiltro.Name = "rb_semfiltro";
            this.rb_semfiltro.Size = new System.Drawing.Size(78, 20);
            this.rb_semfiltro.TabIndex = 44;
            this.rb_semfiltro.TabStop = true;
            this.rb_semfiltro.Text = "Sem Filtro";
            this.rb_semfiltro.UseVisualStyleBackColor = true;
            // 
            // rb_empresa
            // 
            this.rb_empresa.AutoSize = true;
            this.rb_empresa.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_empresa.Location = new System.Drawing.Point(162, 150);
            this.rb_empresa.Name = "rb_empresa";
            this.rb_empresa.Size = new System.Drawing.Size(121, 20);
            this.rb_empresa.TabIndex = 45;
            this.rb_empresa.Text = "Nome da Empresa";
            this.rb_empresa.UseVisualStyleBackColor = true;
            // 
            // rb_servico
            // 
            this.rb_servico.AutoSize = true;
            this.rb_servico.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_servico.Location = new System.Drawing.Point(162, 124);
            this.rb_servico.Name = "rb_servico";
            this.rb_servico.Size = new System.Drawing.Size(116, 20);
            this.rb_servico.TabIndex = 46;
            this.rb_servico.Text = "Nome do Serviço";
            this.rb_servico.UseVisualStyleBackColor = true;
            this.rb_servico.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // rb_recente
            // 
            this.rb_recente.AutoSize = true;
            this.rb_recente.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_recente.Location = new System.Drawing.Point(16, 154);
            this.rb_recente.Name = "rb_recente";
            this.rb_recente.Size = new System.Drawing.Size(96, 20);
            this.rb_recente.TabIndex = 47;
            this.rb_recente.Text = "Mais Recente";
            this.rb_recente.UseVisualStyleBackColor = true;
            // 
            // rb_antigo
            // 
            this.rb_antigo.AutoSize = true;
            this.rb_antigo.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_antigo.Location = new System.Drawing.Point(16, 180);
            this.rb_antigo.Name = "rb_antigo";
            this.rb_antigo.Size = new System.Drawing.Size(90, 20);
            this.rb_antigo.TabIndex = 48;
            this.rb_antigo.Text = "Mais Antigo";
            this.rb_antigo.UseVisualStyleBackColor = true;
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(125)))), ((int)(((byte)(204)))));
            this.panel_left.Controls.Add(this.rb_categoria);
            this.panel_left.Controls.Add(this.rb_antigo);
            this.panel_left.Controls.Add(this.rb_recente);
            this.panel_left.Controls.Add(this.rb_servico);
            this.panel_left.Controls.Add(this.rb_empresa);
            this.panel_left.Controls.Add(this.rb_semfiltro);
            this.panel_left.Controls.Add(this.label2);
            this.panel_left.Controls.Add(this.pb_pesquisar);
            this.panel_left.Controls.Add(this.tb_pesquisar);
            this.panel_left.Location = new System.Drawing.Point(5, 297);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(310, 259);
            this.panel_left.TabIndex = 15;
            // 
            // rb_categoria
            // 
            this.rb_categoria.AutoSize = true;
            this.rb_categoria.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_categoria.Location = new System.Drawing.Point(162, 176);
            this.rb_categoria.Name = "rb_categoria";
            this.rb_categoria.Size = new System.Drawing.Size(76, 20);
            this.rb_categoria.TabIndex = 50;
            this.rb_categoria.Text = "Categoria";
            this.rb_categoria.UseVisualStyleBackColor = true;
            // 
            // bt_antFull
            // 
            this.bt_antFull.BackColor = System.Drawing.Color.Transparent;
            this.bt_antFull.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_antFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_antFull.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_antFull.ForeColor = System.Drawing.Color.Black;
            this.bt_antFull.Location = new System.Drawing.Point(376, 297);
            this.bt_antFull.Name = "bt_antFull";
            this.bt_antFull.Size = new System.Drawing.Size(50, 33);
            this.bt_antFull.TabIndex = 47;
            this.bt_antFull.Text = "↞";
            this.bt_antFull.UseVisualStyleBackColor = false;
            this.bt_antFull.Click += new System.EventHandler(this.Bt_antFull_Click);
            // 
            // bt_proxFull
            // 
            this.bt_proxFull.BackColor = System.Drawing.Color.Transparent;
            this.bt_proxFull.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_proxFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_proxFull.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proxFull.ForeColor = System.Drawing.Color.Black;
            this.bt_proxFull.Location = new System.Drawing.Point(838, 297);
            this.bt_proxFull.Name = "bt_proxFull";
            this.bt_proxFull.Size = new System.Drawing.Size(50, 33);
            this.bt_proxFull.TabIndex = 48;
            this.bt_proxFull.Text = "↠";
            this.bt_proxFull.UseVisualStyleBackColor = false;
            this.bt_proxFull.Click += new System.EventHandler(this.Bt_proxFull_Click);
            // 
            // FormServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.lb_pag);
            this.Controls.Add(this.bt_proxFull);
            this.Controls.Add(this.bt_antFull);
            this.Controls.Add(this.bt_prox);
            this.Controls.Add(this.bt_ant);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "FormServicos";
            this.Text = "servicos";
            this.Load += new System.EventHandler(this.Formservicos_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pesquisar)).EndInit();
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Button bt_empresa;
        private System.Windows.Forms.Button bt_solicitar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_servicos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_ant;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_pag;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bt_mensagens;
        private System.Windows.Forms.Button bt_solicitados;
        private System.Windows.Forms.TextBox tb_pesquisar;
        private System.Windows.Forms.PictureBox pb_pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_semfiltro;
        private System.Windows.Forms.RadioButton rb_empresa;
        private System.Windows.Forms.RadioButton rb_servico;
        private System.Windows.Forms.RadioButton rb_recente;
        private System.Windows.Forms.RadioButton rb_antigo;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button EditarPerfil;
        private System.Windows.Forms.Button bt_antFull;
        private System.Windows.Forms.Button bt_proxFull;
        private System.Windows.Forms.RadioButton rb_categoria;
    }
}