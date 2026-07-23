using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-IGLU1AJ\SQLEXPRESS;Initial Catalog=FristLogin;Integrated Security=True;Encrypt=False");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            /////////////////
            txt_username.Focus();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM LOGIN WHERE username ='" + txt_username.Text + "'AND user_password = '" + txt_password.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    ////////////////////////
                    manu form2 = new manu();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //////////////////
                    txt_username.Clear();
                    txt_password.Clear();
                    /////////////////
                    txt_username.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }

        }
    }
}
