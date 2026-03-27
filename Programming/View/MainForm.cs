using Programming.Model;
using Programming.Model.Enums;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Programming
{
    public partial class MainForm : Form
    {
        Random random = new Random();
        private Rectangles[] _rectangles;
        private Rectangles _currentRectangle;

        private Film[] _films;
        private Film _currentFilm;



        Type[] enumTypes = { typeof(Colors), typeof(EducationForm), typeof(Genre), typeof(Manufacture), typeof(Season), typeof(Weekday) };
        public void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxSeason.DataSource = Enum.GetValues(typeof(Season));
            string[] enums = { "Color", "EducationForm", "Genre", "Manufacture", "Season", "Weekday" };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;

            //Прямоугольники
            _rectangles = new Rectangles[5];

            int colorCount = Enum.GetNames(typeof(Colors)).Length;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                string name = $"Rectangle {i + 1}";
                double length = random.NextDouble() * 100 + 10; // 10–110
                double width = random.NextDouble() * 100 + 10;  // 10–110
                string colour = ((Colors)random.Next(colorCount)).ToString(); // произвольный цвет для примера
                _rectangles[i] = new Rectangles(name, length, width, colour);
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
                double rating = Math.Round(random.NextDouble() * 10, 1); // 0.0–10.0

                _films[i] = new Film(name, minutesDuration, releaseYear, genre, rating);
                listBoxFilms.Items.Add(name);
            }

        }

        public MainForm()
        {
            InitializeComponent();
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




        //----------------------------------Прямоугольники-----------------------------------------//



        private void listBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, что есть выбранный элемент
            if (listBoxRectangles.SelectedIndex == -1)
                return;

            // Проверяем, что индекс находится в границах массива _rectangles
            if (listBoxRectangles.SelectedIndex < 0 || listBoxRectangles.SelectedIndex >= _rectangles.Length)
                return;

            // Присваиваем _currentRectangle соответствующий объект из массива
            _currentRectangle = _rectangles[listBoxRectangles.SelectedIndex];

            // Обновляем интерфейс — отображаем свойства выбранного прямоугольника
            UpdateRectangleInfo(_currentRectangle);
        }

        private void UpdateRectangleInfo(Rectangles rectangle)
        {
            if (rectangle == null)
            {
                // Если прямоугольник null, очищаем поля
                textBoxLength.Text = string.Empty;
                textBoxWidth.Text = string.Empty;
                textBoxColor.Text = string.Empty;
            }
            else
            {
                // Обновляем поля формы данными из выбранного прямоугольника
                textBoxLength.Text = rectangle.Length.ToString("F2");
                textBoxWidth.Text = rectangle.Width.ToString("F2");
                textBoxColor.Text = rectangle.Colour;
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectangles);
            if (index >= 0 && index < _rectangles.Length)
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

                _currentRectangle.Length = value;
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

                _currentRectangle.Width = value;
                textBoxWidth.BackColor = Color.White;
            }

            catch
            {
                textBoxWidth.BackColor = Color.LightPink;
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
