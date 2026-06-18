using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class WeekdayParsingUserControl : UserControl
    {
        public WeekdayParsingUserControl()
        {
            InitializeComponent();
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
