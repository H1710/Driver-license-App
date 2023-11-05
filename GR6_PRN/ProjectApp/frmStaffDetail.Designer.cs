namespace ProjectApp
{
    partial class frmStaffDetail
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
            btnClose = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            txtPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(372, 180);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(112, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(43, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 25);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(163, 50);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(150, 31);
            txtID.TabIndex = 2;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(163, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(150, 31);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(43, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 25);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(163, 182);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(150, 31);
            txtName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(43, 188);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 25);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(530, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(112, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(492, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(138, 31);
            txtPassword.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(372, 112);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 25);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Staff", "Mentor", "Member", "Admin" });
            comboBox1.Location = new System.Drawing.Point(448, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(182, 33);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(372, 53);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(46, 25);
            label5.TabIndex = 11;
            label5.Text = "Role";
            // 
            // frmStaffDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(684, 288);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Name = "frmStaffDetail";
            Text = "frmStaffDetail";
            Load += frmStaffDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}