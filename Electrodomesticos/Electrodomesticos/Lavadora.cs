using System;

namespace Electrodomesticos
{
    class Lavadora : Electrodomesticos
    {
        private double carga;

        public Lavadora(double carga)
        {
            this.carga = carga;

        }
        public Lavadora(double carga, double consumoEnergetico, double precioSegunPeso)
        {
            this.carga = carga;
            base.consumoEnergetico = consumoEnergetico;
            base.peso = precioSegunPeso;

        }  
        public override double PrecioFinal()
        {
            double precioFinal = precioBase + consumoEnergetico + peso;

            if (carga > 30)
            {
                precioFinal += 50;
            }

            return precioFinal;
        }
    }
}
