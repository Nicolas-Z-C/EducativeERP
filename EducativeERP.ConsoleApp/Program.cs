// See https://aka.ms/new-console-template for more information

using EducativeERP.ConsoleApp.Menus;
using EducativeERP.Core.Interfaces;
using EducativeERP.Data.Repositories;
using EducativeERP.Services.Services;

ICamperRepository camperRepo = new CamperRepository();
ITrainerRepository trainerRepo = new TrainerRepository();
ICoordinadorRepository coordinadorRepo = new CoordinadorRepository();

LoginService loginService = new LoginService(camperRepo,trainerRepo,coordinadorRepo);
MenuLogin menuLogin = new MenuLogin(loginService); 

string sesion = menuLogin.IniciarSesion();

switch (sesion)
{
    case "Camper": new MenuEstudiante(); break;
    case "Trainer": new MenuTrainer(); break;
    case "Coordinador": new MenuCoordinacion(); break;
    default: Console.WriteLine(sesion); break;
}
