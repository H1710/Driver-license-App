namespace ProjectApp
{
    partial class frmQuestion
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
            txtTitle = new System.Windows.Forms.TextBox();
            txtB = new System.Windows.Forms.TextBox();
            txtAnswer = new System.Windows.Forms.TextBox();
            txtA = new System.Windows.Forms.TextBox();
            txtC = new System.Windows.Forms.TextBox();
            txtD = new System.Windows.Forms.TextBox();
            btnNew = new System.Windows.Forms.Button();
            btnHome = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            dgvQuestion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(118, 130);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 48);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(118, 223);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 48);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(118, 313);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(163, 48);
            label3.TabIndex = 2;
            label3.Text = "Option A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(118, 394);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(161, 48);
            label4.TabIndex = 3;
            label4.Text = "Option B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(927, 133);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(162, 48);
            label5.TabIndex = 4;
            label5.Text = "Option C";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(927, 220);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(165, 48);
            label6.TabIndex = 5;
            label6.Text = "Option D";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(927, 316);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(136, 48);
            label7.TabIndex = 6;
            label7.Text = "Answer";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(386, 130);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(300, 55);
            txtID.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(386, 220);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(300, 55);
            txtTitle.TabIndex = 8;
            // 
            // txtB
            // 
            txtB.Location = new System.Drawing.Point(386, 410);
            txtB.Name = "txtB";
            txtB.Size = new System.Drawing.Size(300, 55);
            txtB.TabIndex = 9;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new System.Drawing.Point(1163, 313);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new System.Drawing.Size(300, 55);
            txtAnswer.TabIndex = 10;
            // 
            // txtA
            // 
            txtA.Location = new System.Drawing.Point(386, 313);
            txtA.Name = "txtA";
            txtA.Size = new System.Drawing.Size(300, 55);
            txtA.TabIndex = 11;
            // 
            // txtC
            // 
            txtC.Location = new System.Drawing.Point(1163, 133);
            txtC.Name = "txtC";
            txtC.Size = new System.Drawing.Size(300, 55);
            txtC.TabIndex = 12;
            // 
            // txtD
            // 
            txtD.Location = new System.Drawing.Point(1163, 217);
            txtD.Name = "txtD";
            txtD.Size = new System.Drawing.Size(300, 55);
            txtD.TabIndex = 13;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(1520, 217);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(225, 69);
            btnNew.TabIndex = 14;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new System.Drawing.Point(1520, 123);
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(225, 69);
            btnHome.TabIndex = 15;
            btnHome.Text = "Home page";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(1520, 313);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(225, 69);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvQuestion
            // 
            dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestion.Location = new System.Drawing.Point(118, 528);
            dgvQuestion.Name = "dgvQuestion";
            dgvQuestion.RowHeadersWidth = 123;
            dgvQuestion.RowTemplate.Height = 57;
            dgvQuestion.Size = new System.Drawing.Size(1601, 450);
            dgvQuestion.TabIndex = 19;
            dgvQuestion.CellDoubleClick += dgvQuestion_CellDoubleClick;
            // 
            // frmQuestion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1766, 765);
            Controls.Add(dgvQuestion);
            Controls.Add(btnDelete);
            Controls.Add(btnHome);
            Controls.Add(btnNew);
            Controls.Add(txtD);
            Controls.Add(txtC);
            Controls.Add(txtA);
            Controls.Add(txtAnswer);
            Controls.Add(txtB);
            Controls.Add(txtTitle);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmQuestion";
            Text = "Question Management";
            Load += frmQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).EndInit();
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
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvQuestion;
    }
}