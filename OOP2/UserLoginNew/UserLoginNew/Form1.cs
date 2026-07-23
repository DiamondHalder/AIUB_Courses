using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserLoginNew
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=loginapp;Integrated Security=True;Encrypt=False");
            con.Open();
            string query = "SELECT COUNT(*) FROM loginapp WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", UserTxt.Text);
            cmd.Parameters.AddWithValue("@password", PassTxt.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("error in login");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            PassTxt.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
