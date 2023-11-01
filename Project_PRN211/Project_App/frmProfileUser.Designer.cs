namespace Project_App
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
            lbMember = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbMember
            // 
            lbMember.AutoSize = true;
            lbMember.Location = new System.Drawing.Point(638, 58);
            lbMember.Name = "lbMember";
            lbMember.Size = new System.Drawing.Size(50, 20);
            lbMember.TabIndex = 0;
            lbMember.Text = "label1";
            // 
            // frmMember
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1424, 648);
            Controls.Add(lbMember);
            Name = "frmMember";
            Text = "frmMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMember;
    }
}