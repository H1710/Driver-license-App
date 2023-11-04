namespace ProjectApp
{
    partial class frmStaff
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
            btnQuestion = new System.Windows.Forms.Button();
            btnMember = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnTest = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnQuestion
            // 
            btnQuestion.Location = new System.Drawing.Point(200, 370);
            btnQuestion.Name = "btnQuestion";
            btnQuestion.Size = new System.Drawing.Size(225, 69);
            btnQuestion.TabIndex = 0;
            btnQuestion.Text = "Question";
            btnQuestion.UseVisualStyleBackColor = true;
            btnQuestion.Click += btnQuestion_Click;
            // 
            // btnMember
            // 
            btnMember.Location = new System.Drawing.Point(677, 274);
            btnMember.Name = "btnMember";
            btnMember.Size = new System.Drawing.Size(225, 69);
            btnMember.TabIndex = 1;
            btnMember.Text = "Member";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Teal;
            label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Silver;
            label1.Location = new System.Drawing.Point(142, 106);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(826, 92);
            label1.TabIndex = 2;
            label1.Text = "STAFF HOMEPAGE";
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(677, 370);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(225, 69);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnTest
            // 
            btnTest.Location = new System.Drawing.Point(200, 274);
            btnTest.Name = "btnTest";
            btnTest.Size = new System.Drawing.Size(225, 69);
            btnTest.TabIndex = 4;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // frmStaff
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1148, 522);
            Controls.Add(btnTest);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(btnMember);
            Controls.Add(btnQuestion);
            Name = "frmStaff";
            Text = "frmStaff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTest;
    }
}