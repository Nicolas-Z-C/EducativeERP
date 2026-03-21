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
        public MatriculaRepository() : base(Path.Combine("EducativeERP.Data","JSONS","Matriculas.json"))
        {
        }

        public IEnumerable<Matricula> TraerMatriculasPorRuta(int idRuta)
        {
            return LeerTodo().Where(x => x.IdRuta == idRuta);
        }

        
        public IEnumerable<Matricula> TraerMatriculasPorTrainer(int idTrainer)
        {
            return LeerTodo().Where(x => x.IdTrainer == idTrainer);
        }

        public IEnumerable<Matricula> TraerMatriculasPorSalon(int idSalon)
        {
            return LeerTodo().Where(x => x.IdSalon == idSalon);
        }

        public Matricula? TraerMatriculaCamper(int idCamper)
        {
            return LeerTodo().FirstOrDefault(x => x.IdCamper == idCamper);
        } 

        public IEnumerable<Matricula> TraerMatriculasPorHorario(Turno horario)
        {
            return LeerTodo().Where(x => x.Horario == horario);
        }

        public int CapacidadSalonPorTurno(int idSalon, Turno horario)
        {
            var db = LeerTodo().Where(x => x.IdSalon == idSalon && x.Horario == horario);
            return db.Count();
        }
    }
}

