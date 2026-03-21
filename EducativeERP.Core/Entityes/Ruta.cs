using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Core.Entityes
{
    public class Ruta : BaseEntity
    {
        public string Nombre {get;set;}
        public string BaseDeDatos {get;set;}
        public string Backend {get;set;}
    }
}