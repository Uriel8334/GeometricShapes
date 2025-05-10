using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Deltoid : BaseShape
    {
        //clase propia del deltoide (deltoid)
        //atributos del deltoide (deltoid)
        private double principalDiagonal; //diagonal principal
        private double secondaryDiagonal; //diagonal secundaria

        //constructor del deltoide (deltoid)
        public Deltoid(double principalDiagonal, double secondaryDiagonal)
        {
            this.principalDiagonal = principalDiagonal;
            this.secondaryDiagonal = secondaryDiagonal;
        }

        //metodo para calcular el area del deltoide
        public double? CalculateArea()
        {
            return (principalDiagonal * secondaryDiagonal) / 2;
        }

        //metodo para calcular el perimetro del deltoide
        public double? CalculatePerimeter()
        {
            return 4 * (Math.Sqrt(Math.Pow(principalDiagonal / 2, 2) + Math.Pow(secondaryDiagonal / 2, 2)));
        }

        public bool ValidateInput()
        {
            //validar que las diagonales sean positivas
            if (principalDiagonal <= 0 || secondaryDiagonal <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
