using System.Data;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp1
 
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QMJ8D3L;Initial Catalog=Windows_loginpage;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username, user_password;

            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                if (txt_username.Text == "admin" && txt_password.Text == "admin123")
                {
                    Nextpage admin = new Nextpage();
                    admin.Show();
                    this.Hide();
                    Focus();
                }
                else
                {




                    string querry = "SELECT * FROM INSERTS WHERE username ='" + txt_username.Text + "' AND password='" + txt_password.Text + "'";
                    SqlDataAdapter SDA = new SqlDataAdapter(querry, conn);

                    DataTable dtable = new DataTable();
                    SDA.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        username = txt_username.Text;
                        user_password = txt_password.Text;
                        string UserID = dtable.Rows[0]["EMP_KEY_ID"].ToString();



                        //page that need to be load next 
                        MenuForm form2 = new MenuForm(UserID);
                        form2.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Clear();
                        txt_password.Clear();

                        //to focus username
                        txt_username.Focus();

                    }

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

        private void button_Clear_Click(object sender, EventArgs e)

        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f1 = new Register();
            f1.Show();

        }

        //    private void txt_username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(txt_username.Text))
        //        {
        //            e.Cancel = true;
        //            txt_username.Focus();
        //            errorProvider1.SetError(txt_username, "Please Enter your User name !");
        //        }
        //        else
        //        {
        //            e.Cancel = true;
        //            errorProvider1.SetError(txt_username,null);
        //        }
        //    }

        //    private void txt_password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //    {
        //        if (string.IsNullOrEmpty(txt_password.Text))
        //        {
        //            e.Cancel = true;
        //            txt_password.Focus();
        //            errorProvider1.SetError(txt_password, "Please Enter your User name !");
        //        }
        //        else
        //        {
        //            e.Cancel = true;
        //            errorProvider1.SetError(txt_password, null);
        //        }
        //    }
    



    } 
 }
    
