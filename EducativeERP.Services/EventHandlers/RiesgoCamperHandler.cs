using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Services.Services;

namespace EducativeERP.Services.EventHandlers
{
    public class RiesgoCamperHandler
    {
        public void Suscribir(CamperService camperService)
        {
            camperService.CamperCambioRiesgo += (camper) =>
                Console.WriteLine($"El camper {camper.Nombre} ha entrado en riesgo alto");
        }
    }
}