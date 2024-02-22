namespace uygulama_16
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtTurkeceDogru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatematikDogru = new System.Windows.Forms.TextBox();
            this.txtTurkeceYanlıs = new System.Windows.Forms.TextBox();
            this.txtMatematikYanlıs = new System.Windows.Forms.TextBox();
            this.txtTurkeceNet = new System.Windows.Forms.TextBox();
            this.txtMatematikNet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "doğru";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(146, 208);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(161, 42);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTurkeceDogru
            // 
            this.txtTurkeceDogru.Location = new System.Drawing.Point(122, 98);
            this.txtTurkeceDogru.Name = "txtTurkeceDogru";
            this.txtTurkeceDogru.Size = new System.Drawing.Size(25, 20);
            this.txtTurkeceDogru.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "türkçe (40)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "matematik(40)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "yanlış";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "net";
            // 
            // txtMatematikDogru
            // 
            this.txtMatematikDogru.Location = new System.Drawing.Point(122, 148);
            this.txtMatematikDogru.Name = "txtMatematikDogru";
            this.txtMatematikDogru.Size = new System.Drawing.Size(25, 20);
            this.txtMatematikDogru.TabIndex = 12;
            // 
            // txtTurkeceYanlıs
            // 
            this.txtTurkeceYanlıs.Location = new System.Drawing.Point(203, 98);
            this.txtTurkeceYanlıs.Name = "txtTurkeceYanlıs";
            this.txtTurkeceYanlıs.Size = new System.Drawing.Size(25, 20);
            this.txtTurkeceYanlıs.TabIndex = 13;
            // 
            // txtMatematikYanlıs
            // 
            this.txtMatematikYanlıs.Location = new System.Drawing.Point(203, 148);
            this.txtMatematikYanlıs.Name = "txtMatematikYanlıs";
            this.txtMatematikYanlıs.Size = new System.Drawing.Size(25, 20);
            this.txtMatematikYanlıs.TabIndex = 14;
            // 
            // txtTurkeceNet
            // 
            this.txtTurkeceNet.Location = new System.Drawing.Point(282, 98);
            this.txtTurkeceNet.Name = "txtTurkeceNet";
            this.txtTurkeceNet.Size = new System.Drawing.Size(25, 20);
            this.txtTurkeceNet.TabIndex = 15;
            // 
            // txtMatematikNet
            // 
            this.txtMatematikNet.Location = new System.Drawing.Point(282, 148);
            this.txtMatematikNet.Name = "txtMatematikNet";
            this.txtMatematikNet.Size = new System.Drawing.Size(25, 20);
            this.txtMatematikNet.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.txtMatematikNet);
            this.Controls.Add(this.txtTurkeceNet);
            this.Controls.Add(this.txtMatematikYanlıs);
            this.Controls.Add(this.txtTurkeceYanlıs);
            this.Controls.Add(this.txtMatematikDogru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTurkeceDogru);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtTurkeceDogru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatematikDogru;
        private System.Windows.Forms.TextBox txtTurkeceYanlıs;
        private System.Windows.Forms.TextBox txtMatematikYanlıs;
        private System.Windows.Forms.TextBox txtTurkeceNet;
        private System.Windows.Forms.TextBox txtMatematikNet;
    }
}

