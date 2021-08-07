using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BaseDeDonnéesLivres.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string titre { get; set; }

        [DataType(DataType.Date)]
        public DateTime anneePublication { get; set; }
        public string auteur { get; set; }
        public decimal prix { get; set; }
    }
}
