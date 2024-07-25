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
    public partial class frm_Course_List : Form
    {
        public frm_Course_List()
        {
            InitializeComponent();
        }

        private void frm_Course_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yc_Addmission_App_DBDataSet2.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this.yc_Addmission_App_DBDataSet2.Course);
            // TODO: This line of code loads data into the 'yc_Addmission_App_DBDataSet1.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.yc_Addmission_App_DBDataSet1.Course);

        }
    }
}
