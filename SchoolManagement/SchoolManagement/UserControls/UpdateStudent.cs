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
    public partial class UpdateStudentUC : UserControl
    {
        //Connection String Globally Called
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;

        //We can use gobal if We haven't same type selection.

        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtStudent = new DataTable();
        int SelectRow;



        /// UserControl Instance for Menu Load

        private static UpdateStudentUC _instanceUpStudent;
        public static UpdateStudentUC InstanceUpStudent
        {
            get
            {
                if (_instanceUpStudent == null)
                    _instanceUpStudent = new UpdateStudentUC();
                return _instanceUpStudent;
            }
        }




        //Load Time Event or Public Contraction
        public UpdateStudentUC()
        {
            InitializeComponent();
            fillClassCombo();
        }


        //Load Time Event
        private void UpdateStudentUC_Load(object sender, EventArgs e)
        {
            GetStudentList();
        }


        //Load Time Method for Data Display on GridView
        private DataTable GetStudentList()
        {
            SqlConnection con = new SqlConnection(cs);

            con.Open();

            string showQry = "SELECT*FROM dbo.Student";
            SqlCommand cmd = new SqlCommand(showQry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dtStudent = new DataTable();
            da.Fill(dtStudent);
            dtgvUpdateStudent.DataSource = dtStudent.DefaultView;

            con.Close();

            return dtStudent;

        }



        //Load DropDown List from MClass Object or Class
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




        //Load Data on Data Field When GridView Row Click
        private void dtgvUpdateStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;
            DataGridViewRow row = dtgvUpdateStudent.Rows[SelectRow];
            txtStudentID.Text = row.Cells[0].Value.ToString();
            txtStudentName.Text = row.Cells[1].Value.ToString();
            comBoxClassSt.Text = row.Cells[2].Value.ToString();


        }


        //Delete Button when Fired
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            if (txtStudentID.Text != "" )
            {
                con.Open();
                string qry = "DELETE FROM dbo.Student WHERE StudentID =@studentid ";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@studentid", txtStudentID.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Data Successfully!!!");

                string showQry = "SELECT * FROM dbo.Student";
                cmd = new SqlCommand(showQry, con);
                dtStudent = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtStudent);
                dtgvUpdateStudent.DataSource = dtStudent.DefaultView;

                con.Close();
            }
        }


        //Update Button When Fired
        private void btnStudentUdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            if (txtStudentID.Text != "" && txtStudentName.Text != "" && comBoxClassSt.Text != "")
            {
                con.Open();
                string qry = "UPDATE dbo.Student SET StudentName ='" + txtStudentName.Text + "', ClassName ='" + comBoxClassSt.SelectedValue.ToString() + "'   WHERE StudentID ='" + txtStudentID.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@studentname", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@classname", comBoxClassSt.SelectedValue.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Data Successfullt!!!");


                txtStudentName.Text = "";
                txtStudentID.Text = "";
                comBoxClassSt.Text = "";




                string showQry = "SELECT*FROM dbo.Student";
                cmd = new SqlCommand(showQry, con);
                dtStudent = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtStudent);
                dtgvUpdateStudent.DataSource = dtStudent.DefaultView;

                con.Close();
            }
            else
            {
                MessageBox.Show("Please Provide Field!!!!");
            }
        }
    }
}
