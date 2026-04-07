using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Сontact
    {
        private string name = "";           //Имя
        private string surname = "";        //Фамилия
        private string phoneNumber = "";    //Номер телефона
        private string email = "";          //Электронная почта

        public string Name { get { return name; } 
            set 
            { 
                name = value;
                AssertStringContainsOnlyLetters(value, nameof(name));
            } }

        public string Surname { get { return surname; } 
            set 
            {
                surname = value; 
                AssertStringContainsOnlyLetters(value, nameof(surname)); 
            } }

        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }

        public string Email { get { return email; } set { email = value; } }

        public Сontact(string name, string surname, string phoneNumber, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        public Сontact() { }

        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Значение в свойстве {propertyName} не может быть пустым или содержать только пробелы.");
            }

            foreach (char c in value)
            {
                if (!char.IsLetter(c) || !((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                {
                    throw new ArgumentException($"Некорректное значение в свойстве {propertyName}: символ '{c}' не является буквой английского алфавита.");
                }
            }
        }
    }
}
