using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Hexagon : BaseShape
    {
        //clase propia del hexagono (hexagon)
        //atributos del hexagono (hexagon)
        private double side; //lado (side)
        private double apothem; //apotema (apothem)
        //constructor del hexagono (hexagon)
        public Hexagon(double side)
        {
            this.side = side;
        }
        //metodo para calcular el area del hexagono
        public double? CalculateArea()
        {
            apothem = (3 * Math.Pow(side, 2) * Math.Sqrt(3)) / (2); //calculo del apotema 
            return 6 * apothem * side / 2;
        }
        //metodo para calcular el perimetro del hexagono
        public double? CalculatePerimeter()
        {
            return 6 * side;
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
