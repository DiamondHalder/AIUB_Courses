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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InsertingInformation
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private bool IsValid()
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtBloodGroup.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {




                SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=Info;Integrated Security=True;Encrypt=False");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Info
               ([Name]
               ,[Id]
               ,[Age]
               ,[Blood Group])
                   
                VALUES
                ('" + txtName.Text + "','" + txtId.Text + "','" + txtAge.Text + "','" + txtBloodGroup.Text + "') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted Successfully", "Info", MessageBoxButtons.OK);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Check if any of the search fields are filled
            if (string.IsNullOrWhiteSpace(txtName.Text) &&
                string.IsNullOrWhiteSpace(txtId.Text) &&
                string.IsNullOrWhiteSpace(txtAge.Text) &&
                string.IsNullOrWhiteSpace(txtBloodGroup.Text))
            {
                MessageBox.Show("Please provide at least one search criteria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=Info;Integrated Security=True;Encrypt=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            if (con.State != ConnectionState.Open)
                con.Open();

            // Build the query dynamically based on filled fields
            StringBuilder query = new StringBuilder("SELECT * FROM Info WHERE 1=1");

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                query.Append(" AND LTRIM(RTRIM(LOWER([Name]))) LIKE '%' + LTRIM(RTRIM(LOWER(@Name))) + '%'"); // Trimming spaces and handling case
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim().ToLower()); // Trim and convert to lowercase
            }
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                query.Append(" AND [Id] = @Id");
                cmd.Parameters.AddWithValue("@Id", txtId.Text.Trim()); // Ensure ID is trimmed
            }
            if (!string.IsNullOrWhiteSpace(txtAge.Text))
            {
                int age;
                if (int.TryParse(txtAge.Text.Trim(), out age)) // Check if age is a valid integer
                {
                    query.Append(" AND [Age] = @Age");
                    cmd.Parameters.AddWithValue("@Age", age); // Pass as integer
                }
                else
                {
                    MessageBox.Show("Invalid Age. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!string.IsNullOrWhiteSpace(txtBloodGroup.Text))
            {
                query.Append(" AND LTRIM(RTRIM(LOWER([Blood Group]))) LIKE '%' + LTRIM(RTRIM(LOWER(@BloodGroup))) + '%'"); // Handling case sensitivity
                cmd.Parameters.AddWithValue("@BloodGroup", txtBloodGroup.Text.Trim().ToLower()); // Trim and lowercase
            }

            cmd.CommandText = query.ToString();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Assuming you have a DataGridView named dataGridView1 in your form
                    dataGridView1.DataSource = dt;
                    dataGridView1.Visible = true; // Make sure it's visible
                }
                else
                {
                    MessageBox.Show("No records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



    }
}
