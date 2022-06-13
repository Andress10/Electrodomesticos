namespace Electrodomesticos
{
    abstract class Electrodomesticos
    {
        protected double precioBase;
        protected double consumoEnergetico;
        protected double peso;


        public Electrodomesticos()
        {
            this.precioBase = 100;
            this.consumoEnergetico = 60;
            this.peso = 50;
        }
        /// <summary>
        /// Devuelve el precio total de un electrodomestico
        /// </summary>   
        public abstract double PrecioFinal();      
    }
}
