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
            public double NotaTeorica {get;set;}
            public double NotaPractica {get;set;}
            public double QuicesTrabajos {get;set;}
            public double NotaFinal {get;set;}
        }
    }