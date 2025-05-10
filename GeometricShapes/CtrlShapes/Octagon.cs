using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricShapes
{
    internal class Octagon : BaseShape
    {
        //clase propia del octagono (octagon)

        //atributos del octagono (octagon)
        private double side; //lado (side)

        //constructor del octagono 
        public Octagon(double side)
        {
            this.side = side;
        }

        //metodo para calcular el area del octagono
        public double? CalculateArea()
        {
            return 2 * (1 + Math.Sqrt(2) * Math.Pow(side, 2));
        }

        //metodo para calcular el perimetro del octagono
        public double? CalculatePerimeter()
        {
            return 8 * side;
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
