
namespace PDFSayfaSayisi
{
    partial class PDFSayfa
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGozat = new System.Windows.Forms.Button();
            this.TextDizin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sayfa Sayısı:";
            // 
            // BtnGozat
            // 
            this.BtnGozat.Location = new System.Drawing.Point(436, 11);
            this.BtnGozat.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGozat.Name = "BtnGozat";
            this.BtnGozat.Size = new System.Drawing.Size(93, 29);
            this.BtnGozat.TabIndex = 10;
            this.BtnGozat.Text = "... Gözat";
            this.BtnGozat.UseVisualStyleBackColor = true;
            this.BtnGozat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnGozat_MouseClick);
            // 
            // TextDizin
            // 
            this.TextDizin.Location = new System.Drawing.Point(13, 13);
            this.TextDizin.Margin = new System.Windows.Forms.Padding(4);
            this.TextDizin.Name = "TextDizin";
            this.TextDizin.Size = new System.Drawing.Size(415, 27);
            this.TextDizin.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(13, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 7;
            // 
            // PDFSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 113);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGozat);
            this.Controls.Add(this.TextDizin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PDFSayfa";
            this.Text = "PDF Sayfa Sayısı Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGozat;
        private System.Windows.Forms.TextBox TextDizin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

