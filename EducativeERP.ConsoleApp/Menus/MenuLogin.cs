using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Core.Interfaces;
using EducativeERP.Data.Repositories;
using EducativeERP.Services.Services;

namespace EducativeERP.ConsoleApp.Menus
{
    public class MenuLogin
    {
        private readonly LoginService _loginService;

        public MenuLogin(LoginService loginService)
        {
            _loginService = loginService;
        }

        public string IniciarSesion()
        {
            Console.WriteLine("***Bienvenido A EducativeERP*** \n\n");
            Console.Write("---Porfavor ingrese su ID: ");
            string idString = Console.ReadLine();
            int ID; 
            int.TryParse(idString, out ID);
            Console.Write("---Porfavor ingrese su Contraseña: ");
            string Contraseña = Console.ReadLine();

            return _loginService.Login(ID,Contraseña);     
        }
    }
}