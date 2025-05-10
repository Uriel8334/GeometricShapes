using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Rhombus : BaseShape
    {
        //clase propia del rombo (rhombus)

        //atributos del rombo (rhombus)
        private double minorDiagonal; //diagonal corta (short diagonal)
        private double majorDiagonal; //diagonal larga (long diagonal)
        private double side; //lado (side)

        //constructor del rombo (rhombus)
        public Rhombus(double minorDiagonal, double majorDiagonal, double side)
        {
            this.minorDiagonal = minorDiagonal;
            this.majorDiagonal = majorDiagonal;
            this.side = side;
        }

        //metodo para calcular el area del rombo
        public double? CalculateArea()
        {
            return (minorDiagonal * majorDiagonal) / 2;
        }

        //metodo para calcular el perimetro del rombo
        public double? CalculatePerimeter()
        {
            return 4 * side;
        }
        public bool ValidateInput()
        {
            //validar que las diagonales y el lado sean positivos
            if (minorDiagonal <= 0 || majorDiagonal <= 0 || side <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
