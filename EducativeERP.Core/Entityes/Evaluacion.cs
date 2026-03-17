using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Core.Entityes
{
    public class Evaluacion : BaseEntity
    {
        public double notaTeorica {get;set;}
        public double notaPractica {get;set;}
        public double quicesTrabajos {get;set;}
        public double notaFinal {get;set;}
    }
}