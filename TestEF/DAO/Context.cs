using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEF.Models;

namespace TestEF.DAO
{
    public class Context : DbContext
    {
        public Context ()
	    {
            Database.SetInitializer(new DropCreateDatabaseAlways<Context>());           
	    }
        
        public DbSet<Parcour> Parcours { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Figure> Figures { get; set; }
        public DbSet<FigureInSet> FiguresInSet{ get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //}
    }

    
}
