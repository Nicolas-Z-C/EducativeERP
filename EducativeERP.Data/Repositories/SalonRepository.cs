using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;

namespace EducativeERP.Data.Repositories
{
    public class SalonRepository : BaseRepository<Salon>, ISalonRepository
    {
        public SalonRepository() : base(JsonsPath.SalonPath)
        {
        }
        public Salon? TraerSalonPorNombre(string nombre)
        {
            return LeerTodo().FirstOrDefault(x => x.Nombre == nombre);
        }
    }
}