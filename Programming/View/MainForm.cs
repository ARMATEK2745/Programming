using Programming.Model.Enums;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type[] enumTypes = { typeof(Colors), typeof(EducationForm), typeof(Genre), typeof(Manufacture), typeof(Season), typeof(Weekday) };
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
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= enumTypes.Length)
                return;

            string selected_item = ValuesListBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selected_item))
                return;

            Type enumType = enumTypes[selectedIndex];
            object enumValue = Enum.Parse(enumType, selected_item);
            int numberValue = (int)enumValue;
            intValue.Text = numberValue.ToString();
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            string input = textBoxWeekendParsing.Text.Trim();

            if (Enum.TryParse(input, out Weekday day) && Enum.IsDefined(typeof(Weekday), day))
            {
                int number = (int)day;
                labelRecognizedValue.Text = $"Это день недели ({day} = {number})";
            }
            else
            {
                labelRecognizedValue.Text = "Нет такого дня недели";
            }
        }
    }
}
