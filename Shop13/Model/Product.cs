using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop13.Model
{
    internal class Product
    {
        private string _name;
        private string _manufacturer;
        private int _quantity;

        public string Name { get { return _name; } set { _name = Validator.AssertStringLength(value,100); } }
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = Validator.AssertStringLength(value, 100); }
        }
        
        public Category Category { get; set; }

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
