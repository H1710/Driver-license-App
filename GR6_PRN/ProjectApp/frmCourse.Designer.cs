namespace ProjectApp
{
    partial class frmCourse
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
            lbId = new System.Windows.Forms.Label();
            lbTitle = new System.Windows.Forms.Label();
            lbDescription = new System.Windows.Forms.Label();
            lbstart_date = new System.Windows.Forms.Label();
            lbEnd_date = new System.Windows.Forms.Label();
            dgvCourse = new System.Windows.Forms.DataGridView();
            txtId = new System.Windows.Forms.TextBox();
            txtTitle = new System.Windows.Forms.TextBox();
            txtDes = new System.Windows.Forms.TextBox();
            txtStartDate = new System.Windows.Forms.TextBox();
            txtEndDate = new System.Windows.Forms.TextBox();
            cboCourse = new System.Windows.Forms.ComboBox();
            btnSelect = new System.Windows.Forms.Button();
            lbCourse = new System.Windows.Forms.Label();
            lbSlot = new System.Windows.Forms.Label();
            lbMentor = new System.Windows.Forms.Label();
            cboMentor = new System.Windows.Forms.ComboBox();
            cboSlot = new System.Windows.Forms.ComboBox();
            btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new System.Drawing.Point(57, 81);
            lbId.Name = "lbId";
            lbId.Size = new System.Drawing.Size(22, 20);
            lbId.TabIndex = 0;
            lbId.Text = "Id";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new System.Drawing.Point(57, 133);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(38, 20);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Title";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new System.Drawing.Point(57, 189);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new System.Drawing.Size(85, 20);
            lbDescription.TabIndex = 2;
            lbDescription.Text = "Description";
            // 
            // lbstart_date
            // 
            lbstart_date.AutoSize = true;
            lbstart_date.Location = new System.Drawing.Point(57, 244);
            lbstart_date.Name = "lbstart_date";
            lbstart_date.Size = new System.Drawing.Size(76, 20);
            lbstart_date.TabIndex = 3;
            lbstart_date.Text = "Start_date";
            // 
            // lbEnd_date
            // 
            lbEnd_date.AutoSize = true;
            lbEnd_date.Location = new System.Drawing.Point(57, 303);
            lbEnd_date.Name = "lbEnd_date";
            lbEnd_date.Size = new System.Drawing.Size(70, 20);
            lbEnd_date.TabIndex = 4;
            lbEnd_date.Text = "End_date";
            // 
            // dgvCourse
            // 
            dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Location = new System.Drawing.Point(12, 362);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.RowHeadersWidth = 51;
            dgvCourse.RowTemplate.Height = 29;
            dgvCourse.Size = new System.Drawing.Size(1174, 263);
            dgvCourse.TabIndex = 5;
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(223, 81);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(228, 27);
            txtId.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(223, 133);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(228, 27);
            txtTitle.TabIndex = 7;
            // 
            // txtDes
            // 
            txtDes.Location = new System.Drawing.Point(223, 189);
            txtDes.Name = "txtDes";
            txtDes.Size = new System.Drawing.Size(228, 27);
            txtDes.TabIndex = 8;
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new System.Drawing.Point(223, 244);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new System.Drawing.Size(228, 27);
            txtStartDate.TabIndex = 9;
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new System.Drawing.Point(223, 303);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new System.Drawing.Size(228, 27);
            txtEndDate.TabIndex = 10;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new System.Drawing.Point(649, 115);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new System.Drawing.Size(338, 28);
            cboCourse.TabIndex = 11;
            cboCourse.SelectedValueChanged += cboCourse_SelectedValueChanged;
            // 
            // btnSelect
            // 
<<<<<<< HEAD
/*            btnSelect.AutoSize = true;
            btnSelect.Location = new System.Drawing.Point(1050, 202);
=======
            btnSelect.AutoSize = true;
            btnSelect.Location = new System.Drawing.Point(1047, 204);
>>>>>>> Log1_N
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new System.Drawing.Size(122, 30);
            btnSelect.TabIndex = 12;
            btnSelect.Text = "Register Course";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;*/
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Location = new System.Drawing.Point(649, 81);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new System.Drawing.Size(54, 20);
            lbCourse.TabIndex = 13;
            lbCourse.Text = "Course";
            // 
            // lbSlot
            // 
            lbSlot.AutoSize = true;
            lbSlot.Location = new System.Drawing.Point(649, 171);
            lbSlot.Name = "lbSlot";
            lbSlot.Size = new System.Drawing.Size(35, 20);
            lbSlot.TabIndex = 14;
            lbSlot.Text = "Slot";
            // 
            // lbMentor
            // 
            lbMentor.AutoSize = true;
            lbMentor.Location = new System.Drawing.Point(649, 261);
            lbMentor.Name = "lbMentor";
            lbMentor.Size = new System.Drawing.Size(57, 20);
            lbMentor.TabIndex = 15;
            lbMentor.Text = "Mentor";
            // 
            // cboMentor
            // 
            cboMentor.FormattingEnabled = true;
            cboMentor.Location = new System.Drawing.Point(649, 295);
            cboMentor.Name = "cboMentor";
            cboMentor.Size = new System.Drawing.Size(338, 28);
            cboMentor.TabIndex = 16;
            // 
            // cboSlot
            // 
            cboSlot.FormattingEnabled = true;
            cboSlot.Location = new System.Drawing.Point(649, 204);
            cboSlot.Name = "cboSlot";
            cboSlot.Size = new System.Drawing.Size(338, 28);
            cboSlot.TabIndex = 17;
            // 
            // btnTest
            // 
            btnTest.Location = new System.Drawing.Point(1047, 294);
            btnTest.Name = "btnTest";
            btnTest.Size = new System.Drawing.Size(122, 29);
            btnTest.TabIndex = 18;
            btnTest.Text = "Take a test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // frmCourse
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 637);
            Controls.Add(btnTest);
            Controls.Add(cboSlot);
            Controls.Add(cboMentor);
            Controls.Add(lbMentor);
            Controls.Add(lbSlot);
            Controls.Add(lbCourse);
            Controls.Add(btnSelect);
            Controls.Add(cboCourse);
            Controls.Add(txtEndDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtDes);
            Controls.Add(txtTitle);
            Controls.Add(txtId);
            Controls.Add(dgvCourse);
            Controls.Add(lbEnd_date);
            Controls.Add(lbstart_date);
            Controls.Add(lbDescription);
            Controls.Add(lbTitle);
            Controls.Add(lbId);
            Name = "frmCourse";
            Text = "frmCourse";
            Load += frmCourse_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbstart_date;
        private System.Windows.Forms.Label lbEnd_date;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbSlot;
        private System.Windows.Forms.Label lbMentor;
        private System.Windows.Forms.ComboBox cboMentor;
        private System.Windows.Forms.ComboBox cboSlot;
        private System.Windows.Forms.Button btnTest;
    }
}