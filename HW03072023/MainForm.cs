namespace HW03072023
{
	public partial class MainForm : Form
	{
		public MainForm() {
			InitializeComponent();
		}

		private void button_Click(object sender, EventArgs e) => new SearchForm().Show();
	}
}
