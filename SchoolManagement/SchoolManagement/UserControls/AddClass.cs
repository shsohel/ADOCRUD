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
    public partial class AddClassUC : UserControl
    {
        //Gobal ConnectionString Instance
        string cs = ConfigurationManager.ConnectionStrings["DbCon"].ConnectionString;

        //DataTable Gobal Variable 
        DataTable dtAddClass;

      
        /// UserControl Instance for Menu Load
       
        private static AddClassUC _instanceAddClass;
        public static AddClassUC InstanceAddClass
        {
            get
            {
                if (_instanceAddClass == null)
                    _instanceAddClass = new AddClassUC();
                return _instanceAddClass;
            }
        }


        //Public Contractor 
        public AddClassUC()
        {
            InitializeComponent();
        }


  
        /// Data Load Run Time Event
        private void AddClassUC_Load(object sender, EventArgs e)
        {
            GetClassList(); //Class Load Method
        }

        //Load TIme Data Method
        private DataTable GetClassList()
        {
            SqlConnection con = new SqlConnection(cs);

            con.Open();

            string showQry = "SELECT*FROM dbo.MClass";
            SqlCommand cmd = new SqlCommand(showQry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dtAddClass = new DataTable();
            da.Fill(dtAddClass);
            dtgvAddClass.DataSource = dtAddClass.DefaultView;

            con.Close();

            return dtAddClass;
        }

        //Submit Class Name 
        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
                if (txtClassAdd.Text != "")
                {
                    con.Open();

                    string qry = " INSERT INTO dbo.MClass (MClassName) VALUES (@classname )";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@classname", txtClassAdd.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record saved successfully!!!");

                    //Clear Text Box After Data Inserted 
                    txtClassAdd.Text = "";

                    con.Close();

                    //Data Load 
                    con.Open();

                    string showQry = "SELECT*FROM dbo.MClass";
                    cmd = new SqlCommand(showQry, con);
                    dtAddClass = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtAddClass);
                    dtgvAddClass.DataSource = dtAddClass.DefaultView;

                    con.Close();

                }
                else
                {
                    MessageBox.Show("Please Provide Class Name ");
                }
        }


    }
}
