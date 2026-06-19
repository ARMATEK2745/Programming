using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop13.Model
{
    /// <summary>
    /// хранит данные о продукты
    /// </summary>
    internal class Product
    {
        private string _name;
        private string _manufacturer;
        private int _quantity;
        /// <summary>
        /// Возвращает и создает название
        /// </summary>
        public string Name { get { return _name; } set { _name = Validator.AssertStringLength(value,100); } }

        /// <summary>
        /// Возвращает и создает производителя
        /// </summary>
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = Validator.AssertStringLength(value, 100); }
        }

        /// <summary>
        /// Возвращает и создает категорию
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и создает количество
        /// </summary>
        public int Quantity { get { return _quantity; } set { _quantity = Validator.AssertOnPositiveValue(value, nameof(_quantity)); } }

        public Product() 
        {
            Name = "Название";
            Manufacturer = "Производитель";
            Category = Category.None;
            Quantity = 0;
        }
    }
}
