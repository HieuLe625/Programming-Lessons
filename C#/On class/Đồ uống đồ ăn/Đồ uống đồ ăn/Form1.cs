using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_uống_đồ_ăn
{
    public partial class Form1 : Form
    {
        public double b1=0, b2=0, b3=0, b4=0, b5=0, b6=0, b7=0;    
        public double discount=0, a=0,a1=0, a2=0, a3=0, a4=0, a5=0, a6=0, a7=0;
        public string d1 = "", d2 = "", d3 = "", d4 = "", d5 = "", d6 = "", d7 = "", dis = "", dis1 = "20%", dis2 = "10%";

        

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Sinhvien_CheckedChanged(object sender, EventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void cbsuada_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsuada.Checked == true)
            {
                text1.Text = "1";
                text1.Show();
            }
            else
            {
                
                text1.Hide();
            }           
        }
        private void cbd_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbd.Checked == true)
            {
                textBox2.Text = "1";
                textBox2.Show();
            }
            else
            {
                textBox2.Text = "";
                textBox2.Hide();
            }
        }

        private void cbdua_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdua.Checked == true)
            {
                textBox3.Text = "1";
                textBox3.Show();
            }
            else
            {
                textBox3.Text = "";
                textBox3.Hide();

            }
        }

        private void cboi_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cboi.Checked == true)
            {
                textBox4.Text = "1";
                textBox4.Show();
            }
            else
            {
                textBox4.Text = "";
                textBox4.Hide();
            }
        }

        private void cbhoaqua_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhoaqua.Checked == true)
            {
                textBox5.Text = "1";
                textBox5.Show();
            }
            else
            {
                textBox5.Text = "";
                textBox5.Hide();
            }
        }

        private void cbdanhda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdanhda.Checked == true)
            {
                textBox6.Text = "1";
                textBox6.Show();
            }
            else
            {
                textBox6.Text = "";
                textBox6.Hide();
            }
        }

        private void cbchanh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbchanh.Checked == true)
            {
                textBox7.Text = "1";
                textBox7.Show();
            }
            else
            {
                textBox7.Text = "";
                textBox7.Hide();
                
            }
        }

        private void Services_Enter(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nhanvien_Click(object sender, EventArgs e)
        {

        }

        private void ngaythang_Click(object sender, EventArgs e)
        {

        }

        private void Tinhtien_Click(object sender, EventArgs e)
        {



            if (tenkhach.Text == "")
            {
                MessageBox.Show("Vui long nhap ten khach hang");
            }
            else if (cbsuada.Checked == false && cbdanhda.Checked == false && cbdua.Checked == false && cbhoaqua.Checked == false && cboi.Checked == false && cbd.Checked == false && cbchanh.Checked == false)
            {
                MessageBox.Show("Vui long chon mon");
            }
            else if (VIP.Checked == false && khachthuong.Checked == false && Sinhvien.Checked == false)
            {
                MessageBox.Show("Vui long chon doi tuong");
            }
            else
            {
                
               
                if (cbsuada.Checked == true)
                {
                    b1 = float.Parse(text1.Text);
                    a1 = 100 * b1;
                    d1 = b1.ToString() + "  Cafe sữa đá         " + a1.ToString();
                   
                }
                if (cbd.Checked == true)
                {
                    b2 = float.Parse(textBox2.Text);
                    a2 = 200* b2;
                    d2 = b2.ToString() + "  Cafe đá              " + a2.ToString();
                }
                if (cbdua.Checked == true)
                {
                    b3 = float.Parse(textBox3.Text);
                    a3 = 190 * b3;
                    d3 = b3.ToString() + "  Nước ép dứa       " + a3.ToString();
                }
                if (cboi.Checked == true)
                {
                    b4 = float.Parse(textBox4.Text);
                    a4 = 100 * b4;
                    d4 = b4.ToString() + "  Nước ép ổi          " + a4.ToString();
                }
                if (cbhoaqua.Checked == true)
                {
                    b5 = float.Parse(textBox5.Text);
                    a5 = 100 * b5;
                    d5 = b5.ToString() + "  Hoa quả dầm         " + a5.ToString();
                }
                if (cbdanhda.Checked == true)
                {
                    b6 = float.Parse(textBox6.Text);
                    a6 = 900 * b6;
                    d6 = b6.ToString()+ "  Sữa chua đánh đá     " + a6.ToString();
                }
                if (cbchanh.Checked == true)
                {
                    b7 = float.Parse(textBox7.Text);
                    a7 = 1000 * b7;
                    d7 = b7.ToString()+ "  Trà chanh            " + a7.ToString();
                }
                a = a1 + a2 + a3 + a4 + a5 + a6 + a7;
                
                if(Sinhvien.Checked == true)
                {
                    discount = a * 8 /10 ;
                    dis = dis1;
                }
                if (VIP.Checked == true)
                {
                    discount = a * 9 / 10;
                    dis = dis2; 
                }
                if (khachthuong.Checked == true)
                {
                    discount = a ;
                    dis = dis;
                }


                Result.Items.Add("Tên nhân viên: " + this.comboBox1.Text);
                Result.Items.Add("Tên khách hàng: " + this.textBox8.Text);               
                Result.Items.Add("Ngày : " + this.time.Value.ToString("MM/dd/yyyy"));
                Result.Items.Add("Khách hàng được giảm giá: " +  dis );
                Result.Items.Add("");
                if (d1 != "") { Result.Items.Add(d1); }
                if (d2 != "") { Result.Items.Add(d2); }
                if (d3 != "") { Result.Items.Add(d3); }
                if (d4 != "") { Result.Items.Add(d4); }
                if (d5 != "") { Result.Items.Add(d5); }
                if (d6 != "") { Result.Items.Add(d6); }
                if (d7 != "") { Result.Items.Add(d7); }
                Result.Items.Add("Tổng: " + a.ToString());
                Result.Items.Add("Thanh toán: " + discount.ToString());

                Result.Items.Add("--------------------");
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }      
    }
}
