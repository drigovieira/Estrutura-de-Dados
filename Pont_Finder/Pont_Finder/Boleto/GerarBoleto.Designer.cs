namespace Pont_Finder.Boleto
{
    partial class GerarBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarBoleto));
            this.boletoA = new System.Windows.Forms.Panel();
            this.cpflabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valorlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boletoA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // boletoA
            // 
            this.boletoA.Controls.Add(this.label1);
            this.boletoA.Controls.Add(this.pictureBox3);
            this.boletoA.Controls.Add(this.cpflabel);
            this.boletoA.Controls.Add(this.label3);
            this.boletoA.Controls.Add(this.valorlabel);
            this.boletoA.Controls.Add(this.label2);
            this.boletoA.Location = new System.Drawing.Point(108, 12);
            this.boletoA.Name = "boletoA";
            this.boletoA.Size = new System.Drawing.Size(1028, 532);
            this.boletoA.TabIndex = 7;
            // 
            // cpflabel
            // 
            this.cpflabel.AutoSize = true;
            this.cpflabel.Location = new System.Drawing.Point(95, 111);
            this.cpflabel.Name = "cpflabel";
            this.cpflabel.Size = new System.Drawing.Size(113, 13);
            this.cpflabel.TabIndex = 5;
            this.cpflabel.Text = "CPFDOCOMPRADOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // valorlabel
            // 
            this.valorlabel.AutoSize = true;
            this.valorlabel.Location = new System.Drawing.Point(95, 197);
            this.valorlabel.Name = "valorlabel";
            this.valorlabel.Size = new System.Drawing.Size(104, 13);
            this.valorlabel.TabIndex = 1;
            this.valorlabel.Text = "VALORDACOMPRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "VALOR";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "MÓDULO";
            // 
            // btnPrint
            // 
            this.btnPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(12, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(51, 47);
            this.btnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPrint.TabIndex = 2;
            this.btnPrint.TabStop = false;
            this.btnPrint.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pont_Finder.Properties.Resources.images;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(543, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Image = global::Pont_Finder.Properties.Resources.downblue;
            this.btnSalvar.Location = new System.Drawing.Point(12, 110);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(51, 47);
            this.btnSalvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pont_Finder.Properties.Resources.codigodebarra_810x446;
            this.pictureBox1.Location = new System.Drawing.Point(111, 561);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1025, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GerarBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.boletoA);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerarBoleto";
            this.Text = "GerarBoleto";
            this.Load += new System.EventHandler(this.GerarBoleto_Load);
            this.boletoA.ResumeLayout(false);
            this.boletoA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boletoA;
        private System.Windows.Forms.PictureBox btnPrint;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label cpflabel;
        private System.Windows.Forms.PictureBox btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label valorlabel;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}