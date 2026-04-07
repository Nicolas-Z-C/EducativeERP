using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EducativeERP.Services.Services
{
    public class CamperService 
    {
        //Agregar eventos

        public event Action<Camper>? CamperAgregado;
        public event Action<Camper>? CamperCambioEstado;
        public event Action<Camper>? CamperCambioRiesgo;
        public event Action<Camper>? CamperSuspendido;
        private readonly ICamperRepository _CamperRepository;

        public CamperService(ICamperRepository camperRepository)
        {
            _CamperRepository = camperRepository;
        }

        public void AgregarCamper(string nombre,string apellido, string acudiente, string contrasena, string direccion,  int CC, string numero, int fijo = 0)
        {
            if (!CheckNombres(nombre))
                throw new Exception("El nombre del camper no puede esar vacio");
            if (!CheckNombres(apellido))
                throw new Exception("El nombre del camper no puede esar vacio");
            if (!CheckNombres(acudiente))
                throw new Exception("El nombre del acudiente no puede esar vacio");
            if (!CheckContrasena(contrasena))
                throw new Exception("La contrasena debe contener caracteres especiales (% - *) y mayusculas");
            if (!CheckNumero(numero))
                throw new Exception("Porfavor revise el numero celular del camper");

            Camper camper = new Camper
            {
              Nombre = nombre.ToUpper(),
              Apellido = apellido.ToUpper(),
              NombreAcudiente = acudiente.ToUpper(),
              Contrasena = contrasena,
              Numero = numero,
              Direccion = direccion.ToUpper(),
              Fijo = fijo,
              Estado = EstadoCamper.EnProcesoDeIngreso,
              NivelRiesgo = NivelRiesgo.Bajo,
              Ponderado = 100,
              Cc = CC,  
            };

            _CamperRepository.Agregar(camper);
            CamperAgregado?.Invoke(camper);
        }

        public IEnumerable<Camper> ListarCampers()
        {
            return _CamperRepository.LeerTodo();
        }

        public Camper ListarCampers(int ID)
        {
            Camper? camper = _CamperRepository.BuscarId(ID);
            if (camper == null)
                throw new Exception($"El camper con ID {ID} no existe");
            return camper;
        }

        public Camper ListarCampers(string nombre,string apellido)
        {
            Camper? camper = _CamperRepository.TraerCamperPorNombre(nombre,apellido);
            if (camper == null)
                throw new Exception("No se encontro el camper buscado");
            return camper;
        }

        public void CambiarEstadoCamper(int ID, EstadoCamper NuevoEstado)
        {
            Camper? camper = _CamperRepository.BuscarId(ID);
            if (camper == null)
                throw new Exception("No se encontro el camper buscado");
            camper.Estado = NuevoEstado;
            _CamperRepository.Actualizar(camper);
            if (NuevoEstado == EstadoCamper.Expulsado | NuevoEstado == EstadoCamper.Graduado | NuevoEstado == EstadoCamper.Retirado)
                CamperSuspendido?.Invoke(camper);
            else
                CamperCambioEstado?.Invoke(camper);
        }

        public EstadoCamper TraerEstadoCamper(int ID)
        {
            return _CamperRepository.BuscarId(ID).Estado;
        }
        private bool CheckNombres(string nombre)
        {
            if(string.IsNullOrWhiteSpace(nombre))
                return true;
            else
                return false;
        } 

        private bool CheckContrasena(string contrasena)
        {
            if(Regex.Match(contrasena,@"\d").Success && Regex.Match(contrasena,@"[A-Z]").Success && Regex.Match(contrasena,@"\w").Success)
                return true;
            else
                return false;
        }

        private bool CheckNumero(string numero)
        {
            if(numero.Length > 10 | numero.Length < 10)
                return false;
            else
                return true;
        }
    }
}