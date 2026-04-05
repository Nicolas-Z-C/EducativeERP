using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Services.Services;

namespace EducativeERP.Services.EventHandlers
{
    public class PromedioHandler
    {
        private readonly ICamperRepository _camperRepo;

        public PromedioHandler(ICamperRepository camperRepo)
        {
            _camperRepo = camperRepo;
        }
        public void Suscribir(EvaluacionesService service)
        {
            service.ModificarPromedioCamper += Handler;
        } 

        private void Handler(Evaluacion evaluacion)
        {
            Camper camper = _camperRepo.BuscarId(evaluacion.CamperId);
            camper.Ponderado += evaluacion.NotaFinal * 0.20;
        }
    }
}