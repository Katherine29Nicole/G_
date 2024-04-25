using G.EntidadesNegocio.EN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.AcessoDatos.DAL_
{
    public class ComunDB : DbContext
    {
        public DbSet<PersonaEN> GPersona {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Nicole2005\\SQLEXPRESS;Initial Catalog=GDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
