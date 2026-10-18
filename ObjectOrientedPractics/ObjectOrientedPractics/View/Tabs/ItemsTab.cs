using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Панель для работы с товарами
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров 
        /// </summary>
        private BindingList<Item> _items = new();

        /// <summary>
        /// Инциализация компанентов ItemsTab
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки AddButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();
            _items.Add(newItem);
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки RemoveButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;

                _items.RemoveAt(selectedIndex);

                ItemsListBox.SelectedIndex = -1;

                ClearItemsInfo();
            }
        }

        /// <summary>
        /// Метод очистки текста полей в форме
        /// </summary>
        private void ClearItemsInfo()
        {
            IdTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            InfoTextBox.Text = "";
        }

        /// <summary>
        /// Обрабатывает событие смены индекса в ItemsListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                IdTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Id.ToString();
                NameTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Name;
                InfoTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Info;
                CostTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Cost.ToString();
            }
            else
            {
                ClearItemsInfo();
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в CostTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _items[ItemsListBox.SelectedIndex].Cost = double.Parse(CostTextBox.Text);
                    CostTextBox.BackColor = Color.White;
                }
                catch { CostTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в NameTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                    NameTextBox.BackColor = Color.White;
                }
                catch { NameTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в InfoTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _items[ItemsListBox.SelectedIndex].Info = InfoTextBox.Text;
                    InfoTextBox.BackColor = Color.White;
                }
                catch { InfoTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обрабатывает событие выхода из NameTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            RefreshItemsListBox();
        }

        /// <summary>
        /// Обновляет отображение ItemsListBox
        /// </summary>
        private void RefreshItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Name";
        }
    }
}
