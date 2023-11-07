namespace ProjectApp
{
    partial class frmAdmin
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
            btnStaff = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnStaff
            // 
            btnStaff.Location = new System.Drawing.Point(81, 63);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new System.Drawing.Size(112, 34);
            btnStaff.TabIndex = 0;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += button1_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnStaff);
            Name = "frmAdmin";
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnStaff;
    }
}