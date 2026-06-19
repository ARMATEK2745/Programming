using Shop13.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop13.View
{
    public partial class ShopUserControl : UserControl
    {
        private string _saveFileName = "\\Save.txt";
        private string _rootPath;

        private bool _nameChanged;
        private List<Product> _products;
        private Product _currentProduct;
        public ShopUserControl()
        {
            InitializeComponent();
            _rootPath = Directory.GetCurrentDirectory();

            _products = new List<Product>();
            LoadProducts();
            comboBoxCategory.DataSource = Enum.GetValues(typeof(Category));
        }

        public void SaveProducts()
        {
            using (StreamWriter sw = new StreamWriter(_rootPath + _saveFileName))
            {
                foreach (Product product in _products)
                {
                    sw.WriteLine($"{product.Name};{product.Manufacturer};{(int)product.Category};{product.Quantity}");
                }
            }
        }

        private void LoadProducts()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_rootPath + _saveFileName))
                {
                    string line;
                    string[] arrayLine;

                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        arrayLine = line.Split(';');

                        Product product = new Product();
                        product.Name = arrayLine[0];
                        product.Manufacturer = arrayLine[1];
                        product.Category = (Category)int.Parse(arrayLine[2]);
                        product.Quantity = int.Parse(arrayLine[3]);

                        _products.Add(product);
                        listBoxProducts.Items.Add(product.Name);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Не удалось прочитать файл");
            }
        }

        private void Sort()
        {
            _products = _products.OrderBy(x => x.Name).ToList();

            int _currentIndex = _products.IndexOf(_currentProduct);
            listBoxProducts.Items.Clear();
            foreach (Product product in _products)
            {
                listBoxProducts.Items.Add(product.Name);
            }
            listBoxProducts.SelectedIndex = _currentIndex;
        }


        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex < 0) return;
            _currentProduct = _products[listBoxProducts.SelectedIndex];

            if (_currentProduct != null)
            {
                textBoxName.Text = _currentProduct.Name;
                textBoxManufacturer.Text = _currentProduct.Manufacturer;
                comboBoxCategory.SelectedIndex = (int)_currentProduct.Category;
                textBoxQuantity.Text = _currentProduct.Quantity.ToString();
            }
            else
            {
                textBoxName.Text = string.Empty;
                textBoxManufacturer.Text = string.Empty;
                comboBoxCategory.SelectedIndex = 0;
                textBoxQuantity.Text = string.Empty;
            }
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            _products.Add(product);
            listBoxProducts.Items.Add(product.Name);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            _products.RemoveAt(listBoxProducts.SelectedIndex);
            listBoxProducts.Items.RemoveAt(listBoxProducts.SelectedIndex);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (_currentProduct == null) return;
            try
            {
                _currentProduct.Name = textBoxName.Text;
            }
            catch
            {
                textBoxName.BackColor = Color.Red;
                return;
            }
            textBoxName.BackColor = Color.White;
            listBoxProducts.Items[listBoxProducts.SelectedIndex] = _currentProduct.Name;
            if (_nameChanged)
                Sort();
        }

        private void textBoxManufacturer_TextChanged(object sender, EventArgs e)
        {
            if (_currentProduct == null) return;
            try
            {
                _currentProduct.Manufacturer = textBoxManufacturer.Text;
            }
            catch
            {
                textBoxManufacturer.BackColor = Color.Red;
                return;
            }
            textBoxManufacturer.BackColor = Color.White;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentProduct == null) return;
            _currentProduct.Category = (Category)comboBoxCategory.SelectedIndex;
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (_currentProduct == null) return;
            try
            {
                _currentProduct.Quantity = int.Parse(textBoxQuantity.Text);
            }
            catch
            {
                textBoxQuantity.BackColor = Color.Red;
                return;
            }
            textBoxQuantity.BackColor = Color.White;
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            _nameChanged = true;
        }

        private void ShopUserControl_Leave(object sender, EventArgs e)
        {
            _nameChanged = false;
        }
    }
}
