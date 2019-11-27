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
            this.label5 = new System.Windows.Forms.Label();
            this.bt_prox = new System.Windows.Forms.Button();
            this.lb_pag = new System.Windows.Forms.Label();
            this.bt_ant = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openIcone
            // 
            this.openIcone.FileName = "icone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 85;
            this.label5.Text = "Meus Posts...";
            // 
            // bt_prox
            // 
            this.bt_prox.BackColor = System.Drawing.Color.Transparent;
            this.bt_prox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_prox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_prox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_prox.ForeColor = System.Drawing.Color.Black;
            this.bt_prox.Location = new System.Drawing.Point(822, 180);
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
            this.lb_pag.Location = new System.Drawing.Point(562, 193);
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
            this.bt_ant.Location = new System.Drawing.Point(239, 183);
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
            this.panel3.Location = new System.Drawing.Point(239, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 576);
            this.panel3.TabIndex = 89;
            // 
            // MeusPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1233, 710);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bt_prox);
            this.Controls.Add(this.lb_pag);
            this.Controls.Add(this.bt_ant);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeusPost";
            this.Text = "MeusPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openIcone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_prox;
        private System.Windows.Forms.Label lb_pag;
        private System.Windows.Forms.Button bt_ant;
        private System.Windows.Forms.Panel panel3;
    }
}