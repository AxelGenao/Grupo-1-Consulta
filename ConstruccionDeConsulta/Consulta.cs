using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Reflection;

namespace Consulta
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcion;
                Console.Clear();
                Console.WriteLine("Menu de Opciones: ");
                Console.WriteLine("\n" +
                "\n 1. -Seleccionar la tabla Estudiantes" +
                "\n 2. -Salir \n");

            Console.WriteLine("Digite una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("SELECT [Axel],[Genao],[M] From Estudiantes");
                    break;
                
                case 2:
                    break;

            }


        } 
    }    
}
