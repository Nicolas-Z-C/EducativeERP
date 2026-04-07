using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;
using EducativeERP.Core.Enums;

namespace EducativeERP.Core.Interfaces
{
    public interface IRutaRepository : IRepository<Ruta>
    {
        IEnumerable<Ruta> TraerRutaPorBackend(string backend);
        IEnumerable<Ruta> TraerRutaPorBaseDeDatos(string db);
        Ruta ListarTrainerEncargado(int idT);
        IEnumerable<Ruta> ListarPorSalon(int idS);
        IEnumerable<Ruta> ListarPorHorario(Turno turno);

    }
}