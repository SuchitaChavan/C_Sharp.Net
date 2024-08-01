
namespace Employee_General_Details
{
    partial class frm_Employee_General_Details
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
            this.lbl_Employee_General_Details = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Employee_Department = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Known_Language = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Name_Err = new System.Windows.Forms.Label();
            this.cmb_Employee_Department = new System.Windows.Forms.ComboBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.lbl_Gender_Err = new System.Windows.Forms.Label();
            this.lbl_Dept_Err = new System.Windows.Forms.Label();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.gb_Language = new System.Windows.Forms.GroupBox();
            this.lbl_Language_Err = new System.Windows.Forms.Label();
            this.lbl_Hobby_Err = new System.Windows.Forms.Label();
            this.gb_Gender.SuspendLayout();
            this.gb_Language.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employee_General_Details
            // 
            this.lbl_Employee_General_Details.AutoSize = true;
            this.lbl_Employee_General_Details.BackColor = System.Drawing.Color.Green;
            this.lbl_Employee_General_Details.Font = new System.Drawing.Font("HP Simplified Jpan", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_General_Details.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Employee_General_Details.Location = new System.Drawing.Point(196, 9);
            this.lbl_Employee_General_Details.Name = "lbl_Employee_General_Details";
            this.lbl_Employee_General_Details.Size = new System.Drawing.Size(519, 60);
            this.lbl_Employee_General_Details.TabIndex = 0;
            this.lbl_Employee_General_Details.Text = "Employee General Details";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Navy;
            this.btn_Reset.Location = new System.Drawing.Point(206, 442);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(97, 34);
            this.btn_Reset.TabIndex = 11;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Navy;
            this.btn_Submit.Location = new System.Drawing.Point(627, 442);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(109, 34);
            this.btn_Submit.TabIndex = 12;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(12, 135);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(213, 31);
            this.lbl_Employee_Name.TabIndex = 3;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // lbl_Employee_Department
            // 
            this.lbl_Employee_Department.AutoSize = true;
            this.lbl_Employee_Department.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Employee_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Department.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Employee_Department.Location = new System.Drawing.Point(12, 223);
            this.lbl_Employee_Department.Name = "lbl_Employee_Department";
            this.lbl_Employee_Department.Size = new System.Drawing.Size(283, 31);
            this.lbl_Employee_Department.TabIndex = 4;
            this.lbl_Employee_Department.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Gender.Location = new System.Drawing.Point(12, 325);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(104, 31);
            this.lbl_Gender.TabIndex = 5;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Known_Language
            // 
            this.lbl_Known_Language.AutoSize = true;
            this.lbl_Known_Language.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Known_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Known_Language.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Known_Language.Location = new System.Drawing.Point(535, 145);
            this.lbl_Known_Language.Name = "lbl_Known_Language";
            this.lbl_Known_Language.Size = new System.Drawing.Size(224, 31);
            this.lbl_Known_Language.TabIndex = 6;
            this.lbl_Known_Language.Text = "Known Language";
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Hobbies.Location = new System.Drawing.Point(661, 277);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(114, 31);
            this.lbl_Hobbies.TabIndex = 7;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Output.Location = new System.Drawing.Point(20, 504);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(96, 31);
            this.lbl_Output.TabIndex = 8;
            this.lbl_Output.Text = "Output";
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.ForeColor = System.Drawing.Color.Red;
            this.tb_Output.Location = new System.Drawing.Point(148, 506);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(817, 29);
            this.tb_Output.TabIndex = 13;
            this.tb_Output.Text = "Output Appear Here";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(254, 135);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(223, 26);
            this.tb_Name.TabIndex = 1;
            // 
            // lbl_Name_Err
            // 
            this.lbl_Name_Err.AutoSize = true;
            this.lbl_Name_Err.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_Err.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name_Err.Location = new System.Drawing.Point(406, 164);
            this.lbl_Name_Err.Name = "lbl_Name_Err";
            this.lbl_Name_Err.Size = new System.Drawing.Size(71, 15);
            this.lbl_Name_Err.TabIndex = 10;
            this.lbl_Name_Err.Text = "Name Error";
            // 
            // cmb_Employee_Department
            // 
            this.cmb_Employee_Department.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Employee_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Employee_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee_Department.FormattingEnabled = true;
            this.cmb_Employee_Department.Items.AddRange(new object[] {
            "Department Of Chemistry",
            "Department Of Physics",
            "Department Of Biology",
            "Department Of Information Tecnology"});
            this.cmb_Employee_Department.Location = new System.Drawing.Point(319, 223);
            this.cmb_Employee_Department.Name = "cmb_Employee_Department";
            this.cmb_Employee_Department.Size = new System.Drawing.Size(220, 28);
            this.cmb_Employee_Department.TabIndex = 2;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(15, 20);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(61, 24);
            this.rb_Male.TabIndex = 3;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marathi.Location = new System.Drawing.Point(15, 19);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(81, 24);
            this.cb_Marathi.TabIndex = 6;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clb_Hobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Cycling",
            "Singing",
            "Cooking",
            "Driving",
            "Gaming"});
            this.clb_Hobbies.Location = new System.Drawing.Point(817, 277);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(155, 109);
            this.clb_Hobbies.TabIndex = 10;
            // 
            // lbl_Gender_Err
            // 
            this.lbl_Gender_Err.AutoSize = true;
            this.lbl_Gender_Err.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender_Err.ForeColor = System.Drawing.Color.Red;
            this.lbl_Gender_Err.Location = new System.Drawing.Point(295, 380);
            this.lbl_Gender_Err.Name = "lbl_Gender_Err";
            this.lbl_Gender_Err.Size = new System.Drawing.Size(78, 15);
            this.lbl_Gender_Err.TabIndex = 15;
            this.lbl_Gender_Err.Text = "Gender Error";
            // 
            // lbl_Dept_Err
            // 
            this.lbl_Dept_Err.AutoSize = true;
            this.lbl_Dept_Err.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dept_Err.ForeColor = System.Drawing.Color.Red;
            this.lbl_Dept_Err.Location = new System.Drawing.Point(476, 254);
            this.lbl_Dept_Err.Name = "lbl_Dept_Err";
            this.lbl_Dept_Err.Size = new System.Drawing.Size(63, 15);
            this.lbl_Dept_Err.TabIndex = 16;
            this.lbl_Dept_Err.Text = "Dept Error";
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Location = new System.Drawing.Point(185, 325);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(188, 52);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(97, 19);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(80, 24);
            this.rb_Female.TabIndex = 4;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Hindi.Location = new System.Drawing.Point(15, 47);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(64, 24);
            this.cb_Hindi.TabIndex = 7;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_English.Location = new System.Drawing.Point(102, 19);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(80, 24);
            this.cb_English.TabIndex = 8;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_French.Location = new System.Drawing.Point(102, 47);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(78, 24);
            this.cb_French.TabIndex = 9;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // gb_Language
            // 
            this.gb_Language.Controls.Add(this.cb_Marathi);
            this.gb_Language.Controls.Add(this.cb_Hindi);
            this.gb_Language.Controls.Add(this.cb_English);
            this.gb_Language.Controls.Add(this.cb_French);
            this.gb_Language.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gb_Language.Location = new System.Drawing.Point(785, 135);
            this.gb_Language.Name = "gb_Language";
            this.gb_Language.Size = new System.Drawing.Size(187, 77);
            this.gb_Language.TabIndex = 5;
            this.gb_Language.TabStop = false;
            this.gb_Language.Text = "Language";
            // 
            // lbl_Language_Err
            // 
            this.lbl_Language_Err.AutoSize = true;
            this.lbl_Language_Err.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Language_Err.ForeColor = System.Drawing.Color.Red;
            this.lbl_Language_Err.Location = new System.Drawing.Point(907, 215);
            this.lbl_Language_Err.Name = "lbl_Language_Err";
            this.lbl_Language_Err.Size = new System.Drawing.Size(65, 15);
            this.lbl_Language_Err.TabIndex = 17;
            this.lbl_Language_Err.Text = "Lang Error";
            // 
            // lbl_Hobby_Err
            // 
            this.lbl_Hobby_Err.AutoSize = true;
            this.lbl_Hobby_Err.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobby_Err.ForeColor = System.Drawing.Color.Red;
            this.lbl_Hobby_Err.Location = new System.Drawing.Point(889, 389);
            this.lbl_Hobby_Err.Name = "lbl_Hobby_Err";
            this.lbl_Hobby_Err.Size = new System.Drawing.Size(83, 15);
            this.lbl_Hobby_Err.TabIndex = 18;
            this.lbl_Hobby_Err.Text = "Hobbies Error";
            // 
            // frm_Employee_General_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 541);
            this.Controls.Add(this.lbl_Hobby_Err);
            this.Controls.Add(this.lbl_Language_Err);
            this.Controls.Add(this.gb_Language);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.lbl_Dept_Err);
            this.Controls.Add(this.lbl_Gender_Err);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.cmb_Employee_Department);
            this.Controls.Add(this.lbl_Name_Err);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.lbl_Known_Language);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employee_Department);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Employee_General_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Employee_General_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee General Details";
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Language.ResumeLayout(false);
            this.gb_Language.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_General_Details;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Employee_Department;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Known_Language;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Name_Err;
        private System.Windows.Forms.ComboBox cmb_Employee_Department;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.Label lbl_Gender_Err;
        private System.Windows.Forms.Label lbl_Dept_Err;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.GroupBox gb_Language;
        private System.Windows.Forms.Label lbl_Language_Err;
        private System.Windows.Forms.Label lbl_Hobby_Err;
    }
}

