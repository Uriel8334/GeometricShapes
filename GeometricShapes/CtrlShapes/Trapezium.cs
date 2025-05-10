using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Trapezium : BaseShape
    {
        //clase propia del trapezio (trapezium)

        //atributos del trapezio (trapezium)
        private double baseMajor; //base mayor (baseMajor)
        private double baseMinor; //base menor (baseMinor)
        private double height; //altura (height)
        private double leftSide; //lado izquierdo (leftSide)
        private double rightSide; //lado derecho (rightSide)

        //constructor del trapezio (trapezium)
        public Trapezium(double baseMajor, double baseMinor, double height, double leftSide, double rightSide)
        {
            this.baseMajor = baseMajor;
            this.baseMinor = baseMinor;
            this.height = height;
            this.leftSide = leftSide;
            this.rightSide = rightSide;
        }

        //metodo para calcular el area del trapezio
        public double? CalculateArea()
        {
            return ((baseMajor + baseMinor) * height) / 2;
        }

        //metodo para calcular el perimetro del trapezio
        public double? CalculatePerimeter()
        {
            return baseMajor + baseMinor + leftSide + rightSide;
        }
        public bool ValidateInput()
        {
            //validar que las bases y la altura sean positivas
            if (baseMajor <= 0 || baseMinor <= 0 || height <= 0 || leftSide <= 0 || rightSide <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
