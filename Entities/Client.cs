using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Client
    {
        [Key]
        public int Id_Cl { get; set; }
        public string Nom_Cl { get; set; }
        public string Adr_Cl { get; set; }
        public string Tel_Cl { get; set; }
        public string Num_CIN { get; set; }
        public virtual ICollection<Location> Location { get; set; }
    }
}
