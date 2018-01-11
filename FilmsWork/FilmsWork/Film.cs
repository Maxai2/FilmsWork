using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------
namespace FilmsWork
{
    class Film
    {
        public string Title { get; set; }
        public short Year { get; set; }
        public short Runtime { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public bool Viewed { get; set; }

        public Film(string Title, short Year, short Runtime, string Genre, string Language, string Director, string Description, string Type, bool Viewed)
        {
            this.Title = Title;
            this.Year = Year;
            this.Runtime = Runtime;
            this.Genre = Genre;
            this.Language = Language;
            this.Director = Director;
            this.Description = Description;
            this.Type = Type;
            this.Viewed = Viewed;
        }


    }
}
//-------------------------------------------------