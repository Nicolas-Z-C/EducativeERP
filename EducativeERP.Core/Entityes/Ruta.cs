using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Enums;

namespace EducativeERP.Core.Entityes
{
    public class Ruta : BaseEntity
    {
        public string? Nombre {get;set;}
        public string? BaseDeDatos {get;set;}
        public string? Backend {get;set;}
        public int IdTrainer {get;set;}
        required public int IdSalon {get;set;} 
        required public Turno Horario {get;set;}
        required public DateTime FechaInicio {get;set;}
        required public DateTime FechaFinal {get;set;}
    }
}