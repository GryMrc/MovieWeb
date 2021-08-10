using Mov.DataModels.Crew;
using Mov.DataModels.Movies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mov.DataModels.User
{
    public class User
    {
        [Column("USERID")]
        public int Id { get; set; }
        [Column("USER_NAME")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Column("PRIVILEGE")]
        public int PrivilegeId { get; set; }
        public Privilege Privilege { get; set; }
        public List<Director> Directors { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
