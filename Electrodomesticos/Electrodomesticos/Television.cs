using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomesticos
{
    internal class Television : Electrodomesticos
    {
        private int resolucionPulgadas;
        private bool sintonizarTDT;

        public Television(int resolucionPulgadas, bool sintonizarTDT)
        {
            this.resolucionPulgadas = resolucionPulgadas;
            this.sintonizarTDT = sintonizarTDT;
        }
        public Television(int resolucionPulgadas, bool sintonizarTDT, double consumoEnergetico, double precioSegunPeso)
        {
            this.resolucionPulgadas = resolucionPulgadas;
            this.sintonizarTDT = sintonizarTDT;
            base.consumoEnergetico = consumoEnergetico;
            base.peso = precioSegunPeso;
        }         
        public override double PrecioFinal()
        {   
            double precioFinal = precioBase + consumoEnergetico + peso;


            if (this.resolucionPulgadas > 40 && this.sintonizarTDT == true)
            {
                precioFinal = precioFinal + ((precioFinal * 0.3) + 50);
            }
            else if (this.resolucionPulgadas > 40 )
            {
                precioFinal = precioFinal + (precioFinal * 0.3);

            }
            else if (this.sintonizarTDT == true)
            {
                precioFinal += 50 ;
            }                 
            return precioFinal;

        }     
    }
}
