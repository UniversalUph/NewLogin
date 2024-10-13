using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            TitleHome.Parent = GradientBoxTop;
            TitleHome.BackColor = Color.Transparent;

            LoginButton.FlatStyle = FlatStyle.Flat;

            LoginButton.BackColor = Color.FromArgb(100, 52, 152, 219);

            LoginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0, 0);

            LoginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 0, 0, 0);

            //LoginButton.Parent = pictureBox2;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Collection collt = Program.FrmCust;
            collt.Hide();
            button1.BackColor = Color.FromArgb(29, 132, 192);
            Collection.BackColor = Color.FromArgb(67, 130, 212);
            button3.BackColor = Color.FromArgb(67, 130, 212);
            button4.BackColor = Color.FromArgb(67, 130, 212);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(67, 130, 212);
            Collection.BackColor = Color.FromArgb(67, 130, 212);
            button3.BackColor = Color.FromArgb(67, 130, 212);
            button4.BackColor = Color.FromArgb(29, 132, 192);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(67, 130, 212);
            Collection.BackColor = Color.FromArgb(67, 130, 212);
            button3.BackColor = Color.FromArgb(29, 132, 192);
            button4.BackColor = Color.FromArgb(67, 130, 212);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void TitleHome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void GradientBoxTop_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            loginForm.Show();

            this.Hide();
        }
                         

        private void Collection_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(67, 130, 212);
            Collection.BackColor = Color.FromArgb(29, 132, 192);
            button3.BackColor = Color.FromArgb(67, 130, 212);
            button4.BackColor = Color.FromArgb(67, 130, 212);

            Collection collt = Program.FrmCust;
            collt.Show();
            collt.WindowState = FormWindowState.Maximized;
            collt.BringToFront();
        }
    }
}
