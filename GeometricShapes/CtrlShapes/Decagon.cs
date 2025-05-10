using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Decagon : BaseShape
    {
        //clase propia del decagono (decagon)
        //atributos del decagono (decagon)
        private double side; //lado (side)

        //constructor del decagono (decagon)
        public Decagon(double side)
        {
            this.side = side;
        }
        //metodo para calcular el area del decagono
        public double? CalculateArea()
        {
            return CalculatePerimeter() * side / 2;
        }
        //metodo para calcular el perimetro del decagono
        public double? CalculatePerimeter()
        {
            return 10 * side;
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
