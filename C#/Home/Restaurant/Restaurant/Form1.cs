using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public double sl1 = 0, sl2 = 0, sl3 = 0, sl4 = 0, sl5 = 0, sl6 = 0, sl7 = 0;   //số lượng
        public double x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0, x7 = 0; //Tổng giá các loại
        public string d1 = "", d2 = "", d3 = "", d4 = "", d5 = "", d6 = "", d7 = ""; //Dùng để in
        public double sale = 0;      
        public string salein = "";
        public double T = 0;// Tổng giá tiền

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }     
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                      
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
        }
        private void cafesuada_CheckedChanged(object sender, EventArgs e)
        {
            if (cafesuada.Checked == true)
            {
                textBox2.Text = "1";
                textBox2.Show();
            }
            else
            {              
                textBox2.Hide();
            }
        }

        private void cafeden_CheckedChanged(object sender, EventArgs e)
        {
            if (cafeden.Checked == true)
            {
                textBox3.Text = "1";
                textBox3.Show();
            }
            else
            {
                textBox3.Hide();
            }
        }

        private void duajuice_CheckedChanged(object sender, EventArgs e)
        {
            if (duajuice.Checked == true)
            {
                textBox4.Text = "1";
                textBox4.Show();
            }
            else
            {
                textBox4.Hide();
            }
        }

        private void oijuice_CheckedChanged(object sender, EventArgs e)
        {
            if (oijuice.Checked == true)
            {
                textBox5.Text = "1";
                textBox5.Show();
            }
            else
            {
                textBox5.Hide();
            }
        }

        private void hoaquadam_CheckedChanged(object sender, EventArgs e)
        {
            if (hoaquadam.Checked == true)
            {
                textBox6.Text = "1";
                textBox6.Show();
            }
            else
            {
                textBox6.Hide();
            }
        }

        private void suachua_CheckedChanged(object sender, EventArgs e)
        {
            if (suachua.Checked == true)
            {
                textBox7.Text = "1";
                textBox7.Show();
            }
            else
            {
                textBox7.Hide();
            }
        }

        private void lemontea_CheckedChanged(object sender, EventArgs e)
        {
            if (lemontea.Checked == true)
            {
                textBox8.Text = "1";
                textBox8.Show();
            }
            else
            {
                textBox8.Hide();
            }
        }

        private void tinhtien_Click(object sender, EventArgs e)
        {
            if (tenkhach.Text == "")
            {
                MessageBox.Show("Vui long nhap ten khach");
            }
            else if(cafesuada.Checked == false && cafeden.Checked == false
                     && duajuice.Checked == false && oijuice.Checked == false
                      && hoaquadam.Checked == false && suachua.Checked == false && lemontea.Checked == false)
            {
                MessageBox.Show("Vui long chon mon");
            }
            else if(normal.Checked == false && sinhvien.Checked == false && vip.Checked == false)
            {
                MessageBox.Show("Vui long chon doi tuong");
            }
            else
            {

                if(cafesuada.Checked == true) 
                {
                    sl1 = int.Parse(textBox2.Text);
                    x1 = 12000 * sl1;
                    d1 = sl1.ToString() + "   Cafe sữa đá   " + x1.ToString();
                }
                if (cafeden.Checked == true)
                {
                    sl2 = int.Parse(textBox3.Text);
                    x2 = 10000 * sl2;
                    d2 = sl2.ToString() + "   Cafe đen   " + x2.ToString();
                }
                if (duajuice.Checked == true)
                {
                    sl3 = int.Parse(textBox4.Text);
                    x3 = 8000 * sl3;
                    d3 = sl3.ToString() + "   Nước ép dứa   " + x3.ToString();
                }
                if (oijuice.Checked == true)
                {
                    sl4 = int.Parse(textBox5.Text);
                    x4 = 7000 * sl4;
                    d4 = sl4.ToString() + "   Nước ép ổi   " + x4.ToString();
                }
                if (hoaquadam.Checked == true)
                {
                    sl5 = int.Parse(textBox6.Text);
                    x5 = 10000 * sl5;
                    d5 = sl5.ToString() + "   Hoa quả dầm   " + x5.ToString();
                }
                if (suachua.Checked == true)
                {
                    sl6 = int.Parse(textBox7.Text);
                    x6 = 5000 * sl6;
                    d6 = sl6.ToString() + "   Sữa chua đánh đá   " + x6.ToString();
                }
                if (lemontea.Checked == true)
                {
                    sl7 = int.Parse(textBox8.Text);
                    x7 = 10000 * sl7;
                    d7 = sl7.ToString() + "   Trà chanh   " + x7.ToString();
                }
                T = x1 + x2 + x3 + x4 + x5 + x6 + x7;

                if(normal.Checked == true)
                {
                    sale = T * 1;
                    salein = "0 đ";
                }

                if(sinhvien.Checked == true)
                {
                    sale = T * 8 / 10;
                    salein = "20%";
                }
                if (vip.Checked == true)
                {
                    sale = T * 9 / 10;
                    salein = "10%";
                }

                Result.Items.Add("Tên nhân viên: " + comboBox1.Text);
                Result.Items.Add("Tên khách hàng: " + tenkhach.Text);
                Result.Items.Add("Ngày : " + dateTimePicker1.Value.ToString("MM/dd/yyyy")); 
                Result.Items.Add("Khách hàng được giảm giá: " + salein);
                Result.Items.Add("");
                if (d1 != "") { Result.Items.Add(d1); }
                if (d2 != "") { Result.Items.Add(d2); }
                if (d3 != "") { Result.Items.Add(d3); }
                if (d4 != "") { Result.Items.Add(d4); }
                if (d5 != "") { Result.Items.Add(d5); }
                if (d6 != "") { Result.Items.Add(d6); }
                if (d7 != "") { Result.Items.Add(d7); }
                Result.Items.Add("Tổng: " + T.ToString());
                Result.Items.Add("Thanh toán: " + sale.ToString());

                Result.Items.Add("--------------------");


            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            tenkhach.Clear();
            cafesuada.Checked = false;
            cafeden.Checked = false;
            duajuice.Checked = false;
            oijuice.Checked = false;
            hoaquadam.Checked = false;
            suachua.Checked = false;
            lemontea.Checked = false;
            normal.Checked = false;
            sinhvien.Checked = false;
            vip.Checked = false;           
        }
        private void clear_Click(object sender, EventArgs e)
        {
            tenkhach.Clear();
            cafesuada.Checked = false;
            cafeden.Checked = false;
            duajuice.Checked = false;
            oijuice.Checked = false;
            hoaquadam.Checked = false;
            suachua.Checked = false;
            lemontea.Checked = false;
            normal.Checked = false;
            sinhvien.Checked = false;
            vip.Checked = false;
            comboBox1.Text = "";
            Result.Items.Clear();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close ?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void sinhvien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vip_CheckedChanged(object sender, EventArgs e)
        {

        }


        
    }
}
