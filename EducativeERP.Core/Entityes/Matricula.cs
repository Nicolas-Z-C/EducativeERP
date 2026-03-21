using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Enums;

namespace EducativeERP.Core.Entityes
{
    public class Matricula : BaseEntity
    {
        required public int IdCamper  {get;set;}
        required public int IdTrainer {get;set;}
        required public int IdRuta {get;set;}
        required public int IdSalon {get;set;} 
        required public Turno Horario {get;set;}
        required public DateTime FechaInicio {get;set;}
        required public DateTime FechaFinal {get;set;}

    }
}