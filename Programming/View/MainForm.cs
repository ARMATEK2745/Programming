using Programming.Model.Enums;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Programming
{
    public partial class MainForm : Form
    {
        public void MainForm_Load(object sender, EventArgs e)
        {
            string[] enums = { "Color", "EducationForm", "Genre", "Manufacture", "Season", "Weekday" };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
        }
        public MainForm()
        {
            InitializeComponent();
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Color":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Programming.Model.Enums.Color));
                    break;

                case "EducationForm":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;

                case "Genre":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;

                case "Manufacture":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacture));
                    break;

                case "Season":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;

                case "Weekday":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }

    }
}
