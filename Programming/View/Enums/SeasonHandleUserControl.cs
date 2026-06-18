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
    public partial class SeasonHandleUserControl : UserControl
    {
        public SeasonHandleUserControl()
        {
            InitializeComponent();
            comboBoxSeason.DataSource = Enum.GetValues(typeof(Season));
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (comboBoxSeason.SelectedItem == null)
                return;

            Season selectedSeason = (Season)comboBoxSeason.SelectedItem;

            switch (selectedSeason)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;

                case Season.Autumn:
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                    break;

                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case Season.Spring:
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");
                    break;
            }
        }
    }
}
