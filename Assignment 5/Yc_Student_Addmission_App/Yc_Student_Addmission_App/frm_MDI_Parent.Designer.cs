
namespace Yc_Student_Addmission_App
{
    partial class frm_MDI_Parent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notePadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.searchStudentDetailsToolStripMenuItem,
            this.updateStudentDetailsToolStripMenuItem,
            this.listOfStudentsToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.studentToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // searchStudentDetailsToolStripMenuItem
            // 
            this.searchStudentDetailsToolStripMenuItem.Name = "searchStudentDetailsToolStripMenuItem";
            this.searchStudentDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.searchStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.searchStudentDetailsToolStripMenuItem.Text = "Search Student Details";
            this.searchStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchStudentDetailsToolStripMenuItem_Click);
            // 
            // updateStudentDetailsToolStripMenuItem
            // 
            this.updateStudentDetailsToolStripMenuItem.Name = "updateStudentDetailsToolStripMenuItem";
            this.updateStudentDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.updateStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.updateStudentDetailsToolStripMenuItem.Text = "Update Student Details";
            this.updateStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateStudentDetailsToolStripMenuItem_Click);
            // 
            // listOfStudentsToolStripMenuItem
            // 
            this.listOfStudentsToolStripMenuItem.Name = "listOfStudentsToolStripMenuItem";
            this.listOfStudentsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.listOfStudentsToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.listOfStudentsToolStripMenuItem.Text = "List Of Students";
            this.listOfStudentsToolStripMenuItem.Click += new System.EventHandler(this.listOfStudentsToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.courseListToolStripMenuItem});
            this.courseToolStripMenuItem.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // courseListToolStripMenuItem
            // 
            this.courseListToolStripMenuItem.Name = "courseListToolStripMenuItem";
            this.courseListToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.courseListToolStripMenuItem.Text = "Course List";
            this.courseListToolStripMenuItem.Click += new System.EventHandler(this.courseListToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculaterToolStripMenuItem,
            this.notePadToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Fax", 14F);
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculaterToolStripMenuItem
            // 
            this.calculaterToolStripMenuItem.Name = "calculaterToolStripMenuItem";
            this.calculaterToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.calculaterToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.calculaterToolStripMenuItem.Text = "Calculater";
            this.calculaterToolStripMenuItem.Click += new System.EventHandler(this.calculaterToolStripMenuItem_Click);
            // 
            // notePadToolStripMenuItem
            // 
            this.notePadToolStripMenuItem.Name = "notePadToolStripMenuItem";
            this.notePadToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.notePadToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.notePadToolStripMenuItem.Text = "Note Pad";
            this.notePadToolStripMenuItem.Click += new System.EventHandler(this.notePadToolStripMenuItem_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Log_Out.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.White;
            this.btn_Log_Out.Location = new System.Drawing.Point(797, 0);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(107, 30);
            this.btn_Log_Out.TabIndex = 1;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_Username.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Username.Location = new System.Drawing.Point(621, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_Username.Size = new System.Drawing.Size(136, 29);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username";
            // 
            // frm_MDI_Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(894, 541);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MDI_Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI Parent Form";
            this.Load += new System.EventHandler(this.frm_MDI_Parent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notePadToolStripMenuItem;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.ToolStripMenuItem courseListToolStripMenuItem;
    }
}