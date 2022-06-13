using System;
using System.Collections.Generic;

namespace Electrodomesticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electrodomesticos lavadora1 = new Lavadora(10);           
            Electrodomesticos lavadora2 = new Lavadora(50, 100, 80);
            Electrodomesticos lavadora3 = new Lavadora(50, 100, 60);
            Electrodomesticos lavadora4 = new Lavadora(50, 60, 50);
            Electrodomesticos lavadora5 = new Lavadora(50, 80, 80);
            Electrodomesticos tele1 = new Television(45, true);
            Electrodomesticos tele2 = new Television(50, false);
            Electrodomesticos tele3 = new Television(30,false);
            Electrodomesticos tele4 = new Television(60,true, 80, 80);
            Electrodomesticos tele5 = new Television(30,false,100, 10);           

            List<Electrodomesticos> electrodomesticosTotales = new List<Electrodomesticos>();
            electrodomesticosTotales.Add(lavadora2);
            electrodomesticosTotales.Add(lavadora1);
            electrodomesticosTotales.Add(lavadora3);
            electrodomesticosTotales.Add(lavadora4);
            electrodomesticosTotales.Add(lavadora5);
            electrodomesticosTotales.Add(tele1);
            electrodomesticosTotales.Add(tele2);
            electrodomesticosTotales.Add(tele3);
            electrodomesticosTotales.Add(tele4);
            electrodomesticosTotales.Add(tele5);

            foreach (Electrodomesticos electrodomestico in electrodomesticosTotales)
            {
                Console.WriteLine($"El precio total es de: {electrodomestico.PrecioFinal()}");
            }
        }
    }
}
