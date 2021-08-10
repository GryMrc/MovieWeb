using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mov.DataModels.User
{
    public class Privilege
    {
        [Column("PRIVILEGEID")]
        public int Id { get; set; }
        public string Role { get; set; }
    }
}
