using G.EntidadesNegocio.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G.AcessoDatos.DAL_;

namespace G.LogicaNegocio.BL
{
    public class PersonaGBL
    {
        public static async Task<PersonaEN> GetById(int id)
        {
            return await PersonaGDAL.GetById(id);
        }
        public static async Task<int> Create(PersonaEN pRole)
        {
            return await PersonaGDAL.Create(pRole);
        }
        public static async Task<int> Update(PersonaEN pRole)
        {
            return await PersonaGDAL.Update(pRole);
        }
        public static async Task<int> Delete(PersonaEN pRole)
        {
            return await PersonaGDAL.Delete(pRole);
        }
        public static async Task<List<PersonaEN>> GetAll()
        {
            return await PersonaGDAL.GetAll();
        }
    }
}
    
