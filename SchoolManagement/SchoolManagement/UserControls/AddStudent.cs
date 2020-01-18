using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SchoolManagement.UserControls
{
    public partial class AddStudentUC : UserControl
    {
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;

        //We can use gobal if We haven't same type selection.

        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtStudent = new DataTable();



        //Declare an Instance of AddStudent Control for Call it on it's button
        private static AddStudentUC _instanceAddStudent;
        public static AddStudentUC InstanceAddStudent
        {
            get
            {
                if (_instanceAddStudent == null)
                    _instanceAddStudent = new AddStudentUC();
                return _instanceAddStudent;
            }
        }

        public AddStudentUC()
        {
            InitializeComponent();
            fillClassCombo(); //Class DropDown from CombooBox
        }


        //Load Student List on Grid View 
        private void AddStudentUC_Load(object sender, EventArgs e)
        {
            GetStudentList();
        }

        //Load Student List on Grid View Method
        private DataTable GetStudentList()
        {
            SqlConnection con = new SqlConnection(cs);

            con.Open();

            string showQry = "SELECT*FROM dbo.Student";
            SqlCommand cmd = new SqlCommand(showQry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dtStudent = new DataTable();
            da.Fill(dtStudent);
            dtgvAddStudent.DataSource = dtStudent.DefaultView;

            con.Close();

            return dtStudent;
        }



        //Dropdown Box Fill from MClass Object
        public void fillClassCombo()
        {

            SqlConnection con = new SqlConnection(cs);
            string showQry = "SELECT MClassID, MClassName FROM dbo.MClass";
             cmd = new SqlCommand(showQry, con);
            SqlDataAdapter dat = new SqlDataAdapter();
            //DataTable dt = new DataTable();
            dat.SelectCommand = cmd;
            dat.Fill(dtStudent);
            comBoxClassSt.DataSource = dtStudent;
            comBoxClassSt.DisplayMember = "MClassName";
            comBoxClassSt.ValueMember = "MClassID";

        }



        //Insert Student by Insert Button or Submit 
        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (txtStudentName.Text != "" && comBoxClassSt.Text !="")
            {
                con.Open();

                string qry = " INSERT INTO dbo.Student (StudentName,ClassName ) VALUES (@studentname, @classname )";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@studentname", txtStudentName.Text);

                cmd.Parameters.AddWithValue("@classname", comBoxClassSt.SelectedValue.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record saved successfully!!!");

                //Clear Text Box After Data Inserted 
                txtStudentName.Text = "";
                comBoxClassSt.Text = "";

                con.Close();

                //Data Load 
                con.Open();

                string showQry = "SELECT*FROM dbo.Student";
                cmd = new SqlCommand(showQry, con);
                dtStudent = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtStudent);
                dtgvAddStudent.DataSource = dtStudent.DefaultView;

                con.Close();

            }
            else
            {
                MessageBox.Show("Please Provide Accurate Field ");
            }
        }


    }
}
