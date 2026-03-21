using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Core.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T>LeerTodo();
        T? BuscarId(int id);
        void Agregar(T entity);
        void Actualizar(T entity);
        void Eliminar(int id);
    }
}