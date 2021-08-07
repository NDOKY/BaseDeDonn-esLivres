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
        [Display(Name = "Titre")]
        public string titre { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime anneePublication { get; set; }
        [Display(Name = "Auteur")]
        public string auteur { get; set; }
        public decimal prix { get; set; }
    }
}
