
namespace Restaurant
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
            this.label3 = new System.Windows.Forms.Label();
            this.tenkhach = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lemontea = new System.Windows.Forms.CheckBox();
            this.suachua = new System.Windows.Forms.CheckBox();
            this.hoaquadam = new System.Windows.Forms.CheckBox();
            this.oijuice = new System.Windows.Forms.CheckBox();
            this.duajuice = new System.Windows.Forms.CheckBox();
            this.cafeden = new System.Windows.Forms.CheckBox();
            this.cafesuada = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vip = new System.Windows.Forms.RadioButton();
            this.sinhvien = new System.Windows.Forms.RadioButton();
            this.tinhtien = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.normal = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày bán hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên khách Hàng";
            // 
            // tenkhach
            // 
            this.tenkhach.Location = new System.Drawing.Point(144, 92);
            this.tenkhach.Name = "tenkhach";
            this.tenkhach.Size = new System.Drawing.Size(227, 23);
            this.tenkhach.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.FormattingEnabled = true;
            this.Result.ItemHeight = 15;
            this.Result.Location = new System.Drawing.Point(454, 148);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(258, 244);
            this.Result.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lê Trung Hiếu",
            "Lê Thúy Nga",
            "Sơn Duy",
            "Thành Nam"});
            this.comboBox1.Location = new System.Drawing.Point(144, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(-195, 216);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 19);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lemontea);
            this.groupBox1.Controls.Add(this.suachua);
            this.groupBox1.Controls.Add(this.hoaquadam);
            this.groupBox1.Controls.Add(this.oijuice);
            this.groupBox1.Controls.Add(this.duajuice);
            this.groupBox1.Controls.Add(this.cafeden);
            this.groupBox1.Controls.Add(this.cafesuada);
            this.groupBox1.Location = new System.Drawing.Point(19, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 269);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // lemontea
            // 
            this.lemontea.AutoSize = true;
            this.lemontea.Location = new System.Drawing.Point(16, 229);
            this.lemontea.Name = "lemontea";
            this.lemontea.Size = new System.Drawing.Size(77, 19);
            this.lemontea.TabIndex = 6;
            this.lemontea.Text = "Trà chanh";
            this.lemontea.UseVisualStyleBackColor = true;
            this.lemontea.CheckedChanged += new System.EventHandler(this.lemontea_CheckedChanged);
            // 
            // suachua
            // 
            this.suachua.AutoSize = true;
            this.suachua.Location = new System.Drawing.Point(16, 194);
            this.suachua.Name = "suachua";
            this.suachua.Size = new System.Drawing.Size(120, 19);
            this.suachua.TabIndex = 5;
            this.suachua.Text = "Sữa chua đánh đá";
            this.suachua.UseVisualStyleBackColor = true;
            this.suachua.CheckedChanged += new System.EventHandler(this.suachua_CheckedChanged);
            // 
            // hoaquadam
            // 
            this.hoaquadam.AutoSize = true;
            this.hoaquadam.Location = new System.Drawing.Point(15, 160);
            this.hoaquadam.Name = "hoaquadam";
            this.hoaquadam.Size = new System.Drawing.Size(98, 19);
            this.hoaquadam.TabIndex = 4;
            this.hoaquadam.Text = "Hoa quả dầm";
            this.hoaquadam.UseVisualStyleBackColor = true;
            this.hoaquadam.CheckedChanged += new System.EventHandler(this.hoaquadam_CheckedChanged);
            // 
            // oijuice
            // 
            this.oijuice.AutoSize = true;
            this.oijuice.Location = new System.Drawing.Point(15, 126);
            this.oijuice.Name = "oijuice";
            this.oijuice.Size = new System.Drawing.Size(84, 19);
            this.oijuice.TabIndex = 3;
            this.oijuice.Text = "Nước ép ổi";
            this.oijuice.UseVisualStyleBackColor = true;
            this.oijuice.CheckedChanged += new System.EventHandler(this.oijuice_CheckedChanged);
            // 
            // duajuice
            // 
            this.duajuice.AutoSize = true;
            this.duajuice.Location = new System.Drawing.Point(15, 92);
            this.duajuice.Name = "duajuice";
            this.duajuice.Size = new System.Drawing.Size(94, 19);
            this.duajuice.TabIndex = 2;
            this.duajuice.Text = "Nước ép dứa";
            this.duajuice.UseVisualStyleBackColor = true;
            this.duajuice.CheckedChanged += new System.EventHandler(this.duajuice_CheckedChanged);
            // 
            // cafeden
            // 
            this.cafeden.AutoSize = true;
            this.cafeden.Location = new System.Drawing.Point(15, 57);
            this.cafeden.Name = "cafeden";
            this.cafeden.Size = new System.Drawing.Size(73, 19);
            this.cafeden.TabIndex = 1;
            this.cafeden.Text = "Cafe đen";
            this.cafeden.UseVisualStyleBackColor = true;
            this.cafeden.CheckedChanged += new System.EventHandler(this.cafeden_CheckedChanged);
            // 
            // cafesuada
            // 
            this.cafesuada.AutoSize = true;
            this.cafesuada.Location = new System.Drawing.Point(16, 24);
            this.cafesuada.Name = "cafesuada";
            this.cafesuada.Size = new System.Drawing.Size(87, 19);
            this.cafesuada.TabIndex = 0;
            this.cafesuada.Text = "Cafe sữa đá";
            this.cafesuada.UseVisualStyleBackColor = true;
            this.cafesuada.CheckedChanged += new System.EventHandler(this.cafesuada_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(249, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(68, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(16, 229);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(35, 23);
            this.textBox8.TabIndex = 0;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(16, 194);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(35, 23);
            this.textBox7.TabIndex = 0;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(16, 160);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(35, 23);
            this.textBox6.TabIndex = 0;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(16, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(35, 23);
            this.textBox5.TabIndex = 0;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 92);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(35, 23);
            this.textBox4.TabIndex = 0;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 23);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 23);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.normal);
            this.groupBox3.Controls.Add(this.vip);
            this.groupBox3.Controls.Add(this.sinhvien);
            this.groupBox3.Location = new System.Drawing.Point(454, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 107);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guest";
            // 
            // vip
            // 
            this.vip.AutoSize = true;
            this.vip.Location = new System.Drawing.Point(20, 73);
            this.vip.Name = "vip";
            this.vip.Size = new System.Drawing.Size(99, 19);
            this.vip.TabIndex = 0;
            this.vip.TabStop = true;
            this.vip.Text = "VIP (Sale 10%)";
            this.vip.UseVisualStyleBackColor = true;
            this.vip.CheckedChanged += new System.EventHandler(this.vip_CheckedChanged);
            // 
            // sinhvien
            // 
            this.sinhvien.AutoSize = true;
            this.sinhvien.Location = new System.Drawing.Point(20, 43);
            this.sinhvien.Name = "sinhvien";
            this.sinhvien.Size = new System.Drawing.Size(130, 19);
            this.sinhvien.TabIndex = 0;
            this.sinhvien.TabStop = true;
            this.sinhvien.Text = "Sinh viên (Sale 20%)";
            this.sinhvien.UseVisualStyleBackColor = true;
            this.sinhvien.CheckedChanged += new System.EventHandler(this.sinhvien_CheckedChanged);
            // 
            // tinhtien
            // 
            this.tinhtien.Location = new System.Drawing.Point(354, 171);
            this.tinhtien.Name = "tinhtien";
            this.tinhtien.Size = new System.Drawing.Size(78, 27);
            this.tinhtien.TabIndex = 9;
            this.tinhtien.Text = "Tính tiền";
            this.tinhtien.UseVisualStyleBackColor = true;
            this.tinhtien.Click += new System.EventHandler(this.tinhtien_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(354, 213);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(78, 27);
            this.reset.TabIndex = 9;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(655, 398);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(85, 40);
            this.close.TabIndex = 9;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bill";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(353, 257);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(79, 26);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear All";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Location = new System.Drawing.Point(20, 16);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(65, 19);
            this.normal.TabIndex = 1;
            this.normal.TabStop = true;
            this.normal.Text = "Normal";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.close);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.tinhtien);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.tenkhach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AI QUÁN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenkhach;
        private System.Windows.Forms.ListBox Result;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton vip;
        private System.Windows.Forms.RadioButton sinhvien;
        private System.Windows.Forms.Button tinhtien;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cafeden;
        private System.Windows.Forms.CheckBox cafesuada;
        private System.Windows.Forms.CheckBox suachua;
        private System.Windows.Forms.CheckBox hoaquadam;
        private System.Windows.Forms.CheckBox oijuice;
        private System.Windows.Forms.CheckBox duajuice;
        private System.Windows.Forms.CheckBox lemontea;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RadioButton normal;
    }
}

