using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Services.Services;

namespace EducativeERP.Services.EventHandlers
{
    public class CierreModuloHandler
    {
        private readonly IRutaRepository _rutaRepo;

        public CierreModuloHandler(IRutaRepository rutaRepo)
        {
            _rutaRepo = rutaRepo;
        }
        public void Suscribir(EvaluacionesService service)
        {
            service.CerrarModulos += CierreHandler;
        }

        private void CierreHandler(IEnumerable<Evaluacion> evaluaciones)
        {
            int RutaId = evaluaciones.Select( x => x.RutaId).First();

            NombreModulo modulo = evaluaciones.Select(x => x.NombreModulo).First();

            Ruta? ruta = _rutaRepo.BuscarId(RutaId);

            Console.WriteLine($"La ruta {ruta.Nombre} ha cerrado el modulo {modulo}\nNo se podran hacer mas cambios");
        }
    }
}