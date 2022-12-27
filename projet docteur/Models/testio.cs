using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projet_docteur.Models
{
    public class testio
    {
        [Required(ErrorMessage = "Ce champs est obligatoire")]
        [StringLength(100, MinimumLength = 7)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public string Password { get; set; }
    }
}