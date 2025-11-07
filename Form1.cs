namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("ایا میخواهید خارج شوید ؟", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
