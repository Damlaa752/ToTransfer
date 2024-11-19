namespace ToTransfer
{
    partial class Form1
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
            this.rchSQL = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rchTransfer = new System.Windows.Forms.RichTextBox();
            this.btnDonustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchSQL
            // 
            this.rchSQL.Location = new System.Drawing.Point(14, 61);
            this.rchSQL.Name = "rchSQL";
            this.rchSQL.Size = new System.Drawing.Size(891, 791);
            this.rchSQL.TabIndex = 0;
            this.rchSQL.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Kod Bloğu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(966, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Alan :";
            // 
            // rchTransfer
            // 
            this.rchTransfer.Location = new System.Drawing.Point(961, 58);
            this.rchTransfer.Name = "rchTransfer";
            this.rchTransfer.Size = new System.Drawing.Size(871, 794);
            this.rchTransfer.TabIndex = 3;
            this.rchTransfer.Text = "";
            // 
            // btnDonustur
            // 
            this.btnDonustur.Location = new System.Drawing.Point(721, 896);
            this.btnDonustur.Name = "btnDonustur";
            this.btnDonustur.Size = new System.Drawing.Size(158, 52);
            this.btnDonustur.TabIndex = 4;
            this.btnDonustur.Text = "Dönüştür";
            this.btnDonustur.UseVisualStyleBackColor = true;
            this.btnDonustur.Click += new System.EventHandler(this.btnDonustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 989);
            this.Controls.Add(this.btnDonustur);
            this.Controls.Add(this.rchTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchSQL);
            this.Name = "Form1";
            this.Text = "BTİ SQL KOD DÜZENLEYİCİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchTransfer;
        private System.Windows.Forms.Button btnDonustur;
    }
}

