using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Pentagon : BaseShape
    {
        //clase propia del pentagono (pentagon)
        //atributos del pentagono (pentagon)
        private double side; //lado (side)

        //constructor del pentagono (pentagon)
        public Pentagon(double side)
        {
            this.side = side;
        }
        //metodo para calcular el area del pentagono
        public double? CalculateArea()
        {
            return (5 * Math.Pow(side, 2) / 4) * (1 / Math.Tan(Math.PI / 5));
        }

        //metodo para calcular el perimetro del pentagono
        public double? CalculatePerimeter()
        {
            return 5 * side;
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
