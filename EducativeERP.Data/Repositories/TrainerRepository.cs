using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;

namespace EducativeERP.Data.Repositories
{
    public class TrainerRepository : BaseRepository<Trainer>, ITrainerRepository
    {
        public TrainerRepository() : base(Path.Combine("EducativeERP.Data","JSONS","Trainers.json"))
        {
        }

        public Trainer? TraerTrainerPorCC(int CC)
        {
            return LeerTodo().FirstOrDefault(x => x.Cc == CC);
        }

        public Trainer?  TraerTrainerPorNombre(string nombreApellido)
        {
            return LeerTodo().FirstOrDefault(x => x.NombreApellido == nombreApellido);
        }
        public IEnumerable<Trainer> TraerTrainersPorEspecialidad(string especialidad)
        {
            return LeerTodo()
                   .Where(x => x.Especialidad == especialidad);
        }

        
        public IEnumerable<Trainer> TraerTrainersPorHorario(Turno horario)
        {
            return LeerTodo()
                   .Where(x => x.Horario == horario);
        }
    }
}