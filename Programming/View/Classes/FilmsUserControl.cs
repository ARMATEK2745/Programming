using Programming.Model;
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
    public partial class FilmsUserControl : UserControl
    {
        private Film[] _films;
        private Film _currentFilm;

        public FilmsUserControl()
        {
            InitializeComponent();
            Random random = new Random();
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
