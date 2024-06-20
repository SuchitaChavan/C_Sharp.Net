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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text=="Admin" && tb_Password.Text=="123" || tb_Username.Text=="S" && tb_Password.Text=="s")
            {
                MessageBox.Show("Login Successful", "Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Enter Correct Username & Password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_Username.Clear();
                tb_Password.Clear();

            }
        }

   
    }
}
