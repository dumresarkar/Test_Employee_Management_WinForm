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
    public partial class MenuForm : Form
    {
        string connectionstring = @"Data Source=DESKTOP-QMJ8D3L;Initial Catalog=Windows_loginpage;Integrated Security=True";
        string GENDER;
        public string id = "";
        public MenuForm(string UserID)
        {
            InitializeComponent();
            id = UserID;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f1 = new MenuForm();
            f1.Show();
        }
        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT EMP_KEY_ID, Name, EMAIL, GENDER, CONTACT, ADDRESS,USERNAME, PIC_PATH,LAPTOP_NUMBER, LOCKER_NUMBER, OFFICIAL_MAIL, OFFICIAL_PASSWORD, GIT_USERNAME, GIT_PASSWORD FROM INSERTS WHERE EMP_KEY_ID = '" + id + "'"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        //txt_EMP_ID.Text = sdr["EMP_KEY_ID"].ToString();
                        txt_username.Text = sdr["USERNAME"].ToString();
                        txt_name.Text = sdr["Name"].ToString();
                        txt_email.Text = sdr["EMAIL"].ToString();
                        txt_gender.Text = sdr["GENDER"].ToString();
                        txt_contact.Text = sdr["CONTACT"].ToString();
                        txt_address.Text = sdr["ADDRESS"].ToString();
                        txt_labtopnumber.Text = sdr["LAPTOP_NUMBER"].ToString();
                        txt_lockernumber.Text = sdr["LOCKER_NUMBER"].ToString();
                        txt_officialmail.Text = sdr["OFFICIAL_MAIL"].ToString();
                        txt_officialpassword.Text = sdr["OFFICIAL_PASSWORD"].ToString();
                        txt_gitusername.Text = sdr["GIT_USERNAME"].ToString();
                        txt_gitpassword.Text = sdr["GIT_PASSWORD"].ToString();

                        string path = sdr["PIC_PATH"].ToString();
                        pictureBox1.Image = Image.FromFile(path);
                    }
                    con.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
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
            sqlBuilder.AppendLine("          ,GENDER='" + txt_gender.Text + "'");
            sqlBuilder.AppendLine("          ,CONTACT='" + txt_contact.Text + "'");
            sqlBuilder.AppendLine("          ,ADDRESS='" + txt_address.Text + "'");
            sqlBuilder.AppendLine("          ,USERNAME='" + txt_username.Text + "'");

            //sqlBuilder.AppendLine("          ,PIC_PATH='" + PATH + "'");
            //sqlBuilder.AppendLine("          ,LAPTOP_NUMBER='" + txt_labtopnumber.Text + "'");
            //sqlBuilder.AppendLine("          ,LOCKER_NUMBER='" + txt_lockernumber.Text + "'");
            sqlBuilder.AppendLine("          ,OFFICIAL_MAIL='" + txt_officialmail.Text + "'");
            sqlBuilder.AppendLine("          ,OFFICIAL_PASSWORD='" + txt_officialpassword.Text + "'");
            sqlBuilder.AppendLine("          ,GIT_USERNAME='" + txt_gitusername.Text + "'");
            sqlBuilder.AppendLine("          ,GIT_PASSWORD='" + txt_gitpassword.Text + "'");
            sqlBuilder.AppendLine("          WHERE EMP_KEY_ID ='" + id + "'");
            command.CommandText = sqlBuilder.ToString();



            try
            {

                SqlCommand cmd = new SqlCommand(command.CommandText, con);
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
               





            }



        }
    }
}
