using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class IsoscelesTrapezium : BaseShape
    {
        //calase propia del trapecio isosceles (isosceles trapezium)
        //atributos del trapecio isosceles (isosceles trapezium)
        private double majorBase; //base mayor (major base)
        private double minorBase; //base menor (minor base)
        private double height; //altura (height)

        //constructor del trapecio isosceles 
        public IsoscelesTrapezium(double majorBase, double minorBase, double height)
        {
            this.majorBase = majorBase;
            this.minorBase = minorBase;
            this.height = height;
        }

        //metodo para calcular el area del trapecio isosceles
        public double? CalculateArea()
        {
            return ((majorBase + minorBase) * height) / 2;
        }

        //metodo para calcular el perimetro del trapecio isosceles
        public double? CalculatePerimeter()
        {
            double side = Math.Sqrt(Math.Pow((majorBase - minorBase) / 2, 2) + Math.Pow(height, 2));
            return majorBase + minorBase + (2 * side);
        }
        public bool ValidateInput()
        {
            //validar que las bases y la altura sean positivas
            if (majorBase <= 0 || minorBase <= 0 || height <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
