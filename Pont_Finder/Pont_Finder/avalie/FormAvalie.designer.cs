namespace Pont_Finder
{
    partial class FormAvalie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvalie));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cb_problemas = new System.Windows.Forms.ComboBox();
            this.button_Pesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_pag = new System.Windows.Forms.Label();
            this.bt_prox = new System.Windows.Forms.Button();
            this.bt_ant = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Databox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(450, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Realizar post!";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel7.Controls.Add(this.cb_problemas);
            this.panel7.Controls.Add(this.button_Pesquisar);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(5, 482);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(310, 200);
            this.panel7.TabIndex = 14;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // cb_problemas
            // 
            this.cb_problemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_problemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_problemas.FormattingEnabled = true;
            this.cb_problemas.Items.AddRange(new object[] {
            "Infraestrutura",
            "Serviços",
            "Outros"});
            this.cb_problemas.Location = new System.Drawing.Point(65, 72);
            this.cb_problemas.Name = "cb_problemas";
            this.cb_problemas.Size = new System.Drawing.Size(200, 28);
            this.cb_problemas.TabIndex = 82;
            // 
            // button_Pesquisar
            // 
            this.button_Pesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pesquisar.ForeColor = System.Drawing.Color.White;
            this.button_Pesquisar.Location = new System.Drawing.Point(92, 123);
            this.button_Pesquisar.Name = "button_Pesquisar";
            this.button_Pesquisar.Size = new System.Drawing.Size(110, 34);
            this.button_Pesquisar.TabIndex = 79;
            this.button_Pesquisar.Text = "Filtrar";
            this.button_Pesquisar.UseVisualStyleBackColor = false;
            this.button_Pesquisar.Click += new System.EventHandler(this.button_Pesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filtrar Reclamações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Período de:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(950, 619);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 160);
            this.panel5.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Propaganda Externa";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1265, 150);
            this.panel8.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(463, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 42);
            this.label6.TabIndex = 1;
            this.label6.Text = "Expresse sua opinião";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel9.Controls.Add(this.button2);
            this.panel9.Controls.Add(this.button3);
            this.panel9.Location = new System.Drawing.Point(0, 150);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1265, 40);
            this.panel9.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(726, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Meus Posts";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 84;
            this.label5.Text = "Ultimos Posts...";
            // 
            // lb_pag
            // 
            this.lb_pag.AutoSize = true;
            this.lb_pag.Location = new System.Drawing.Point(617, 250);
            this.lb_pag.Name = "lb_pag";
            this.lb_pag.Size = new System.Drawing.Size(39, 13);
            this.lb_pag.TabIndex = 83;
            this.lb_pag.Text = "lb_pag";
            // 
            // bt_prox
            // 
            this.bt_prox.BackColor = System.Drawing.Color.Transparent;
            this.bt_prox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prox.ForeColor = System.Drawing.Color.Black;
            this.bt_prox.Location = new System.Drawing.Point(869, 241);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(75, 23);
            this.bt_prox.TabIndex = 82;
            this.bt_prox.Text = ">>";
            this.bt_prox.UseVisualStyleBackColor = false;
            this.bt_prox.Click += new System.EventHandler(this.bt_prox_Click);
            // 
            // bt_ant
            // 
            this.bt_ant.BackColor = System.Drawing.Color.Transparent;
            this.bt_ant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ant.ForeColor = System.Drawing.Color.Black;
            this.bt_ant.Location = new System.Drawing.Point(317, 240);
            this.bt_ant.Name = "bt_ant";
            this.bt_ant.Size = new System.Drawing.Size(75, 23);
            this.bt_ant.TabIndex = 81;
            this.bt_ant.Text = "<<";
            this.bt_ant.UseVisualStyleBackColor = false;
            this.bt_ant.Click += new System.EventHandler(this.bt_ant_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Location = new System.Drawing.Point(319, 269);
            this.panel3.MaximumSize = new System.Drawing.Size(625, 0);
            this.panel3.MinimumSize = new System.Drawing.Size(625, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 0);
            this.panel3.TabIndex = 80;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(950, 785);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 325);
            this.panel4.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(84, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Propaganda modulos";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(950, 270);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 343);
            this.panel6.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "5 maiores reclamações";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 100);
            this.panel1.TabIndex = 85;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.Databox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(5, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 189);
            this.panel2.TabIndex = 80;
            // 
            // Databox
            // 
            this.Databox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Databox.Location = new System.Drawing.Point(86, 85);
            this.Databox.Margin = new System.Windows.Forms.Padding(2);
            this.Databox.Mask = "00/00/0000";
            this.Databox.Name = "Databox";
            this.Databox.Size = new System.Drawing.Size(115, 29);
            this.Databox.TabIndex = 81;
            this.Databox.ValidatingType = typeof(System.DateTime);
            this.Databox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Databox_MaskInputRejected);
            this.Databox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Databox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Pesquisar Reclamações";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(86, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormAvalie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_prox);
            this.Controls.Add(this.lb_pag);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.bt_ant);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "FormAvalie";
            this.Text = "FormAvalie";
            this.Load += new System.EventHandler(this.FormAvalie_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Pesquisar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_pag;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Button bt_ant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox Databox;
        private System.Windows.Forms.ComboBox cb_problemas;
    }
}