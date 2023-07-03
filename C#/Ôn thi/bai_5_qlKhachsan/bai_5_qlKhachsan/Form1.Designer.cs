
namespace bai_5_qlKhachsan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.internet = new System.Windows.Forms.CheckBox();
            this.giatla = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nuocloc = new System.Windows.Forms.CheckBox();
            this.nuockhoang = new System.Windows.Forms.CheckBox();
            this.Result = new System.Windows.Forms.ListBox();
            this.close = new System.Windows.Forms.Button();
            this.tinhtien = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhan vien";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Le Trung Hieu",
            "Xi Muoi",
            "Son Duy"});
            this.comboBox1.Location = new System.Drawing.Point(120, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(217, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngay den";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.internet);
            this.groupBox1.Controls.Add(this.giatla);
            this.groupBox1.Location = new System.Drawing.Point(37, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // internet
            // 
            this.internet.AutoSize = true;
            this.internet.Location = new System.Drawing.Point(6, 60);
            this.internet.Name = "internet";
            this.internet.Size = new System.Drawing.Size(67, 19);
            this.internet.TabIndex = 6;
            this.internet.Text = "Internet";
            this.internet.UseVisualStyleBackColor = true;
            // 
            // giatla
            // 
            this.giatla.AutoSize = true;
            this.giatla.Location = new System.Drawing.Point(6, 22);
            this.giatla.Name = "giatla";
            this.giatla.Size = new System.Drawing.Size(59, 19);
            this.giatla.TabIndex = 6;
            this.giatla.Text = "Giat la";
            this.giatla.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.nuocloc);
            this.groupBox2.Controls.Add(this.nuockhoang);
            this.groupBox2.Location = new System.Drawing.Point(37, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "So luong";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nuocloc
            // 
            this.nuocloc.AutoSize = true;
            this.nuocloc.Location = new System.Drawing.Point(6, 70);
            this.nuocloc.Name = "nuocloc";
            this.nuocloc.Size = new System.Drawing.Size(74, 19);
            this.nuocloc.TabIndex = 6;
            this.nuocloc.Text = "Nuoc loc";
            this.nuocloc.UseVisualStyleBackColor = true;
            this.nuocloc.CheckedChanged += new System.EventHandler(this.nuocloc_CheckedChanged);
            // 
            // nuockhoang
            // 
            this.nuockhoang.AutoSize = true;
            this.nuockhoang.Location = new System.Drawing.Point(6, 32);
            this.nuockhoang.Name = "nuockhoang";
            this.nuockhoang.Size = new System.Drawing.Size(98, 19);
            this.nuockhoang.TabIndex = 6;
            this.nuockhoang.Text = "Nuoc khoang";
            this.nuockhoang.UseVisualStyleBackColor = true;
            this.nuockhoang.CheckedChanged += new System.EventHandler(this.nuockhoang_CheckedChanged);
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 15;
            this.Result.Location = new System.Drawing.Point(299, 126);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(213, 244);
            this.Result.TabIndex = 6;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(428, 376);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 36);
            this.close.TabIndex = 7;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // tinhtien
            // 
            this.tinhtien.Location = new System.Drawing.Point(230, 176);
            this.tinhtien.Name = "tinhtien";
            this.tinhtien.Size = new System.Drawing.Size(63, 26);
            this.tinhtien.TabIndex = 8;
            this.tinhtien.Text = "Tinh tien";
            this.tinhtien.UseVisualStyleBackColor = true;
            this.tinhtien.Click += new System.EventHandler(this.tinhtien_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(230, 217);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(63, 29);
            this.clear.TabIndex = 9;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ngay di";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(119, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(218, 23);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.Value = new System.DateTime(2021, 6, 17, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 424);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.tinhtien);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox internet;
        private System.Windows.Forms.CheckBox giatla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox nuocloc;
        private System.Windows.Forms.CheckBox nuockhoang;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button tinhtien;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

