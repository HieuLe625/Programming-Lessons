
namespace Đồ_uống_đồ_ăn
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
            this.cbsuada = new System.Windows.Forms.CheckBox();
            this.cbd = new System.Windows.Forms.CheckBox();
            this.cbdua = new System.Windows.Forms.CheckBox();
            this.cboi = new System.Windows.Forms.CheckBox();
            this.cbhoaqua = new System.Windows.Forms.CheckBox();
            this.cbdanhda = new System.Windows.Forms.CheckBox();
            this.cbchanh = new System.Windows.Forms.CheckBox();
            this.Services = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.soluong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.khachthuong = new System.Windows.Forms.RadioButton();
            this.VIP = new System.Windows.Forms.RadioButton();
            this.Sinhvien = new System.Windows.Forms.RadioButton();
            this.nhanvien = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.ngaythang = new System.Windows.Forms.Label();
            this.tenkhach = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Result = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Tinhtien = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.Services.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbsuada
            // 
            this.cbsuada.AutoSize = true;
            this.cbsuada.Location = new System.Drawing.Point(6, 36);
            this.cbsuada.Name = "cbsuada";
            this.cbsuada.Size = new System.Drawing.Size(151, 29);
            this.cbsuada.TabIndex = 0;
            this.cbsuada.Text = "Cafe sữa đá";
            this.cbsuada.UseVisualStyleBackColor = true;
            this.cbsuada.CheckedChanged += new System.EventHandler(this.cbsuada_CheckedChanged);
            // 
            // cbd
            // 
            this.cbd.AutoSize = true;
            this.cbd.Location = new System.Drawing.Point(6, 71);
            this.cbd.Name = "cbd";
            this.cbd.Size = new System.Drawing.Size(122, 29);
            this.cbd.TabIndex = 0;
            this.cbd.Text = "Cafe đen";
            this.cbd.UseVisualStyleBackColor = true;
            this.cbd.CheckedChanged += new System.EventHandler(this.cbd_CheckedChanged);
            // 
            // cbdua
            // 
            this.cbdua.AutoSize = true;
            this.cbdua.Location = new System.Drawing.Point(6, 106);
            this.cbdua.Name = "cbdua";
            this.cbdua.Size = new System.Drawing.Size(156, 29);
            this.cbdua.TabIndex = 0;
            this.cbdua.Text = "Nước ép dứa";
            this.cbdua.UseVisualStyleBackColor = true;
            this.cbdua.CheckedChanged += new System.EventHandler(this.cbdua_CheckedChanged);
            // 
            // cboi
            // 
            this.cboi.AutoSize = true;
            this.cboi.Location = new System.Drawing.Point(6, 141);
            this.cboi.Name = "cboi";
            this.cboi.Size = new System.Drawing.Size(137, 29);
            this.cboi.TabIndex = 0;
            this.cboi.Text = "Nước ép ổi";
            this.cboi.UseVisualStyleBackColor = true;
            this.cboi.CheckedChanged += new System.EventHandler(this.cboi_CheckedChanged);
            // 
            // cbhoaqua
            // 
            this.cbhoaqua.AutoSize = true;
            this.cbhoaqua.Location = new System.Drawing.Point(6, 176);
            this.cbhoaqua.Name = "cbhoaqua";
            this.cbhoaqua.Size = new System.Drawing.Size(162, 29);
            this.cbhoaqua.TabIndex = 0;
            this.cbhoaqua.Text = "Hoa quả dầm";
            this.cbhoaqua.UseVisualStyleBackColor = true;
            this.cbhoaqua.CheckedChanged += new System.EventHandler(this.cbhoaqua_CheckedChanged);
            // 
            // cbdanhda
            // 
            this.cbdanhda.AutoSize = true;
            this.cbdanhda.Location = new System.Drawing.Point(6, 211);
            this.cbdanhda.Name = "cbdanhda";
            this.cbdanhda.Size = new System.Drawing.Size(210, 29);
            this.cbdanhda.TabIndex = 0;
            this.cbdanhda.Text = "Sữa chua đánh đá";
            this.cbdanhda.UseVisualStyleBackColor = true;
            this.cbdanhda.CheckedChanged += new System.EventHandler(this.cbdanhda_CheckedChanged);
            // 
            // cbchanh
            // 
            this.cbchanh.AutoSize = true;
            this.cbchanh.Location = new System.Drawing.Point(6, 246);
            this.cbchanh.Name = "cbchanh";
            this.cbchanh.Size = new System.Drawing.Size(132, 29);
            this.cbchanh.TabIndex = 0;
            this.cbchanh.Text = "Trà chanh";
            this.cbchanh.UseVisualStyleBackColor = true;
            this.cbchanh.CheckedChanged += new System.EventHandler(this.cbchanh_CheckedChanged);
            // 
            // Services
            // 
            this.Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Services.Controls.Add(this.textBox7);
            this.Services.Controls.Add(this.textBox6);
            this.Services.Controls.Add(this.textBox5);
            this.Services.Controls.Add(this.textBox4);
            this.Services.Controls.Add(this.textBox3);
            this.Services.Controls.Add(this.textBox2);
            this.Services.Controls.Add(this.text1);
            this.Services.Controls.Add(this.soluong);
            this.Services.Controls.Add(this.cbsuada);
            this.Services.Controls.Add(this.cbchanh);
            this.Services.Controls.Add(this.cbd);
            this.Services.Controls.Add(this.cbdanhda);
            this.Services.Controls.Add(this.cbdua);
            this.Services.Controls.Add(this.cbhoaqua);
            this.Services.Controls.Add(this.cboi);
            this.Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Location = new System.Drawing.Point(28, 217);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(415, 528);
            this.Services.TabIndex = 1;
            this.Services.TabStop = false;
            this.Services.Text = "ĐỒ UỐNG";
            this.Services.Enter += new System.EventHandler(this.Services_Enter);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(283, 244);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(21, 30);
            this.textBox7.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(283, 209);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(21, 30);
            this.textBox6.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(283, 174);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(21, 30);
            this.textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(283, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(21, 30);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(283, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(21, 30);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(21, 30);
            this.textBox2.TabIndex = 2;
            // 
            // text1
            // 
            this.text1.ForeColor = System.Drawing.Color.Black;
            this.text1.Location = new System.Drawing.Point(283, 34);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(21, 30);
            this.text1.TabIndex = 2;
            // 
            // soluong
            // 
            this.soluong.AutoSize = true;
            this.soluong.Location = new System.Drawing.Point(246, 0);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(98, 25);
            this.soluong.TabIndex = 1;
            this.soluong.Text = "Số lượng";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.khachthuong);
            this.groupBox1.Controls.Add(this.VIP);
            this.groupBox1.Controls.Add(this.Sinhvien);
            this.groupBox1.Controls.Add(this.nhanvien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(472, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 360);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ĐỐI TƯỢNG";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // khachthuong
            // 
            this.khachthuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.khachthuong.AutoSize = true;
            this.khachthuong.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khachthuong.Location = new System.Drawing.Point(11, 85);
            this.khachthuong.Name = "khachthuong";
            this.khachthuong.Size = new System.Drawing.Size(183, 29);
            this.khachthuong.TabIndex = 1;
            this.khachthuong.TabStop = true;
            this.khachthuong.Text = "KHÁCH THƯỜNG";
            this.khachthuong.UseVisualStyleBackColor = true;
            // 
            // VIP
            // 
            this.VIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VIP.AutoSize = true;
            this.VIP.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIP.Location = new System.Drawing.Point(11, 59);
            this.VIP.Name = "VIP";
            this.VIP.Size = new System.Drawing.Size(116, 29);
            this.VIP.TabIndex = 1;
            this.VIP.TabStop = true;
            this.VIP.Text = "VIP (10%)";
            this.VIP.UseVisualStyleBackColor = true;
            // 
            // Sinhvien
            // 
            this.Sinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sinhvien.AutoSize = true;
            this.Sinhvien.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sinhvien.Location = new System.Drawing.Point(11, 32);
            this.Sinhvien.Name = "Sinhvien";
            this.Sinhvien.Size = new System.Drawing.Size(180, 29);
            this.Sinhvien.TabIndex = 0;
            this.Sinhvien.TabStop = true;
            this.Sinhvien.Text = "SINH VIÊN (20%)";
            this.Sinhvien.UseVisualStyleBackColor = true;
            this.Sinhvien.CheckedChanged += new System.EventHandler(this.Sinhvien_CheckedChanged);
            // 
            // nhanvien
            // 
            this.nhanvien.AutoSize = true;
            this.nhanvien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nhanvien.Location = new System.Drawing.Point(161, 152);
            this.nhanvien.Name = "nhanvien";
            this.nhanvien.Size = new System.Drawing.Size(58, 27);
            this.nhanvien.TabIndex = 9;
            this.nhanvien.Text = "BILL";
            this.nhanvien.Click += new System.EventHandler(this.nhanvien_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(172, 101);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(200, 22);
            this.time.TabIndex = 4;
            // 
            // ngaythang
            // 
            this.ngaythang.AutoSize = true;
            this.ngaythang.Location = new System.Drawing.Point(20, 101);
            this.ngaythang.Name = "ngaythang";
            this.ngaythang.Size = new System.Drawing.Size(119, 17);
            this.ngaythang.TabIndex = 9;
            this.ngaythang.Text = "Ngày/Tháng/Năm";
            this.ngaythang.Click += new System.EventHandler(this.ngaythang_Click);
            // 
            // tenkhach
            // 
            this.tenkhach.AutoSize = true;
            this.tenkhach.Location = new System.Drawing.Point(20, 154);
            this.tenkhach.Name = "tenkhach";
            this.tenkhach.Size = new System.Drawing.Size(111, 17);
            this.tenkhach.TabIndex = 9;
            this.tenkhach.Text = "Tên khách hàng";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(172, 154);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 22);
            this.textBox8.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bùi Hữu Phước",
            "Trần Văn Vương",
            "Lê Thị Thúy Nga"});
            this.comboBox1.Location = new System.Drawing.Point(173, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.HideSelection = false;
            this.Result.Location = new System.Drawing.Point(472, 211);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(356, 403);
            this.Result.TabIndex = 13;
            this.Result.UseCompatibleStateImageBehavior = false;
            this.Result.View = System.Windows.Forms.View.List;
            this.Result.SelectedIndexChanged += new System.EventHandler(this.Result_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên nhân viên";
            this.label1.Click += new System.EventHandler(this.ngaythang_Click);
            // 
            // Tinhtien
            // 
            this.Tinhtien.Location = new System.Drawing.Point(472, 634);
            this.Tinhtien.Name = "Tinhtien";
            this.Tinhtien.Size = new System.Drawing.Size(75, 23);
            this.Tinhtien.TabIndex = 14;
            this.Tinhtien.Text = "Tính tiền";
            this.Tinhtien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Tinhtien.UseVisualStyleBackColor = true;
            this.Tinhtien.Click += new System.EventHandler(this.Tinhtien_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(753, 634);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 14;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 751);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.Tinhtien);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.tenkhach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ngaythang);
            this.Controls.Add(this.time);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Services);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbsuada;
        private System.Windows.Forms.CheckBox cbd;
        private System.Windows.Forms.CheckBox cbdua;
        private System.Windows.Forms.CheckBox cboi;
        private System.Windows.Forms.CheckBox cbhoaqua;
        private System.Windows.Forms.CheckBox cbdanhda;
        private System.Windows.Forms.CheckBox cbchanh;
        private System.Windows.Forms.GroupBox Services;
        private System.Windows.Forms.Label soluong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton khachthuong;
        private System.Windows.Forms.RadioButton VIP;
        private System.Windows.Forms.RadioButton Sinhvien;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label ngaythang;
        private System.Windows.Forms.Label tenkhach;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label nhanvien;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Tinhtien;
        private System.Windows.Forms.Button thoat;
    }
}

