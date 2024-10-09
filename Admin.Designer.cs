namespace TeacherAdmin_Winform
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
            gridStudents = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            txtStudid = new TextBox();
            txtStudName = new TextBox();
            txtStudGPA = new TextBox();
            btnExport = new Button();
            cboxHighest = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)gridStudents).BeginInit();
            SuspendLayout();
            // 
            // gridStudents
            // 
            gridStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudents.Location = new Point(18, 19);
            gridStudents.Name = "gridStudents";
            gridStudents.Size = new Size(377, 404);
            gridStudents.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(557, 212);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(557, 266);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtStudid
            // 
            txtStudid.Location = new Point(521, 61);
            txtStudid.Name = "txtStudid";
            txtStudid.Size = new Size(162, 23);
            txtStudid.TabIndex = 3;
            // 
            // txtStudName
            // 
            txtStudName.Location = new Point(521, 112);
            txtStudName.Name = "txtStudName";
            txtStudName.Size = new Size(162, 23);
            txtStudName.TabIndex = 4;
            // 
            // txtStudGPA
            // 
            txtStudGPA.Location = new Point(521, 163);
            txtStudGPA.Name = "txtStudGPA";
            txtStudGPA.Size = new Size(162, 23);
            txtStudGPA.TabIndex = 5;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(557, 367);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // cboxHighest
            // 
            cboxHighest.AutoSize = true;
            cboxHighest.Location = new Point(468, 329);
            cboxHighest.Name = "cboxHighest";
            cboxHighest.Size = new Size(92, 19);
            cboxHighest.TabIndex = 7;
            cboxHighest.Text = "Highest GPA";
            cboxHighest.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboxHighest);
            Controls.Add(btnExport);
            Controls.Add(txtStudGPA);
            Controls.Add(txtStudName);
            Controls.Add(txtStudid);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(gridStudents);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)gridStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridStudents;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtStudid;
        private TextBox txtStudName;
        private TextBox txtStudGPA;
        private Button btnExport;
        private CheckBox cboxHighest;
    }
}