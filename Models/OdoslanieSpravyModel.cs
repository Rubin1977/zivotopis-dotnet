using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RastislavRuzbackyMvcOsobnaStranka.Models
{
    public class OdoslanieSpravyModel
    {
        [Required(ErrorMessage = "Priezvisko a meno musí byť zadané!")]
        [Display(Name = "Priezvisko a meno")]
        public string Meno { get; set; }

        [Required(ErrorMessage = "Email musí byť zadaný!")]
        [Display(Name = "Email")]
        [Email(ErrorMessage = "Nezadali ste platnú mailovú adresu!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefón musí byť zadaný!")]
        [Display(Name = "Telefón")]
        [Number(ErrorMessage = "Zadajte platné telefónne číslo.")]
        public string Telefon { get; set; }


        [Required(ErrorMessage = "Text správy musí byť zadaný!")]
        [Display(Name = "Text správy")]
        public string Sprava { get; set; }
    }
}