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
    public partial class UpdateClassUC : UserControl
    {
        //Connectiong String Link here
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;


        //DataTable Gobal Variable 
        DataTable dtClass;

        //Select Row Gobal Variable
        int SelectRow;



        //Create Instace or Object to call Home Menu Button
        private static UpdateClassUC _updateClass;
        public static UpdateClassUC InstanceUpClass
        {
            get
            {
                if (_updateClass == null)
                    _updateClass = new UpdateClassUC();
                return _updateClass;
            }
        }



        public UpdateClassUC()
        {
            InitializeComponent();
        }

        //Form Load GridView Display Data
        private void UpdateClass_Load(object sender, EventArgs e)
        {
            GetClassList();
        }



        //Load TIme Data Method
        private DataTable GetClassList()
        {
            SqlConnection con = new SqlConnection(cs);

            con.Open();

            string showQry = "SELECT*FROM dbo.MClass";
            SqlCommand cmd = new SqlCommand(showQry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dtClass = new DataTable();
            da.Fill(dtClass);
            dtgvUpdateClass.DataSource = dtClass.DefaultView;

            con.Close();

            return dtClass;
        }





        //Update Button When Fired
        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            if (txtClassIDUpdate.Text != "" && txtClassName.Text != "")
            {
                con.Open();
                string qry = "UPDATE dbo.MClass SET MClassName='" + txtClassName.Text + "'WHERE MClassID='" + txtClassIDUpdate.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@mclassname", txtClassName.Text);
                cmd.Parameters.AddWithValue("@mclassid", txtClassIDUpdate.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Data Successfullt!!!");


                txtClassIDUpdate.Text = "";
                txtClassName.Text = "";



                //For Fresh Data After Fired Event
                string showQry = "SELECT*FROM dbo.MClass";
                cmd = new SqlCommand(showQry, con);
                dtClass = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtClass);
                dtgvUpdateClass.DataSource = dtClass.DefaultView;

                con.Close();
            }
            else
            {
                MessageBox.Show("Please Provide Field Missing!!!!");
            }


        }

        //Delete Button Event
        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            if (txtClassIDUpdate.Text != "")
            {
                con.Open();
                string qry = "DELETE FROM dbo.MClass WHERE MClassID=@mclassid";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@mclassid", txtClassIDUpdate.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Data Successfully!!!");


                //For Fresh Data After Fired Event
                string showQry = "SELECT * FROM dbo.MClass";
                cmd = new SqlCommand(showQry, con);
                dtClass = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtClass);
                dtgvUpdateClass.DataSource = dtClass.DefaultView;

                con.Close();
            }


            
        }


        //Select Row on GridView for Update and Delete
        private void dtgvUpdateClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow = e.RowIndex;
            DataGridViewRow row = dtgvUpdateClass.Rows[SelectRow];
            txtClassIDUpdate.Text = row.Cells[0].Value.ToString();
            txtClassName.Text = row.Cells[1].Value.ToString();
        }
    }
}
