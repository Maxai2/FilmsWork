using System;
using System.Collections.Generic;
using System.Linq;
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

        static List<Film> FilmList = new List<Film>();

        public void AddFilm(Film film)
        {
            FilmList.Add(film);
        }
    }
}
//-------------------------------------------------