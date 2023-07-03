namespace Quản_lý_khách_sạn_application
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
            this.ComeDay = new System.Windows.Forms.DateTimePicker();
            this.LeaveDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DoubleRoom = new System.Windows.Forms.RadioButton();
            this.SingleRoom = new System.Windows.Forms.RadioButton();
            this.Services = new System.Windows.Forms.GroupBox();
            this.Laundry = new System.Windows.Forms.CheckBox();
            this.Internet = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckOut = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.CloseB = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Services.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đến";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày đi";
            // 
            // ComeDay
            // 
            this.ComeDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComeDay.Location = new System.Drawing.Point(77, 24);
            this.ComeDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComeDay.Name = "ComeDay";
            this.ComeDay.Size = new System.Drawing.Size(276, 26);
            this.ComeDay.TabIndex = 4;
            this.ComeDay.ValueChanged += new System.EventHandler(this.ComeDay_ValueChanged);
            // 
            // LeaveDay
            // 
            this.LeaveDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaveDay.Location = new System.Drawing.Point(76, 63);
            this.LeaveDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeaveDay.Name = "LeaveDay";
            this.LeaveDay.Size = new System.Drawing.Size(277, 26);
            this.LeaveDay.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DoubleRoom);
            this.groupBox1.Controls.Add(this.SingleRoom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(114, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DoubleRoom
            // 
            this.DoubleRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoubleRoom.AutoSize = true;
            this.DoubleRoom.Location = new System.Drawing.Point(8, 48);
            this.DoubleRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoubleRoom.Name = "DoubleRoom";
            this.DoubleRoom.Size = new System.Drawing.Size(107, 24);
            this.DoubleRoom.TabIndex = 1;
            this.DoubleRoom.TabStop = true;
            this.DoubleRoom.Text = "Phòng đôi";
            this.DoubleRoom.UseVisualStyleBackColor = true;
            // 
            // SingleRoom
            // 
            this.SingleRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SingleRoom.AutoSize = true;
            this.SingleRoom.Location = new System.Drawing.Point(8, 26);
            this.SingleRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SingleRoom.Name = "SingleRoom";
            this.SingleRoom.Size = new System.Drawing.Size(113, 24);
            this.SingleRoom.TabIndex = 0;
            this.SingleRoom.TabStop = true;
            this.SingleRoom.Text = "Phòng đơn";
            this.SingleRoom.UseVisualStyleBackColor = true;
            this.SingleRoom.CheckedChanged += new System.EventHandler(this.SingleRoom_CheckedChanged);
            // 
            // Services
            // 
            this.Services.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Services.Controls.Add(this.Laundry);
            this.Services.Controls.Add(this.Internet);
            this.Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Location = new System.Drawing.Point(150, 274);
            this.Services.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Services.Name = "Services";
            this.Services.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Services.Size = new System.Drawing.Size(146, 77);
            this.Services.TabIndex = 0;
            this.Services.TabStop = false;
            this.Services.Text = "Room services";
            this.Services.Enter += new System.EventHandler(this.Services_Enter);
            // 
            // Laundry
            // 
            this.Laundry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Laundry.AutoSize = true;
            this.Laundry.Location = new System.Drawing.Point(17, 51);
            this.Laundry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Laundry.Name = "Laundry";
            this.Laundry.Size = new System.Drawing.Size(92, 24);
            this.Laundry.TabIndex = 2;
            this.Laundry.Text = "Laundry";
            this.Laundry.UseVisualStyleBackColor = true;
            // 
            // Internet
            // 
            this.Internet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Internet.AutoSize = true;
            this.Internet.Location = new System.Drawing.Point(17, 26);
            this.Internet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Internet.Name = "Internet";
            this.Internet.Size = new System.Drawing.Size(92, 24);
            this.Internet.TabIndex = 1;
            this.Internet.Text = "Internet";
            this.Internet.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.LeaveDay);
            this.groupBox3.Controls.Add(this.ComeDay);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 154);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(364, 103);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Staying time";
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.Location = new System.Drawing.Point(86, 72);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(176, 20);
            this.NameBox.TabIndex = 8;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // AddressBox
            // 
            this.AddressBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBox.Location = new System.Drawing.Point(86, 105);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(176, 20);
            this.AddressBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quản lý khách lưu trú";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CheckOut
            // 
            this.CheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckOut.Location = new System.Drawing.Point(314, 54);
            this.CheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(96, 92);
            this.CheckOut.TabIndex = 11;
            this.CheckOut.Text = "CheckOut";
            this.CheckOut.UseVisualStyleBackColor = true;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.HideSelection = false;
            this.Result.Location = new System.Drawing.Point(414, 54);
            this.Result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(199, 238);
            this.Result.TabIndex = 12;
            this.Result.UseCompatibleStateImageBehavior = false;
            this.Result.View = System.Windows.Forms.View.List;
            this.Result.SelectedIndexChanged += new System.EventHandler(this.Result_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hóa đơn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Refresh
            // 
            this.Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh.Location = new System.Drawing.Point(414, 300);
            this.Refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(77, 39);
            this.Refresh.TabIndex = 14;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // CloseB
            // 
            this.CloseB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseB.Location = new System.Drawing.Point(535, 300);
            this.CloseB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(77, 39);
            this.CloseB.TabIndex = 15;
            this.CloseB.Text = "Close";
            this.CloseB.UseVisualStyleBackColor = true;
            this.CloseB.Click += new System.EventHandler(this.CloseB_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(621, 388);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Quản lý khách sạn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ComeDay;
        private System.Windows.Forms.DateTimePicker LeaveDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DoubleRoom;
        private System.Windows.Forms.RadioButton SingleRoom;
        private System.Windows.Forms.GroupBox Services;
        private System.Windows.Forms.CheckBox Laundry;
        private System.Windows.Forms.CheckBox Internet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.ListView Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.Label label7;
    }
}

