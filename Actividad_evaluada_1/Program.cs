using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_evaluada_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto de credito");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de cuotas");
            int cuotas = int.Parse(Console.ReadLine());



            Cuotas c1 = new Cuotas();

            c1.monto_solicitado = monto;
            c1.cantidad_cuota = cuotas;
            c1.calcular_todo();

            Console.ReadLine();
        }
    }
}
