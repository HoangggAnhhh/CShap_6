namespace CShap_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHKI = new System.Windows.Forms.TextBox();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.txtHKII = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.label1.Location = new System.Drawing.Point(409, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết Quả Học Tập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(209, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "HKI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(209, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "HKII";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(212, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm Trung Bình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(215, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kết Quả";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label6.Location = new System.Drawing.Point(218, 525);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Xếp Loại Học Lực";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.Location = new System.Drawing.Point(506, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xem Kết Quả";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtHKI
            // 
            this.txtHKI.Location = new System.Drawing.Point(451, 223);
            this.txtHKI.Name = "txtHKI";
            this.txtHKI.Size = new System.Drawing.Size(412, 20);
            this.txtHKI.TabIndex = 7;
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(451, 363);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(412, 20);
            this.txtdtb.TabIndex = 8;
            // 
            // txtHKII
            // 
            this.txtHKII.Location = new System.Drawing.Point(451, 287);
            this.txtHKII.Name = "txtHKII";
            this.txtHKII.Size = new System.Drawing.Size(412, 20);
            this.txtHKII.TabIndex = 9;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(451, 446);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(412, 20);
            this.txtkq.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(451, 536);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(412, 20);
            this.textBox5.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 783);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txtHKII);
            this.Controls.Add(this.txtdtb);
            this.Controls.Add(this.txtHKI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bảng Điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHKI;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.TextBox txtHKII;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.TextBox textBox5;
    }
}

