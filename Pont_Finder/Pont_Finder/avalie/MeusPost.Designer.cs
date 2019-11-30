namespace Pont_Finder.avalie
{
    partial class MeusPost
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
            this.openIcone = new System.Windows.Forms.OpenFileDialog();
            this.bt_prox = new System.Windows.Forms.Button();
            this.lb_pag = new System.Windows.Forms.Label();
            this.bt_ant = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            // 
            // bt_prox
            // 
            this.bt_prox.BackColor = System.Drawing.Color.Transparent;
            this.bt_prox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prox.ForeColor = System.Drawing.Color.Black;
            this.bt_prox.Location = new System.Drawing.Point(770, 76);
            this.bt_prox.Name = "bt_prox";
            this.bt_prox.Size = new System.Drawing.Size(75, 23);
            this.bt_prox.TabIndex = 87;
            this.bt_prox.Text = ">>";
            this.bt_prox.UseVisualStyleBackColor = false;
            this.bt_prox.Click += new System.EventHandler(this.bt_prox_Click);
            // 
            // lb_pag
            // 
            this.lb_pag.AutoSize = true;
            this.lb_pag.Location = new System.Drawing.Point(515, 86);
            this.lb_pag.Name = "lb_pag";
            this.lb_pag.Size = new System.Drawing.Size(39, 13);
            this.lb_pag.TabIndex = 88;
            this.lb_pag.Text = "lb_pag";
            // 
            // bt_ant
            // 
            this.bt_ant.BackColor = System.Drawing.Color.Transparent;
            this.bt_ant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ant.ForeColor = System.Drawing.Color.Black;
            this.bt_ant.Location = new System.Drawing.Point(196, 76);
            this.bt_ant.Name = "bt_ant";
            this.bt_ant.Size = new System.Drawing.Size(75, 23);
            this.bt_ant.TabIndex = 86;
            this.bt_ant.Text = "<<";
            this.bt_ant.UseVisualStyleBackColor = false;
            this.bt_ant.Click += new System.EventHandler(this.bt_ant_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(164, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 576);
            this.panel3.TabIndex = 89;
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.bt_ant);
            this.panel6.Controls.Add(this.bt_prox);
            this.panel6.Controls.Add(this.lb_pag);
            this.panel6.Location = new System.Drawing.Point(127, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1055, 1166);
            this.panel6.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 31);
            this.label11.TabIndex = 86;
            this.label11.Text = "Meus Posts";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.BackgroundImage = global::Pont_Finder.Properties.Resources.back_1;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Location = new System.Drawing.Point(81, 31);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(40, 40);
            this.btn_back.TabIndex = 91;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.MouseLeave += new System.EventHandler(this.btn_back_MouseLeave);
            this.btn_back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_back_MouseMove);
            // 
            // MeusPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 710);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeusPost";
            this.Text = "MeusPost";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openIcone;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Label lb_pag;
        private System.Windows.Forms.Button bt_ant;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btn_back;
    }
}