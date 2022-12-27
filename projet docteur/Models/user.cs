using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace projet_docteur.Models
{
    public class user
    {

        public int id { get; set; }

        [StringLength(200)]

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public string nom { get; set; }

        [StringLength(200)]

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public string mail { get; set; }

        [StringLength(200)]

        [Required(ErrorMessage = "Ce champs est obligatoire")]
        public string pass { get; set; }


        public user(int id,string  Nom,string  Email,string  Password)
        {
            this.id = id;
            this.nom = Nom;
            this.mail=Email;
            this.pass = Password;
        }

        public user()
        {
        }

    }



}