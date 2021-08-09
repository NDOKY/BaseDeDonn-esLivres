using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace BaseDeDonnéesLivres.Models
{
    public class LivreDesire
    {
        public int Id { get; set; }
        [Display(Name = "Titre")]
        public string titre { get; set; }

        [Display(Name = "Année de publication")]
        [DataType(DataType.Date)]
        public DateTime anneePublication { get; set; }
        [Display(Name = "Auteur")]
        public string auteur { get; set; }
        //public IFormFile imageLivre { get; set; }
    }
}
