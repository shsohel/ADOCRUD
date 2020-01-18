using SchoolManagement.Forms;
using SchoolManagement.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }




        //All Menu Click Event Here
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(HomePageUC.Instancehpg))
            {
                panelMain.Controls.Add(HomePageUC.Instancehpg);
                HomePageUC.Instancehpg.Dock = DockStyle.Fill;
                HomePageUC.Instancehpg.BringToFront();
            }
            else
            {
                HomePageUC.Instancehpg.BringToFront();
            }
        }


        private void AddClassMenu_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(AddClassUC.InstanceAddClass))
            {
                panelMain.Controls.Add(AddClassUC.InstanceAddClass);
                AddClassUC.InstanceAddClass.Dock = DockStyle.Fill;
                AddClassUC.InstanceAddClass.BringToFront();
            }
            else
            {
                AddClassUC.InstanceAddClass.BringToFront();
            }
        }

        private void updateClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(UpdateClassUC.InstanceUpClass))
            {
                panelMain.Controls.Add(UpdateClassUC.InstanceUpClass);
                UpdateClassUC.InstanceUpClass.Dock = DockStyle.Fill;
                UpdateClassUC.InstanceUpClass.BringToFront();
            }
            else
            {
                UpdateClassUC.InstanceUpClass.BringToFront();
            }
        }

        private void assignStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(AddStudentUC.InstanceAddStudent))
            {
                panelMain.Controls.Add(AddStudentUC.InstanceAddStudent);
                AddStudentUC.InstanceAddStudent.Dock = DockStyle.Fill;
                AddStudentUC.InstanceAddStudent.BringToFront();
            }
            else
            {
                AddStudentUC.InstanceAddStudent.BringToFront();
            }
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(UpdateStudentUC.InstanceUpStudent))
            {
                panelMain.Controls.Add(UpdateStudentUC.InstanceUpStudent);
                UpdateStudentUC.InstanceUpStudent.Dock = DockStyle.Fill;
                UpdateStudentUC.InstanceUpStudent.BringToFront();
            }
            else
            {
                UpdateStudentUC.InstanceUpStudent.BringToFront();
            }
        }


        //Logout Button
        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Close();
            Login llout = new Login();
            llout.Show();

        }
    }
}
