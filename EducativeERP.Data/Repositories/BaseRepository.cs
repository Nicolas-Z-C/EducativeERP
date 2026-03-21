using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EducativeERP.Core.Entityes;

namespace EducativeERP.Data.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    { 
        private readonly string _filepath;

        private readonly JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true,
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };

        protected BaseRepository(string filepath)
        {
            _filepath = filepath;
        }

        public IEnumerable<T> LeerTodo()
        {
            if (!File.Exists(_filepath)) return new List<T>(); //chequear si existe el archivo
            var json = File.ReadAllText(_filepath);
            return JsonSerializer.Deserialize<List<T>>(json, options) ?? new List<T>();
        }

        public T? BuscarId(int id)
        {
            return LeerTodo().FirstOrDefault(e => e.Id == id);
        }

        public void Agregar(T entity)
        {
            var db = LeerTodo().ToList();
            entity.Id = db.Any() ? db.Max(x => x.Id) + 1 : 1;
            db.Add(entity); 
            Guardar(db);
        }

        public void Actualizar(T entity)
        {
            var db = LeerTodo().ToList();
            var idx = db.FindIndex(x => x.Id == entity.Id);
            if (idx != -1) db[idx] = entity;
            Guardar(db);
        }

        public void Eliminar(T entity)
        {
            var db = LeerTodo().Where(x => x.Id != entity.Id);
            Guardar(db.ToList());
        }

        private void Guardar(List<T> db)
        {
            File.WriteAllText(_filepath, System.Text.Json.JsonSerializer.Serialize(db, options));
        }
    }
}