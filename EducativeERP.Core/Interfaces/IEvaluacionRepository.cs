using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;

namespace EducativeERP.Core.Interfaces
{
    public interface IEvaluacionRepository : IRepository<Evaluacion>
    {
        IEnumerable<Evaluacion> TraerNotasCamper(int IdCamper);
        Evaluacion TraerNotasCamper(int IdCamper, NombreModulo modulo);
        IEnumerable<Evaluacion> TraerNotasPorRuta(int IdRuta);
    }
}