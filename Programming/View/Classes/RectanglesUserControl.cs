using Programming.Model.Enums;
using Programming.Model.Geometry;
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
    public partial class RectanglesUserControl : UserControl
    {
        private Rectangles[] _rectanglesClasses;
        private Rectangles _currentRectangleClasses;


        public RectanglesUserControl()
        {
            InitializeComponent();
            Random random = new Random();
            //Прямоугольники
            _rectanglesClasses = new Rectangles[5];

            int colorCount = Enum.GetNames(typeof(Colors)).Length;
            for (int i = 0; i < _rectanglesClasses.Length; i++)
            {
                string name = $"Rectangle {i + 1}";
                double length = random.NextDouble() * 100 + 10; // 10–110
                double width = random.NextDouble() * 100 + 10;  // 10–110
                string colour = ((Colors)random.Next(colorCount)).ToString(); // произвольный цвет для примера
                Point2D center = new Point2D(random.NextDouble() * 100 + 10, random.NextDouble() * 100 + 10);
                _rectanglesClasses[i] = new Rectangles(name, length, width, colour, center);
                listBoxRectangles.Items.Add(name);
            }
        }

        private void UpdateRectangleInfoClasses(Rectangles rectangle)
        {
            if (rectangle == null)
            {
                // Если прямоугольник null, очищаем поля
                textBoxIdRectangles.Text = string.Empty;
                textBoxLength.Text = string.Empty;
                textBoxWidth.Text = string.Empty;
                textBoxColor.Text = string.Empty;
                textBoxXRectangle.Text = string.Empty; // Очищаем поле X центра
                textBoxYRectangle.Text = string.Empty; // Очищаем поле Y центра
            }
            else
            {
                textBoxIdRectangles.Text = rectangle.Id.ToString();
                // Обновляем поля формы данными из выбранного прямоугольника
                textBoxLength.Text = rectangle.Length.ToString("F2");
                textBoxWidth.Text = rectangle.Width.ToString("F2");
                textBoxColor.Text = rectangle.Colour;
                // Заполняем поля центра
                textBoxXRectangle.Text = rectangle.Center.X.ToString("F2");
                textBoxYRectangle.Text = rectangle.Center.Y.ToString("F2");
            }
        }

        private int FindRectangleWithMaxWidth(Rectangles[] rectangles)
        {
            if (rectangles == null || rectangles.Length == 0)
                return -1;

            int maxIndex = 0;
            double maxWidth = rectangles[0].Width;

            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void listBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, что есть выбранный элемент
            if (listBoxRectangles.SelectedIndex == -1)
                return;

            // Проверяем, что индекс находится в границах массива _rectangles
            if (listBoxRectangles.SelectedIndex < 0 || listBoxRectangles.SelectedIndex >= _rectanglesClasses.Length)
                return;

            // Присваиваем _currentRectangle соответствующий объект из массива
            _currentRectangleClasses = _rectanglesClasses[listBoxRectangles.SelectedIndex];

            // Обновляем интерфейс — отображаем свойства выбранного прямоугольника
            UpdateRectangleInfoClasses(_currentRectangleClasses);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectanglesClasses);
            if (index >= 0 && index < _rectanglesClasses.Length)
            {
                listBoxRectangles.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Прямоугольники отсутствуют.");
            }
        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(textBoxLength.Text);
                if (value < 10 || value > 110)
                    throw new ArgumentException();

                _currentRectangleClasses.Length = value;
                textBoxLength.BackColor = Color.White;
            }
            catch
            {
                textBoxLength.BackColor = Color.LightPink;
            }
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(textBoxWidth.Text);
                if (value < 10 || value > 110)
                    throw new ArgumentException();

                _currentRectangleClasses.Width = value;
                textBoxWidth.BackColor = Color.White;
            }

            catch
            {
                textBoxWidth.BackColor = Color.LightPink;
            }
        }
    }
}
