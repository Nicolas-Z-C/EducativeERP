using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Services.Services;

namespace EducativeERP.Services.EventHandlers
{
    public class MatriculaCreadaHandler
    {
        private readonly EvaluacionesService _evaluacionService;

        public MatriculaCreadaHandler(EvaluacionesService evaluacionesService)
        {
            _evaluacionService = evaluacionesService;
        }

        public void Suscribir(MatriculaService matriculaService)
        {
            matriculaService.MatriculaCreada += Handler;
        }

        private void Handler(Matricula matricula)
        {
            NombreModulo[] modulos =
            {
                NombreModulo.Fundamentos,
                NombreModulo.ProgramacionWeb,
                NombreModulo.ProgramacionFormal,
                NombreModulo.BasesDeDatos,
                NombreModulo.Backend,
            };
            
            int camper = matricula.IdCamper;
            int ruta = matricula.IdRuta;

            for (int i = 0; i < 5; i++)
            {
                Evaluacion evaluacion = new Evaluacion
                {
                    CamperId = camper,
                    RutaId = ruta,
                    NombreModulo = modulos[i],
                    EstadoModulo = EstadoModulo.EnCurso,
                };

                _evaluacionService.Agregar(evaluacion);
            }
        }
    }
}