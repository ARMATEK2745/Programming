using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Subject
    {
        private string name = "";       // Название дисциплины
        private int semester;           // Семестр
        private int grade;              // Оценка (зачёт/экзамен)

        public string Name { get { return name; } set { name = value; } }

        public int Semester
        {
            set
            {
                if (value > 0 && value < 3) semester = value;
                else throw new ArgumentException(nameof(value), "Семестр должен быть только 1 или 2");
            }
            get { return semester; }
        }

        public int Grade
        {
            set
            {
                if (value > 2 && value < 6) grade = value;
                else throw new ArgumentException(nameof(value), "Оценка должна быть в диапозоне от 3 до 5");
            }
            get { return grade; }
        }
    }
}
