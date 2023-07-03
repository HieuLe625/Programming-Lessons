using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_khách_sạn_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this application?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            NameBox.Clear();
            AddressBox.Clear();
            Result.Clear();
            SingleRoom.Checked = false;
            DoubleRoom.Checked = false;
            Internet.Checked = false;
            Laundry.Checked = false;
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                MessageBox.Show("Please enter your name");
            }
            else if (AddressBox.Text == "")
            {
                MessageBox.Show("Please enter your address");
            }
            else if (SingleRoom.Checked == false && DoubleRoom.Checked == false)
            {
                MessageBox.Show("Please select room type");
            }
            else
            {
                string room = "";
                string service = "";
                if (SingleRoom.Checked == true)
                {
                    room = SingleRoom.Text;
                }
                else if (DoubleRoom.Checked == true)
                {
                    room = DoubleRoom.Text;
                }
                if (Internet.Checked == true) service = service + Internet.Text;
                if (Laundry.Checked == true) service = service + Laundry.Text;
                Result.Items.Add("Name: " + this.NameBox.Text);
                Result.Items.Add("Address: " + this.AddressBox.Text);
                Result.Items.Add("Ngày đến: " + this.ComeDay.Value.ToString("MM/dd/yyyy"));
                Result.Items.Add("Ngày đi: " + this.LeaveDay.Value.ToString("MM/dd/yyyy"));
                Result.Items.Add("Loại phòng: " + room);
                Result.Items.Add("Service: " + service);
                Result.Items.Add("--------------------");
            }
        }

        private void Services_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComeDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SingleRoom_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
