using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducativeERP.Services.Services;

namespace EducativeERP.ConsoleApp.Menus
{
    public class MenuEstudiante
    {
        private readonly CamperService _CamperService;

        public MenuEstudiante(CamperService camperService)
        {
            _CamperService = camperService;
        }

        public void Menu()
        {
            ClearHelper.Clear();
            Console.WriteLine("Bienvenido\n");
            Console.WriteLine("Porfavor elije una de las siguientes opciones");
            Console.WriteLine("1. Mirar notas por modulo");
            Console.WriteLine("2. Mirar promedio actual");
            Console.WriteLine("3. Salir del sistema");
        }
    }
}