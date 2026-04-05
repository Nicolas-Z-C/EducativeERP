using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Enums;

namespace EducativeERP.Core.Entityes
    {
        public class Evaluacion : BaseEntity
        {
            public int CamperId {get;set;}
            public int RutaId {get;set;}
            public NombreModulo NombreModulo{get;set;}            
            public double NotaTeorica {get;set;} = 0;
            public double NotaPractica {get;set;} = 0;
            public double QuicesTrabajos {get;set;} = 0;
            public double NotaFinal {get;set;}
            public EstadoModulo EstadoModulo {get;set;}
        }
    }