namespace ProjectApp
{
    partial class frmQuestionDetail
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            txtTiltle = new System.Windows.Forms.TextBox();
            txtAnswer = new System.Windows.Forms.TextBox();
            txtA = new System.Windows.Forms.TextBox();
            txtB = new System.Windows.Forms.TextBox();
            txtC = new System.Windows.Forms.TextBox();
            txtD = new System.Windows.Forms.TextBox();
            txtSave = new System.Windows.Forms.Button();
            txtClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(146, 109);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 48);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(146, 187);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 48);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(146, 271);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(136, 48);
            label3.TabIndex = 2;
            label3.Text = "Answer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(734, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(163, 48);
            label4.TabIndex = 3;
            label4.Text = "Option A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(734, 187);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(161, 48);
            label5.TabIndex = 4;
            label5.Text = "Option B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(734, 271);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(162, 48);
            label6.TabIndex = 5;
            label6.Text = "Option C";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(734, 358);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(165, 48);
            label7.TabIndex = 6;
            label7.Text = "Option D";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(349, 119);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(300, 55);
            txtID.TabIndex = 7;
            // 
            // txtTiltle
            // 
            txtTiltle.Location = new System.Drawing.Point(349, 199);
            txtTiltle.Name = "txtTiltle";
            txtTiltle.Size = new System.Drawing.Size(300, 55);
            txtTiltle.TabIndex = 8;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new System.Drawing.Point(349, 271);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new System.Drawing.Size(300, 55);
            txtAnswer.TabIndex = 9;
            // 
            // txtA
            // 
            txtA.Location = new System.Drawing.Point(1012, 106);
            txtA.Name = "txtA";
            txtA.Size = new System.Drawing.Size(300, 55);
            txtA.TabIndex = 10;
            txtA.TextChanged += textBox4_TextChanged;
            // 
            // txtB
            // 
            txtB.Location = new System.Drawing.Point(1012, 187);
            txtB.Name = "txtB";
            txtB.Size = new System.Drawing.Size(300, 55);
            txtB.TabIndex = 11;
            // 
            // txtC
            // 
            txtC.Location = new System.Drawing.Point(1012, 282);
            txtC.Name = "txtC";
            txtC.Size = new System.Drawing.Size(300, 55);
            txtC.TabIndex = 12;
            // 
            // txtD
            // 
            txtD.Location = new System.Drawing.Point(1012, 355);
            txtD.Name = "txtD";
            txtD.Size = new System.Drawing.Size(300, 55);
            txtD.TabIndex = 13;
            // 
            // txtSave
            // 
            txtSave.Location = new System.Drawing.Point(245, 481);
            txtSave.Name = "txtSave";
            txtSave.Size = new System.Drawing.Size(225, 69);
            txtSave.TabIndex = 14;
            txtSave.Text = "Save";
            txtSave.UseVisualStyleBackColor = true;
            txtSave.Click += txtSave_Click;
            // 
            // txtClose
            // 
            txtClose.Location = new System.Drawing.Point(705, 481);
            txtClose.Name = "txtClose";
            txtClose.Size = new System.Drawing.Size(225, 69);
            txtClose.TabIndex = 15;
            txtClose.Text = "Close";
            txtClose.UseVisualStyleBackColor = true;
            txtClose.Click += txtClose_Click;
            // 
            // frmQuestionDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1399, 595);
            Controls.Add(txtClose);
            Controls.Add(txtSave);
            Controls.Add(txtD);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(txtAnswer);
            Controls.Add(txtTiltle);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmQuestionDetail";
            Text = "frmQuestionDetail";
            Load += frmQuestionDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTiltle;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.Button txtClose;
    }
}