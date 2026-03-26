using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;

namespace EducativeERP.Core.Interfaces
{
    public interface ICamperRepository : IRepository<Camper> 
    {
        Camper? TraerCamperPorCC(int CC);
        Camper? TraerCamperPorNombre(string nombre,string apellido);
        IEnumerable<Camper> TraerPorEstado(EstadoCamper estado);
        IEnumerable<Camper> TraerPorRiesgo(NivelRiesgo riesgo);
    }
}