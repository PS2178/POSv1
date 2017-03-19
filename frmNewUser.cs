using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUI
{
    public partial class frmNewUser : Form
    {
        Point lastClick;
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewUser_Paint(object sender, PaintEventArgs e)
        {
            // Paints a gray borer around the form
            e.Graphics.DrawRectangle(new Pen(Color.Gray, 3),
                this.DisplayRectangle);
        }

        private void frmNewUser_MouseMove(object sender, MouseEventArgs e)
        {
            // Change the position of the form if the user clicks and drags the mouse across
            // the screen.,
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void frmNewUser_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(40, 40, 40);
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
            this.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text fields
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.Black;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.ForeColor = Color.White;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.Black;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.White;
        }
    }
}
