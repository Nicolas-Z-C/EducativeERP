using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Services.Services
{
    public class RutaService
    {
        private readonly IRutaRepository _rutaRepository;
        private readonly TrainerService _trainerService;
        public event Action<Ruta> LiberarTrainer;
        public RutaService(IRutaRepository rutaRepository, TrainerService trainerService, SalonService salonService)
        {
            _rutaRepository = rutaRepository;
            _trainerService = trainerService;
        }

        public void CrearRuta(string nombre, string db, string backend, int Idtrainer, int idsalon, Turno horario)
        {
            
        }

        public void CerrarRuta(int ID)
        {
            
        }
        public Ruta ListarRutaPorTrainer(int idT)
        {
            Ruta ruta = _rutaRepository.ListarTrainerEncargado(idT);
            if (ruta != null)
                return ruta;
            else
                throw new Exception("El trainer no ha sido encontrado");
        }
        public IEnumerable<Ruta> ListarRutaPorSalon(int idT)
        {
            var rutas = _rutaRepository.ListarPorSalon(idT);
            if (rutas != null)
                return rutas;
            else
                throw new Exception("Actualmente no se encuentran rutas asignadas a este salon");
        }
        public IEnumerable<Ruta> ListarRutaPorTurno(Turno turno)
        {
            var rutas = _rutaRepository.ListarPorHorario(turno);
            if (rutas != null)
                return rutas;
            else
                throw new Exception("Actualmente no se encuentran rutas asignadas a este horario");
        }
        
        private bool CheckTrainer(int idT)
        {
            
        }
    }
}