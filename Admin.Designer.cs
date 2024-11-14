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
            radioHighestGPA = new RadioButton();
            radioHonorRoll = new RadioButton();
            lblStudentid = new Label();
            lblStudentName = new Label();
            lblGPA = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gridStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gridStudents
            // 
            gridStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridStudents.BackgroundColor = Color.White;
            gridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudents.Location = new Point(12, 15);
            gridStudents.Name = "gridStudents";
            gridStudents.Size = new Size(396, 421);
            gridStudents.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(557, 214);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(557, 261);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
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
            btnExport.BackColor = Color.Gainsboro;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderColor = Color.SteelBlue;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Black;
            btnExport.Location = new Point(557, 364);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 29);
            btnExport.TabIndex = 6;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // radioHighestGPA
            // 
            radioHighestGPA.AutoSize = true;
            radioHighestGPA.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioHighestGPA.Location = new Point(478, 318);
            radioHighestGPA.Name = "radioHighestGPA";
            radioHighestGPA.Size = new Size(97, 21);
            radioHighestGPA.TabIndex = 9;
            radioHighestGPA.TabStop = true;
            radioHighestGPA.Text = "Highest GPA";
            radioHighestGPA.UseVisualStyleBackColor = true;
            // 
            // radioHonorRoll
            // 
            radioHonorRoll.AutoSize = true;
            radioHonorRoll.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioHonorRoll.Location = new Point(623, 318);
            radioHonorRoll.Name = "radioHonorRoll";
            radioHonorRoll.Size = new Size(89, 21);
            radioHonorRoll.TabIndex = 10;
            radioHonorRoll.TabStop = true;
            radioHonorRoll.Text = "Honor Roll";
            radioHonorRoll.UseVisualStyleBackColor = true;
            // 
            // lblStudentid
            // 
            lblStudentid.AutoSize = true;
            lblStudentid.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentid.Location = new Point(448, 64);
            lblStudentid.Name = "lblStudentid";
            lblStudentid.Size = new Size(67, 17);
            lblStudentid.TabIndex = 11;
            lblStudentid.Text = "Student Id";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(470, 115);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(43, 17);
            lblStudentName.TabIndex = 12;
            lblStudentName.Text = "Name";
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGPA.Location = new Point(470, 171);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(31, 17);
            lblGPA.TabIndex = 13;
            lblGPA.Text = "GPA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SteelBlue;
            pictureBox1.Location = new Point(4, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 437);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(758, 450);
            Controls.Add(lblGPA);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentid);
            Controls.Add(radioHonorRoll);
            Controls.Add(radioHighestGPA);
            Controls.Add(btnExport);
            Controls.Add(txtStudGPA);
            Controls.Add(txtStudName);
            Controls.Add(txtStudid);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(gridStudents);
            Controls.Add(pictureBox1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)gridStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private RadioButton radioHighestGPA;
        private RadioButton radioHonorRoll;
        private Label lblStudentid;
        private Label lblStudentName;
        private Label lblGPA;
        private PictureBox pictureBox1;
    }
}