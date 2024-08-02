
namespace Picture_Box_Assignment
{
    partial class frm_Show_Image
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Show_Image = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Image_List = new System.Windows.Forms.Label();
            this.dgv_Image_List = new System.Windows.Forms.DataGridView();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Add_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Show_Image
            // 
            this.lbl_Show_Image.AutoSize = true;
            this.lbl_Show_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Show_Image.Font = new System.Drawing.Font("Lucida Fax", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Show_Image.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Show_Image.Location = new System.Drawing.Point(294, 19);
            this.lbl_Show_Image.Name = "lbl_Show_Image";
            this.lbl_Show_Image.Size = new System.Drawing.Size(260, 45);
            this.lbl_Show_Image.TabIndex = 0;
            this.lbl_Show_Image.Text = "Show Image";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Image.Location = new System.Drawing.Point(179, 97);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(96, 32);
            this.lbl_Image.TabIndex = 1;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Image_List
            // 
            this.lbl_Image_List.AutoSize = true;
            this.lbl_Image_List.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_List.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Image_List.Location = new System.Drawing.Point(546, 97);
            this.lbl_Image_List.Name = "lbl_Image_List";
            this.lbl_Image_List.Size = new System.Drawing.Size(153, 32);
            this.lbl_Image_List.TabIndex = 2;
            this.lbl_Image_List.Text = "Image List";
            // 
            // dgv_Image_List
            // 
            this.dgv_Image_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Image_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Image_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Image_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Image_List.Location = new System.Drawing.Point(468, 147);
            this.dgv_Image_List.Name = "dgv_Image_List";
            this.dgv_Image_List.Size = new System.Drawing.Size(352, 252);
            this.dgv_Image_List.TabIndex = 3;
            this.dgv_Image_List.SelectionChanged += new System.EventHandler(this.dgv_Image_List_SelectionChanged);
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.Color.White;
            this.pb_Image.Location = new System.Drawing.Point(81, 147);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(300, 252);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 4;
            this.pb_Image.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Image
            // 
            this.btn_Add_Image.BackColor = System.Drawing.Color.Tomato;
            this.btn_Add_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_Image.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Add_Image.Location = new System.Drawing.Point(352, 447);
            this.btn_Add_Image.Name = "btn_Add_Image";
            this.btn_Add_Image.Size = new System.Drawing.Size(144, 39);
            this.btn_Add_Image.TabIndex = 3;
            this.btn_Add_Image.Text = "Add Image";
            this.btn_Add_Image.UseVisualStyleBackColor = false;
            this.btn_Add_Image.Click += new System.EventHandler(this.btn_Add_Image_Click);
            // 
            // frm_Show_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.btn_Add_Image);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.dgv_Image_List);
            this.Controls.Add(this.lbl_Image_List);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Show_Image);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Show_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Image";
            this.Load += new System.EventHandler(this.frm_Show_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Show_Image;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Image_List;
        private System.Windows.Forms.DataGridView dgv_Image_List;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Add_Image;
    }
}

