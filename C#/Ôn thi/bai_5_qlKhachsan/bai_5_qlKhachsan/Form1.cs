using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_5_qlKhachsan
{

    public partial class Form1 : Form
    {
        public double x1, x2, x3, x4, T;
        public double xl3, xl4;
        public string d1="", d2="", d3="", d4="";

        private void clear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            giatla.Checked = false;
            internet.Checked = false;
            nuockhoang.Checked = false;
            nuocloc.Checked = false;
            x1 = 0;
            x2 = 0;
            x3 = 0;
            x4 = 0;
            Result.Items.Add(d1 = "");
            Result.Items.Add(d2 = ""); 
            Result.Items.Add(d3 = "");
            Result.Items.Add(d4 = "");
            Result.Items.Add(T = 0);
            Result.Items.Clear();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            textBox2.Hide();
        }

        private void nuockhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (nuockhoang.Checked == true)
            {
                textBox1.Show();
                textBox1.Text = "1";
            }
            else 
            { 
                textBox1.Hide(); 
            }
        }

        private void nuocloc_CheckedChanged(object sender, EventArgs e)
        {
            if (nuocloc.Checked == true)
            {
                textBox2.Show();
                textBox2.Text = "1";
            }
            else
            {
                textBox2.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tinhtien_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Vui long chon nhan vien");
            }
            else if (giatla.Checked == false && internet.Checked == false)
            {
                MessageBox.Show("Vui long chon dich vu");
            }
            else if (nuockhoang.Checked == false && nuocloc.Checked == false)
            {
                MessageBox.Show("Vui long chon nuoc uong");
            }
            else
            {
                if (giatla.Checked == true)
                {
                    x1 = 5000;
                    d1 = "Giat la   " + x1.ToString();
                }
                if (internet.Checked == true)
                {
                    x2 = 15000;
                    d2 = "Internet   " + x2.ToString();
                }
                if (nuockhoang.Checked == true)
                {
                    xl3 = int.Parse(textBox1.Text);
                    x3 = 10000 * xl3;
                    d3 = xl3.ToString() + "   Nuoc Khoang   " + x3;

                }
                if (nuocloc.Checked == true)
                {
                    xl4 = int.Parse(textBox2.Text);
                    x4 = 7000 * xl4;
                    d4 = xl4.ToString() + "   Nuoc Loc   " + x4;
                }

                T = x1 + x2 + x3 + x4;

                Result.Items.Add("Ten nhan vien: " + comboBox1.Text);
                Result.Items.Add("Ngay dat phong: " + dateTimePicker1.Value.ToString("MM,dd,yyyy"));
                Result.Items.Add("Ngay tra phong: " + dateTimePicker2.Value.ToString("MM,dd,yyyy"));
                Result.Items.Add("");
                if (d1 != "") { Result.Items.Add(d1); }
                if (d2 != "") { Result.Items.Add(d2); }
                if (d3 != "") { Result.Items.Add(d3); }
                if (d4 != "") { Result.Items.Add(d4); }
                Result.Items.Add("");
                Result.Items.Add("Tong tien la: " + T);
                Result.Items.Add("-----------------------------");
            }
        }
    }
}
