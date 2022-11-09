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
    public partial class Emp_edits : Form
    {
        string GENDER;
        string PATH;
        public string id = "";
        public string Uid = "";
        string connectionstring = @"Data Source=DESKTOP-QMJ8D3L;Initial Catalog=Windows_loginpage;Integrated Security=True";
        public Emp_edits( string UserID)
        {
            InitializeComponent();
            id = UserID;
            Uid = UserID;
            string Gender;
        }

        private void Editcs_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT EMP_KEY_ID, NAME, EMAIL, GENDER, CONTACT, ADDRESS, USERNAME, PASSWORD, CONFORM_PASSWORD, PIC_PATH, LAPTOP_NUMBER, LOCKER_NUMBER, OFFICIAL_MAIL, OFFICIAL_PASSWORD, GIT_USERNAME, GIT_PASSWORD FROM INSERTS WHERE EMP_KEY_ID = '" + id + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        //txt_EMP_ID.Text = sdr["EMP_KEY_ID"].ToString();
                        txt_name.Text = sdr["Name"].ToString();
                        txt_email.Text = sdr["EMAIL"].ToString();

                        txt_contact.Text = sdr["CONTACT"].ToString();
                        txt_address.Text = sdr["ADDRESS"].ToString();
                        txt_username.Text = sdr["USERNAME"].ToString();
                        txt_password.Text = sdr["PASSWORD"].ToString();
                        txt_confirmpassword.Text = sdr["CONFORM_PASSWORD"].ToString();
                        txt_laptopnumber.Text = sdr["LAPTOP_NUMBER"].ToString();
                        txt_lockernumber.Text = sdr["LOCKER_NUMBER"].ToString();
                        txt_officialmail.Text = sdr["OFFICIAL_MAIL"].ToString();
                        txt_officalpassword.Text = sdr["OFFICIAL_PASSWORD"].ToString();
                        txt_gitusername.Text = sdr["GIT_USERNAME"].ToString();
                        txt_gitpassword.Text = sdr["GIT_PASSWORD"].ToString();

                      
            
                            string Gender = sdr["GENDER"].ToString();

                            if (Gender == "Male")
                            {
                            radioButtonMale.Checked = true;

                            }else if ( Gender == "Female")
                            {
                            radioButtonFemale.Checked = true;
                        }
                        else
                        {
                            radioButtonOthers.Checked = true;
                        }
      



                        string path = sdr["PIC_PATH"].ToString();
                        pictureBox2.Image = Image.FromFile(path);
                    }
                    con.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Nextpage f2 = new Nextpage();
            f2.Show();
            f2.hello();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            MenuForm logf = new MenuForm();
            logf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            List_of_Employee fee = new List_of_Employee();
            fee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nextpage fh = new Nextpage();
            fh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            StringBuilder sqlBuilder;
            SqlCommand command = new SqlCommand();
        
            con.Open();
            sqlBuilder = new StringBuilder();
            sqlBuilder.AppendLine("UPDATE INSERTS ");
                sqlBuilder.AppendLine("          SET ");
                sqlBuilder.AppendLine("          NAME='" + txt_name.Text + "'");
                sqlBuilder.AppendLine("          ,EMAIL='" + txt_email.Text + "'");
                sqlBuilder.AppendLine("          ,GENDER='" + GENDER + "'");
                sqlBuilder.AppendLine("          ,CONTACT='" + txt_contact.Text + "'");
                sqlBuilder.AppendLine("          ,ADDRESS='" + txt_address.Text + "'");
                sqlBuilder.AppendLine("          ,USERNAME='" + txt_username.Text + "'");
                sqlBuilder.AppendLine("          ,PASSWORD='" + txt_password.Text + "'");
                sqlBuilder.AppendLine("          ,CONFORM_PASSWORD='" + txt_confirmpassword.Text + "'");
                //sqlBuilder.AppendLine("          ,PIC_PATH='" + PATH + "'");
                sqlBuilder.AppendLine("          ,LAPTOP_NUMBER='" + txt_laptopnumber.Text + "'");
                sqlBuilder.AppendLine("          ,LOCKER_NUMBER='" + txt_lockernumber.Text + "'");
                sqlBuilder.AppendLine("          ,OFFICIAL_MAIL='" + txt_officialmail.Text + "'");
                sqlBuilder.AppendLine("          ,OFFICIAL_PASSWORD='" + txt_officalpassword.Text + "'");
                sqlBuilder.AppendLine("          ,GIT_USERNAME='" + txt_gitusername.Text + "'");
                sqlBuilder.AppendLine("          ,GIT_PASSWORD='" + txt_gitpassword.Text + "'");
                sqlBuilder.AppendLine("          WHERE EMP_KEY_ID ='" + id + "'");
            command.CommandText = sqlBuilder.ToString();



            try
                {

                SqlCommand cmd= new SqlCommand(command.CommandText,con);
                cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                this.Close();

                Nextpage f2 = new Nextpage();
                f2.Show();
                f2.hello();
            }



        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Male";
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Female";
        }

        private void radioButtonOthers_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Other";
        }
    }
}
