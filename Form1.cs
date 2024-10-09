namespace TeacherAdmin_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Teacher" && txtPassword.Text == "Admin")
            {
                this.Hide();
                Admin admin = new Admin();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password, Please try again");
            }
        }
    }
}
