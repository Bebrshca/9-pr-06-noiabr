using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    public class Genre
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public static List<Genre> Genres = new List<Genre>
        {
            new Genre { Code = 1, Title = "Фантастика" },
            new Genre { Code = 2, Title = "Детектив" },
            new Genre { Code = 3, Title = "Роман" },
            new Genre { Code = 4, Title = "Приключения" }
        };
        public override string ToString()
        {
            return Title;
        }
    }
}
