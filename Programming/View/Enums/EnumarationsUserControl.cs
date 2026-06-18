using Programming.Model.Enums;

namespace Programming.View
{
    public partial class EnumarationsUserControl : UserControl
    {
        Type[] enumTypes = { typeof(Colors), typeof(EducationForm), typeof(Genre), typeof(Manufacture), typeof(Season), typeof(Weekday) };

       
        public EnumarationsUserControl()
        {
            InitializeComponent();

            string[] enums = { "Color", "EducationForm", "Genre", "Manufacture", "Season", "Weekday" };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
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
    }
}
