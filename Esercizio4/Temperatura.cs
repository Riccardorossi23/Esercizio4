using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio4
{
    public class Temperatura
    {
        public static double MediaTemperature(double[] temperature)
        {
            double resp = 0;
            if (temperature != null && temperature.Length > 0)
            {
                int quantita = temperature.Length;
                double somma = 0;
                for (int i = 0; i < quantita; i++)
                {
                    somma = somma + temperature[i];
                }
                resp = somma / quantita;
            }
            else
                resp = double.NaN;
            return resp;
        }
    }
}
