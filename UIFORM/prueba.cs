using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFORM
{
    class prueba
    {
        public double monto_solicitado;
        public double monto_total;
        public double valor_cuota;
        public int cantidad_cuota;
        public string nombre;
        public string apellido;
        public double interes;

        public void calulcar_valor_cuota()
        {
            if (monto_solicitado >= 500000)
            {
                if (cantidad_cuota >= 1 && cantidad_cuota <= 36)
                {
                    if (cantidad_cuota <= 12)
                    {
                        interes = 10 * monto_solicitado;
                        interes /= 100;
                        valor_cuota = monto_solicitado + interes;
                        valor_cuota /= cantidad_cuota;
                        Console.WriteLine("El valor cuota es: " + valor_cuota + " por " + cantidad_cuota + " cuotas");
                    }
                    else if (cantidad_cuota > 12 && cantidad_cuota <= 24)
                    {
                        interes = 20 * monto_solicitado;
                        interes /= 100;
                        valor_cuota = monto_solicitado + interes;
                        valor_cuota /= cantidad_cuota;
                        Console.WriteLine("El valor cuota es: " + valor_cuota + " por " + cantidad_cuota + " cuotas");
                    }
                    else if (cantidad_cuota > 24)
                    {
                        interes = 35 * monto_solicitado;
                        interes /= 100;
                        valor_cuota = monto_solicitado + interes;
                        valor_cuota /= cantidad_cuota;
                        Console.WriteLine("El valor cuota es: " + valor_cuota + " por " + cantidad_cuota + " cuotas");
                    }
                }
                else
                {
                    Console.WriteLine("La cantidad de cuotas debe ser entre 1 y 36 cuotas, porfavor ingresa otra cantidad de cuotas");
                }
            }
            else
            {
                Console.WriteLine("El monto solicitado debe ser mayor a $500.000, porfavor ingresa otro monto");
            }
        }

        public void calcular_monto_total()
        {
            monto_total = valor_cuota * cantidad_cuota;
            Console.WriteLine("El monto total es de: " + monto_total);
        }

        public void calcular_todo()
        {
            this.calulcar_valor_cuota();
            this.calcular_monto_total();
        }
    }
}
