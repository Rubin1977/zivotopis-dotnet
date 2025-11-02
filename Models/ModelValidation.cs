using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RastislavRuzbackyMvcOsobnaStranka.Models
{
    public class NumberAttribute : RegularExpressionAttribute
    {
        public NumberAttribute()
            // Povolené: voliteľné +, čísla, voliteľné medzery medzi blokmi
            : base(@"^\+?[0-9\s]{9,15}$")
        {
        }
    }

    public class EmailAttribute : RegularExpressionAttribute
    {
        public EmailAttribute()
            : base("^[a-zA-Z0-9_\\+-]+(\\.[a-zA-Z0-9_\\+-]+)*@[a-zA-Z0-9-]+(\\.[a-zA-Z0-9-]+)*\\.([a-zA-Z]{2,4})$")
        {
        }
    }

}