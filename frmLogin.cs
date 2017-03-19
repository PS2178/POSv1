using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUI
{
    public partial class frmUI : Form
    {
        // This saves the last coordinate point on mouse click
        Point lastClick;
        public frmUI()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void frmUI_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void frmUI_MouseMove(object sender, MouseEventArgs e)
        {
            // Change the position of the form if the user clicks and drags the mouse across
            // the screen.,
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Create a border around the form
        private void frmUI_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Gray, 3),
                            this.DisplayRectangle);
        }

        private void lblMyProfile_MouseEnter(object sender, EventArgs e)
        {
            lblMyProfile.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void lblMyProfile_MouseLeave(object sender, EventArgs e)
        {
            lblMyProfile.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void lblMyProfile_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/PS2178");
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            while (proBar.Value < proBar.Maximum)
            {
                proBar.Value += 1;
            }
            if (proBar.Value == proBar.Maximum)
            {
                tmrLoad.Stop();
                this.Enabled = true;
                MessageBox.Show($"Welcome back {txtUsername.Text.ToString()}!", "Login Successfull");
                proBar.Visible = false;
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                this.Enabled = false;
                tmrLoad.Start();
                proBar.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter a valid username and password!", "Error!");
            }
            
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.ForeColor = Color.Black;
            //btnNext.FlatAppearance.BorderColor = Color.Black;

        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.ForeColor = Color.White;
            //btnNext.FlatAppearance.BorderColor = Color.Silver;
        }

        private void lblNewUser_MouseEnter(object sender, EventArgs e)
        {
            lblNewUser.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void lblNewUser_MouseLeave(object sender, EventArgs e)
        {
            lblNewUser.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void lblNewUser_Click(object sender, EventArgs e)
        {
            (new frmNewUser()).ShowDialog();
        }
    }
}
