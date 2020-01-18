using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Forms
{
    public partial class Login : Form
    {
        //Connection String Declared from App.Config File
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;


        public Login()
        {
            InitializeComponent();
        }


        //Login Button When Click 

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            

            SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM MyUser WHERE  UserName = '" + txtBoxUser.Text + "' AND Password = '" + txtBoxPassword.Text + "' ", con);

            DataTable dt = new DataTable();
            cmd.Fill(dt);


                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        Home mainhome = new Home();
                        mainhome.Show();
                    }
                    else
                    {
                        MessageBox.Show("UserName or PassWord INcorrect");
                    } 

        }


        ///Cancel Button When Click or Closed
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Reset Field
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxUser.Text = "";
            txtBoxPassword.Text = "";


        }
    }
}
