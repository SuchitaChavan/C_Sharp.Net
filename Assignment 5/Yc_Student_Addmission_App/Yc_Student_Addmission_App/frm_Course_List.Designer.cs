
namespace Yc_Student_Addmission_App
{
    partial class frm_Course_List
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
            this.lbl_Course_List = new System.Windows.Forms.Label();
            this.dgv_Course_List = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yc_Addmission_App_DBDataSet1 = new Yc_Student_Addmission_App.Yc_Addmission_App_DBDataSet1();
            this.courseTableAdapter = new Yc_Student_Addmission_App.Yc_Addmission_App_DBDataSet1TableAdapters.CourseTableAdapter();
            this.yc_Addmission_App_DBDataSet2 = new Yc_Student_Addmission_App.Yc_Addmission_App_DBDataSet2();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter1 = new Yc_Student_Addmission_App.Yc_Addmission_App_DBDataSet2TableAdapters.CourseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yc_Addmission_App_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yc_Addmission_App_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Course_List
            // 
            this.lbl_Course_List.AutoSize = true;
            this.lbl_Course_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Course_List.Font = new System.Drawing.Font("Lucida Fax", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_List.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Course_List.Location = new System.Drawing.Point(223, 43);
            this.lbl_Course_List.Name = "lbl_Course_List";
            this.lbl_Course_List.Size = new System.Drawing.Size(334, 61);
            this.lbl_Course_List.TabIndex = 0;
            this.lbl_Course_List.Text = "Course List";
            // 
            // dgv_Course_List
            // 
            this.dgv_Course_List.AllowUserToAddRows = false;
            this.dgv_Course_List.AllowUserToDeleteRows = false;
            this.dgv_Course_List.AutoGenerateColumns = false;
            this.dgv_Course_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Course_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Course_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Course_List.ColumnHeadersHeight = 30;
            this.dgv_Course_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Course_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dgv_Course_List.DataSource = this.courseBindingSource1;
            this.dgv_Course_List.Location = new System.Drawing.Point(78, 146);
            this.dgv_Course_List.Name = "dgv_Course_List";
            this.dgv_Course_List.ReadOnly = true;
            this.dgv_Course_List.Size = new System.Drawing.Size(639, 292);
            this.dgv_Course_List.TabIndex = 1;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.yc_Addmission_App_DBDataSet1;
            // 
            // yc_Addmission_App_DBDataSet1
            // 
            this.yc_Addmission_App_DBDataSet1.DataSetName = "Yc_Addmission_App_DBDataSet1";
            this.yc_Addmission_App_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // yc_Addmission_App_DBDataSet2
            // 
            this.yc_Addmission_App_DBDataSet2.DataSetName = "Yc_Addmission_App_DBDataSet2";
            this.yc_Addmission_App_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.yc_Addmission_App_DBDataSet2;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_Course_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Course_List);
            this.Controls.Add(this.lbl_Course_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Course_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Course_List";
            this.Load += new System.EventHandler(this.frm_Course_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yc_Addmission_App_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yc_Addmission_App_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Course_List;
        private System.Windows.Forms.DataGridView dgv_Course_List;
        private Yc_Addmission_App_DBDataSet1 yc_Addmission_App_DBDataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Yc_Addmission_App_DBDataSet1TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private Yc_Addmission_App_DBDataSet2 yc_Addmission_App_DBDataSet2;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private Yc_Addmission_App_DBDataSet2TableAdapters.CourseTableAdapter courseTableAdapter1;
    }
}