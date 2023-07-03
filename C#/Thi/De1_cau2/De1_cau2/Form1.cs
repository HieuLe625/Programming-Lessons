using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1_cau2     
{   
    public partial class Form1 : Form
    {
        public double x1, x2, x3, x4;
        public double sl1, sl2, sl3, sl4;
        public string d1 = "", d2 = "", d3 = "", d4 = "";
        public double T;
        public double sale;       
        public string salein = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
        }

        private void cafe_CheckedChanged(object sender, EventArgs e)
        {
            if (cafe.Checked == true)
            {
                textBox2.Show();
                textBox2.Text = "1";
            }
            else
                textBox2.Hide();
        }

        private void trasua_CheckedChanged(object sender, EventArgs e)
        {
            if (trasua.Checked == true)
            {
                textBox3.Show();
                textBox3.Text = "1";
            }
            else
                textBox3.Hide();
        }

        private void juice_CheckedChanged(object sender, EventArgs e)
        {
            if (juice.Checked == true)
            {
                textBox4.Show();
                textBox4.Text = "1";
            }
            else
                textBox4.Hide();
        }

        private void sinhto_CheckedChanged(object sender, EventArgs e)
        {
            if (sinhto.Checked == true)
            {
                textBox5.Show();
                textBox5.Text = "1";
            }
            else
                textBox5.Hide();
        }

        private void tinhtien_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                MessageBox.Show("Vui long chon nhan vien");
            }
            else if(tenkhach.Text == "")
            {
                MessageBox.Show("Vui long nhap ten khach");
            }
            else if(cafe.Checked == false && trasua.Checked == false && juice.Checked == false && sinhto.Checked == false)
            {
                MessageBox.Show("Vui long chon mon");
            }
            else if(normal.Checked == false && student.Checked == false)
            {
                MessageBox.Show("Vui long chon doi tuong");
            }
            else
            {
                if(cafe.Checked == true)
                {
                    sl1 = int.Parse(textBox2.Text);
                    x1 = 10000 * sl1;
                    d1 = sl1.ToString() + "     Cafe     " + x1.ToString();
                }
                if (trasua.Checked == true)
                {
                    sl2 = int.Parse(textBox3.Text);
                    x2 = 15000 * sl2;
                    d2 = sl2.ToString() + "     Tra sua     " + x2.ToString();
                }
                if (juice.Checked == true)
                {
                    sl3 = int.Parse(textBox4.Text);
                    x3 = 8000 * sl3;
                    d3 = sl3.ToString() + "     Nuoc ep trai cay     " + x3.ToString();
                }
                if (sinhto.Checked == true)
                {
                    sl4 = int.Parse(textBox5.Text);
                    x4 = 20000 * sl4;
                    d4 = sl4.ToString() + "     Sinh to     " + x4.ToString();
                }
                T = x1 + x2 + x3 + x4;

                if(normal.Checked == true)
                {
                    sale = T;
                    salein = "0 d";
                }
                if(student.Checked == true)
                {
                    sale = T * 9 / 10;
                    salein = "10%";
                }
                result.Items.Add("Ten nhan vien: " + comboBox1.Text);
                result.Items.Add("Ten khach hang: " + tenkhach.Text);
                result.Items.Add("Ngay ban: " + dateTimePicker1.Value.ToString("dd/MM/yyyy"));
                result.Items.Add("Khach hang duoc giam gia: " + salein);
                result.Items.Add("");
                if (d1 != "") { result.Items.Add(d1); }
                if (d2 != "") { result.Items.Add(d2); }
                if (d3 != "") { result.Items.Add(d3); }
                if (d4 != "") { result.Items.Add(d4); }              
                result.Items.Add("Tong tien: " + T);
                result.Items.Add("Thanh tien: " + sale);

                result.Items.Add("------------------------");
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            tenkhach.Text = "";
            cafe.Checked = false;
            trasua.Checked = false;
            juice.Checked = false;
            sinhto.Checked = false;
            normal.Checked = false;
            student.Checked = false;
            x1 = 0;
            x2 = 0;
            x3 = 0;
            x4 = 0;
            sl1 = 0;
            sl2 = 0;
            sl2 = 0;
            sl2 = 0;
            result.Items.Add(d1 = "");
            result.Items.Add(d2 = "");
            result.Items.Add(d3 = "");
            result.Items.Add(d4 = "");
            result.Items.Add(T = 0);
            result.Items.Clear();
        }
        private void close_Click(object sender, EventArgs e)
        {            
            Close();
        }
    }
}
