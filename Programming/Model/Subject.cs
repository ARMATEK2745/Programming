using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о учебном предмете
    /// </summary>
    internal class Subject
    {
        private string name = "";       // Название дисциплины
        private int semester;           // Семестр
        private int grade;              // Оценка (зачёт/экзамен)

        /// <summary>
        /// Возвращает и задаёт название предмета
        /// </summary>
        public string Name { get { return name; } set { name = value; } }

        /// <summary>
        /// Возвращает и задаёт номер семестра
        /// </summary>
        public int Semester
        {
            set
            {
                semester = Validator.AssertValueInRange(value, 1, 2, nameof(semester));
            }
            get { return semester; }
        }

        /// <summary>
        /// Возвращает и задаёт оценку
        /// </summary>
        public int Grade
        {
            set
            {
                grade = Validator.AssertValueInRange(value, 3, 5, nameof(grade));
            }
            get { return grade; }
        }

        public Subject(string name, int semester, int grade)
        {
            Name = name;
            Semester = semester;
            Grade = grade;
        }

        public Subject() { }
    }
}
