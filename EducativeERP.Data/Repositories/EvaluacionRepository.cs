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
        public EvaluacionRepository() : base(Path.Combine("EducativeERP.Data","JSONS","Evaluaciones.json"))
        {
        }

        public IEnumerable<Evaluacion> TraerNotasCamper(int IdCamper)
        {
            return LeerTodo().Where(x => x.CamperId == IdCamper);
        }
    }
}