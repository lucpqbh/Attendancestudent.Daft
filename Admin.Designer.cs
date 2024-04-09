namespace ASM2.database
{
    partial class Admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Attendances = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateAttendance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDeleteUpdate = new System.Windows.Forms.TextBox();
            this.tbAccountID = new System.Windows.Forms.TextBox();
            this.cbbClassID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbAttendance = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbSubjectID = new System.Windows.Forms.TextBox();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.tbClassID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lable5 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnCreateClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnUpdateClass = new System.Windows.Forms.Button();
            this.tbDeleteUpdateClassID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Attendances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Attendances);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 559);
            this.tabControl1.TabIndex = 2;
            // 
            // Attendances
            // 
            this.Attendances.BackColor = System.Drawing.Color.Cornsilk;
            this.Attendances.Controls.Add(this.btnUpdate);
            this.Attendances.Controls.Add(this.btnDelete);
            this.Attendances.Controls.Add(this.btnCreateAttendance);
            this.Attendances.Controls.Add(this.label3);
            this.Attendances.Controls.Add(this.label4);
            this.Attendances.Controls.Add(this.label2);
            this.Attendances.Controls.Add(this.tbDeleteUpdate);
            this.Attendances.Controls.Add(this.tbAccountID);
            this.Attendances.Controls.Add(this.cbbClassID);
            this.Attendances.Controls.Add(this.label1);
            this.Attendances.Controls.Add(this.cbbAttendance);
            this.Attendances.Controls.Add(this.dgv);
            this.Attendances.Controls.Add(this.btnSave);
            this.Attendances.Location = new System.Drawing.Point(4, 29);
            this.Attendances.Name = "Attendances";
            this.Attendances.Padding = new System.Windows.Forms.Padding(3);
            this.Attendances.Size = new System.Drawing.Size(857, 526);
            this.Attendances.TabIndex = 0;
            this.Attendances.Text = "Attendance";
            this.Attendances.Click += new System.EventHandler(this.Attendances_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(454, 83);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(356, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 31);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateAttendance
            // 
            this.btnCreateAttendance.Location = new System.Drawing.Point(161, 154);
            this.btnCreateAttendance.Name = "btnCreateAttendance";
            this.btnCreateAttendance.Size = new System.Drawing.Size(74, 31);
            this.btnCreateAttendance.TabIndex = 9;
            this.btnCreateAttendance.Text = "Create";
            this.btnCreateAttendance.UseVisualStyleBackColor = true;
            this.btnCreateAttendance.Click += new System.EventHandler(this.btnCreateAttendance_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Class ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "De or Up Account ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Account ID";
            // 
            // tbDeleteUpdate
            // 
            this.tbDeleteUpdate.Location = new System.Drawing.Point(356, 40);
            this.tbDeleteUpdate.Multiline = true;
            this.tbDeleteUpdate.Name = "tbDeleteUpdate";
            this.tbDeleteUpdate.Size = new System.Drawing.Size(191, 29);
            this.tbDeleteUpdate.TabIndex = 7;
            // 
            // tbAccountID
            // 
            this.tbAccountID.Location = new System.Drawing.Point(63, 40);
            this.tbAccountID.Multiline = true;
            this.tbAccountID.Name = "tbAccountID";
            this.tbAccountID.Size = new System.Drawing.Size(172, 29);
            this.tbAccountID.TabIndex = 7;
            // 
            // cbbClassID
            // 
            this.cbbClassID.FormattingEnabled = true;
            this.cbbClassID.Items.AddRange(new object[] {
            "SE06303",
            "SE06304",
            "SE06305",
            "SE06306",
            "SE06307"});
            this.cbbClassID.Location = new System.Drawing.Point(63, 109);
            this.cbbClassID.Name = "cbbClassID";
            this.cbbClassID.Size = new System.Drawing.Size(172, 28);
            this.cbbClassID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Attendance Status";
            // 
            // cbbAttendance
            // 
            this.cbbAttendance.FormattingEnabled = true;
            this.cbbAttendance.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.cbbAttendance.Location = new System.Drawing.Point(640, 38);
            this.cbbAttendance.Name = "cbbAttendance";
            this.cbbAttendance.Size = new System.Drawing.Size(159, 28);
            this.cbbAttendance.TabIndex = 4;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(5, 212);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(846, 308);
            this.dgv.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(716, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage2.Controls.Add(this.btnUpdateClass);
            this.tabPage2.Controls.Add(this.btnDeleteClass);
            this.tabPage2.Controls.Add(this.btnCreateClass);
            this.tabPage2.Controls.Add(this.tbSubjectID);
            this.tabPage2.Controls.Add(this.tbClassName);
            this.tabPage2.Controls.Add(this.tbDeleteUpdateClassID);
            this.tabPage2.Controls.Add(this.tbClassID);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lable5);
            this.tabPage2.Controls.Add(this.dgv1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(857, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Class";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tbSubjectID
            // 
            this.tbSubjectID.Location = new System.Drawing.Point(141, 148);
            this.tbSubjectID.Multiline = true;
            this.tbSubjectID.Name = "tbSubjectID";
            this.tbSubjectID.Size = new System.Drawing.Size(158, 33);
            this.tbSubjectID.TabIndex = 2;
            // 
            // tbClassName
            // 
            this.tbClassName.Location = new System.Drawing.Point(141, 89);
            this.tbClassName.Multiline = true;
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.Size = new System.Drawing.Size(158, 33);
            this.tbClassName.TabIndex = 2;
            // 
            // tbClassID
            // 
            this.tbClassID.Location = new System.Drawing.Point(141, 24);
            this.tbClassID.Multiline = true;
            this.tbClassID.Name = "tbClassID";
            this.tbClassID.Size = new System.Drawing.Size(158, 33);
            this.tbClassID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Subject ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Class Name";
            // 
            // lable5
            // 
            this.lable5.AutoSize = true;
            this.lable5.Location = new System.Drawing.Point(20, 37);
            this.lable5.Name = "lable5";
            this.lable5.Size = new System.Drawing.Size(69, 20);
            this.lable5.TabIndex = 1;
            this.lable5.Text = "Class ID";
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(364, 3);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(492, 522);
            this.dgv1.TabIndex = 0;
            // 
            // btnCreateClass
            // 
            this.btnCreateClass.Location = new System.Drawing.Point(215, 196);
            this.btnCreateClass.Name = "btnCreateClass";
            this.btnCreateClass.Size = new System.Drawing.Size(84, 29);
            this.btnCreateClass.TabIndex = 3;
            this.btnCreateClass.Text = "Create";
            this.btnCreateClass.UseVisualStyleBackColor = true;
            this.btnCreateClass.Click += new System.EventHandler(this.btnCreateClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(141, 332);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(74, 31);
            this.btnDeleteClass.TabIndex = 3;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnUpdateClass
            // 
            this.btnUpdateClass.Location = new System.Drawing.Point(221, 332);
            this.btnUpdateClass.Name = "btnUpdateClass";
            this.btnUpdateClass.Size = new System.Drawing.Size(78, 31);
            this.btnUpdateClass.TabIndex = 3;
            this.btnUpdateClass.Text = "Update";
            this.btnUpdateClass.UseVisualStyleBackColor = true;
            this.btnUpdateClass.Click += new System.EventHandler(this.btnUpdateClass_Click);
            // 
            // tbDeleteUpdateClassID
            // 
            this.tbDeleteUpdateClassID.Location = new System.Drawing.Point(141, 278);
            this.tbDeleteUpdateClassID.Multiline = true;
            this.tbDeleteUpdateClassID.Name = "tbDeleteUpdateClassID";
            this.tbDeleteUpdateClassID.Size = new System.Drawing.Size(158, 33);
            this.tbDeleteUpdateClassID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Class ID";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 565);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.Attendances.ResumeLayout(false);
            this.Attendances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Attendances;
        private System.Windows.Forms.ComboBox cbbAttendance;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreateAttendance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAccountID;
        private System.Windows.Forms.ComboBox cbbClassID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDeleteUpdate;
        private System.Windows.Forms.TextBox tbSubjectID;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.TextBox tbClassID;
        private System.Windows.Forms.Label lable5;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnCreateClass;
        private System.Windows.Forms.TextBox tbDeleteUpdateClassID;
        private System.Windows.Forms.Label label5;
    }
}