using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;

namespace EducativeERP.Core.Interfaces
{
    public interface ITrainerRepository : IRepository<Trainer>
    {
        Trainer? TraerTrainerPorCC(int CC);
        Trainer?  TraerTrainerPorNombre(string nombre, string apellido);
        IEnumerable<Trainer> TraerTrainersPorEspecialidad(string especialidad);
        IEnumerable<Trainer> TraerTrainersPorHorario(Turno horario);
    }
}