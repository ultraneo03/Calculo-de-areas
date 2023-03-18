using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo_de_areas
{
    class Circulo : FiguraGeometrica
    {
        private double radio;

        private double area;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override void CalcularArea()
        {
            this.area = Math.PI * Math.Pow(radio, 2);
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("Círculo con radio " + radio);
        }

        public override void MostrarResultado()
        {
            Console.WriteLine("El área del circulo es: " + this.area);
        }
    }
}
