namespace RastislavRuzbackyMojeCVmvc.Migrations
{
    using RastislavRuzbackyMojeCVmvc.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RastislavRuzbackyMojeCVmvc.Data.AplikaciaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RastislavRuzbackyMojeCVmvc.Data.AplikaciaDbContext";
        }

        protected override void Seed(RastislavRuzbackyMojeCVmvc.Data.AplikaciaDbContext context)
        {
            System.Diagnostics.Debug.WriteLine(">>> Seed sa spustil!");

            var pacient = new PacientModel
            {
                Meno = "Ján Novák",
                DatumNarodenia = new DateTime(1980, 1, 1),
                Pohlavie = "Muž",
                RodneCislo = "800512/1234",
                Priznaky = new List<PriznakModel>
                {
                    new PriznakModel { Nazov = "Šikmé očné štrbiny" },
                    new PriznakModel { Nazov = "Plochý vzhľad tváre" },
                    new PriznakModel { Nazov = "Krátky krk" },
                },
                GenetickeVysetrenia = new List<GenetickeVysetrenieModel>
                {
                    new GenetickeVysetrenieModel
                    {
                        Nazov = "Karyotyp",
                        Vysledok = "47,XY,+21",
                    }
                },
                Diagnozy = new List<DiagnozaModel>
                {
                    new DiagnozaModel
                    {
                        Nazov = "Downov syndróm",
                        Popis = "47,XY,+21",
                    }
                }
            };

            context.Pacienti.Add(pacient);
            context.SaveChanges();

            System.Diagnostics.Debug.WriteLine("Počet pacientov v DB: " + context.Pacienti.Count());
        }
    }
}
