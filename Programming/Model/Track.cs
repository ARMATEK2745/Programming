using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о музыке
    /// </summary>
    internal class Track
    {
        private string title = "";  //Название песни
        private string artist = ""; //Автор
        private string genre = "";  //Жанр

        /// <summary>
        /// Хранит информацию о названии песни
        /// </summary>
        public string Title { get { return title; } set { title = value; } }

        /// <summary>
        /// Хранит информацию об авторе
        /// </summary>
        public string Artist { get { return artist; } set { artist = value; } }

        /// <summary>
        /// Хранит информацию о жанр
        /// </summary>
        public string Genre { get { return genre; } set { genre = value; } }

        public Track(string title, string artist, string genre)
        {
            this.Title = title;
            this.Artist = artist;
            this.Genre = genre;
        }

        public Track() { }
    }
}
