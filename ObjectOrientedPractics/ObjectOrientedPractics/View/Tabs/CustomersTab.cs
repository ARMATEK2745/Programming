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
    /// Панель для работы с покупателями
    /// </summary>
    public partial class CustomersTab : UserControl
    {   
        /// <summary>
        /// Список покупателей 
        /// </summary>
        private BindingList<Customer> _customers = new BindingList<Customer>();

        /// <summary>
        /// Инциализация компанентов CustomersTab
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "Fullname";
        }

        /// <summary>
        /// Обрабатывает событие нажатие кнопки AddButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            _customers.Add(newCustomer);
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки RemoveButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;

                _customers.RemoveAt(selectedIndex);

                CustomersListBox.SelectedIndex = -1;

                ClearCustomersInfo();
            }

        }

        /// <summary>
        /// Обрабатывает событие смены индекса в CustomersListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                IdTextBox.Text = ((Customer)CustomersListBox.SelectedItem).Id.ToString();
                FullnameTextBox.Text = ((Customer)CustomersListBox.SelectedItem).Fullname;
                AddressTextBox.Text = ((Customer)CustomersListBox.SelectedItem).Address;
            }
            else
            {
                ClearCustomersInfo();
            }
        }

        /// <summary>
        /// Обрабатывает событие изменение текста в AddressTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    _customers[CustomersListBox.SelectedIndex].Address = AddressTextBox.Text;
                    AddressTextBox.BackColor = Color.White;
                }
                catch { AddressTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обрабатывает событие изменение текста в FullnameTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    _customers[CustomersListBox.SelectedIndex].Fullname = FullnameTextBox.Text;
                    FullnameTextBox.BackColor = Color.White;
                }
                catch { FullnameTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обрабатывает событие выхода из FullnameTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullnameTextBox_Leave(object sender, EventArgs e)
        {
            RefreshCustomersListBox();
        }

        /// <summary>
        /// Очищает текстовые поля формы о данных покупателя.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IdTextBox.Text = "";
            FullnameTextBox.Text = "";
            AddressTextBox.Text = "";
        }

        /// <summary>
        /// Обновляет отображение CustomersListBox
        /// </summary>
        private void RefreshCustomersListBox()
        {
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "Fullname";
        }
    }
}
