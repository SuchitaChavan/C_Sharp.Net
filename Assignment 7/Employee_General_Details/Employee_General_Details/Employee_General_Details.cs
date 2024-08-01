using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_General_Details
{
    public partial class frm_Employee_General_Details : Form
    {
        public frm_Employee_General_Details()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string result = " ";
            bool flag = true, Lflag = true;

            if(tb_Name.Text != "")
            {
                result += tb_Name.Text + " is from ";
                lbl_Name_Err.Visible = false;
            }
            else
            {
                lbl_Name_Err.Text = "Enter Employee Name";
                lbl_Name_Err.Visible = true;
                flag = false;
            }



            if (cmb_Employee_Department.Text != "")
            {
                result += cmb_Employee_Department.Text;
                lbl_Dept_Err.Visible = false;
            }
            else
            {
                lbl_Dept_Err.Text = "Select Department";
                lbl_Dept_Err.Visible = true;
                flag = false;
            }
            


            if(rb_Male.Checked == true)
            {
                result += " is " + rb_Male.Text + " and he knows ";
                lbl_Gender_Err.Visible = false;
            }
            else if(rb_Female.Checked == true)
            {
                result += " is " + rb_Female.Text + " and she knows ";
                lbl_Gender_Err.Visible = false;
            }
             else
            {
                lbl_Gender_Err.Text = "Select Gender";
                lbl_Gender_Err.Visible = true;
                flag = false;
            }




            if(cb_Marathi.Checked == true)
            {
                result += cb_Marathi.Text + ",";
                lbl_Language_Err.Visible = false;
                Lflag = false;
            }
             if(cb_Hindi.Checked == true)
            {
                result += cb_Hindi.Text + ",";
                lbl_Language_Err.Visible = false;
                Lflag = false;
            }
             if(cb_English.Checked == true)
            {
                result += cb_English.Text + ",";
                lbl_Language_Err.Visible = false;
                Lflag = false;
            }
             if(cb_French.Checked == true)
            {
                result += cb_French.Text + ",";
                lbl_Language_Err.Visible = false;
                Lflag = false;
            }
            if(Lflag == true)
            {
                lbl_Language_Err.Text = "Select Language";
                lbl_Language_Err.Visible = true;
                flag = false;
            }



            int cnt = clb_Hobbies.CheckedItems.Count;
            if (cnt > 0)
            {
                lbl_Hobby_Err.Visible = false;
                result += " and has hobbies as ";
                for (int i = 0; i < clb_Hobbies.CheckedItems.Count; i++)
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        result += clb_Hobbies.Items[i] + ",";

                    }
                    else
                    {
                        result += clb_Hobbies.Items[i] + ".";
                        break;
                    }
                    cnt--;
                }
            }
            else
            {
                lbl_Hobby_Err.Text = "Select Hobby";
                lbl_Hobby_Err.Visible = true;
                flag = false;
            }
            

        if(flag == false)
            {

                tb_Output.Text = "Incomplete Information";
                tb_Output.Visible = true;
            }
        else
            {
                tb_Output.Text = result;
                tb_Output.Visible = true;
            }
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();

            cmb_Employee_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            cb_Marathi.Checked = false;
            cb_English.Checked = false;
            cb_French.Checked = false;
            cb_Hindi.Checked = false;

            for(int i=0;i<clb_Hobbies.Items.Count;i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }
            tb_Output.Clear();

        }

      
    }
}


















