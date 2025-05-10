using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes.CtrlShapes
{
    internal class Trapezoid
    {
        //atributos de la clase trapezoide 
        private double base1;
        private double base2;
        private double height;

        //contructor de la clase trapezoide
        public Trapezoid(double base1, double base2, double height)
        {
            this.base1 = base1;
            this.base2 = base2;
            this.height = height;
        }

        //metodo para calcular el area del trapezoide 
        public double? CalculateArea()
        {
            return ((base1 + base2) * height) / 2;
        }

        //metodo para calcular el perimetro del trapezoide
        public double? CalculatePerimeter()
        {
            //verifica si el valor de la base y la altura son validos
            if (base1 <= 0 || base2 <= 0 || height <= 0)
            {
                return null;
            }
            return base1 + base2 + (2 * Math.Sqrt(Math.Pow(height, 2) + Math.Pow((base1 - base2) / 2, 2)));
        }

        //metodo para validar los datos de entrada positivos 
        public bool ValidateInput()
        {
            //verifica si el valor de la base y la altura son validos
            if (base1 <= 0 || base2 <= 0 || height <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
