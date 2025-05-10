using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Circle : BaseShape
    {
        //clase propia del circulo (circle)

        //atributos del circulo (Circle)
        private double radius; //radio (radius)

        //constructor del circulo (Circle)
        public Circle(double radius)
        {
            this.radius = radius;
        }
        //metodo para calcular el area del circulo
        public double? CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        //metodo para calcular el perimetro del circulo
        public double? CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public bool ValidateInput()
        {
            //validar que el radio sea positivo
            if (radius <= 0)
            {
                return false;
            }
            return true;
        }


    }
}
