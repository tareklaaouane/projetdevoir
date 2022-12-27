using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projet_docteur.Models
{
    public class docteur
    {

        public int id { get; set; }

        [StringLength(200)]

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public string nom { get; set; }

        [StringLength(200)]

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public string spec { get; set; }

        [StringLength(200)] 

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public string addres { get; set; }

        [StringLength(200)]

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public string telephone { get; set; }

        public bool dispo { get; set; }

    }
}