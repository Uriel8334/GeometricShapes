using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Heptagon : BaseShape
    {
        //clase propia del heptagono (heptagon)
        //atributos del heptagono (heptagon)
        private double side; //lado (side)
        private double apothem; //apotema (apothem)

        //constructor del heptagono (heptagon)
        public Heptagon(double side)
        {
            this.side = side;
        }
        //metodo para calcular el area del heptagono
        public double? CalculateArea()
        {
            apothem = (7 * Math.Pow(side, 2)) / (4 * Math.Tan(Math.PI / 7)); //calculo del apotema 
            return (7 * side * apothem) / 2;
        }
        //metodo para calcular el perimetro del heptagono
        public double? CalculatePerimeter()
        {
            return 7 * side;
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
