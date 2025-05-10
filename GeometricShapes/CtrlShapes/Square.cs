using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Square : BaseShape
    {
        //clase propia del cuadrado (square)

        //atributos del cuadrado (Square)
        private double side; //lado (side)

        //constructor del cuadrado (Square)
        public Square(double side)
        {
            this.side = side;
        }

        //metodo para calcular el area del cuadrado
        public double? CalculateArea()
        {
            return side * side;
        }
        //metodo para calcular el perimetro del cuadrado
        public double? CalculatePerimeter()
        {
            return 4 * side;
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
