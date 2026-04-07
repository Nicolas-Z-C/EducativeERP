using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;

namespace EducativeERP.Data.Repositories
{
    public class MatriculaRepository : BaseRepository<Matricula>, IMatriculaRepository
    {
        public MatriculaRepository() : base(JsonsPath.MatriculaPath)
        {
        }

        public IEnumerable<Matricula> TraerMatriculasPorRuta(int idRuta)
        {
            return LeerTodo().Where(x => x.IdRuta == idRuta);
        }

        public Matricula? TraerMatriculaCamper(int idCamper)
        {
            return LeerTodo().FirstOrDefault(x => x.IdCamper == idCamper);
        } 

        public int CapacidadActual(int idR)
        {
            return LeerTodo().Where(x => x.IdRuta == idR).Count();
        }
    }
}

