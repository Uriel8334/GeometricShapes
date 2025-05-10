using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes.CtrlShapes
{
    internal class Oval : BaseShape
    {
        //clase propia del ovalo de cassini

        //atributos del ovalo de cassini
        private double aFocus;
        private double bFocus;

        //contructor de la clase ovalo
        public Oval(double aFocus, double bFocus)
        {
            this.aFocus = aFocus;
            this.bFocus = bFocus;
        }

        //metodo para calcular el area del ovalo
        public double? CalculateArea()
        {
            //area del ovalo de cassini
            return Math.PI * (aFocus * aFocus - bFocus * bFocus);
        }

        //metodo para calcular el perimetro del ovalo
        public double? CalculatePerimeter()
        {
            return Math.PI * Math.Sqrt(2 * (aFocus * aFocus + bFocus * bFocus));
        }

        //metodo para validar datos ingresados positivos 
        public bool ValidateInput()
        {
            //validar que los focos sean positivos
            if (aFocus <= 0 || bFocus <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
