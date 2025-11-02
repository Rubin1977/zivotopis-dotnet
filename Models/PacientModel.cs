using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RastislavRuzbackyMojeCVmvc.Models
{
    public class PacientModel
    {
        public int Id { get; set; }
        public string Meno { get; set; }
        public DateTime DatumNarodenia { get; set; }
        public string Pohlavie { get; set; }
        public string RodneCislo { get; set; }

        // Diagnózy pacienta
        public virtual ICollection<DiagnozaModel> Diagnozy { get; set; }

        // Pripravené na budúce rozšírenie
        public virtual ICollection<PriznakModel> Priznaky { get; set; }
        public virtual ICollection<GenetickeVysetrenieModel> GenetickeVysetrenia { get; set; }

        public PacientModel()
        {
            Diagnozy = new List<DiagnozaModel>();
            Priznaky = new List<PriznakModel>();
            GenetickeVysetrenia = new List<GenetickeVysetrenieModel>();
        }

    }
}