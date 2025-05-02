namespace PracticeApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbbMarvelDC.Items.Add("Marvel");
            cbbMarvelDC.Items.Add("DC");

            cbbMarvelDC.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
