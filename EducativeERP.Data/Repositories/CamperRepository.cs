using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;

namespace EducativeERP.Data.Repositories
{
    //EducativeERP.Data\JSONS
    public class CamperRepository : BaseRepository<Camper>, ICamperRepository
    {

        public CamperRepository() : base(Path.Combine("EducativeERP","Data","JSONS","Campers.json"))
        {
        }

        public IEnumerable<Camper> TraerPorEstado(EstadoCamper estado)
        {
            return   LeerTodo()
                     .ToList()
                     .Where(x => x.Estado == estado);
        }

        public IEnumerable<Camper> TraerPorRiesgo(NivelRiesgo riesgo)
        {
           return LeerTodo()
                  .ToList()
                  .Where(x => x.NivelRiesgo == riesgo);
        }
    }
}