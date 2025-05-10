using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricShapes.ModelShapes;
using GeometricShapes.Utility;

namespace GeometricShapes.ModelShapes
{
    public partial class UserCtrlTriangle : UserControl, BaseShape
    {
        public UserCtrlTriangle()
        {
            InitializeComponent();
        }
        //metodo para calcular el area
        public double? CalculateArea()
        {
            //verifica si el valor de la base y la altura son validos
            if (double.TryParse(txtBase.Text, out double baseTriangle) && double.TryParse(txtHeight.Text, out double height))
            {
                Triangle triangle = new Triangle(baseTriangle, height);
                return triangle.CalculateArea();
            }
            return null;
        }
        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            //verifica si el valor de la base y la altura son validos
            if (double.TryParse(txtBase.Text, out double baseTriangle) && double.TryParse(txtHeight.Text, out double height))
            {
                Triangle triangle = new Triangle(baseTriangle, height);
                return triangle.CalculatePerimeter();
            }
            return null;
        }

        public bool ValidateInput()
        {
            //verifica si el valor de la base y la altura son validos
            double? baseTriangle = FuncValidation.ValidatePositiveNumber(txtBase, "Base");
            double? height = FuncValidation.ValidatePositiveNumber(txtHeight, "Altura");
            return baseTriangle.HasValue && height.HasValue;
        }

    }
}
