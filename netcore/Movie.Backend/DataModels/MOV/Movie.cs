using DataModels.CREW;
using Movie.DataModels.USR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataModels.MOV
{
    public class Movie
    {
        [Column("MOVIEID")]
        public int Id { get; set; }
        [Column("MOVIE_NAME")]
        public string Name { get; set; }
        [Column("DIRECTOR")]
        public int DirectorId { get; set; }
        public float IMDB { get; set; }
        public int Duration { get; set; }
        [Column("CREATE_DT")]
        public DateTime CreateDate { get; set; }
        [Column("UPDATE_DT")]
        public DateTime UpdateDate { get; set; }
        [Column("RELEASE_DT")]
        public DateTime ReleaseDate { get; set; }
        public string Promo { get; set; }
        public Director Director { get; set; }
        public string ImageUrl { get; set; }
        [Column("USER")]
        public int UserId { get; set; }
        public User User { get; set; }
        public string UserComment { get; set; }
    }
}
