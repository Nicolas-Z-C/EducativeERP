using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EducativeERP.Core.Interfaces;
using Microsoft.VisualBasic;

namespace EducativeERP.Services.Services
{
    public class LoginService
    {
        private readonly ICamperRepository _camperRepo;
        private readonly ITrainerRepository _trainerRepo;
        private readonly ICoordinadorRepository _coordinadorRepo;

        public LoginService(ICamperRepository camperRepo,
                            ITrainerRepository trainerRepo,
                            ICoordinadorRepository coordinadorRepo)
        {
            _camperRepo = camperRepo;
            _trainerRepo = trainerRepo;
            _coordinadorRepo = coordinadorRepo;
        } 

        public string Login(int id, string contrasena)
        { 
            var camper = _camperRepo.BuscarId(id);
            if (camper != null && camper.Contrasena == contrasena)
                return "Camper";

            var trainer = _trainerRepo.BuscarId(id);
            if (trainer != null && trainer.Contrasena == contrasena)
                return "Trainer";

            var coordinador = _coordinadorRepo.BuscarId(id);
            if (coordinador != null && coordinador.Contrasena == contrasena)
                return "Coordinador";

            return "Usuario o contraseña incorrectos\n Revisa los valores ingresados";
        }
    }
}