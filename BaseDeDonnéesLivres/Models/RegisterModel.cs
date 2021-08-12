using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseDeDonnéesLivres.Models
{
    public class RegisterModel: IdentityUser
    {
        //[PersonalData]
        //[Column(TypeName ="nvchar(100)")]
        //public string FirstName { get; set; }

        //[PersonalData]
        //[Column(TypeName = "nvchar(100)")]
        //public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirmer mot de passe")]
        [Compare("Password", ErrorMessage ="Mot de passe n'est pas identique")]
        public string ConfirmPassword { get; set; }
    }

}
