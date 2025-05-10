using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Rectangle : BaseShape
    {
        //clase propia del rectangulo (rectangle)
        //atributos del rectangulo (rectangle)
        private double baseRectangle; //base (base)
        private double height; //altura (height)

        //constructor del rectangulo (rectangle)
        public Rectangle(double baseRectangle, double height)
        {
            this.baseRectangle = baseRectangle;
            this.height = height;
        }

        //metodo para calcular el area del rectangulo
        public double? CalculateArea()
        {
            return baseRectangle * height;
        }

        //metodo para calcular el perimetro del rectangulo
        public double? CalculatePerimeter()
        {
            return 2 * (baseRectangle + height);
        }

        public bool ValidateInput()
        {
            //validar que la base y la altura sean positivas
            if (baseRectangle <= 0 || height <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
