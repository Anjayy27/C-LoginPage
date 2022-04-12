using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crazy_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text=="root" && txtpassword.Text=="root")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid LoginInfo!");
                txtUsername.Clear();
                txtpassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
