namespace Pont_Finder.eventos
{
    partial class FormEventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventos));
            this.tb_fai = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_cat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel_center = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_prox = new System.Windows.Forms.Button();
            this.lb_pag = new System.Windows.Forms.Label();
            this.bt_ant = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_fai
            // 
            this.tb_fai.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fai.Location = new System.Drawing.Point(145, 97);
            this.tb_fai.Name = "tb_fai";
            this.tb_fai.Size = new System.Drawing.Size(130, 24);
            this.tb_fai.TabIndex = 4;
            this.tb_fai.TextChanged += new System.EventHandler(this.Tb_fai_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(46, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Faixa etária:";
            // 
            // tb_cat
            // 
            this.tb_cat.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cat.Location = new System.Drawing.Point(145, 54);
            this.tb_cat.Name = "tb_cat";
            this.tb_cat.Size = new System.Drawing.Size(130, 24);
            this.tb_cat.TabIndex = 2;
            this.tb_cat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tb_cat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(46, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área de pesquisa";
            this.label1.UseWaitCursor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(6, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "Cadastrar Empresa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 1292);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1265, 100);
            this.panel7.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(78)))), ((int)(((byte)(210)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bt_pesquisar);
            this.panel2.Controls.Add(this.tb_fai);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.tb_cat);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 212);
            this.panel2.TabIndex = 19;
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.bt_pesquisar.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar.ForeColor = System.Drawing.Color.White;
            this.bt_pesquisar.Location = new System.Drawing.Point(95, 154);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(110, 34);
            this.bt_pesquisar.TabIndex = 27;
            this.bt_pesquisar.Text = "Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = false;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.label21);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1265, 200);
            this.panel6.TabIndex = 25;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft PhagsPa", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(317, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(621, 53);
            this.label21.TabIndex = 0;
            this.label21.Text = "Os melhores eventos da cidade!";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(198, 206);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 35);
            this.button5.TabIndex = 27;
            this.button5.Text = "Gerenciar Eventos";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(470, 206);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(378, 36);
            this.label22.TabIndex = 36;
            this.label22.Text = "Veja o que temos para você!";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1047, 226);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 25);
            this.label23.TabIndex = 42;
            this.label23.Text = "Top 5 eventos";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(78)))), ((int)(((byte)(210)))));
            this.panel8.Location = new System.Drawing.Point(950, 280);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(310, 300);
            this.panel8.TabIndex = 43;
            // 
            // panel_center
            // 
            this.panel_center.AutoSize = true;
            this.panel_center.Location = new System.Drawing.Point(320, 275);
            this.panel_center.MaximumSize = new System.Drawing.Size(625, 0);
            this.panel_center.MinimumSize = new System.Drawing.Size(625, 0);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(625, 0);
            this.panel_center.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(78)))), ((int)(((byte)(210)))));
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(950, 942);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 350);
            this.panel4.TabIndex = 46;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.Location = new System.Drawing.Point(30, 186);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(250, 140);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.Location = new System.Drawing.Point(30, 28);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(250, 140);
            this.panel10.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propaganda modulos";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(78)))), ((int)(((byte)(210)))));
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(950, 586);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 350);
            this.panel5.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(30, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 140);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(30, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 140);
            this.panel3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Propaganda Externa";
            // 
            // bt_prox
            // 
            this.bt_prox.BackColor = System.Drawing.Color.Transparent;
            this.bt_prox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prox.ForeColor = System.Drawing.Color.Black;
            this.bt_prox.Location = new System.Drawing.Point(867, 252);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(75, 23);
            this.bt_prox.TabIndex = 85;
            this.bt_prox.Text = ">>";
            this.bt_prox.UseVisualStyleBackColor = false;
            this.bt_prox.Click += new System.EventHandler(this.bt_prox_Click);
            // 
            // lb_pag
            // 
            this.lb_pag.AutoSize = true;
            this.lb_pag.Location = new System.Drawing.Point(620, 262);
            this.lb_pag.Name = "lb_pag";
            this.lb_pag.Size = new System.Drawing.Size(39, 13);
            this.lb_pag.TabIndex = 86;
            this.lb_pag.Text = "lb_pag";
            // 
            // bt_ant
            // 
            this.bt_ant.BackColor = System.Drawing.Color.Transparent;
            this.bt_ant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ant.ForeColor = System.Drawing.Color.Black;
            this.bt_ant.Location = new System.Drawing.Point(320, 252);
            this.bt_ant.Name = "bt_ant";
            this.bt_ant.Size = new System.Drawing.Size(75, 23);
            this.bt_ant.TabIndex = 84;
            this.bt_ant.Text = "<<";
            this.bt_ant.UseVisualStyleBackColor = false;
            this.bt_ant.Click += new System.EventHandler(this.bt_ant_Click);
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.bt_prox);
            this.Controls.Add(this.lb_pag);
            this.Controls.Add(this.bt_ant);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "FormEventos";
            this.Text = "FormEventos";
            this.Load += new System.EventHandler(this.FormEventos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_fai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_cat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel_center;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Label lb_pag;
        private System.Windows.Forms.Button bt_ant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
    }
}