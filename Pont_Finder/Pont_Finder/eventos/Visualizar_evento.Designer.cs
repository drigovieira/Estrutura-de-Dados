﻿namespace Pont_Finder.eventos
{
    partial class Visualizar_evento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_rs_cartao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_txt4 = new System.Windows.Forms.Label();
            this.esgotado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_txt7 = new System.Windows.Forms.Label();
            this.lb_txt3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bt_postar = new System.Windows.Forms.Button();
            this.tb_resposta = new System.Windows.Forms.RichTextBox();
            this.bt_ant = new System.Windows.Forms.Button();
            this.bt_prox = new System.Windows.Forms.Button();
            this.lb_pag = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.painelcoment = new System.Windows.Forms.Panel();
            this.lb_descricao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_horario = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.lb_txt8 = new System.Windows.Forms.Label();
            this.lb_txt9 = new System.Windows.Forms.Label();
            this.lb_txt10 = new System.Windows.Forms.Label();
            this.lb_txt11 = new System.Windows.Forms.Label();
            this.pb_principal = new System.Windows.Forms.PictureBox();
            this.lb_rs_boleto = new System.Windows.Forms.Label();
            this.bt_comprar = new System.Windows.Forms.Button();
            this.lb_nome_evento = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_principal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lb_rs_cartao);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_txt4);
            this.panel1.Controls.Add(this.esgotado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lb_txt7);
            this.panel1.Controls.Add(this.lb_txt3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pb_principal);
            this.panel1.Controls.Add(this.lb_rs_boleto);
            this.panel1.Controls.Add(this.bt_comprar);
            this.panel1.Controls.Add(this.lb_nome_evento);
            this.panel1.Location = new System.Drawing.Point(114, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 1500);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Em até 6 vezes no cartão\r\n";
            // 
            // lb_rs_cartao
            // 
            this.lb_rs_cartao.AutoSize = true;
            this.lb_rs_cartao.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rs_cartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.lb_rs_cartao.Location = new System.Drawing.Point(918, 87);
            this.lb_rs_cartao.Name = "lb_rs_cartao";
            this.lb_rs_cartao.Size = new System.Drawing.Size(43, 46);
            this.lb_rs_cartao.TabIndex = 44;
            this.lb_rs_cartao.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(849, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 46);
            this.label4.TabIndex = 43;
            this.label4.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(888, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ou";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lb_txt4
            // 
            this.lb_txt4.AutoSize = true;
            this.lb_txt4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt4.Location = new System.Drawing.Point(820, 146);
            this.lb_txt4.Name = "lb_txt4";
            this.lb_txt4.Size = new System.Drawing.Size(190, 21);
            this.lb_txt4.TabIndex = 41;
            this.lb_txt4.Text = "A vista no boleto bancário";
            // 
            // esgotado
            // 
            this.esgotado.AutoSize = true;
            this.esgotado.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold);
            this.esgotado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.esgotado.Location = new System.Drawing.Point(852, 392);
            this.esgotado.Name = "esgotado";
            this.esgotado.Size = new System.Drawing.Size(124, 27);
            this.esgotado.TabIndex = 40;
            this.esgotado.Text = "ESGOTADO";
            this.esgotado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(849, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 46);
            this.label1.TabIndex = 39;
            this.label1.Text = "R$";
            // 
            // lb_txt7
            // 
            this.lb_txt7.AutoSize = true;
            this.lb_txt7.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt7.Location = new System.Drawing.Point(485, 412);
            this.lb_txt7.Name = "lb_txt7";
            this.lb_txt7.Size = new System.Drawing.Size(96, 27);
            this.lb_txt7.TabIndex = 31;
            this.lb_txt7.Text = "Detalhes";
            // 
            // lb_txt3
            // 
            this.lb_txt3.AutoSize = true;
            this.lb_txt3.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt3.Location = new System.Drawing.Point(888, 54);
            this.lb_txt3.Name = "lb_txt3";
            this.lb_txt3.Size = new System.Drawing.Size(47, 20);
            this.lb_txt3.TabIndex = 25;
            this.lb_txt3.Text = "Valor:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.bt_postar);
            this.panel4.Controls.Add(this.tb_resposta);
            this.panel4.Controls.Add(this.bt_ant);
            this.panel4.Controls.Add(this.bt_prox);
            this.panel4.Controls.Add(this.lb_pag);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.painelcoment);
            this.panel4.Controls.Add(this.lb_descricao);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lb_horario);
            this.panel4.Controls.Add(this.lb_data);
            this.panel4.Controls.Add(this.lb_categoria);
            this.panel4.Controls.Add(this.lb_txt8);
            this.panel4.Controls.Add(this.lb_txt9);
            this.panel4.Controls.Add(this.lb_txt10);
            this.panel4.Controls.Add(this.lb_txt11);
            this.panel4.Location = new System.Drawing.Point(40, 451);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(966, 1000);
            this.panel4.TabIndex = 37;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // bt_postar
            // 
            this.bt_postar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(95)))), ((int)(((byte)(233)))));
            this.bt_postar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_postar.ForeColor = System.Drawing.Color.White;
            this.bt_postar.Location = new System.Drawing.Point(759, 808);
            this.bt_postar.Name = "bt_postar";
            this.bt_postar.Size = new System.Drawing.Size(86, 38);
            this.bt_postar.TabIndex = 102;
            this.bt_postar.Text = "Postar";
            this.bt_postar.UseVisualStyleBackColor = false;
            this.bt_postar.Click += new System.EventHandler(this.Bt_postar_Click);
            // 
            // tb_resposta
            // 
            this.tb_resposta.BackColor = System.Drawing.Color.White;
            this.tb_resposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_resposta.Location = new System.Drawing.Point(580, 680);
            this.tb_resposta.Name = "tb_resposta";
            this.tb_resposta.Size = new System.Drawing.Size(267, 116);
            this.tb_resposta.TabIndex = 101;
            this.tb_resposta.Text = "";
            // 
            // bt_ant
            // 
            this.bt_ant.BackColor = System.Drawing.Color.Transparent;
            this.bt_ant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ant.ForeColor = System.Drawing.Color.Black;
            this.bt_ant.Location = new System.Drawing.Point(16, 525);
            this.bt_ant.Name = "bt_ant";
            this.bt_ant.Size = new System.Drawing.Size(75, 23);
            this.bt_ant.TabIndex = 98;
            this.bt_ant.Text = "<<";
            this.bt_ant.UseVisualStyleBackColor = false;
            // 
            // bt_prox
            // 
            this.bt_prox.BackColor = System.Drawing.Color.Transparent;
            this.bt_prox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prox.ForeColor = System.Drawing.Color.Black;
            this.bt_prox.Location = new System.Drawing.Point(466, 525);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(75, 23);
            this.bt_prox.TabIndex = 99;
            this.bt_prox.Text = ">>";
            this.bt_prox.UseVisualStyleBackColor = false;
            // 
            // lb_pag
            // 
            this.lb_pag.AutoSize = true;
            this.lb_pag.Location = new System.Drawing.Point(248, 535);
            this.lb_pag.Name = "lb_pag";
            this.lb_pag.Size = new System.Drawing.Size(39, 13);
            this.lb_pag.TabIndex = 100;
            this.lb_pag.Text = "lb_pag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 27);
            this.label6.TabIndex = 97;
            this.label6.Text = "Comentários:";
            // 
            // painelcoment
            // 
            this.painelcoment.AutoScroll = true;
            this.painelcoment.AutoSize = true;
            this.painelcoment.BackColor = System.Drawing.Color.Transparent;
            this.painelcoment.Location = new System.Drawing.Point(17, 565);
            this.painelcoment.Name = "painelcoment";
            this.painelcoment.Size = new System.Drawing.Size(525, 24);
            this.painelcoment.TabIndex = 96;
            // 
            // lb_descricao
            // 
            this.lb_descricao.AutoSize = true;
            this.lb_descricao.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descricao.Location = new System.Drawing.Point(157, 63);
            this.lb_descricao.Name = "lb_descricao";
            this.lb_descricao.Size = new System.Drawing.Size(58, 24);
            this.lb_descricao.TabIndex = 39;
            this.lb_descricao.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Descrição:";
            // 
            // lb_horario
            // 
            this.lb_horario.AutoSize = true;
            this.lb_horario.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_horario.Location = new System.Drawing.Point(139, 261);
            this.lb_horario.Name = "lb_horario";
            this.lb_horario.Size = new System.Drawing.Size(58, 24);
            this.lb_horario.TabIndex = 36;
            this.lb_horario.Text = "Value";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(114, 212);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(58, 24);
            this.lb_data.TabIndex = 35;
            this.lb_data.Text = "Value";
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoria.Location = new System.Drawing.Point(157, 157);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(58, 24);
            this.lb_categoria.TabIndex = 34;
            this.lb_categoria.Text = "Value";
            // 
            // lb_txt8
            // 
            this.lb_txt8.AutoSize = true;
            this.lb_txt8.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt8.Location = new System.Drawing.Point(48, 15);
            this.lb_txt8.Name = "lb_txt8";
            this.lb_txt8.Size = new System.Drawing.Size(161, 27);
            this.lb_txt8.TabIndex = 31;
            this.lb_txt8.Text = "Sobre o evento";
            // 
            // lb_txt9
            // 
            this.lb_txt9.AutoSize = true;
            this.lb_txt9.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt9.Location = new System.Drawing.Point(55, 157);
            this.lb_txt9.Name = "lb_txt9";
            this.lb_txt9.Size = new System.Drawing.Size(96, 24);
            this.lb_txt9.TabIndex = 27;
            this.lb_txt9.Text = "Categoria:";
            // 
            // lb_txt10
            // 
            this.lb_txt10.AutoSize = true;
            this.lb_txt10.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt10.Location = new System.Drawing.Point(55, 212);
            this.lb_txt10.Name = "lb_txt10";
            this.lb_txt10.Size = new System.Drawing.Size(53, 24);
            this.lb_txt10.TabIndex = 22;
            this.lb_txt10.Text = "Data:";
            // 
            // lb_txt11
            // 
            this.lb_txt11.AutoSize = true;
            this.lb_txt11.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_txt11.Location = new System.Drawing.Point(55, 261);
            this.lb_txt11.Name = "lb_txt11";
            this.lb_txt11.Size = new System.Drawing.Size(78, 24);
            this.lb_txt11.TabIndex = 23;
            this.lb_txt11.Text = "Horário:";
            // 
            // pb_principal
            // 
            this.pb_principal.BackColor = System.Drawing.SystemColors.Control;
            this.pb_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_principal.Location = new System.Drawing.Point(42, 54);
            this.pb_principal.Name = "pb_principal";
            this.pb_principal.Size = new System.Drawing.Size(450, 225);
            this.pb_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_principal.TabIndex = 36;
            this.pb_principal.TabStop = false;
            // 
            // lb_rs_boleto
            // 
            this.lb_rs_boleto.AutoSize = true;
            this.lb_rs_boleto.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rs_boleto.ForeColor = System.Drawing.Color.Red;
            this.lb_rs_boleto.Location = new System.Drawing.Point(918, 214);
            this.lb_rs_boleto.Name = "lb_rs_boleto";
            this.lb_rs_boleto.Size = new System.Drawing.Size(43, 46);
            this.lb_rs_boleto.TabIndex = 34;
            this.lb_rs_boleto.Text = "V";
            this.lb_rs_boleto.Click += new System.EventHandler(this.Lb_rs_boleto_Click);
            // 
            // bt_comprar
            // 
            this.bt_comprar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_comprar.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_comprar.ForeColor = System.Drawing.Color.White;
            this.bt_comprar.Location = new System.Drawing.Point(824, 336);
            this.bt_comprar.Name = "bt_comprar";
            this.bt_comprar.Size = new System.Drawing.Size(164, 44);
            this.bt_comprar.TabIndex = 26;
            this.bt_comprar.Text = "Comprar";
            this.bt_comprar.UseVisualStyleBackColor = false;
            this.bt_comprar.Click += new System.EventHandler(this.Bt_comprar_Click);
            // 
            // lb_nome_evento
            // 
            this.lb_nome_evento.AutoSize = true;
            this.lb_nome_evento.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome_evento.Location = new System.Drawing.Point(483, 8);
            this.lb_nome_evento.Name = "lb_nome_evento";
            this.lb_nome_evento.Size = new System.Drawing.Size(206, 32);
            this.lb_nome_evento.TabIndex = 20;
            this.lb_nome_evento.Text = "Nome do evento";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(66, 29);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 15;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1206, 1491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 100);
            this.panel2.TabIndex = 16;
            // 
            // Visualizar_evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1316, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visualizar_evento";
            this.Text = "Visualizar_evento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_principal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_txt7;
        private System.Windows.Forms.Label lb_txt3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_horario;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.Label lb_txt8;
        private System.Windows.Forms.Label lb_txt9;
        private System.Windows.Forms.Label lb_txt10;
        private System.Windows.Forms.Label lb_txt11;
        private System.Windows.Forms.PictureBox pb_principal;
        private System.Windows.Forms.Label lb_rs_boleto;
        private System.Windows.Forms.Button bt_comprar;
        private System.Windows.Forms.Label lb_nome_evento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.Label lb_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label esgotado;
        private System.Windows.Forms.Label lb_txt4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_rs_cartao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_postar;
        private System.Windows.Forms.RichTextBox tb_resposta;
        private System.Windows.Forms.Button bt_ant;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Label lb_pag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel painelcoment;
        private System.Windows.Forms.Panel panel2;
    }
}