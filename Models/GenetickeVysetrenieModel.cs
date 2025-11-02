using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RastislavRuzbackyMojeCVmvc.Models
{
    public class GenetickeVysetrenieModel
    {
        public int Id { get; set; }
        public string Nazov { get; set; }
        public string Vysledok { get; set; }
        public DateTime? DatumVysetrenia { get; set; }

        // Prepojenie na pacienta
        public int PacientModelId { get; set; }
        public virtual PacientModel Pacient { get; set; }
    }
}