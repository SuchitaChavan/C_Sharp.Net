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
using System.IO;


namespace Picture_Box_Assignment
{
    public partial class frm_Show_Image : Form
    {
        public frm_Show_Image()
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

        private void btn_Add_Image_Click(object sender, EventArgs e)
        {
            frm_Insert_Image II = new frm_Insert_Image();
            II.Show();
            this.Hide();
        }


        void Bind_Grid(String Query,DataGridView obj)
        {
            Con_Open();

            obj.DataSource = "";
            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable DT = new DataTable();

            SDA.Fill(DT);
            obj.DataSource = DT;
            
            Con_Close();
        }

        void View_Image(String Query,PictureBox pb)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand(Query,Con);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count>0)
            {
               MemoryStream ms = new MemoryStream((byte[])DS.Tables[0].Rows[0]["Image"]);

                pb.Image = new Bitmap(ms);

            }
            else
            {
                MessageBox.Show("Invalid Image Id!!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            Con_Close();
        }

        private void frm_Show_Image_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select Image_Id,Image_Description from Image", dgv_Image_List);
        }

        private void dgv_Image_List_SelectionChanged(object sender, EventArgs e)
        {
            Int32 SelectedRowCount = dgv_Image_List.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if(SelectedRowCount == 1)
            {
                String value = dgv_Image_List.SelectedCells[0].RowIndex.ToString();

                int Index = Convert.ToInt32(value);

                int ID = Convert.ToInt32(dgv_Image_List.Rows[Index].Cells[0].Value);

                View_Image("Select Image from Image where Image_Id = " + ID + " ", pb_Image);

            }
        }
    }
}




































