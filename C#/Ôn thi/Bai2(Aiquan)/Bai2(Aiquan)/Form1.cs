using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_Aiquan_
{
    public partial class Form1 : Form
    {
        public double x1, x2, x3, x4, x5, x6, x7;
        public double sl1, sl2, sl3, sl4, sl5, sl6, sl7;
        public string d1="", d2="", d3="", d4="", d5="", d6="", d7="";
        public double T;
        public double sale;
        public string salein="";
        public Form1()
        {
            InitializeComponent();
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (oijuice.Checked == true)
            {
                textBox5.Show();
                textBox5.Text = "1";
            }
            else
                textBox5.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cafeden.Checked == true)
            {
                textBox3.Show();
                textBox3.Text = "1";
            }
            else
                textBox3.Hide();
        }

        private void cafesuada_CheckedChanged(object sender, EventArgs e)
        {
            if (cafesuada.Checked == true)
            {
                textBox2.Show();
                textBox2.Text = "1";
            }
            else
                textBox2.Hide();            
        }

        private void duajuice_CheckedChanged(object sender, EventArgs e)
        {
            if (duajuice.Checked == true)
            {
                textBox4.Show();
                textBox4.Text = "1";
            }
            else
                textBox4.Hide();
        }

        private void hoaqua_CheckedChanged(object sender, EventArgs e)
        {
            if (hoaqua.Checked == true)
            {
                textBox6.Show();
                textBox6.Text = "1";
            }
            else
                textBox6.Hide();
        }

        private void suachua_CheckedChanged(object sender, EventArgs e)
        {
            if (suachua.Checked == true)
            {
                textBox7.Show();
                textBox7.Text = "1";
            }
            else
                textBox7.Hide();
        }

        private void trachanh_CheckedChanged(object sender, EventArgs e)
        {
            if (trachanh.Checked == true)
            {
                textBox8.Show();
                textBox8.Text = "1";
            }
            else
                textBox8.Hide();
        }

        private void tinhtien_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Vui long chon nhan vien");
            }
                
            else if (tenkhach.Text == "")
            {
                MessageBox.Show("Vui long nhap ten khach hang");
            }
                
            else if (cafesuada.Checked == false && cafeden.Checked == false && duajuice.Checked == false
                && oijuice.Checked == false && hoaqua.Checked == false && suachua.Checked == false && trachanh.Checked == false)
            {
                MessageBox.Show("Vui long chon mon");
            }
            else if (normal.Checked == false && student.Checked == false && vip.Checked == false)
            {
                MessageBox.Show("Vui long chon doi tuong");
            }
            else
            {
                if(cafesuada.Checked == true)
                {
                    sl1 = int.Parse(textBox2.Text);
                    x1 = 12000 * sl1;
                    d1 = sl1.ToString() + "   Cafe sua da   " + x1.ToString();
                }
                if (cafeden.Checked == true)
                {
                    sl2 = int.Parse(textBox3.Text);
                    x2 = 10000 * sl2;
                    d2 = sl2.ToString() + "   Cafe den   " + x2.ToString();
                }
                if (duajuice.Checked == true)
                {
                    sl3 = int.Parse(textBox4.Text);
                    x3 = 10000 * sl3;
                    d3 = sl3.ToString() + "   Nuoc ep dua  " + x3.ToString();
                }
                if (oijuice.Checked == true)
                {
                    sl4 = int.Parse(textBox5.Text);
                    x4 = 10000 * sl4;
                    d4 = sl4.ToString() + "   Nuoc ep oi   " + x4.ToString();
                }
                if (hoaqua.Checked == true)
                {
                    sl5 = int.Parse(textBox6.Text);
                    x5 = 15000 * sl5;
                    d5 = sl5.ToString() + "   Hoa qua dam   " + x5.ToString();
                }
                if (suachua.Checked == true)
                {
                    sl6 = int.Parse(textBox7.Text);
                    x6 = 8000 * sl6;
                    d6 = sl6.ToString() + "   Sua chua danh da   " + x6.ToString();
                }
                if (trachanh.Checked == true)
                {
                    sl7 = int.Parse(textBox8.Text);
                    x7 = 10000 * sl7;
                    d7 = sl7.ToString() + "   Tra chanh   " + x7.ToString();
                }
                T = x1 + x2 + x3 + x4 + x5 + x6 + x7;
                if(normal.Checked == true)
                {
                    sale = T;
                    salein = "0 d";

                }
                if(student.Checked == true)
                {
                    sale = T * 8 / 10;
                    salein = "20%";
                }
                if(vip.Checked == true)
                {
                    sale = T * 9 / 10;
                    salein = "10%";
                }

                result.Items.Add("Ten nhan vien: " + comboBox1.Text);
                result.Items.Add("Ten khach hang: " + tenkhach.Text);
                result.Items.Add("Ngay ban: " + dateTimePicker1.Value.ToString("MM/dd/yyyy"));
                result.Items.Add("Khach hang duoc giam gia: " + salein);
                result.Items.Add("");
                if (d1 != "") { result.Items.Add(d1); }
                if (d2 != "") { result.Items.Add(d2); }
                if (d3 != "") { result.Items.Add(d3); }
                if (d4 != "") { result.Items.Add(d4); }
                if (d5 != "") { result.Items.Add(d5); }
                if (d6 != "") { result.Items.Add(d6); }
                if (d7 != "") { result.Items.Add(d7); }
                result.Items.Add("Tong tien: " + T);
                result.Items.Add("Thanh tien: " + sale);

                result.Items.Add("------------------------");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            tenkhach.Text = "";
            cafesuada.Checked = false;
            cafeden.Checked = false;
            duajuice.Checked = false;
            oijuice.Checked = false;
            hoaqua.Checked = false;
            suachua.Checked = false;
            trachanh.Checked = false;
            normal.Checked = false;
            student.Checked = false;
            vip.Checked = false;
            result.Items.Remove(d1);
            result.Items.Clear();

        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want close?", "closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            Close();
        }

    }
}
