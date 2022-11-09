using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WinFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        string pattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm f3 = new MenuForm();
            f3.Show();
        }
        string GENDER;
        string HOBBIES;
      

        //leave event For validating while leaving that box 
        private void txt_username_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_username.Text) == true)
            {
                
                errorProvider1.SetError(this.txt_username, "Please Enter Username !!");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_password.Text, pattern) == false)
            {
               
                errorProvider2.SetError(this.txt_password, "UPPERCASE, LOWERCASE, NUMBER ,SPECIAL CHARACTER");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txt_conformpassword_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text != txt_conformpassword.Text)
            {
                
                errorProvider3.SetError(this.txt_conformpassword, "Passowrd Doesnt Match !!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txt_username.Text) == true)
            {

                errorProvider1.SetError(this.txt_username, "Please Enter Username !!");

            }
            else if (Regex.IsMatch(txt_password.Text, pattern) == false)
            {

                errorProvider2.SetError(this.txt_password, "UPPERCASE, LOWERCASE, NUMBER ,SPECIAL CHARACTER");
            }
            else if (txt_password.Text != txt_conformpassword.Text)
            {

                errorProvider3.SetError(this.txt_conformpassword, "Password Doesnt Match !!");
            }
            else
            {

                //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QMJ8D3L;Initial Catalog=Windows_loginpage;Integrated Security=True");

                string location = "C:\\Users\\Sabin Dumre\\Desktop\\windows application\\WinFormsApp1\\WinFormsApp1\\ProfilePic";
                
                string path = Path.Combine(location, txt_username.Text+".jpg");


                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO INSERTS (NAME, EMAIL, GENDER, CONTACT, ADDRESS, USERNAME, PASSWORD, CONFORM_PASSWORD, PIC_PATH, LAPTOP_NUMBER, LOCKER_NUMBER, OFFICIAL_MAIL, OFFICIAL_PASSWORD, GIT_USERNAME, GIT_PASSWORD ) " +
                    "Values ( '" + txt_name.Text + "','" + txt_email.Text + "','" + GENDER + "','" + txt_contact.Text + "', '" + txt_address.Text + "' , '" + txt_username.Text + "','" + txt_password.Text + "','" + txt_conformpassword.Text + "','" + path + "', '" + txt_laptopnumber.Text + "' , '" + txt_lockernumber.Text + "','" + txt_officialmail.Text + "','" + txt_officalpassword.Text + "','" + txt_gitusername.Text + "','" + txt_gitpassword.Text + "')", con);
                
                

                SqlCommand cmmd = new SqlCommand("INSERT INTO H_INSERTS (NAME, READING, GAMMING, TRAVELLING, HIKING) " +
                    "Values ( '" + txt_name.Text + "','" + checkBox_reading.Checked + "','" + checkBox_gamming.Checked + "','" + checkBox3_reading.Checked + "', '" + checkBox4_hiking.Checked + "')", con);

                //SqlCommand I_cmd = new SqlCommand("INSERT INTO LoginPage ( username , password) " +
                //     "Values ( '" + txt_username.Text + "','" + txt_password.Text + "')", con);

                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@NAME",txt_name.Text);
                //cmd.Parameters.AddWithValue("@EMAIL",txt_email.Text);
                ////cmd.Parameters.AddWithValue("@GENDER",txt_email.Text);
                //cmd.Parameters.AddWithValue("@CONTACT",txt_contact.Text);
                //cmd.Parameters.AddWithValue("@ADDRESS",txt_address.Text);
                ////cmd.Parameters.AddWithValue("@HOBBIES",txt_hobbies.Text);
                //cmd.Parameters.AddWithValue("@USERNAME", txt_username.Text);
                //cmd.Parameters.AddWithValue("@PASSWORD",txt_password.Text);
                //cmd.Parameters.AddWithValue("@CONFORM_PASSWORD",txt_conformpassword.Text);
                //con.Open();
                /*  int i = */
                Image a = pictureBox1.Image;
                cmd.ExecuteNonQuery();
                a.Save(path);
                cmmd.ExecuteNonQuery();
                //I_cmd.ExecuteNonQuery();


                MessageBox.Show("Registered Successfully !!!");
                con.Close();

                this.Hide();
                MenuForm f3 = new MenuForm();
                f3.Show();

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


        public static void main(string[] args)
        {
            Application.Run(new Register());
        }


       
        private void txt_name_Validating(object sender, CancelEventArgs e)
        {
            if (txt_name.Text == string.Empty)
            {
                errorProvider4.SetError(this.txt_name, "Please Fulfill this field !");
            }
        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            if (txt_email.TextLength == 0)
            {
                errorProvider4.SetError(this.txt_email, "please enter mail");
            }
            if (txt_email.Text.IndexOf("@") > -1)
            {
                if (txt_email.Text.IndexOf(".", txt_email.Text.IndexOf("@")) > txt_email.Text.IndexOf("@"))
                {
                    errorProvider4.SetError(this.txt_email, "Must be in form of : Someone@example.com ");
                   
                }
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            Button p = sender as Button;
            if (p != null)
            {
                open.Filter = "(*.jpg;*.jpeg;*.png) | *.jpg; *.jpeg; *.png;*.j";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap (open.FileName);
                }
            }
        }

      
    }
}
