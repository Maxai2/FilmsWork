using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------
namespace FilmsWork
{
    [Serializable] 
    class Film
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public int Runtime { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public bool Viewed { get; set; }
        public string PicturePath { get; set; }

        public Film(string Title, int Year, int Runtime, string Genre, string Language, string Director, string Description, bool Viewed, string PicturePath)
        {
            this.Title = Title;
            this.Year = Year;
            this.Runtime = Runtime;
            this.Genre = Genre;
            this.Language = Language;
            this.Director = Director;
            this.Description = Description;
            this.Viewed = Viewed;
            this.PicturePath = PicturePath;
        }
    }
}
//-------------------------------------------------