using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;

namespace EducativeERP.Core.Interfaces
{
    public interface ISalonRepository : IRepository<Salon>
    {
        Salon? TraerSalonPorNombre(string nombre);
    }
}