namespace PracticeApp10
{

    public partial class Form1 : Form
    {
        List<Comic> ComicList = new List<Comic>();
        public Form1()
        {
            InitializeComponent();

            cbbPublisher.Items.Add("Marvel");
            cbbPublisher.Items.Add("DC");
            cbbPublisher.Items.Add("Other");

            cbbPublisher.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) || string.IsNullOrWhiteSpace(cbbPublisher.Text) || 
                string.IsNullOrWhiteSpace(txtGenre.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(txtYear.Text, out int year) || !int.TryParse(txtPrice.Text, out int price))
            {
                MessageBox.Show("Year and Price must be numbers.");
                return;
            }

            Comic comic = new Comic(txtName.Text, year, txtAuthor.Text, cbbPublisher.Text, txtGenre.Text, price);
            ComicList.Add(comic);

            //MessageBox.Show("Comic added successfully!");

            gridComics.DataSource = null; 
            gridComics.DataSource = ComicList; 
        }
    }
}
