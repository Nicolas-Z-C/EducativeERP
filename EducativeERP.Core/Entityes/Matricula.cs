using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Core.Entityes
{
    public class Matricula : BaseEntity
    {
        public Camper Camper {get;set;}
        public Trainer Trainer {get;set;}
        public Ruta Ruta {get;set;}

    }
}