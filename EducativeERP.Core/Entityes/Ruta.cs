using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Core.Entityes
{
    public class Ruta : BaseEntity
    {
        public string Fundamentos {get;set;}
        public string Web {get;set;}
        public string Formal {get;set;}
        public string Datos {get;set;}
        public string Backend {get;set;}
    }
}