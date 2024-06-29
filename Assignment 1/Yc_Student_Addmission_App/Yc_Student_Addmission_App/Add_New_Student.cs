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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection DBCon = new SqlConnection(@"Data Source=DESKTOP-AHT8DKD;Initial Catalog=Yc_Addmission_App_DB;Integrated Security=True");
        void S_Con_Open()
        {
            if(DBCon.State != ConnectionState.Open)
            {
                DBCon.Open();
            }
        }

        void S_Con_Close()
        {
            if(DBCon.State != ConnectionState.Closed)
            {
                DBCon.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)||(e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;
            }
          
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)||(e.KeyChar==(char)Keys.Back)||(e.KeyChar==(char)Keys.Space)||(e.KeyChar==(char)Keys.ShiftKey)||(e.KeyChar==(char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }


        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            dtp_Date_Of_Birth.ResetText();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
        }
        private void 
            btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            S_Con_Open();

            if(tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = DBCon;
                Cmd.CommandText = "Insert Into Student_Details(Roll_No,Name,Date_Of_Birth,Mobile_No,Course) values(@RNo,@NM,@DOB,@Mob_No,@Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("NM", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                Cmd.Parameters.Add("Mob_No", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Information Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            S_Con_Close();
        }

        private void btn_List_Of_Students_Click(object sender, EventArgs e)
        {
            frm_List_Of_Students obj = new frm_List_Of_Students();
            obj.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

       
    }
}
