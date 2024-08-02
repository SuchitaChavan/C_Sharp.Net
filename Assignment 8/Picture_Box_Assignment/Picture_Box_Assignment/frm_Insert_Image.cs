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

namespace Picture_Box_Assignment
{
    public partial class frm_Insert_Image : Form
    {
        public frm_Insert_Image()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-AHT8DKD;Initial Catalog=Picture_Box_DB;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        int Auto_Incr()

        {
            int count = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Con;
            cmd.CommandText = "select count(*) from Image";

            count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                cmd.Dispose();

                cmd.Connection = Con;
                cmd.CommandText = "select max(Image_Id) from Image";

                count = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            }

            else
            {
                count = 101;
            }

            Con_Close();
            return count;
        }

        private void frm_Insert_Image_Load(object sender, EventArgs e)
        {
            tb_Image_Id.Focus();
            tb_Image_Id.Text = Convert.ToString(Auto_Incr());
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (Char)Keys.Back)));
        }

        void Clear_Controls()
        {
            tb_Image_Id.Text = Convert.ToString(Auto_Incr());
            tb_Image_Description.Clear();
            pb_Image.Image = null;
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files(*.jpg; *.png; *.gif; *.ico; *.bmp)|*.jpg; *.png; *.gif; *.ico; *.bmp";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Image_Id.Text != "" && tb_Image_Description.Text != "" && pb_Image.Image != null)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insert into Image values(@Id,@Image_D,@Image)";

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = tb_Image_Id.Text;
                cmd.Parameters.Add("@Image_D", SqlDbType.NVarChar).Value = tb_Image_Description.Text;

                ImageConverter IC = new ImageConverter();
                byte[] imgArray = (byte[])IC.ConvertTo(pb_Image.Image, typeof(byte[]));

                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgArray;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Image Details Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }

            else
            {
                MessageBox.Show("Fill All Fields", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();

        }

        private void btn_Show_Image_Click(object sender, EventArgs e)
        {
            frm_Show_Image SI = new frm_Show_Image();
            SI.Show();
            this.Hide();
        }

    }
}
















