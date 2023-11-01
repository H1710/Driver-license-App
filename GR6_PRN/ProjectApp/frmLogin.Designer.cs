namespace ProjectApp
{
    partial class frmLogin
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
            lbLogin = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbPass = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.BackColor = System.Drawing.Color.Cyan;
            lbLogin.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbLogin.Location = new System.Drawing.Point(351, 34);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(137, 45);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(146, 121);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.BackColor = System.Drawing.SystemColors.Control;
            lbPass.Location = new System.Drawing.Point(146, 236);
            lbPass.Name = "lbPass";
            lbPass.Size = new System.Drawing.Size(70, 20);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(338, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(226, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(338, 236);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new System.Drawing.Size(226, 27);
            txtPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.Location = new System.Drawing.Point(351, 323);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Submit";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(lbPass);
            Controls.Add(lbEmail);
            Controls.Add(lbLogin);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
    }
}