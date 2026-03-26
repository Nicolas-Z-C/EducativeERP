using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;
using EducativeERP.Data;
namespace EducativeERP.Data.Repositories
{
    //EducativeERP.Data\JSONS
    public class CamperRepository : BaseRepository<Camper>, ICamperRepository
    {

        public CamperRepository() : base(JsonsPath.CamperPath)
        {
        }

        public Camper? TraerCamperPorCC(int CC)
        {
            return LeerTodo().FirstOrDefault(x => x.Cc == CC);
        }

        public Camper? TraerCamperPorNombre(string nombre, string apellido)
        {
            return LeerTodo().FirstOrDefault(x => x.Nombre == nombre && x.Apellido == apellido);
        }

        public IEnumerable<Camper> TraerPorEstado(EstadoCamper estado)
        {
            return   LeerTodo().Where(x => x.Estado == estado);
        }

        public IEnumerable<Camper> TraerPorRiesgo(NivelRiesgo riesgo)
        {
           return LeerTodo().Where(x => x.NivelRiesgo == riesgo);
        }
    }
}