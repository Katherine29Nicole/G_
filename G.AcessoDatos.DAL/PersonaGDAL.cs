using G.EntidadesNegocio.EN;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.AcessoDatos.DAL_
{
    public class PersonaGDAL
    {
        public static async Task<PersonaEN> GetById(int id)
        {
            var role = new PersonaEN();
            using (var dbContext = new ComunDB())
            {
                role = await dbContext.GPersona.FirstOrDefaultAsync(s => s.Id == id);
            }
            return role;
        }
        public static async Task<int> Create(PersonaEN pRole)
        {
            int result = 0;
            using (var bdContext = new ComunDB())
            {
                bdContext.Add(pRole);
                result = await bdContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Update(PersonaEN pRole)
        {
            int result = 0;
            using (var dbContext = new ComunDB())
            {
                var role = await  dbContext.GPersona.FirstOrDefaultAsync(r => r.Id == pRole.Id);
                role.NombreG = pRole.NombreG;
                role.ApellidoG= pRole.ApellidoG;
                role.FechaNacimientoG=pRole.FechaNacimientoG;
                role.SueldoG= pRole.SueldoG;
                role.EstatusG= pRole.EstatusG;
                dbContext.Update(role);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<int> Delete(PersonaEN personaEN)
        {
            int result = 0;
            using(var dbContext = new ComunDB())
            {
                
                dbContext.Remove(personaEN);
                result = await dbContext.SaveChangesAsync();
            }
            return result;
        }
        public static async Task<List<PersonaEN>> GetAll()
        {
            var roles = new List<PersonaEN>();
            using(var dbContext = new ComunDB())
            {
                roles = await dbContext.GPersona.ToListAsync();
            }
            return roles;
        }
    }
}
