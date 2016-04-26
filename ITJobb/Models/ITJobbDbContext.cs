using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITJobb.Models
{
    public class ITJobbDbContext : DbContext
    {
        public ITJobbDbContext() : base("name=ITJobbDBContextConnectionString")
        {
        }
        public DbSet<Annons> Annonses { get; set; }
        public DbSet<Anvandare> Anvandares { get; set; }
        public DbSet<ForetagsAnnons> ForetagsAnnonses { get; set; }
        public DbSet<Malsida> Malsidas { get; set; }
        public DbSet<Ort> Orts { get; set; }
        public DbSet<PersonAnnons> PersonAnnonses { get; set; }
        public DbSet<Rekryterare> Rekryterares { get; set; }
        public DbSet<Tag> Tages { get; set; }
        public DbSet<YrkesTitel> Yrkestitels { get; set; }

    }
}