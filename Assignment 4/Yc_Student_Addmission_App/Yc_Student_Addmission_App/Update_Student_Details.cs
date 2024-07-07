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
    public partial class frm_Update_Student_Details : Form
    {
        public frm_Update_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection DBcon = new SqlConnection (@"Data Source=DESKTOP-AHT8DKD;Initial Catalog=Yc_Addmission_App_DB;Integrated Security=True");

        void DBcon_open()
        {
            if(DBcon.State != ConnectionState.Open)
            {
                DBcon.Open();
            }
        }
        
        void DBcon_close()
        {
            if(DBcon.State != ConnectionState.Closed)
            {
                DBcon.Close();
            }
        }


        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }


     

        void Disable_Controls()
        {
            tb_Roll_No.Enabled = true;
            tb_Name.Enabled = false;
            tb_Mobile_No.Enabled = false;
            cmb_Course.Enabled = false;
            dtp_Date_Of_Birth.Enabled = false;
        }
        
        void Enable_Controls()
        {
            tb_Roll_No.Enabled = false;
            tb_Name.Enabled = true;
            tb_Mobile_No.Enabled = true;
            cmb_Course.Enabled = true;
            dtp_Date_Of_Birth.Enabled = true;

        }

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            dtp_Date_Of_Birth.ResetText();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Enable_Controls();
        }


        private void btn_Search_Click(object sender, EventArgs e)
        {

            DBcon.Open();

            if(tb_Roll_No.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = DBcon;
                cmd.CommandText = "Select * From Student_Details where Roll_No = @Rno";

                cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.Read())
                {
                    tb_Name.Text = sdr.GetString(sdr.GetOrdinal("Name"));
                    tb_Mobile_No.Text = (sdr["Mobile_No"].ToString());
                    cmb_Course.Text = sdr.GetString(sdr.GetOrdinal("Course"));
                    dtp_Date_Of_Birth.Text = (sdr["Date_Of_Birth"].ToString());
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Roll_No", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    tb_Roll_No.Clear();
                    tb_Roll_No.Focus();
                }
            }

            else
            {
                MessageBox.Show("First Fill Roll No", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DBcon_close();

     }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            DBcon_open();

            if (tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = DBcon;
                cmd.CommandText = "Update Student_Details set Name = @Nm , Mobile_No = @Mob , Date_Of_Birth = @Dob , Course = @course where Roll_No = @Rno";

                cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Mob", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                cmd.Parameters.Add("course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Is Updated","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Clear_Controls();
                Disable_Controls();

            }
            else
            {
                MessageBox.Show("Fill All Fields", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }

            DBcon_close();
        }


        private void btn_List_Of_Students_Click(object sender, EventArgs e)
        {
            frm_List_Of_Students LOS = new frm_List_Of_Students();
            LOS.Show();
            this.Hide();
        }


        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form LF = new frm_Login_Form();
            LF.Show();
            this.Hide();

        }

   
    }
}
