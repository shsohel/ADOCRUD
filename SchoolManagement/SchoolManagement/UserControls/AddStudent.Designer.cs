namespace SchoolManagement.UserControls
{
    partial class AddStudentUC
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
            this.dtgvAddStudent = new System.Windows.Forms.DataGridView();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentTitle = new System.Windows.Forms.Label();
            this.comBoxClassSt = new System.Windows.Forms.ComboBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAddStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAddStudent
            // 
            this.dtgvAddStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAddStudent.Location = new System.Drawing.Point(190, 203);
            this.dtgvAddStudent.Name = "dtgvAddStudent";
            this.dtgvAddStudent.Size = new System.Drawing.Size(439, 228);
            this.dtgvAddStudent.TabIndex = 10;
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStudentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudentAdd.Location = new System.Drawing.Point(554, 158);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnStudentAdd.TabIndex = 9;
            this.btnStudentAdd.Text = "INSERT";
            this.btnStudentAdd.UseVisualStyleBackColor = false;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(149, 112);
            this.txtStudentName.Multiline = true;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(226, 30);
            this.txtStudentName.TabIndex = 8;
            // 
            // lblStudentTitle
            // 
            this.lblStudentTitle.AutoSize = true;
            this.lblStudentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentTitle.Location = new System.Drawing.Point(395, 62);
            this.lblStudentTitle.Name = "lblStudentTitle";
            this.lblStudentTitle.Size = new System.Drawing.Size(125, 24);
            this.lblStudentTitle.TabIndex = 6;
            this.lblStudentTitle.Text = "Add Student";
            // 
            // comBoxClassSt
            // 
            this.comBoxClassSt.FormattingEnabled = true;
            this.comBoxClassSt.Location = new System.Drawing.Point(497, 117);
            this.comBoxClassSt.Name = "comBoxClassSt";
            this.comBoxClassSt.Size = new System.Drawing.Size(132, 21);
            this.comBoxClassSt.TabIndex = 11;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(38, 119);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(105, 16);
            this.lblStudentName.TabIndex = 7;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(396, 119);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(95, 16);
            this.lblClassName.TabIndex = 12;
            this.lblClassName.Text = "Select Class";
            // 
            // AddStudentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.comBoxClassSt);
            this.Controls.Add(this.dtgvAddStudent);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentTitle);
            this.Name = "AddStudentUC";
            this.Size = new System.Drawing.Size(800, 474);
            this.Load += new System.EventHandler(this.AddStudentUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAddStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAddStudent;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentTitle;
        private System.Windows.Forms.ComboBox comBoxClassSt;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblClassName;
    }
}
