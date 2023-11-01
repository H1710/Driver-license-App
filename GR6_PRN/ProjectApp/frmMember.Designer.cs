namespace ProjectApp
{
    partial class frmMember
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
            txtId = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            lbId = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbPass = new System.Windows.Forms.Label();
            lbName = new System.Windows.Forms.Label();
            lbRoleId = new System.Windows.Forms.Label();
            txtRole = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnViewCourse = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(154, 76);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(213, 27);
            txtId.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(154, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(213, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(154, 207);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(213, 27);
            txtPass.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(154, 277);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(213, 27);
            txtName.TabIndex = 3;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new System.Drawing.Point(41, 76);
            lbId.Name = "lbId";
            lbId.Size = new System.Drawing.Size(22, 20);
            lbId.TabIndex = 4;
            lbId.Text = "Id";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(41, 142);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new System.Drawing.Point(41, 207);
            lbPass.Name = "lbPass";
            lbPass.Size = new System.Drawing.Size(36, 20);
            lbPass.TabIndex = 6;
            lbPass.Text = "Pass";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(41, 277);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(49, 20);
            lbName.TabIndex = 7;
            lbName.Text = "Name";
            // 
            // lbRoleId
            // 
            lbRoleId.AutoSize = true;
            lbRoleId.Location = new System.Drawing.Point(41, 339);
            lbRoleId.Name = "lbRoleId";
            lbRoleId.Size = new System.Drawing.Size(52, 20);
            lbRoleId.TabIndex = 8;
            lbRoleId.Text = "RoleId";
            // 
            // txtRole
            // 
            txtRole.Location = new System.Drawing.Point(154, 339);
            txtRole.Name = "txtRole";
            txtRole.Size = new System.Drawing.Size(213, 27);
            txtRole.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(482, 73);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(482, 142);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnViewCourse
            // 
            btnViewCourse.AutoSize = true;
            btnViewCourse.Location = new System.Drawing.Point(482, 207);
            btnViewCourse.Name = "btnViewCourse";
            btnViewCourse.Size = new System.Drawing.Size(100, 30);
            btnViewCourse.TabIndex = 12;
            btnViewCourse.Text = "View Course";
            btnViewCourse.UseVisualStyleBackColor = true;
            btnViewCourse.Click += btnViewCourse_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(482, 277);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMember
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(692, 418);
            Controls.Add(btnClose);
            Controls.Add(btnViewCourse);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtRole);
            Controls.Add(lbRoleId);
            Controls.Add(lbName);
            Controls.Add(lbPass);
            Controls.Add(lbEmail);
            Controls.Add(lbId);
            Controls.Add(txtName);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtId);
            Name = "frmMember";
            Text = "frmMember";
            Load += frmMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbRoleId;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnViewCourse;
        private System.Windows.Forms.Button btnClose;
    }
}