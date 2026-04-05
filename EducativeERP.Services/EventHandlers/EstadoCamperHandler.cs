using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Services.Services;

namespace EducativeERP.Services.EventHandlers
{
    public class EstadoCamperHandler
    {
        public void Suscribir(CamperService camperService)
        {
            camperService.CamperCambioEstado += (camper) =>
                Console.WriteLine($"El camper {camper.Nombre} ha cambiado de estado\nNuevo estado: {camper.Estado}");
        }
    }
}