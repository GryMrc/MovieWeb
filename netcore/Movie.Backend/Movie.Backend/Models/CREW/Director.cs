using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Backend.Models.CREW
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Nation { get; set; }
        public List<Models.MOV.Movie> Movies { get; set; }
    }
}
