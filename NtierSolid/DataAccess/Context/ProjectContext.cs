using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-OTAOT39G;Database=NtierSolid;Trusted_Connection=True;";
        }

        DbSet<Product> Products { get; set; }
        DbSet<Category> Category { get; set; }

        DbSet<AppUser> AppUsers { get; set; }
    }
}
