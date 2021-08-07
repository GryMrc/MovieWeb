using Movie.Backend.Models.CREW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Backend.Models.MOV
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public float IMDB { get; set; }
        public string ImageUrl { get; set; }
        public int Duration { get; set; }
        public string Promo { get; set; }
        public string UserComment { get; set; }

    }
}
