using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Triangle : BaseShape
    {
        //clase propia del triangulo (triangle)

        //atributos del triangulo (triangle)
        private double baseTriangle; //base (base)
        private double height; //altura (height)

        //constructor del triangulo (triangle)
        public Triangle(double baseTriangle, double height)
        {
            this.baseTriangle = baseTriangle;
            this.height = height;
        }

        //metodo para calcular el area del triangulo
        public double? CalculateArea()
        {
            return (baseTriangle * height) / 2;
        }

        //metodo para calcular el perimetro del triangulo
        public double? CalculatePerimeter()
        {
            return baseTriangle * 3;
        }
        public bool ValidateInput()
        {
            //validar que la base y la altura sean positivas
            if (baseTriangle <= 0 || height <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
