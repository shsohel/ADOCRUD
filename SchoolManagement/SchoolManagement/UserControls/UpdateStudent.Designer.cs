namespace SchoolManagement.UserControls
{
    partial class UpdateStudentUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClassName = new System.Windows.Forms.Label();
            this.comBoxClassSt = new System.Windows.Forms.ComboBox();
            this.dtgvUpdateStudent = new System.Windows.Forms.DataGridView();
            this.btnStudentUdate = new System.Windows.Forms.Button();
            this.lblStudentTitle = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUpdateStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(427, 109);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(95, 16);
            this.lblClassName.TabIndex = 19;
            this.lblClassName.Text = "Select Class";
            // 
            // comBoxClassSt
            // 
            this.comBoxClassSt.FormattingEnabled = true;
            this.comBoxClassSt.Location = new System.Drawing.Point(528, 107);
            this.comBoxClassSt.Name = "comBoxClassSt";
            this.comBoxClassSt.Size = new System.Drawing.Size(132, 21);
            this.comBoxClassSt.TabIndex = 18;
            // 
            // dtgvUpdateStudent
            // 
            this.dtgvUpdateStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUpdateStudent.Location = new System.Drawing.Point(221, 193);
            this.dtgvUpdateStudent.Name = "dtgvUpdateStudent";
            this.dtgvUpdateStudent.Size = new System.Drawing.Size(439, 228);
            this.dtgvUpdateStudent.TabIndex = 17;
            this.dtgvUpdateStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUpdateStudent_CellClick);
            // 
            // btnStudentUdate
            // 
            this.btnStudentUdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStudentUdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentUdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudentUdate.Location = new System.Drawing.Point(585, 148);
            this.btnStudentUdate.Name = "btnStudentUdate";
            this.btnStudentUdate.Size = new System.Drawing.Size(75, 23);
            this.btnStudentUdate.TabIndex = 16;
            this.btnStudentUdate.Text = "UPDATE";
            this.btnStudentUdate.UseVisualStyleBackColor = false;
            this.btnStudentUdate.Click += new System.EventHandler(this.btnStudentUdate_Click);
            // 
            // lblStudentTitle
            // 
            this.lblStudentTitle.AutoSize = true;
            this.lblStudentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentTitle.Location = new System.Drawing.Point(426, 52);
            this.lblStudentTitle.Name = "lblStudentTitle";
            this.lblStudentTitle.Size = new System.Drawing.Size(153, 24);
            this.lblStudentTitle.TabIndex = 13;
            this.lblStudentTitle.Text = "Update Student";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteStudent.Location = new System.Drawing.Point(494, 148);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 20;
            this.btnDeleteStudent.Text = "DELETE";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(110, 148);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(105, 16);
            this.lblStudentName.TabIndex = 14;
            this.lblStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(221, 141);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(226, 30);
            this.txtStudentName.TabIndex = 15;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(221, 102);
            this.txtStudentID.Multiline = true;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(157, 30);
            this.txtStudentID.TabIndex = 22;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(192, 109);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(23, 16);
            this.lblStudentID.TabIndex = 21;
            this.lblStudentID.Text = "ID";
            // 
            // UpdateStudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.comBoxClassSt);
            this.Controls.Add(this.dtgvUpdateStudent);
            this.Controls.Add(this.btnStudentUdate);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentTitle);
            this.Name = "UpdateStudentUC";
            this.Size = new System.Drawing.Size(800, 474);
            this.Load += new System.EventHandler(this.UpdateStudentUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUpdateStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.ComboBox comBoxClassSt;
        private System.Windows.Forms.DataGridView dtgvUpdateStudent;
        private System.Windows.Forms.Button btnStudentUdate;
        private System.Windows.Forms.Label lblStudentTitle;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentID;
    }
}
