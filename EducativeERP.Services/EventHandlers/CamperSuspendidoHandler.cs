using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Services.Services;

namespace EducativeERP.Services.EventHandlers
{
    public class CamperSuspendidoHandler
    {
        private readonly MatriculaService _matriculaService;

        public CamperSuspendidoHandler(MatriculaService matriculaService)
        {
            _matriculaService = matriculaService;
        }
        public void Suscribir(CamperService camperService)
        {
            camperService.CamperSuspendido += EliminarMatricula;
        }

        private void EliminarMatricula(Camper camper)
        {
            _matriculaService.EliminarMatricula(camper.Id);
        }
    }
}