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
        IEnumerable<Matricula> TraerMatriculasPorTrainer(int idTrainer);
        IEnumerable<Matricula> TraerMatriculasPorSalon(int idSalon);
        Matricula? TraerMatriculaCamper(int idCamper);
        IEnumerable<Matricula> TraerMatriculasPorHorario(Turno horario);
        int CapacidadSalonPorTurno(int idSalon, Turno horario);
    }
}