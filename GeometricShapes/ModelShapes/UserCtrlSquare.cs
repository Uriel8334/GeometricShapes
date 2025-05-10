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

namespace GeometricShapes
{
    public partial class UserCtrlSquare : UserControl, BaseShape
    {
        public UserCtrlSquare()
        {
            InitializeComponent();
        }
        //metodo para calcular el area
        public double? CalculateArea()
        {
            if (double.TryParse(txtSide.Text, out double sideLength))
            {
                Square square = new Square(sideLength);
                return square.CalculateArea();
            }
            return null;
        }
        //metodo para calcular el perimetro
        public double? CalculatePerimeter()
        {
            if (double.TryParse(txtSide.Text, out double sideLength))
            {
                Square square = new Square(sideLength);
                return square.CalculatePerimeter();
            }
            return null;
        }

        public bool ValidateInput()
        {
            double? side = FuncValidation.ValidatePositiveNumber(txtSide, "Lado");
            return side.HasValue;
        }

    }
}

