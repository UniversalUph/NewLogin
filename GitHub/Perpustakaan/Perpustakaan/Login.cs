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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Red)), this.ClientRectangle);
        //    base.OnPaint(e);
        //}

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string email = TxtEmail.Text;
            string username = TxtUserName.Text;
            string password = TxtPass.Text;

            // Validasi email, username, dan password
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email harus berakhiran @gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username != "20")
            {
                MessageBox.Show("Username salah! Username harus '20'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != "12")
            {
                MessageBox.Show("Password salah! Password harus '12'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Jika validasi berhasil, buka Home form
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide(); // Sembunyikan form login
        }
    }
}
    
