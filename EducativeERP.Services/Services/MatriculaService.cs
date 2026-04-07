using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducativeERP.Services.Services
{
    public class MatriculaService
    {
        public event Action<Matricula>? MatriculaCreada;

        private readonly CamperService _camperService;
        private readonly IMatriculaRepository _matriculaRepo;

        public MatriculaService(IMatriculaRepository matriculaRepository, CamperService camperService)
        {
            _matriculaRepo = matriculaRepository;
            _camperService = camperService;
        }

        public void CrearMatricula(int idCamper, int idRuta)
        {
            if(!CheckCamper(idCamper))
                throw new Exception("El camper no esta disponible para ser agregado a la ruta");            

            Matricula matricula = new Matricula
            {
                IdCamper = idCamper,
                IdRuta = idRuta,
            };

            _matriculaRepo.Agregar(matricula);
            MatriculaCreada?.Invoke(matricula);
        }

        internal void EliminarMatricula(int id)
        {
            Matricula? matricula = _matriculaRepo.TraerMatriculaCamper(id);
            _matriculaRepo.Eliminar(matricula.Id);
        }

        private bool CheckCamper(int id)
        {
            EstadoCamper estado = _camperService.TraerEstadoCamper(id);
            if (estado == EstadoCamper.Aprobado)
                return true;
            else
                return false;
        }

        public Matricula ListarMatriculaporCamper(int id)
        {
            return _matriculaRepo.TraerMatriculaCamper(id);
        }
        public IEnumerable<Matricula> ListarMatriculasPorRuta(int id)
        {
            return _matriculaRepo.TraerMatriculasPorRuta(id);
        }
    }
}