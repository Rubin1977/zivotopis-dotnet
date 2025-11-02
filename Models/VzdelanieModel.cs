using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace RastislavRuzbackyMvcOsobnaStranka.Models
{
    public class VzdelanieModel
    {
        public List<Vzdelanie> Vzdelania { get; set; }
        public List<Kurz> Kurzy { get; set; }
        public List<Skusenost> Skusenosti { get; set; }

        public VzdelanieModel()
        {
            Vzdelania = new List<Vzdelanie>();
            Kurzy = new List<Kurz>();
            Skusenosti = new List<Skusenost>();
        }
    }

    public class Vzdelanie
    {
        public string Obdobie { get; set; }
        public string Skola { get; set; }
        public string Fakulta { get; set; }
        public string Titul { get; set; }
        public string Popis { get; set; }
    }

    public class Kurz
    {
        public string Datum { get; set; }
        public string Nazov { get; set; }
    }

    public class Skusenost
    {
        public string Obdobie { get; set; }
        public string Pozicia { get; set; }
        public string Miesto { get; set; }
        public List<string> PopisPrace { get; set; }
    }
}
