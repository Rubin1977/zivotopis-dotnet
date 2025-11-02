using RastislavRuzbackyMojeCVmvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RastislavRuzbackyMojeCVmvc.Data
{
    public class AplikaciaDbContext : DbContext
    {
        public DbSet<PacientModel> Pacienti { get; set; }
        public DbSet<PriznakModel> Priznaky { get; set; }
        public DbSet<GenetickeVysetrenieModel> Vysetrenia { get; set; }

        public AplikaciaDbContext() : base("DefaultConnection") { }
    }
}