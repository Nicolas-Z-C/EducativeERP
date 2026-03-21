using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Enums;

namespace EducativeERP.Core.Entityes
{
    public class Trainer : Persona
    {
        public Turno Horario {get;set;}
        public string Especialidad {get;set;}
    }
}