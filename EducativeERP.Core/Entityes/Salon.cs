using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Enums;

namespace EducativeERP.Core.Entityes
{
    public class Salon : BaseEntity
    {
        public string Nombre {get;set;}
        public int Capacidad {get;set;} = 33;
    }
}