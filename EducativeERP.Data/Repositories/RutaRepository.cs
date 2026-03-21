using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;

namespace EducativeERP.Data.Repositories
{
    public class RutaRepository : BaseRepository<Ruta>, IRutaRepository
    {
        public RutaRepository() : base(Path.Combine("EducativeERP.Data","JSONS","Rutas.json"))
        {
        }

        public IEnumerable<Ruta> TraerRutaPorBackend(string backend)
        {
            return LeerTodo().Where(x => x.Backend == backend);
        }

        public IEnumerable<Ruta> TraerRutaPorBaseDeDatos(string db)
        {
            return LeerTodo().Where(x => x.BaseDeDatos == db);
        }
    }
}