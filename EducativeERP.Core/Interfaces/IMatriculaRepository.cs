using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;

namespace EducativeERP.Core.Interfaces
{
    public interface IMatriculaRepository : IRepository<Matricula>
    {
        IEnumerable<Matricula> TraerMatriculasPorRuta(int idRuta);
        Matricula? TraerMatriculaCamper(int idCamper);
    }
}