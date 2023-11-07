namespace ProjectApp
{
    partial class frmStaffManagement
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
            dgvStaffList = new System.Windows.Forms.DataGridView();
            txtUserID = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtUserEmail = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtUserName = new System.Windows.Forms.TextBox();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtRole = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).BeginInit();
            SuspendLayout();
            // 
            // dgvStaffList
            // 
            dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffList.Location = new System.Drawing.Point(12, 223);
            dgvStaffList.Name = "dgvStaffList";
            dgvStaffList.RowHeadersWidth = 62;
            dgvStaffList.RowTemplate.Height = 33;
            dgvStaffList.Size = new System.Drawing.Size(907, 262);
            dgvStaffList.TabIndex = 0;
            dgvStaffList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtUserID
            // 
            txtUserID.Location = new System.Drawing.Point(75, 46);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new System.Drawing.Size(179, 31);
            txtUserID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 25);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 111);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 25);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new System.Drawing.Point(75, 111);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new System.Drawing.Size(179, 31);
            txtUserEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(290, 46);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 25);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(353, 46);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(177, 31);
            txtUserName.TabIndex = 5;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(583, 111);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(112, 34);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(711, 111);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(112, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(290, 111);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 25);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(383, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(147, 31);
            txtPassword.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(583, 46);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(46, 25);
            label6.TabIndex = 12;
            label6.Text = "Role";
            // 
            // txtRole
            // 
            txtRole.Location = new System.Drawing.Point(646, 46);
            txtRole.Name = "txtRole";
            txtRole.Size = new System.Drawing.Size(177, 31);
            txtRole.TabIndex = 11;
            // 
            // frmStaffManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(931, 512);
            Controls.Add(label6);
            Controls.Add(txtRole);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtUserEmail);
            Controls.Add(label1);
            Controls.Add(txtUserID);
            Controls.Add(dgvStaffList);
            Name = "frmStaffManagement";
            Text = "frmStaffManagement";
            Load += frmStaffManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserRole;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRole;
    }
}