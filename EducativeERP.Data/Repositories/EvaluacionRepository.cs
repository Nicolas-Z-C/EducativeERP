using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;
namespace EducativeERP.Data.Repositories
{
    public class EvaluacionRepository : BaseRepository<Evaluacion>, IEvaluacionRepository
    {
        public EvaluacionRepository() : base(JsonsPath.EvaluacionPath)
        {
        }

        public IEnumerable<Evaluacion> TraerNotasCamper(int IdCamper)
        {
            return LeerTodo().Where(x => x.CamperId == IdCamper);
        }

        public Evaluacion TraerNotasCamper(int IDCamper, NombreModulo modulo)
        {
            return TraerNotasCamper(IDCamper).FirstOrDefault(x => x.NombreModulo == modulo);
        }

        public IEnumerable<Evaluacion> TraerNotasPorRuta(int IdRuta)
        {
            return LeerTodo().Where(x => x.RutaId == IdRuta);
        }
    
    }
}