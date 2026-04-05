using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using EducativeERP.Services.Services;
namespace EducativeERP.Services.EventHandlers
{
    public class CamperAgregadoHandler
    {
        public void Suscribir(CamperService camperService)
        {
            camperService.CamperAgregado += (Camper) => 
                Console.WriteLine($"Camper {Camper.Nombre} Agregado exitosamente");
        }
    }
}