using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;

namespace EducativeERP.Data.Repositories
{
    public class CoordinadorRepository : BaseRepository<Coordiador>, ICoordinadorRepository
    {
        public CoordinadorRepository() : base(Path.Combine("EducativeERP.Data","JSONS","Coordinador.json"))
        {
        }
    }
}