
namespace Yc_Student_Addmission_App
{
    partial class frm_List_Of_Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_List_Of_Students));
            this.lbl_List_Of_Students = new System.Windows.Forms.Label();
            this.dgv_Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yc_Addmission_App_DBDataSet = new Yc_Student_Addmission_App.Yc_Addmission_App_DBDataSet();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yc_Student_Addmission_App_DBDataSet1 = new Yc_Student_Addmission_App.Yc_Student_Addmission_App_DBDataSet1();
            this.student_DetailsTableAdapter = new Yc_Student_Addmission_App.Yc_Student_Addmission_App_DBDataSet1TableAdapters.Student_DetailsTableAdapter();
            this.student_DetailsTableAdapter1 = new Yc_Student_Addmission_App.Yc_Addmission_App_DBDataSetTableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data_Grid_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yc_Addmission_App_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yc_Student_Addmission_App_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_List_Of_Students
            // 
            this.lbl_List_Of_Students.AutoSize = true;
            this.lbl_List_Of_Students.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_List_Of_Students.Font = new System.Drawing.Font("Lucida Fax", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_List_Of_Students.ForeColor = System.Drawing.Color.Green;
            this.lbl_List_Of_Students.Location = new System.Drawing.Point(231, 43);
            this.lbl_List_Of_Students.Name = "lbl_List_Of_Students";
            this.lbl_List_Of_Students.Size = new System.Drawing.Size(412, 55);
            this.lbl_List_Of_Students.TabIndex = 0;
            this.lbl_List_Of_Students.Text = "List Of Students";
            this.lbl_List_Of_Students.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Data_Grid_View
            // 
            this.dgv_Data_Grid_View.AllowUserToAddRows = false;
            this.dgv_Data_Grid_View.AllowUserToDeleteRows = false;
            this.dgv_Data_Grid_View.AutoGenerateColumns = false;
            this.dgv_Data_Grid_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Data_Grid_View.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Data_Grid_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Data_Grid_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data_Grid_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Data_Grid_View.DataSource = this.studentDetailsBindingSource1;
            this.dgv_Data_Grid_View.GridColor = System.Drawing.Color.Maroon;
            this.dgv_Data_Grid_View.Location = new System.Drawing.Point(31, 153);
            this.dgv_Data_Grid_View.Name = "dgv_Data_Grid_View";
            this.dgv_Data_Grid_View.ReadOnly = true;
            this.dgv_Data_Grid_View.Size = new System.Drawing.Size(830, 335);
            this.dgv_Data_Grid_View.TabIndex = 1;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";
            this.studentDetailsBindingSource1.DataSource = this.yc_Addmission_App_DBDataSet;
            // 
            // yc_Addmission_App_DBDataSet
            // 
            this.yc_Addmission_App_DBDataSet.DataSetName = "Yc_Addmission_App_DBDataSet";
            this.yc_Addmission_App_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.yc_Student_Addmission_App_DBDataSet1;
            // 
            // yc_Student_Addmission_App_DBDataSet1
            // 
            this.yc_Student_Addmission_App_DBDataSet1.DataSetName = "Yc_Student_Addmission_App_DBDataSet1";
            this.yc_Student_Addmission_App_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // student_DetailsTableAdapter1
            // 
            this.student_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_List_Of_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(890, 500);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Data_Grid_View);
            this.Controls.Add(this.lbl_List_Of_Students);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_List_Of_Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Of Students";
            this.Load += new System.EventHandler(this.frm_List_Of_Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data_Grid_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yc_Addmission_App_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yc_Student_Addmission_App_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_List_Of_Students;
        private System.Windows.Forms.DataGridView dgv_Data_Grid_View;
        private Yc_Student_Addmission_App_DBDataSet1 yc_Student_Addmission_App_DBDataSet1;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Yc_Student_Addmission_App_DBDataSet1TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private Yc_Addmission_App_DBDataSet yc_Addmission_App_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private Yc_Addmission_App_DBDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter1;
    }
}