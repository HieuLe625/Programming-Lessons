
namespace De1_cau2
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tenkhach = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sinhto = new System.Windows.Forms.CheckBox();
            this.juice = new System.Windows.Forms.CheckBox();
            this.trasua = new System.Windows.Forms.CheckBox();
            this.cafe = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.student = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.ListBox();
            this.tinhtien = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người bán hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bán Hàng";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Le Trung Hieu",
            "Kalz",
            "Ukiyo",
            "Umeko"});
            this.comboBox1.Location = new System.Drawing.Point(111, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ten khách hàng";
            // 
            // tenkhach
            // 
            this.tenkhach.Location = new System.Drawing.Point(111, 136);
            this.tenkhach.Name = "tenkhach";
            this.tenkhach.Size = new System.Drawing.Size(234, 23);
            this.tenkhach.TabIndex = 5;
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.textBox5);
            this.Menu.Controls.Add(this.textBox4);
            this.Menu.Controls.Add(this.textBox3);
            this.Menu.Controls.Add(this.textBox2);
            this.Menu.Controls.Add(this.label4);
            this.Menu.Controls.Add(this.sinhto);
            this.Menu.Controls.Add(this.juice);
            this.Menu.Controls.Add(this.trasua);
            this.Menu.Controls.Add(this.cafe);
            this.Menu.Location = new System.Drawing.Point(53, 200);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(219, 197);
            this.Menu.TabIndex = 6;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 150);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(26, 23);
            this.textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(158, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(26, 23);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(26, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 23);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "So luong";
            // 
            // sinhto
            // 
            this.sinhto.AutoSize = true;
            this.sinhto.Location = new System.Drawing.Point(6, 154);
            this.sinhto.Name = "sinhto";
            this.sinhto.Size = new System.Drawing.Size(63, 19);
            this.sinhto.TabIndex = 7;
            this.sinhto.Text = "Sinh to";
            this.sinhto.UseVisualStyleBackColor = true;
            this.sinhto.CheckedChanged += new System.EventHandler(this.sinhto_CheckedChanged);
            // 
            // juice
            // 
            this.juice.AutoSize = true;
            this.juice.Location = new System.Drawing.Point(6, 114);
            this.juice.Name = "juice";
            this.juice.Size = new System.Drawing.Size(112, 19);
            this.juice.TabIndex = 2;
            this.juice.Text = "Nuoc ep trai cay";
            this.juice.UseVisualStyleBackColor = true;
            this.juice.CheckedChanged += new System.EventHandler(this.juice_CheckedChanged);
            // 
            // trasua
            // 
            this.trasua.AutoSize = true;
            this.trasua.Location = new System.Drawing.Point(6, 74);
            this.trasua.Name = "trasua";
            this.trasua.Size = new System.Drawing.Size(62, 19);
            this.trasua.TabIndex = 1;
            this.trasua.Text = "Tra sua";
            this.trasua.UseVisualStyleBackColor = true;
            this.trasua.CheckedChanged += new System.EventHandler(this.trasua_CheckedChanged);
            // 
            // cafe
            // 
            this.cafe.AutoSize = true;
            this.cafe.Location = new System.Drawing.Point(6, 34);
            this.cafe.Name = "cafe";
            this.cafe.Size = new System.Drawing.Size(50, 19);
            this.cafe.TabIndex = 0;
            this.cafe.Text = "Cafe";
            this.cafe.UseVisualStyleBackColor = true;
            this.cafe.CheckedChanged += new System.EventHandler(this.cafe_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.student);
            this.groupBox1.Controls.Add(this.normal);
            this.groupBox1.Location = new System.Drawing.Point(427, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 102);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests";
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Location = new System.Drawing.Point(13, 65);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(73, 19);
            this.student.TabIndex = 1;
            this.student.TabStop = true;
            this.student.Text = "Sinh viên";
            this.student.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Location = new System.Drawing.Point(13, 22);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(100, 19);
            this.normal.TabIndex = 0;
            this.normal.TabStop = true;
            this.normal.Text = "Khách thường";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.FormattingEnabled = true;
            this.result.ItemHeight = 15;
            this.result.Location = new System.Drawing.Point(402, 162);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(214, 229);
            this.result.TabIndex = 8;
            // 
            // tinhtien
            // 
            this.tinhtien.Location = new System.Drawing.Point(308, 200);
            this.tinhtien.Name = "tinhtien";
            this.tinhtien.Size = new System.Drawing.Size(70, 28);
            this.tinhtien.TabIndex = 9;
            this.tinhtien.Text = "Tính tiền";
            this.tinhtien.UseVisualStyleBackColor = true;
            this.tinhtien.Click += new System.EventHandler(this.tinhtien_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bill";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(308, 243);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(70, 29);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(559, 397);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 41);
            this.close.TabIndex = 12;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tinhtien);
            this.Controls.Add(this.result);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.tenkhach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hieu Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenkhach;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox sinhto;
        private System.Windows.Forms.CheckBox juice;
        private System.Windows.Forms.CheckBox trasua;
        private System.Windows.Forms.CheckBox cafe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton student;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.ListBox result;
        private System.Windows.Forms.Button tinhtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button close;
    }
}

