using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double BASE, ALTURA, RESUL;
            string linea;
            Console.Write("DIGITE LA BASE :"); linea = Console.ReadLine();
            BASE = double.Parse(linea);
            Console.Write("DIGITE LA ALTURA:"); linea = Console.ReadLine();
            ALTURA = double.Parse(linea);
            RESUL = (BASE * ALTURA) / 2;
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", RESUL));
            Console.WriteLine();
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd}{0:dd/MM/yyy}",
           DateTime.Now));
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
