using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Core.Entityes
{
    public abstract class Persona : BaseEntity
    {
        public int Cc {get;set;}

        public string NombreApellido {get;set;}

        public int Numero {get;set;}

        public string Contrasena {get;set;}
    }
}