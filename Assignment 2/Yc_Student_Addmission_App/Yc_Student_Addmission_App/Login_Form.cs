using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yc_Student_Addmission_App
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        SqlConnection DBCon = new SqlConnection(@"Data Source=DESKTOP-AHT8DKD;Initial Catalog=Yc_Addmission_App_DB;Integrated Security=True");

        void Con_open()
        { 
          if(DBCon.State != ConnectionState.Open)
            {
                DBCon.Open();
            }
        }

        void Con_Close()
        {
            if(DBCon.State != ConnectionState.Closed)
            {
                DBCon.Close();
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_open();

            int Ret= 0;

            SqlCommand cmd = new SqlCommand("Select Count(*) From Login_Details Where Username = @Uname And Password = @Pwd ",DBCon);
           // cmd.Connection = DBCon;
            //cmd.CommandText = "select count(*) from Login_Details where Username = @Uname , Password = @Pwd ";

            cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
            cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

           Ret = Convert.ToInt32(cmd.ExecuteScalar());

            if(Ret > 0)
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            
            else
            {
                lbl_Error.Text = "Invalid Username And Password";
                lbl_Error.ForeColor = Color.Red;

            }


            tb_Username.Clear();
            tb_Password.Clear();

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;

            tb_Username.Focus();

            Con_Close();
            
           }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Error.Visible = true;
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;

        }
    }
     }
