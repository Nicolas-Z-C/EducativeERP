using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;

namespace EducativeERP.Core.Interfaces
{
    public interface IRutaRepository : IRepository<Ruta>
    {
        IEnumerable<Ruta> TraerRutaPorBackend(string backend);
        IEnumerable<Ruta> TraerRutaPorBasedeDatos(string db);
    }
}