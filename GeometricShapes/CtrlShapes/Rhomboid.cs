using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Rhomboid : BaseShape
    {
        //clase propia del romboide (Rhomboid)

        //atributos del romboide (Rhomboid)
        private double baseLength; //base (baseLength)
        private double height; //altura (height)
        private double side; //lado (side)

        //constructor del romboide (Rhomboid)
        public Rhomboid(double baseLength, double height, double side)
        {
            this.baseLength = baseLength;
            this.height = height;
            this.side = side;
        }

        //metodo para calcular el area del romboide
        public double? CalculateArea()
        {
            return baseLength * height;
        }

        //metodo para calcular el perimetro del romboide
        public double? CalculatePerimeter()
        {
            return 2 * (baseLength + side);
        }

        public bool ValidateInput()
        {
            //validar que la base y la altura sean positivas
            if (baseLength <= 0 || height <= 0 || side <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
