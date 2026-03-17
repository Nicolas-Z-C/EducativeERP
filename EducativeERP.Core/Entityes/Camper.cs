using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Enums;


namespace EducativeERP.Core.Entityes
{
    public class Camper : Persona
    {
        public string Direccion {get;set;}
        public int Fijo {get;set;}
        public EstadoCamper Estado {get;set;}
        public NivelRiesgo NivelRiesgo {get;set;}
    }
}