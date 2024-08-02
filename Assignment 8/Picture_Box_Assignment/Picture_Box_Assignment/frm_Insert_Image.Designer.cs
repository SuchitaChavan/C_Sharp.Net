
namespace Picture_Box_Assignment
{
    partial class frm_Insert_Image
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
            this.lbl_Insert_Image = new System.Windows.Forms.Label();
            this.lbl_Image_Id = new System.Windows.Forms.Label();
            this.lbl_Image_Description = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Show_Image = new System.Windows.Forms.Button();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.tb_Image_Id = new System.Windows.Forms.TextBox();
            this.tb_Image_Description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Insert_Image
            // 
            this.lbl_Insert_Image.AutoSize = true;
            this.lbl_Insert_Image.BackColor = System.Drawing.Color.Turquoise;
            this.lbl_Insert_Image.Font = new System.Drawing.Font("Lucida Bright", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Insert_Image.ForeColor = System.Drawing.Color.Purple;
            this.lbl_Insert_Image.Location = new System.Drawing.Point(327, 19);
            this.lbl_Insert_Image.Name = "lbl_Insert_Image";
            this.lbl_Insert_Image.Size = new System.Drawing.Size(220, 39);
            this.lbl_Insert_Image.TabIndex = 0;
            this.lbl_Insert_Image.Text = "Insert Image";
            // 
            // lbl_Image_Id
            // 
            this.lbl_Image_Id.AutoSize = true;
            this.lbl_Image_Id.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_Id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Image_Id.Location = new System.Drawing.Point(32, 117);
            this.lbl_Image_Id.Name = "lbl_Image_Id";
            this.lbl_Image_Id.Size = new System.Drawing.Size(116, 27);
            this.lbl_Image_Id.TabIndex = 1;
            this.lbl_Image_Id.Text = "Image Id";
            // 
            // lbl_Image_Description
            // 
            this.lbl_Image_Description.AutoSize = true;
            this.lbl_Image_Description.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_Description.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Image_Description.Location = new System.Drawing.Point(32, 208);
            this.lbl_Image_Description.Name = "lbl_Image_Description";
            this.lbl_Image_Description.Size = new System.Drawing.Size(235, 27);
            this.lbl_Image_Description.TabIndex = 2;
            this.lbl_Image_Description.Text = "Image Description";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Image.Location = new System.Drawing.Point(660, 87);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(84, 27);
            this.lbl_Image.TabIndex = 3;
            this.lbl_Image.Text = "Image";
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.Crimson;
            this.btn_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Browse.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.White;
            this.btn_Browse.Location = new System.Drawing.Point(665, 346);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(95, 39);
            this.btn_Browse.TabIndex = 4;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Crimson;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(77, 447);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(95, 41);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Crimson;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(383, 447);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(95, 41);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Show_Image
            // 
            this.btn_Show_Image.BackColor = System.Drawing.Color.Crimson;
            this.btn_Show_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Show_Image.Font = new System.Drawing.Font("Lucida Bright", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Image.ForeColor = System.Drawing.Color.White;
            this.btn_Show_Image.Location = new System.Drawing.Point(646, 447);
            this.btn_Show_Image.Name = "btn_Show_Image";
            this.btn_Show_Image.Size = new System.Drawing.Size(157, 41);
            this.btn_Show_Image.TabIndex = 7;
            this.btn_Show_Image.Text = "Show Image";
            this.btn_Show_Image.UseVisualStyleBackColor = false;
            this.btn_Show_Image.Click += new System.EventHandler(this.btn_Show_Image_Click);
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.Color.White;
            this.pb_Image.Location = new System.Drawing.Point(575, 117);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(279, 223);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 8;
            this.pb_Image.TabStop = false;
            // 
            // tb_Image_Id
            // 
            this.tb_Image_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_Id.Location = new System.Drawing.Point(289, 117);
            this.tb_Image_Id.MaxLength = 5;
            this.tb_Image_Id.Name = "tb_Image_Id";
            this.tb_Image_Id.Size = new System.Drawing.Size(189, 32);
            this.tb_Image_Id.TabIndex = 1;
            this.tb_Image_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Image_Description
            // 
            this.tb_Image_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_Description.Location = new System.Drawing.Point(289, 207);
            this.tb_Image_Description.MaxLength = 50;
            this.tb_Image_Description.Multiline = true;
            this.tb_Image_Description.Name = "tb_Image_Description";
            this.tb_Image_Description.Size = new System.Drawing.Size(198, 149);
            this.tb_Image_Description.TabIndex = 2;
            // 
            // frm_Insert_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.tb_Image_Description);
            this.Controls.Add(this.tb_Image_Id);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.btn_Show_Image);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Image_Description);
            this.Controls.Add(this.lbl_Image_Id);
            this.Controls.Add(this.lbl_Insert_Image);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Insert_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Insert_Image";
            this.Load += new System.EventHandler(this.frm_Insert_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Insert_Image;
        private System.Windows.Forms.Label lbl_Image_Id;
        private System.Windows.Forms.Label lbl_Image_Description;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Show_Image;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.TextBox tb_Image_Id;
        private System.Windows.Forms.TextBox tb_Image_Description;
    }
}