
namespace WindowsFormsApp2
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
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtrong = new System.Windows.Forms.TextBox();
            this.txtdai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.botton2 = new System.Windows.Forms.Button();
            this.txtcv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(182, 265);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(116, 20);
            this.txtdt.TabIndex = 0;
            this.txtdt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtrong
            // 
            this.txtrong.Location = new System.Drawing.Point(182, 150);
            this.txtrong.Name = "txtrong";
            this.txtrong.Size = new System.Drawing.Size(116, 20);
            this.txtrong.TabIndex = 1;
            this.txtrong.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdai
            // 
            this.txtdai.Location = new System.Drawing.Point(182, 103);
            this.txtdai.Name = "txtdai";
            this.txtdai.Size = new System.Drawing.Size(116, 20);
            this.txtdai.TabIndex = 2;
            this.txtdai.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chieu Dai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chieu Rong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = " Tinh Dien tich";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // botton2
            // 
            this.botton2.Location = new System.Drawing.Point(29, 307);
            this.botton2.Name = "botton2";
            this.botton2.Size = new System.Drawing.Size(108, 23);
            this.botton2.TabIndex = 6;
            this.botton2.Text = " Tinh Chu vi";
            this.botton2.UseVisualStyleBackColor = true;
            this.botton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(182, 307);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(116, 20);
            this.txtcv.TabIndex = 0;
            this.txtcv.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.botton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdai);
            this.Controls.Add(this.txtrong);
            this.Controls.Add(this.txtcv);
            this.Controls.Add(this.txtdt);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "TInh dien tich";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txtrong;
        private System.Windows.Forms.TextBox txtdai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botton2;
        private System.Windows.Forms.TextBox txtcv;
    }
}

