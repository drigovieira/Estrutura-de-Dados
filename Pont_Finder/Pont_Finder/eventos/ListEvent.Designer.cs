﻿namespace Pont_Finder.eventos
{
    partial class ListEvent
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
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.painel = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(127, 142);
            this.panel1.MaximumSize = new System.Drawing.Size(1010, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(1010, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 0);
            this.panel1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(916, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Adicionar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastre seu Evento aqui!";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(105, 97);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 16;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(1169, 142);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 521);
            this.panel7.TabIndex = 41;
            // 
            // painel
            // 
            this.painel.AutoSize = true;
            this.painel.Location = new System.Drawing.Point(119, 142);
            this.painel.MaximumSize = new System.Drawing.Size(1045, 0);
            this.painel.MinimumSize = new System.Drawing.Size(1045, 0);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(1045, 0);
            this.painel.TabIndex = 31;
            this.painel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(14, 142);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(100, 521);
            this.panel13.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 663);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 100);
            this.panel2.TabIndex = 42;
            // 
            // ListEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1282, 675);
            this.MinimumSize = new System.Drawing.Size(1282, 675);
            this.Name = "ListEvent";
            this.Text = "ListEvent";
            this.Load += new System.EventHandler(this.ListEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel2;
    }
}