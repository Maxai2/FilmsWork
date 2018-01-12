using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------
namespace FilmsWork
{
    class Functions
    {
        private static Functions instance;

        private Functions()
        { }

        public static Functions getInstance()
        {
            if (instance == null)
                instance = new Functions();
            return instance;
        }

        public bool CancelAdd { get; set; }

        static List<Film> FilmList = new List<Film>();

        public void AddFilm(Film film) => FilmList.Add(film);

        public Film GetFilm(int index) => FilmList[index];

        public int FilmCount() => FilmList.Count;

        public List<Film> GetList() => FilmList;

        public void LoadList()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (var fStream = new FileStream("Films.dat", FileMode.Open))
            {
                List<Film> newFilm = (List<Film>)formatter.Deserialize(fStream);

                FilmList = newFilm;
            }
        }
    }
}
//-------------------------------------------------