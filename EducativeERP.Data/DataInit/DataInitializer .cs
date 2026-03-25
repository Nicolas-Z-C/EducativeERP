using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EducativeERP.Data.DataInit
{
    public class DataInitializer 
    {
        private readonly string[] _archivos =
        [
            JsonsPath.CamperPath,
            JsonsPath.CoordiadorPath,
            JsonsPath.EvaluacionPath,
            JsonsPath.MatriculaPath,
            JsonsPath.RutaPath,
            JsonsPath.SalonPath,
            JsonsPath.TrainerPath,
        ];

        public void Inicializar()
        {
            foreach (var archivo in _archivos)
            {
                if (!File.Exists(archivo))
                    File.WriteAllText(archivo, "{}");
            }
        }
    }
}