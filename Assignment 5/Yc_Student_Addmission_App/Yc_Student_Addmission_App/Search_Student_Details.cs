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
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection DBcon = new SqlConnection(@"Data Source=DESKTOP-AHT8DKD;Initial Catalog=Yc_Addmission_App_DB;Integrated Security=True");

        void DBcon_open()
        {
            if (DBcon.State != ConnectionState.Open)
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
        void Enable_Controls()
        {
            tb_Name.Enabled = true;
            cmb_Course.Enabled = true;
            dtp_Date_Of_Birth.Enabled = true;
            tb_Mobile_No.Enabled = true;
        }

        private void tb_Roll_No_TextChanged(object sender, EventArgs e)
        {
            Enable_Controls();
        }

        private void frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DBcon_open();

            if (tb_Roll_No.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = DBcon;
                cmd.CommandText = "Select * From Student_Details where Roll_No = @Rno";

                cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
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
                MessageBox.Show("First Fill Roll No", "Incomplete Info",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

           DBcon_close();

        }

      

       void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_Date_Of_Birth.ResetText();
            cmb_Course.SelectedIndex = -1;
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Enable_Controls();

        }  
    }
}
