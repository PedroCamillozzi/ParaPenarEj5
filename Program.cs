using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPenarEj5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes;
            string nomMes;
            Console.WriteLine("Ingrese Un Nombre de Mes");
            nomMes = Console.ReadLine();
            mes = ConvierteNombreANumeroMes(nomMes);
            Console.WriteLine(nomMes + " " + mes);
            Console.ReadKey();
        }

        static int ConvierteNombreANumeroMes(string nombreMes)
        {
            int numMes=0;
            switch (nombreMes) { 
                case "Enero" :  numMes = 1; break;
                case "Febrero": numMes = 2; break;
                case "Marzo": numMes= 3; break;
                case "Abril": numMes = 4; break;
                case "Mayo": numMes= 5; break;
                case "Junio": numMes = 6; break;
                case "Julio": numMes = 7; break;
                case "Agosto": numMes = 8; break;
                case "Septiembre": numMes = 9; break;
                case "Octubre": numMes = 10; break;
                case "Noviembre": numMes = 11; break;
                case "Diciembre": numMes = 12; break;
                default: Console.WriteLine("No escribió un mes"); break;
                     }
            return numMes;
        }

    }
}
