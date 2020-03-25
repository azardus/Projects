using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HelloWord.Models
{
    // Point d'entee du a heritage DbContext du System.Data.Entity

    public class BddContext : DbContext 
    {
        public DbSet<Sondage> Sondages { get; set; }
        public DbSet<Resto> Restos { get; set; }

    }
}