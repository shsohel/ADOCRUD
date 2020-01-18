namespace SchoolManagement.UserControls
{
    partial class AddClassUC
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
            this.lblClassTitle = new System.Windows.Forms.Label();
            this.lblAddClass = new System.Windows.Forms.Label();
            this.txtClassAdd = new System.Windows.Forms.TextBox();
            this.btnClassAdd = new System.Windows.Forms.Button();
            this.dtgvAddClass = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAddClass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassTitle
            // 
            this.lblClassTitle.AutoSize = true;
            this.lblClassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassTitle.Location = new System.Drawing.Point(293, 34);
            this.lblClassTitle.Name = "lblClassTitle";
            this.lblClassTitle.Size = new System.Drawing.Size(104, 24);
            this.lblClassTitle.TabIndex = 1;
            this.lblClassTitle.Text = "Add Class";
            // 
            // lblAddClass
            // 
            this.lblAddClass.AutoSize = true;
            this.lblAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClass.Location = new System.Drawing.Point(69, 91);
            this.lblAddClass.Name = "lblAddClass";
            this.lblAddClass.Size = new System.Drawing.Size(79, 16);
            this.lblAddClass.TabIndex = 2;
            this.lblAddClass.Text = "Add Class";
            // 
            // txtClassAdd
            // 
            this.txtClassAdd.Location = new System.Drawing.Point(171, 84);
            this.txtClassAdd.Multiline = true;
            this.txtClassAdd.Name = "txtClassAdd";
            this.txtClassAdd.Size = new System.Drawing.Size(226, 30);
            this.txtClassAdd.TabIndex = 3;
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnClassAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClassAdd.Location = new System.Drawing.Point(452, 88);
            this.btnClassAdd.Name = "btnClassAdd";
            this.btnClassAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClassAdd.TabIndex = 4;
            this.btnClassAdd.Text = "INSERT";
            this.btnClassAdd.UseVisualStyleBackColor = false;
            this.btnClassAdd.Click += new System.EventHandler(this.btnClassAdd_Click);
            // 
            // dtgvAddClass
            // 
            this.dtgvAddClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAddClass.Location = new System.Drawing.Point(88, 157);
            this.dtgvAddClass.Name = "dtgvAddClass";
            this.dtgvAddClass.Size = new System.Drawing.Size(439, 228);
            this.dtgvAddClass.TabIndex = 5;
            // 
            // AddClassUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvAddClass);
            this.Controls.Add(this.btnClassAdd);
            this.Controls.Add(this.txtClassAdd);
            this.Controls.Add(this.lblAddClass);
            this.Controls.Add(this.lblClassTitle);
            this.Name = "AddClassUC";
            this.Size = new System.Drawing.Size(800, 474);
            this.Load += new System.EventHandler(this.AddClassUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAddClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassTitle;
        private System.Windows.Forms.Label lblAddClass;
        private System.Windows.Forms.TextBox txtClassAdd;
        private System.Windows.Forms.Button btnClassAdd;
        private System.Windows.Forms.DataGridView dtgvAddClass;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
