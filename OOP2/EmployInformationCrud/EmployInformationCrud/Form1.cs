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
namespace EmployInformationCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=EmployeInformation;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        SqlDataAdapter da;

        void GetData()
        {
            string query = "SELECT * FROM EmployeInformation";
            con.Open();
            da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridView.DataSource = dt;
            con.Close();

        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO EmployeInformation ([Employe Name],[Employe Contact],[Employe Gender],[Employe Birthdate]) VALUES (@name,@contact,@gender,@birthdate)";


            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", txtEmployeName.Text);
            cmd.Parameters.AddWithValue("@contact", txtEmployeContact.Text);
            cmd.Parameters.AddWithValue("@gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@birthdate", txtDateTimePicker.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            ResetEverything();
            MessageBox.Show("Inserted!!!!", "Informarion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void DataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployId.Text = DataGridView.CurrentRow.Cells[0].Value.ToString();
            txtEmployeName.Text = DataGridView.CurrentRow.Cells[1].Value.ToString();
            txtEmployeContact.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
            txtGender.Text = DataGridView.CurrentRow.Cells[3].Value.ToString();
            txtDateTimePicker.Text = DataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE EmployeInformation SET [Employe Name]=@name,[Employe Contact] =@contact,[Employe Gender] =@gender,[Employe Birthdate]=@birthdate WHERE [Employe Id] =@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmployId.Text));
            cmd.Parameters.AddWithValue("@name", txtEmployeName.Text);
            cmd.Parameters.AddWithValue("@contact", txtEmployeContact.Text);
            cmd.Parameters.AddWithValue("@gender", txtGender.Text);
            cmd.Parameters.AddWithValue("@birthdate", txtDateTimePicker.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            ResetEverything();

            MessageBox.Show("Updated!!!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM EmployeInformation WHERE [Employe Id]=@id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmployId.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            MessageBox.Show("Deleted!!!!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (txtEmployId.Text == "")
                GetData();
            else
            {
                string query = "SELECT * FROM EmployeInformation WHERE [Employe Id]= '" + Convert.ToInt32(txtEmployId.Text) + "' ";
                con.Open();
                da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridView.DataSource = dt;
                con.Close();
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            ResetEverything();
        }

        private void ResetEverything()
        {
             txtEmployId.Clear();
            txtEmployeName.Clear();
            txtEmployeContact.Clear();
            txtGender.SelectedIndex = -1;
            txtDateTimePicker.Value = DateTime.Now;

        }
    }
}
