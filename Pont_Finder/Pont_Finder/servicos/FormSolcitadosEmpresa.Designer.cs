namespace Pont_Finder.servicos
{
    partial class FormSolicitadosEmpresa
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.painel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.painel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 652);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 50);
            this.panel3.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 42);
            this.label1.TabIndex = 37;
            this.label1.Text = "Lista de Serviços Solicitados";
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(1160, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 630);
            this.panel7.TabIndex = 36;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(1055, 22);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 630);
            this.panel8.TabIndex = 35;
            // 
            // painel
            // 
            this.painel.Controls.Add(this.vScrollBar1);
            this.painel.Location = new System.Drawing.Point(215, 120);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(835, 532);
            this.painel.TabIndex = 34;
            this.painel.Paint += new System.Windows.Forms.PaintEventHandler(this.Painel_Paint);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(815, 11);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 518);
            this.vScrollBar1.TabIndex = 0;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(110, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 630);
            this.panel2.TabIndex = 33;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(27, 98);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 39;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            this.btn_back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_back_MouseClick);
            this.btn_back.MouseEnter += new System.EventHandler(this.Btn_back_MouseEnter);
            this.btn_back.MouseLeave += new System.EventHandler(this.Btn_back_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 630);
            this.panel1.TabIndex = 32;
            // 
            // FormSolicitadosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSolicitadosEmpresa";
            this.Text = "ServicosADM";
            this.Load += new System.EventHandler(this.FormSolicitadosEmpresa_Load);
            this.painel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}