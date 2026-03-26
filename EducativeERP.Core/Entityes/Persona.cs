using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Core.Entityes
{
    public abstract class Persona : BaseEntity
    {
        public int Cc {get;set;}

        public string Nombre {get;set;}
        public string Apellido {get;set;}

        public string Numero {get;set;}

        public string Contrasena {get;set;}
    }
}