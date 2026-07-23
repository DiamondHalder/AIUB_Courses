using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
//using CRUD_Operations.General;

namespace StudentInfoCrudOperation
{
    public partial class Form1 : Form
    {
        public int SerialNumber;
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (SerialNumber > 0)
            {
                using (SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=CrudTest;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE  CrudTest SET StudentName=@StudentName, StudentId=@StudentId,FatherName=@FatherName, Address=@Address, MobileNumber=@MobileNumber WHERE @SerialNumber=serialnumber", con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
                        cmd.Parameters.AddWithValue("@StudentId", txtStudentId.Text);
                        cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);

                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text);
                        cmd.Parameters.AddWithValue("@serialnumber", this.SerialNumber);


                        if (con.State != ConnectionState.Open)
                            con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student Information is successfully updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select any row ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void GetStudentsRecord()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=CrudTest;Integrated Security=True;Encrypt=False"))
            {
                using (SqlCommand cmd = new SqlCommand("select * from CrudTest", con))
                {
                    // Change CommandType from StoredProcedure to Text
                    cmd.CommandType = CommandType.Text;

                    DataTable dt = new DataTable();

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);

                    GridView.DataSource = dt;
                }
            }
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=CrudTest;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO CrudTest (StudentName, StudentId, FatherName, Address, MobileNumber) VALUES (@StudentName, @StudentId, @FatherName, @Address, @MobileNumber)", con))
                    {
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@StudentName", txtStudentName.Text);
                        cmd.Parameters.AddWithValue("@StudentId", txtStudentId.Text);
                        cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);

                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text);
                        //cmd.Parameters.AddWithValue("@StudentId", this.SerialNumber);


                        if (con.State != ConnectionState.Open)
                            con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student Information is successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();
                ResetFormControls();
            }
        }
        private bool IsValid()
        {
            if (txtStudentName.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetFormControls();

        }

        private void ResetFormControls()
        {
            SerialNumber = 0;
            txtStudentName.Clear();
            txtStudentId.Clear();
            txtFatherName.Clear();
            txtAddress.Clear();
            txtMobileNumber.Clear();

            txtStudentName.Focus();
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SerialNumber = Convert.ToInt32(GridView.SelectedRows[0].Cells[0].Value);
            txtStudentName.Text = GridView.SelectedRows[0].Cells[1].Value.ToString();
            txtFatherName.Text = GridView.SelectedRows[0].Cells[2].Value.ToString();
            txtStudentId.Text = GridView.SelectedRows[0].Cells[3].Value.ToString();
            txtAddress.Text = GridView.SelectedRows[0].Cells[4].Value.ToString();
            txtMobileNumber.Text = GridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (SerialNumber > 0)
            {
                using (SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=CrudTest;Integrated Security=True;Encrypt=False"))
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM  CrudTest  WHERE @SerialNumber=serialnumber", con))
                    {
                        cmd.CommandType = CommandType.Text;

                        
                        cmd.Parameters.AddWithValue("@serialnumber", this.SerialNumber);


                        if (con.State != ConnectionState.Open)
                            con.Open();

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student Information is successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsRecord();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select any row to delete ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
