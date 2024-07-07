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
    public partial class frm_List_Of_Students : Form
    {
        public frm_List_Of_Students()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();

        }

        private void frm_List_Of_Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yc_Addmission_App_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter1.Fill(this.yc_Addmission_App_DBDataSet.Student_Details);

            lbl_Logged_User.Text = " Welcome " + Shared_Content.Logged_User;

        }

      
    }
}
