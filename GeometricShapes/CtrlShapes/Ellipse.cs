using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Ellipse : BaseShape
    {
        //clase propia de la elipse (ellipse)
        //atributos de la elipse (ellipse)
        private double minorRadius; //lado mayor (largeSide)
        private double majorRadius; //lado menor (smallSide)

        //constructor de la elipse (ellipse)
        public Ellipse(double minorRadius, double majorRadius)
        {
            this.minorRadius = minorRadius;
            this.majorRadius = majorRadius;
        }

        //metodo para calcular el area de la elipse
        public double? CalculateArea()
        {
            return Math.PI * minorRadius * minorRadius;
        }

        //metodo para calcular el perimetro de la elipse
        public double? CalculatePerimeter()
        {
            //formula aproximada para el perimetro de la elipse
            return Math.PI * (3 * (minorRadius + minorRadius) - Math.Sqrt((3 * minorRadius + majorRadius) * (minorRadius + 3 * majorRadius)));
        }

        public bool ValidateInput()
        {
            //validar que los radios sean positivos
            if (minorRadius <= 0 || majorRadius <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
