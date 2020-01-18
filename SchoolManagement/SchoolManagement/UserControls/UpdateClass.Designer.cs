namespace SchoolManagement.UserControls
{
    partial class UpdateClassUC
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
            this.dtgvUpdateClass = new System.Windows.Forms.DataGridView();
            this.btnClassUpdate = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblUpdateClassName = new System.Windows.Forms.Label();
            this.lblClassTitle = new System.Windows.Forms.Label();
            this.txtClassIDUpdate = new System.Windows.Forms.TextBox();
            this.lblClassID = new System.Windows.Forms.Label();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUpdateClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvUpdateClass
            // 
            this.dtgvUpdateClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUpdateClass.Location = new System.Drawing.Point(168, 170);
            this.dtgvUpdateClass.Name = "dtgvUpdateClass";
            this.dtgvUpdateClass.Size = new System.Drawing.Size(439, 228);
            this.dtgvUpdateClass.TabIndex = 10;
            this.dtgvUpdateClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUpdateClass_CellClick);
            // 
            // btnClassUpdate
            // 
            this.btnClassUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnClassUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClassUpdate.Location = new System.Drawing.Point(532, 123);
            this.btnClassUpdate.Name = "btnClassUpdate";
            this.btnClassUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnClassUpdate.TabIndex = 9;
            this.btnClassUpdate.Text = "Update";
            this.btnClassUpdate.UseVisualStyleBackColor = false;
            this.btnClassUpdate.Click += new System.EventHandler(this.btnClassUpdate_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(251, 119);
            this.txtClassName.Multiline = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(226, 30);
            this.txtClassName.TabIndex = 8;
            // 
            // lblUpdateClassName
            // 
            this.lblUpdateClassName.AutoSize = true;
            this.lblUpdateClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateClassName.Location = new System.Drawing.Point(149, 126);
            this.lblUpdateClassName.Name = "lblUpdateClassName";
            this.lblUpdateClassName.Size = new System.Drawing.Size(92, 16);
            this.lblUpdateClassName.TabIndex = 7;
            this.lblUpdateClassName.Text = "Class Name";
            // 
            // lblClassTitle
            // 
            this.lblClassTitle.AutoSize = true;
            this.lblClassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassTitle.Location = new System.Drawing.Point(373, 47);
            this.lblClassTitle.Name = "lblClassTitle";
            this.lblClassTitle.Size = new System.Drawing.Size(104, 24);
            this.lblClassTitle.TabIndex = 6;
            this.lblClassTitle.Text = "Add Class";
            // 
            // txtClassIDUpdate
            // 
            this.txtClassIDUpdate.Location = new System.Drawing.Point(251, 83);
            this.txtClassIDUpdate.Multiline = true;
            this.txtClassIDUpdate.Name = "txtClassIDUpdate";
            this.txtClassIDUpdate.ReadOnly = true;
            this.txtClassIDUpdate.Size = new System.Drawing.Size(79, 30);
            this.txtClassIDUpdate.TabIndex = 12;
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.Location = new System.Drawing.Point(218, 90);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(23, 16);
            this.lblClassID.TabIndex = 11;
            this.lblClassID.Text = "ID";
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.BackColor = System.Drawing.Color.Red;
            this.btnDeleteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteClass.Location = new System.Drawing.Point(532, 87);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClass.TabIndex = 13;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.UseVisualStyleBackColor = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // UpdateClassUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.txtClassIDUpdate);
            this.Controls.Add(this.lblClassID);
            this.Controls.Add(this.dtgvUpdateClass);
            this.Controls.Add(this.btnClassUpdate);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.lblUpdateClassName);
            this.Controls.Add(this.lblClassTitle);
            this.Name = "UpdateClassUC";
            this.Size = new System.Drawing.Size(800, 474);
            this.Load += new System.EventHandler(this.UpdateClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUpdateClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvUpdateClass;
        private System.Windows.Forms.Button btnClassUpdate;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblUpdateClassName;
        private System.Windows.Forms.Label lblClassTitle;
        private System.Windows.Forms.TextBox txtClassIDUpdate;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.Button btnDeleteClass;
    }
}
