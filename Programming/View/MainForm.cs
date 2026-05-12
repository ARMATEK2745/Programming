using Programming.Model;
using Programming.Model.Enums;
using Programming.Model.Geometry;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Programming
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        private Rectangles[] _rectanglesClasses;
        private Rectangles _currentRectangleClasses;

        private Film[] _films;
        private Film _currentFilm;


        private Rectangles _currentRectangle;
        private List<Rectangles> _rectangles = new List<Rectangles>();
        private List<Panel> _rectanglePanels = new List<Panel>();

        private static double panelWidthRectangleParameters = 521;
        private static double panelHeightRectangleParameters = 471; 

        Type[] enumTypes = { typeof(Colors), typeof(EducationForm), typeof(Genre), typeof(Manufacture), typeof(Season), typeof(Weekday) };
        public void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxSeason.DataSource = Enum.GetValues(typeof(Season));
            string[] enums = { "Color", "EducationForm", "Genre", "Manufacture", "Season", "Weekday" };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;

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

            //Фильмы
            _films = new Film[5];
            string[] genres = { "Драма", "Комедия", "Боевик", "Фантастика", "Триллер" };

            for (int i = 0; i < _films.Length; i++)
            {
                string name = $"Фильм {i + 1}";
                int minutesDuration = random.Next(90, 180); // 90–180 минут
                int releaseYear = random.Next(1990, DateTime.Now.Year + 1);
                string genre = genres[random.Next(genres.Length)];
                double rating = Math.Round(random.NextDouble() * 9 + 1, 1); // 1.0–10.0

                _films[i] = new Film(name, minutesDuration, releaseYear, genre, rating);
                listBoxFilms.Items.Add(name);
            }

        }

        public MainForm()
        {

            InitializeComponent();
            this.MinimumSize = new Size(1000, 600);
        }


        //----------------------------------Enums-----------------------------------------//
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Color":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
                    break;

                case "EducationForm":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;

                case "Genre":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;

                case "Manufacture":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacture));
                    break;

                case "Season":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;

                case "Weekday":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= enumTypes.Length)
                return;

            string selected_item = ValuesListBox.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selected_item))
                return;

            Type enumType = enumTypes[selectedIndex];
            object enumValue = Enum.Parse(enumType, selected_item);
            int numberValue = (int)enumValue;
            intValue.Text = numberValue.ToString();
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            string input = textBoxWeekendParsing.Text.Trim();

            if (Enum.TryParse(input, out Weekday day) && Enum.IsDefined(typeof(Weekday), day))
            {
                int number = (int)day;
                labelRecognizedValue.Text = $"Это день недели ({day} = {number})";
            }
            else
            {
                labelRecognizedValue.Text = "Нет такого дня недели";
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (comboBoxSeason.SelectedItem == null)
                return;

            Season selectedSeason = (Season)comboBoxSeason.SelectedItem;

            switch (selectedSeason)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;

                case Season.Autumn:
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                    break;

                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case Season.Spring:
                    this.BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");
                    break;
            }
        }




        //----------------------------------ПрямоугольникиClasses-----------------------------------------//



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


        //----------------------------------Прямоугольники-----------------------------------------//

        private void listBoxRectanglesParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRectanglesParameters.SelectedIndex;

            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            FindCollisions();

            if (selectedIndex >= 0 && selectedIndex < _rectangles.Count)
            {
                _currentRectangle = _rectangles[selectedIndex];
                UpdateRectangleInfo(_currentRectangle);
                _rectanglePanels[selectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
            }
            else
            {
                _currentRectangle = null;
                ClearRectangleInfo();
            }
        }

        private void buttonAddRectangleParameters_Click(object sender, EventArgs e)
        {
            Rectangles _rectangle = Rectangles.RandomRectangle(30, 100, 30, 100, 15, panelWidthRectangleParameters, 15, panelHeightRectangleParameters);
            _rectangles.Add(_rectangle);
            string _rectangle_str = _rectangle.Id.ToString() + ": (" +
                "X= " + _rectangle.Center.X.ToString("F2") + "; Y= " + _rectangle.Center.Y.ToString("F2") +
                "; W= " + _rectangle.Width.ToString("F2") + "; H=" + _rectangle.Length.ToString("F2") + ")";
            listBoxRectanglesParameters.Items.Add(_rectangle_str);

            Panel panel = new Panel();
            int canvasHeight = panelRectanglesDisplay.Height;
            int left = (int)(_rectangle.Center.X - _rectangle.Width / 2);
            int top = (int)(canvasHeight - (_rectangle.Center.Y + _rectangle.Length / 2));
            panel.Location = new Point(left, top);
            panel.Size = new Size((int)_rectangle.Width, (int)_rectangle.Length);
            panel.Size = new Size((int)_rectangle.Width, (int)_rectangle.Length);
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panelRectanglesDisplay.Controls.Add(panel);
            _rectanglePanels.Add(panel);
            FindCollisions();
        }

        private void buttonDelRectangleParameters_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxRectanglesParameters.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _rectangles.Count)
            {
                return;
            }
            panelRectanglesDisplay.Controls.RemoveAt(selectedIndex);
            _rectanglePanels.RemoveAt(selectedIndex);
            _rectangles.RemoveAt(selectedIndex);
            listBoxRectanglesParameters.Items.RemoveAt(selectedIndex);
            FindCollisions();
            // Вариант удаления панели по объекту
            //RectanglesPanel.Controls.Remove(panel);
        }

        private void textBoxXRectangleParameter_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = textBoxXRectangleParameter.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }
                double minX = _currentRectangle.Width / 2 + 15;
                double maxX = panelWidthRectangleParameters - _currentRectangle.Width / 2 - 15;
                if (value < minX)
                {
                    value = minX;
                }
                else if (value > maxX)
                {
                    value = maxX;
                }
                _currentRectangle.Center.SetX(value);
                UpdateRectangleInListBox();
                UpdatePanel();

            }
            catch
            {
                textBoxXRectangleParameter.Text = _currentRectangle.Center.X.ToString("F2");
            }
            _rectanglePanels[listBoxRectanglesParameters.SelectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
        }

        private void textBoxYRectangleParameter_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = textBoxYRectangleParameter.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }
                double minY = _currentRectangle.Length / 2 + 15;
                double maxY = panelHeightRectangleParameters - _currentRectangle.Length / 2 - 15;
                if (value < minY)
                {
                    value = minY;
                }
                else if (value > maxY)
                {
                    value = maxY;
                }
                _currentRectangle.Center.SetY(value);
                UpdateRectangleInListBox();
                UpdatePanel();
            }
            catch
            {
                textBoxYRectangleParameter.Text = _currentRectangle.Center.Y.ToString("F2");
            }
            _rectanglePanels[listBoxRectanglesParameters.SelectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
        }

        private void textBoxWidthRectangleParameter_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = textBoxWidthRectangleParameter.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }

                //if (value < 0)
                //{
                //    value = 1;
                //}
                //else if (value > 100)
                //{
                //    value = 100;
                //}

                Validator.AssertValueInRange(value, 0, 400, "Width");

                _currentRectangle.Width = value;
                UpdateRectangleInListBox();
                UpdatePanel();
            }
            catch
            {
                textBoxWidthRectangleParameter.Text = _currentRectangle.Width.ToString("F2");
            }
            _rectanglePanels[listBoxRectanglesParameters.SelectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
        }

        private void textBoxHeightRectangleParameter_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                string input = textBoxHeightRectangleParameter.Text;
                if (!double.TryParse(input, out double value))
                {
                    throw new ArgumentException();
                }

                /*if (value < 0)
                {
                    value = 1;
                }
                else if (value > 100)
                {
                    value = 100;
                }*/

                Validator.AssertValueInRange(value, 0, 400, "Height");

                _currentRectangle.Length = value;
                UpdateRectangleInListBox();
                UpdatePanel();
            }
            catch
            {
                textBoxHeightRectangleParameter.Text = _currentRectangle.Length.ToString("F2");
            }
            _rectanglePanels[listBoxRectanglesParameters.SelectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
        }

        private void ClearRectangleInfo()
        {
            textBoxIdRectangleParameter.Text = "";
            textBoxXRectangleParameter.Text = "";
            textBoxYRectangleParameter.Text = "";
            textBoxWidthRectangleParameter.Text = "";
            textBoxHeightRectangleParameter.Text = "";
        }
        private void UpdateRectangleInfo(Rectangles rectangle)
        {
            if (rectangle == null) return;

            textBoxIdRectangleParameter.Text = _currentRectangle.Id.ToString();
            textBoxXRectangleParameter.Text = _currentRectangle.Center.X.ToString("F2");
            textBoxYRectangleParameter.Text = _currentRectangle.Center.Y.ToString("F2");
            textBoxWidthRectangleParameter.Text = _currentRectangle.Width.ToString("F2");
            textBoxHeightRectangleParameter.Text = _currentRectangle.Length.ToString("F2");
        }
        private void UpdatePanel()
        {
            int index = _rectangles.IndexOf(_currentRectangle);
            int canvasHeight = panelRectanglesDisplay.Height;
            int left = (int)(_currentRectangle.Center.X - _currentRectangle.Width / 2);
            int top = (int)(canvasHeight - (_currentRectangle.Center.Y + _currentRectangle.Length / 2));
            _rectanglePanels[index].Location = new Point(left, top);
            _rectanglePanels[index].Size = new Size((int)_currentRectangle.Width, (int)_currentRectangle.Length);
            FindCollisions();
            _rectanglePanels[listBoxRectanglesParameters.SelectedIndex].BackColor = Color.FromArgb(200, 127, 255, 255);
        }
        private void UpdateRectangleInListBox()
        {
            if (_currentRectangle == null) return;

            int selectedIndex = listBoxRectanglesParameters.SelectedIndex;
            string _rectangle_str = _currentRectangle.Id.ToString() + ": (" +
                                "X= " + _currentRectangle.Center.X.ToString("F2") +
                                "; Y= " + _currentRectangle.Center.Y.ToString("F2") +
                                "; W= " + _currentRectangle.Width.ToString("F2") +
                                "; H= " + _currentRectangle.Length.ToString("F2") + ")";
            listBoxRectanglesParameters.Items[selectedIndex] = _rectangle_str;
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (i == j) continue;

                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        //------------------------------------Фильмы---------------------------------------//

        private void listBoxFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilms.SelectedIndex == -1)
                return;

            if (listBoxFilms.SelectedIndex < 0 || listBoxFilms.SelectedIndex >= _films.Length)
                return;

            _currentFilm = _films[listBoxFilms.SelectedIndex];
            UpdateFilmInfo(_currentFilm);
        }

        private void UpdateFilmInfo(Film film)
        {
            if (film == null)
            {
                textBoxNameFilm.Text = string.Empty;
                textBoxMinutesDurationFilm.Text = string.Empty;
                textBoxReleaseYearFilm.Text = string.Empty;
                textBoxGenreFilm.Text = string.Empty;
                textBoxRatingFilm.Text = string.Empty;
            }
            else
            {
                textBoxNameFilm.Text = film.Name;
                textBoxMinutesDurationFilm.Text = film.MinutesDuration.ToString();
                textBoxReleaseYearFilm.Text = film.ReleaseYear.ToString();
                textBoxGenreFilm.Text = film.Genre;
                textBoxRatingFilm.Text = film.Rating.ToString("F1");
            }
        }


        private int FindFilmWithMaxRating(Film[] films)
        {
            if (films == null || films.Length == 0)
                return -1;

            int maxIndex = 0;
            double maxRating = films[0].Rating;

            for (int i = 1; i < films.Length; i++)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = films[i].Rating;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void buttonFindBestFilm_Click(object sender, EventArgs e)
        {
            int index = FindFilmWithMaxRating(_films);
            if (index >= 0 && index < _films.Length)
            {
                listBoxFilms.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Фильмы отсутствуют.");
            }
        }

        private void textBoxMinutesDurationFilm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(textBoxMinutesDurationFilm.Text);
                _currentFilm.MinutesDuration = value;
                textBoxMinutesDurationFilm.BackColor = Color.White;
            }
            catch
            {
                textBoxMinutesDurationFilm.BackColor = Color.LightPink;
            }
        }

        private void textBoxReleaseYearFilm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(textBoxReleaseYearFilm.Text);
                _currentFilm.ReleaseYear = value;
                textBoxReleaseYearFilm.BackColor = Color.White;
            }
            catch
            {
                textBoxReleaseYearFilm.BackColor = Color.LightPink;
            }
        }

        private void textBoxGenreFilm_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = textBoxGenreFilm.Text;
        }

        private void textBoxRatingFilm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(textBoxRatingFilm.Text);
                _currentFilm.Rating = value;
                textBoxRatingFilm.BackColor = Color.White;
            }
            catch
            {
                textBoxRatingFilm.BackColor = Color.LightPink;
            }
        }

        
    }
}
