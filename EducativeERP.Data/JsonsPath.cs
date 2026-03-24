using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Data
{
    public static class JsonsPath
    {
        private static readonly string Folder = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..","..","..","..","EducativeERP.Data","JSONS"));
        public static readonly string CamperPath = Path.Combine(Folder, "Campers.json");
        public static readonly string CoordiadorPath = Path.Combine(Folder,"Coordinadores.json");
        public static readonly string EvaluacionPath = Path.Combine(Folder, "Evaluaciones.json");
        public static readonly string MatriculaPath = Path.Combine(Folder, "Matriculas.json");
        public static readonly string RutaPath = Path.Combine(Folder, "Rutas.json");
        public static readonly string SalonPath = Path.Combine(Folder, "Salones.json");
        public static readonly string TrainerPath = Path.Combine(Folder, "Trainers.json");
    }
}