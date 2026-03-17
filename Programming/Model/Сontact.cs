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
        private string phoneNumber = "";    //Номер телефона
        private string email = "";          //Электронная почта

        public string Name { get { return name; } set { name = value; } }

        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }

        public string Email { get { return email; } set { email = value; } }

        public Сontact(string name, string phoneNumber, string email)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        public Сontact() { }
    }
}
