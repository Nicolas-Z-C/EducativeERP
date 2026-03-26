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
            Console.WriteLine(@"+------------------------------------------------------------------------------------+
| /$$$$$$$$       /$$                                 /$$     /$$                    |
|| $$_____/      | $$                                | $$    |__/                    |
|| $$        /$$$$$$$ /$$   /$$  /$$$$$$$  /$$$$$$  /$$$$$$   /$$ /$$    /$$ /$$$$$$ |
|| $$$$$    /$$__  $$| $$  | $$ /$$_____/ |____  $$|_  $$_/  | $$|  $$  /$$//$$__  $$|
|| $$__/   | $$  | $$| $$  | $$| $$        /$$$$$$$  | $$    | $$ \  $$/$$/| $$$$$$$$|
|| $$      | $$  | $$| $$  | $$| $$       /$$__  $$  | $$ /$$| $$  \  $$$/ | $$_____/|
|| $$$$$$$$|  $$$$$$$|  $$$$$$/|  $$$$$$$|  $$$$$$$  |  $$$$/| $$   \  $/  |  $$$$$$$|
||________/ \_______/ \______/  \_______/ \_______/   \___/  |__/    \_/    \_______/|
| /$$$$$$$$ /$$$$$$$  /$$$$$$$                                                       |
|| $$_____/| $$__  $$| $$__  $$                                                      |
|| $$      | $$  \ $$| $$  \ $$                                                      |
|| $$$$$   | $$$$$$$/| $$$$$$$/                                                      |
|| $$__/   | $$__  $$| $$____/                                                       |
|| $$      | $$  \ $$| $$                                                            |
|| $$$$$$$$| $$  | $$| $$                                                            |
||________/|__/  |__/|__/                                                            |
+------------------------------------------------------------------------------------+");
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