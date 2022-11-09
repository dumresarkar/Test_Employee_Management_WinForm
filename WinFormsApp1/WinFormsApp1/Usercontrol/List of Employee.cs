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


namespace WinFormsApp1
{
    public partial class List_of_Employee : UserControl
    {
        string ConnectionString = "Data Source=DESKTOP-QMJ8D3L;Initial Catalog=Windows_loginpage;Integrated Security=True";

        public List_of_Employee()
        {
            InitializeComponent();
        }

        private void List_of_Employee_Load(object sender, EventArgs e)
        {
            GetdataFromdatabase();

        }

        private void GetdataFromdatabase()
        {


            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string query = "SELECT EMP_KEY_ID, NAME, EMAIL, GENDER, CONTACT, USERNAME, PASSWORD FROM INSERTS";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //dataGridView1.Columns["EMP_KEY_ID"].HeaderText = "Employee ID";
            //dataGridView1.Columns["NAME"].HeaderText = "Full Name";
            //dataGridView1.Columns["EMAIL"].HeaderText = "Email";
            //dataGridView1.Columns["GENDER"].HeaderText = "Gender";
            //dataGridView1.Columns["CONTACT"].HeaderText = "Contact No";
            //dataGridView1.Columns["USERNAME"].HeaderText = "Username";
            //dataGridView1.Columns["PASSWORD"].HeaderText = "Password";




            //SqlCommand cmd = new SqlCommand(query, con);
            //var reader = cmd.ExecuteReader();


            //dataGridView1.Rows.Add(reader["EMP_KEY_ID"], reader["NAME"], reader["EMAIL"], reader["GENDER"], reader["CONTACT"], reader["USERNAME"], reader["PASSWORD"]);


            //DataTable basictable = new DataTable();
            //basictable.Load(reader);

            //dataGridView1.DataSource = basictable;

            con.Close();

            SqlConnection conn = new SqlConnection(ConnectionString);

            conn.Open();

            string querry = "SELECT EMP_KEY_ID, NAME, LAPTOP_NUMBER, LOCKER_NUMBER, OFFICIAL_MAIL, OFFICIAL_PASSWORD, GIT_USERNAME, GIT_PASSWORD FROM INSERTS ";
            SqlDataAdapter dat = new SqlDataAdapter(querry, conn);
            DataTable dt1 = new DataTable();
            dat.Fill(dt1);
            dataGridView2.DataSource = dt1;



            conn.Close();

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Deletion")
            {
                DialogResult confirm = MessageBox.Show("Are You sure you want to delete!!","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Emp_key_id1"].Value);
                    //MessageBox.Show(id.ToString());
                    SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                try
                {
                    string querry = "DELETE FROM INSERTS WHERE EMP_KEY_ID = @id";

                    //SqlDataAdapter dat = new SqlDataAdapter(querry, conn);
                    SqlCommand cmd = new SqlCommand(querry, conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data has been deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Data not deleted");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    conn.Close();
                }
                }





            }
            //Code for edit
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {

                
                string id;
                //string name, email, gender, contact, address, username, password,c_password, labtop_no, official_mailL, oddicial_password,git_username, git_password;

                id = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Emp_key_id1"].Value);


                Emp_edits form = new Emp_edits(id);
                form.Show();
                //this.Parent.Hide();
                this.ParentForm.Close();

            }

            



            GetdataFromdatabase();

        }

    }
}

