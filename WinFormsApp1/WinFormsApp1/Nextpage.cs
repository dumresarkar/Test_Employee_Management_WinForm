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
using Raven.Client.Documents.Operations.ETL.SQL;
using System.Configuration;
using System.Windows.Forms;
using Raven.Client.Documents.Operations.ConnectionStrings;

namespace WinFormsApp1
{
    public partial class Nextpage : Form
    {
        public Nextpage()
        {
            InitializeComponent();
        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f1 = new MenuForm();
            f1.Show();
        }        

        private void button5_Click(object sender, EventArgs e)
        {
            list_of_Employee1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            welcome1.BringToFront();
        }

        public void hello()
        {
            list_of_Employee1.BringToFront();
        }

        private void Nextpage_Load(object sender, EventArgs e)
        {
            welcome1.BringToFront();
        }


        //private void Nextpage_Load(object sender, EventArgs e)
        //{



        //    //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QMJ8D3L;Initial Catalog=Windows_loginpage;Integrated Security=True");

        //    string location = "C:\\Users\\Sabin Dumre\\Desktop\\windows application\\WinFormsApp1\\WinFormsApp1\\ProfilePic";

        //    string path = Path.Combine(location, txt_username.Text + ".jpg");


        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("INSERT INTO INSERTS (NAME, EMAIL, GENDER, CONTACT, ADDRESS, USERNAME, PASSWORD, CONFORM_PASSWORD,PIC_PATH) " +
        //        "Values ( '" + txt_name.Text + "','" + txt_email.Text + "','" + GENDER + "','" + txt_contact.Text + "', '" + txt_address.Text + "' , '" + txt_username.Text + "','" + txt_password.Text + "','" + txt_conformpassword.Text + "','" + path + "')", con);



        //    SqlCommand cmmd = new SqlCommand("INSERT INTO H_INSERTS (NAME, READING, GAMMING, TRAVELLING, HIKING) " +
        //        "Values ( '" + txt_name.Text + "','" + checkBox_reading.Checked + "','" + checkBox_gamming.Checked + "','" + checkBox3_reading.Checked + "', '" + checkBox4_hiking.Checked + "')", con);

        //    SqlCommand I_cmd = new SqlCommand("INSERT INTO LoginPage ( username , password) " +
        //         "Values ( '" + txt_username.Text + "','" + txt_password.Text + "')", con);

        //    //cmd.CommandType = CommandType.StoredProcedure;
        //    //cmd.Parameters.AddWithValue("@NAME",txt_name.Text);
        //    //cmd.Parameters.AddWithValue("@EMAIL",txt_email.Text);
        //    ////cmd.Parameters.AddWithValue("@GENDER",txt_email.Text);
        //    //cmd.Parameters.AddWithValue("@CONTACT",txt_contact.Text);
        //    //cmd.Parameters.AddWithValue("@ADDRESS",txt_address.Text);
        //    ////cmd.Parameters.AddWithValue("@HOBBIES",txt_hobbies.Text);
        //    //cmd.Parameters.AddWithValue("@USERNAME", txt_username.Text);
        //    //cmd.Parameters.AddWithValue("@PASSWORD",txt_password.Text);
        //    //cmd.Parameters.AddWithValue("@CONFORM_PASSWORD",txt_conformpassword.Text);
        //    //con.Open();
        //    /*  int i = */
        //    Image a = pictureBox1.Image;
        //    cmd.ExecuteNonQuery();
        //    a.Save(path);
        //    cmmd.ExecuteNonQuery();
        //    I_cmd.ExecuteNonQuery();


        //    MessageBox.Show("Registered Successfully !!!");
        //    con.Close();
    }
    }
