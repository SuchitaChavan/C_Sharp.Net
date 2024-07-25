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
    public partial class frm_Add_Course : Form
    {
        public frm_Add_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-AHT8DKD;Initial Catalog=Yc_Addmission_App_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }


        int AutoIncr()

        {
            int count = 0;

          Con_Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Con;
            cmd.CommandText = "select count(*) from Course";

            count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                cmd.Dispose();

                cmd.Connection = Con;
                cmd.CommandText = "select max(Course_Id) from Course";

                count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            }

            else
            {
                count = 101;
            }

            Con_Close();
            return count;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Course_Id.Text != "" && tb_Course_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert into Course(Course_Id,Course_Name) Values(@Id,@Nm)";

                cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Course_Id.Text;
                cmd.Parameters.Add("Nm", SqlDbType.NVarChar).Value = tb_Course_Name.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Course is Saved", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_Course_Id.Text = Convert.ToString(AutoIncr());
                tb_Course_Name.Clear();
            }

            else
            {

                MessageBox.Show("Fill All Fields", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();

        }

        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            tb_Course_Id.Text = Convert.ToString(AutoIncr());
        }

       
    }
}
