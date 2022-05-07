using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;

namespace DataAccess.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-OTAOT39G;Database=HamburgerSiparisDB;Trusted_Connection=True;";

        }
        public DbSet<HamburgerMenu> HamburgerMenuler { get; set; }

        public DbSet<Ekstra> Ekstralar { get; set; }

        public DbSet<Siparis> Siparisler { get; set; }
    }
}
