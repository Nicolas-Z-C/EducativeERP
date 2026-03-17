using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Core.Entityes
{
    public class Evaluacion : BaseEntity
    {
        public double NotaTeorica {get;set;}
        public double NotaPractica {get;set;}
        public double QuicesTrabajos {get;set;}
        public double NotaFinal {get;set;}
    }
}