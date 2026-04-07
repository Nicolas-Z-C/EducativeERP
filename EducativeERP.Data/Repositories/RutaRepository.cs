using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;

namespace EducativeERP.Data.Repositories
{
    public class RutaRepository : BaseRepository<Ruta>, IRutaRepository
    {
        public RutaRepository() : base(JsonsPath.RutaPath)
        {
        }

        public IEnumerable<Ruta> TraerRutaPorBackend(string backend)
        {
            return LeerTodo().Where(x => x.Backend == backend);
        }

        public Ruta ListarTrainerEncargado(int idT)
        {
            return LeerTodo().FirstOrDefault(x => x.IdTrainer == idT);
        }

        public IEnumerable<Ruta> ListarPorSalon(int idS)
        {
            return LeerTodo().Where(x => x.IdSalon == idS);
        }

        public IEnumerable<Ruta> ListarPorHorario(Turno turno)
        {
            return LeerTodo().Where(x => x.Horario == turno);
        }

        public IEnumerable<Ruta> TraerRutaPorBaseDeDatos(string db)
        {
            return LeerTodo().Where(x => x.BaseDeDatos == db);
        }
    }
}