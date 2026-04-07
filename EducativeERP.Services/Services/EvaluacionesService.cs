using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EducativeERP.Services.Services
{
    public class EvaluacionesService
    {
        public event Action<Evaluacion>? ModificarPromedioCamper;
        public event Action<IEnumerable<Evaluacion>>? CerrarModulos; 
        private readonly IEvaluacionRepository _EvaliacionRepo;

        public EvaluacionesService(IEvaluacionRepository evaluacionRepository)
        {
            _EvaliacionRepo = evaluacionRepository;
        }

        //Metodos generales para uso en eventos 

        internal void Agregar(Evaluacion evaluacion)
        {
            _EvaliacionRepo.Agregar(evaluacion);
        }

        //Metodos Disenados para el coordinador

        public void SubirNotasCamperAdmin(int ID,double[] notas,NombreModulo modulo)
        {
            Evaluacion NotasCamper = _EvaliacionRepo.TraerNotasCamper(ID,modulo);
            NotasCamper.NotaPractica = notas[0];
            NotasCamper.NotaTeorica = notas[1];
            NotasCamper.NotaFinal = NotasCamper.NotaPractica * NotasCamper.NotaTeorica/2;

            _EvaliacionRepo.Actualizar(NotasCamper);
            ModificarPromedioCamper?.Invoke(NotasCamper);
        }

        //Metodos disenados para el trainer
        public void SubirNotasCamperModulo(int ID,double[] notas,NombreModulo modulo)
        {
            Evaluacion NotasCamper = _EvaliacionRepo.TraerNotasCamper(ID,modulo);
            if(!CheckEstadoModulo(NotasCamper))
                throw new Exception("El modulo ya ha sido finalizado no se pueden hacer cambios");
            NotasCamper.NotaPractica = notas[0];
            NotasCamper.NotaTeorica = notas[1];
            NotasCamper.NotaFinal = NotasCamper.NotaPractica * NotasCamper.NotaTeorica/2;

            _EvaliacionRepo.Actualizar(NotasCamper);
            ModificarPromedioCamper?.Invoke(NotasCamper);
        }

        public void CerrarModulo(int ID, NombreModulo modulo)
        {
            var Evaluaciones = _EvaliacionRepo.TraerNotasPorRuta(ID).Where(x => x.NombreModulo == modulo);

            foreach (var evaluacion in Evaluaciones)
            {
                evaluacion.EstadoModulo = EstadoModulo.Terminado;
                _EvaliacionRepo.Actualizar(evaluacion);
            }

            CerrarModulos?.Invoke(Evaluaciones);
        }

        //Metodos del camper

        public IEnumerable<Evaluacion> ListarNotas(int ID)
        {
            return _EvaliacionRepo.TraerNotasCamper(ID);
        }

        private bool CheckEstadoModulo(Evaluacion evaluacion)
        {
            if(evaluacion.EstadoModulo == EstadoModulo.Terminado)
                return false;
            return true;
        }
    }
}