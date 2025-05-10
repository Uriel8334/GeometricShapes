using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Enneagon : BaseShape
    {
        //clase propia del enneagono (enneagon)
        //atributos del enneagono (enneagon)
        private double side; //lado (side)
        private double apothem; //apotema (apothem)
        //constructor del enneagono (enneagon)
        public Enneagon(double side)
        {
            this.side = side;
        }

        //metodo para calcular el area del enneagono
        public double? CalculateArea()
        {
            apothem = (side / 2) * (Math.Sin(70) / Math.Sin(20)); //calculo del apotema 
            return 9 * apothem * side / 2;
        }

        //metodo para calcular el perimetro del enneagono
        public double? CalculatePerimeter()
        {
            return 9 * side;
        }

        public bool ValidateInput()
        {
            //validar que el lado sea positivo
            if (side <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
