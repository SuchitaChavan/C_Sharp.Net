using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yc_Student_Addmission_App
{
    public partial class frm_MDI_Parent : Form
    {
        public frm_MDI_Parent()
        {
            InitializeComponent();
        }

        private void frm_MDI_Parent_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = " Welcome " + Shared_Content.User_Name;
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student ANS = new frm_Add_New_Student();
            ANS.MdiParent = this;
            ANS.WindowState = FormWindowState.Maximized;
            ANS.Show();
        }

        private void searchStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details SSD = new frm_Search_Student_Details();
            SSD.MdiParent = this;
            SSD.WindowState = FormWindowState.Maximized;
            SSD.Show();
        }

        private void updateStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details USD = new frm_Update_Student_Details();
            USD.MdiParent = this;
            USD.WindowState = FormWindowState.Maximized;
            USD.Show();

        }

        private void listOfStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_List_Of_Students LOS = new frm_List_Of_Students();
            LOS.MdiParent = this;
            LOS.WindowState = FormWindowState.Maximized;
            LOS.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Course AC = new frm_Add_Course();
            AC.MdiParent = this;
            AC.StartPosition = FormStartPosition.CenterScreen;
            AC.Show();
        }

        private void courseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Course_List CL = new frm_Course_List();
            CL.MdiParent = this;
            CL.StartPosition = FormStartPosition.CenterScreen;
            CL.Show();
        }

        private void calculaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are You Sure You Want To Logout !!", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DR == DialogResult.Yes)
            {
                frm_Login_Form obj = new frm_Login_Form();
                obj.Show();
                this.Hide();

            }
        }
    }
}
